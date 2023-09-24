using System;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.Extensions.Logging;
using System.Reactive.Concurrency;
using NetDaemon.HassModel.Integration;

// Use unique namespaces for your apps if you going to share with others to avoid
// conflicting names
namespace NdGreenhouse.Apps.Greenhouse
{

    [Focus]
    [NetDaemonApp]
    public class RefillApp : IDisposable
    {
        private IHaContext haContext { get; set; } = default!;
        private ILogger<RefillApp> _logger { get; set; } = default!;
        private IScheduler scheduler { get; set; } = default!;
        public IEnumerable<string>? ActiveReservoirs { get; set; }


        public RefillApp(IHaContext ha,  ILogger<RefillApp> logger)
        {
            haContext = ha;

            ha.RegisterServiceCallBack<dynamic>("Heat_Current_Zone", async e => await HeatWaterInCurrentZone());

            ha.RegisterServiceCallBack<dynamic>("RefillCurrentZone", async e => await RefillCurrentZone());
            ha.RegisterServiceCallBack<dynamic>("RefillWaterTank",async e => await RefillWaterTank());
            ha.RegisterServiceCallBack<dynamic>("RefillSwpCooler", async e=> await RefillSwpCooler());
            ha.RegisterServiceCallBack<dynamic>("RunDumpRutineForCurrentZone", async e => await RunDumpRutineForCurrentZone());

            _logger = logger;
            //var entities = new Entities(ha);
            _logger.LogInformation("Refill started and is ready for a callback");
            GhProcedures gh = new(haContext, _logger);
            //gh.HeatCurrentZone();
            //entities.InputSelect.ReservoirRes.SelectOption("DB2");
            //ha.CallService("input_select", "select_option",null, new { target = new { entity_id = "input_select.reservoir_res" }, option = "DB2" });
        }



        
        public async Task RefillCurrentZone()
        {

            GhProcedures gh = new GhProcedures(haContext, _logger);
            await gh.RefillCurrentReservior();

        }


        
        public async Task RefillWaterTank()
        {
            GhProcedures gh = new GhProcedures(haContext, _logger);
            await gh.RefillMainWaterTank();
        }


       
        public async Task RefillSwpCooler()
        {
            GhProcedures gh = new GhProcedures(haContext, _logger);
            await gh.RefillSwampCooler();

        }

       
        public async Task HeatWaterInCurrentZone()
        {
            GhProcedures gh = new(haContext, _logger);
            await gh.HeatCurrentZone();

        }

        
        public async Task RunDumpRutineForCurrentZone()
        {
            GhProcedures gh = new(haContext, _logger);
            await gh.RunOneTankEmptyRunForCurrentZone();

        }

        public void Dispose()
        {
            GhProcedures gh = new GhProcedures(haContext, _logger);
            gh.MakeSureEverythingisOff();
            _logger.LogInformation("Made sure everythign is off");
        }
    }
}

