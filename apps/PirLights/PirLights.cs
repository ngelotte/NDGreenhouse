using System;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Reactive.Concurrency;
using NdGreenhouse;
using NetDaemon.HassModel.Entities;
using HomeAssistantGenerated;

namespace NdGreenhouse.Apps.Greenhouse
{

    public class LightConfig
    {
        public double? SunElevation { get; set; }
        public int LeaveLightsOnForSeconds { get; set; }
    }

    [NetDaemonApp]
    public class PirLightsApp : IDisposable
    {
        private IHaContext haContext { get; set; } = default!;
        private ILogger<PirLightsApp> _logger { get; set; } = default!;

        public double? SunElevation { get; set; }
        public List<SwitchEntity> Lights { get; set; } = new();
        public List<BinarySensorEntity> PirSensors { get; set; } = new();
        public int LeaveLightsOnForSeconds { get; set; }

        public PirLightsApp(IHaContext ha, ILogger<PirLightsApp> logger, IAppConfig<LightConfig> config)
        {
            haContext = ha;
            _logger = logger;
            SunElevation = config?.Value?.SunElevation;
            LeaveLightsOnForSeconds = config?.Value?.LeaveLightsOnForSeconds ?? 600;
            Lights = new List<SwitchEntity>();
            SwitchEntities sw = new SwitchEntities(ha);
            BinarySensorEntities bse = new BinarySensorEntities(ha);
            Lights.Add(sw.GhFrontLightSwitch);
            Lights.Add(sw.GhBackLight);
            PirSensors.Add(bse.Espcam01Pir);

            _logger.LogInformation("Pir App Initializing");
            SunEntities sunEntities = new SunEntities(haContext);
            if (Lights != null && PirSensors != null && SunElevation != null)
            {
                _logger.LogInformation("Pir App is running");

                var entities = new Entities(haContext);
                PirSensors.StateAllChanges()
                        .Where(e => e.New?.State == "on")
                        .Subscribe(e =>
                        {
                            if (sunEntities.Sun.Attributes != null)
                            {
                                if (sunEntities.Sun.Attributes.Elevation < SunElevation)
                                {
                                    Lights.TurnOn();
                                }
                                else
                                {
                                    _logger.LogInformation($"Did not turn on the lights because the current sun elevation is {sunEntities.Sun.Attributes.Elevation} which is more then {SunElevation}");
                                }
                            }
                            else
                            {
                                _logger.LogInformation($"Sun entities is null. Nothing is going to work.");
                            }
                        });



                PirSensors.StateChanges()
                    .Where(e =>
                        (e.New?.State == "off" &&
                        e.Old?.State == "on") || (e.New?.State == "on" &&
                        e.Old?.State == "off")
                    )
                    .Throttle(TimeSpan.FromSeconds(LeaveLightsOnForSeconds))
                    .Subscribe(e =>
                    {
                        if (e.New.IsOff())
                        {
                            _logger.LogInformation("Turning Lights Off");
                            Lights.TurnOff();
                        }
                    });
            }
            else
            {
                _logger.LogInformation("Pir App is not running");
                if (Lights == null)
                {
                    _logger.LogInformation("Lights is null pulling from the yaml so the automation could not start.");
                }
                if (PirSensors == null)
                {
                    _logger.LogInformation("PirSensors is null pulling from the yaml so the automation could not start.");
                }
                if (SunElevation == null)
                {
                    _logger.LogInformation("ElevationEvening is null pulling from the yaml so the automation could not start.");
                }

            }

            //var entities = new Entities(ha);

            //entities.InputSelect.ReservoirRes.SelectOption("DB2");
            //ha.CallService("input_select", "select_option",null, new { target = new { entity_id = "input_select.reservoir_res" }, option = "DB2" });
        }


        public void Dispose()
        {

        }
    }

}
