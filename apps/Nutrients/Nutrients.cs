using System;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Reactive.Concurrency;
using NetDaemon.HassModel.Integration;
using HomeAssistantGenerated;

namespace NdGreenhouse.Apps.Greenhouse
{

    public class NutrientStartData
    {
        public int pumpNumber { get; set; }
        public int doses { get; set; }
    }

    [NetDaemonApp]
    public class NutrientsApp : IDisposable
    {
        private IHaContext haContext { get; set; } = default!;
        private ILogger<NutrientsApp> _logger { get; set; } = default!;
        private IScheduler scheduler { get; set; } = default!;
        private bool HoldCurrentZoneIsRunning { get; set; } = false;

        public NutrientsApp(IHaContext ha, ILogger<NutrientsApp> logger) : this(ha, DefaultScheduler.Instance, logger)
        { }

        public NutrientsApp(IHaContext ha, IScheduler scheduler, ILogger<NutrientsApp> logger)
        {
            ha.RegisterServiceCallBack<NutrientStartData>("addNutrients", (NutrientStartData data) => AddNutrient(data));
            ha.RegisterServiceCallBack<dynamic>("AddOneDoseToCurrentZone", async e => await AddOneDoseToCurrentZone());
            haContext = ha;
            _logger = logger;
            GhProcedures gh = new GhProcedures(ha, logger);
            _logger.LogInformation("Nutrients is Starting");

            InputBooleanEntities ibe = new(ha);
            ibe.TestingTankHold.StateChanges().Where(t => t.New.IsOn()).Subscribe(async e =>
            {
                if (HoldCurrentZoneIsRunning == false)
                {
                    HoldCurrentZoneIsRunning = true;
                    bool completedSuccesfully = await gh.HoldCurrentZone();
                    _logger.LogInformation($"Hold currentZone completed with the completedSuccesfully set to {completedSuccesfully}");
                    HoldCurrentZoneIsRunning = false;
                }
            });
        }



        public async Task<bool> AddOneDoseToCurrentZone()
        {
            GhProcedures gh = new GhProcedures(haContext, _logger);
            await gh.AddNutrientsToCurrentZone();
            return true;

        }


        public async Task<bool> AddNutrient(NutrientStartData data)
        {

            GhProcedures gh = new GhProcedures(haContext, _logger);
            if (data.pumpNumber > 0 && data.doses > 0)
            {
                await gh.AddNutrients(data.pumpNumber, data.doses);
            }

            return true;

        }

        public void Dispose()
        {
            GhProcedures gh = new GhProcedures(haContext, _logger);
            gh.MakeSureEverythingisOff();
        }
    }
}