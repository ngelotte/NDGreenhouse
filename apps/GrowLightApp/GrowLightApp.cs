using System;
using System.Reactive.Linq;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using NdGreenhouse;
using NetDaemon.Extensions.Scheduler;
using HomeAssistantGenerated;

namespace NdGreenhouse.Apps.Greenhouse
{

    public class GrowLightConfig
    {
        public double? ElevationEvening { get; set; }
        public double? ElevationMorning { get; set; }
        public string NightEndTime { get; set; } = "";
        public string MorningStartTime { get; set; } = "";
        public IList<SwitchEntity>? GrowLights { get; set; }
    }

    [NetDaemonApp]
    public class GrowLightApp : IDisposable
    {
        private IHaContext _haContext { get; set; } = default!;
        private ILogger<GrowLightApp> _logger { get; set; } = default!;
        public INetDaemonScheduler _scheduler { get; set; } = default!;
        public double? ElevationEvening { get; set; }
        public double? ElevationMorning { get; set; }
        public string NightEndTime { get; set; } = "";
        public string MorningStartTime { get; set; } = "";
        public IList<SwitchEntity>? GrowLights { get; set; }
        public GrowLightApp(IHaContext ha, ILogger<GrowLightApp> logger, INetDaemonScheduler scheduler, IAppConfig<GrowLightConfig> config)
        {
            ElevationEvening = config?.Value?.ElevationEvening;
            ElevationMorning = config?.Value?.ElevationMorning;
            NightEndTime = config?.Value?.NightEndTime ?? "";
            MorningStartTime = config?.Value?.MorningStartTime ?? "";
            GrowLights = config?.Value?.GrowLights;

            _logger = logger;
            _haContext = ha;
            _scheduler = scheduler;
            InitNightTime();
            InitTurnOnLightsInTheMorning();
        }

        private void InitNightTime()
        {
            if (NightEndTime != null && ElevationEvening != null && GrowLights != null)
            {
                SunEntities sunEntities = new SunEntities(_haContext);
                sunEntities.Sun
                    .StateAllChanges()
                    .Where(e =>
                        e.New?.Attributes?.Elevation <= ElevationEvening &&
                        e.New?.Attributes?.Rising == false &&
                        e.Old?.Attributes?.Elevation > ElevationEvening
                        )
                    .Subscribe(s =>
                    {
                        DateTime currentTime = DateTime.Now;
                        DateTime todaysEndTime = currentTime.Date.Add(TimeSpan.Parse(NightEndTime));
                        if (todaysEndTime >= DateTime.Now.AddMinutes(1))
                        {
                            _logger.LogInformation($"Turning on the Lights at {DateTime.Now}");
                            GrowLights.TurnOn();
                        }
                        else
                        {
                            _logger.LogInformation($"Skipping turning on the Lights because it is {currentTime} but Night End Time is {todaysEndTime}");
                        }
                    });
            }
            if (NightEndTime != null && GrowLights != null)
            {
                //I have absolutely no idea if this parses correctly. 
                //DateTimeOffset firstTimeToStart = DateTimeOffset.Parse(NightEndTime);
                _scheduler.RunDaily(TimeSpan.Parse(NightEndTime), () =>
                                {
                                    GrowLights.TurnOff();
                                    _logger.LogInformation($"Turning off the Lights at {DateTime.Now}");
                                });
            }
        }

        private void InitTurnOnLightsInTheMorning()
        {
            SunEntities sunEntities = new SunEntities(_haContext);
            if (MorningStartTime != null && ElevationMorning != null && GrowLights != null)
            {//I have absolutely no idea if this parses correctly. 
                DateTimeOffset firstTimeToStart = DateTimeOffset.Parse(MorningStartTime);
                if (firstTimeToStart < DateTimeOffset.Now)
                {
                    firstTimeToStart = firstTimeToStart.AddDays(1);
                }
                _scheduler.RunEvery(TimeSpan.FromHours(24), firstTimeToStart, () =>
                   {
                       if (sunEntities != null && sunEntities?.Sun?.Attributes != null)
                       {
                           if (sunEntities.Sun.Attributes.Elevation < ElevationMorning)
                           {
                               _logger.LogInformation($"Turning on the Lights at {DateTime.Now}");
                               GrowLights.TurnOn();

                           }
                           else
                           {
                               _logger.LogInformation($"Skipping turning on the Lights because the sun is at  {sunEntities.Sun.Attributes.Elevation} but it needs to be below {ElevationMorning}");
                           }
                       }
                       else
                       {
                           _logger.LogInformation($"Sun attributes is null. So not turning on the lights because we dont know where the sun is.");
                       }
                   }
           );
            }
            //
            if (MorningStartTime != null && ElevationMorning != null && GrowLights != null)
            {
                sunEntities.Sun
                            .StateAllChanges()
                            .Where(e =>
                                e.New?.Attributes?.Elevation >= ElevationMorning &&
                                e.New?.Attributes?.Rising == true &&
                                e.Old?.Attributes?.Elevation < ElevationMorning
                                )
                            .Subscribe(s =>
                            {
                                GrowLights.TurnOff();
                                _logger.LogInformation($"Turning off the Lights at {DateTime.Now}");
                            }
                        );
            }
        }

        public void Dispose()
        {

        }
    }
}

