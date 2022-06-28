using System;
using System.Collections.Generic;
using NetDaemon.HassModel;
using NetDaemon.HassModel.Entities;
using NetDaemon.HassModel.Entities.Core;
using System.Text.Json.Serialization;

namespace HomeAssistantGenerated
{
    public interface IEntities
    {
        AutomationEntities Automation { get; }

        BinarySensorEntities BinarySensor { get; }

        ButtonEntities Button { get; }

        CameraEntities Camera { get; }

        ClimateEntities Climate { get; }

        DeviceTrackerEntities DeviceTracker { get; }

        InputBooleanEntities InputBoolean { get; }

        InputNumberEntities InputNumber { get; }

        InputSelectEntities InputSelect { get; }

        LightEntities Light { get; }

        PersonEntities Person { get; }

        ScriptEntities Script { get; }

        SensorEntities Sensor { get; }

        SunEntities Sun { get; }

        SwitchEntities Switch { get; }

        UpdateEntities Update { get; }

        VacuumEntities Vacuum { get; }

        WeatherEntities Weather { get; }

        ZoneEntities Zone { get; }
    }

    public partial class Entities : IEntities
    {
        private readonly IHaContext _haContext;
        public Entities(IHaContext haContext)
        {
            _haContext = haContext;
        }

        public AutomationEntities Automation => new(_haContext);
        public BinarySensorEntities BinarySensor => new(_haContext);
        public ButtonEntities Button => new(_haContext);
        public CameraEntities Camera => new(_haContext);
        public ClimateEntities Climate => new(_haContext);
        public DeviceTrackerEntities DeviceTracker => new(_haContext);
        public InputBooleanEntities InputBoolean => new(_haContext);
        public InputNumberEntities InputNumber => new(_haContext);
        public InputSelectEntities InputSelect => new(_haContext);
        public LightEntities Light => new(_haContext);
        public PersonEntities Person => new(_haContext);
        public ScriptEntities Script => new(_haContext);
        public SensorEntities Sensor => new(_haContext);
        public SunEntities Sun => new(_haContext);
        public SwitchEntities Switch => new(_haContext);
        public UpdateEntities Update => new(_haContext);
        public VacuumEntities Vacuum => new(_haContext);
        public WeatherEntities Weather => new(_haContext);
        public ZoneEntities Zone => new(_haContext);
    }

    public partial class AutomationEntities
    {
        private readonly IHaContext _haContext;
        public AutomationEntities(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Check Temperature of DB1 Reservoir</summary>
        public AutomationEntity CheckTemperatureOfDb1Reservoir => new(_haContext, "automation.check_temperature_of_db1_reservoir");
        ///<summary>Db1 Watering Pump</summary>
        public AutomationEntity Db1WateringPump => new(_haContext, "automation.db1_watering_pump");
        ///<summary>Db2 Watering Pump</summary>
        public AutomationEntity Db2WateringPump => new(_haContext, "automation.db2_watering_pump");
        ///<summary>Db5 Watering Pump</summary>
        public AutomationEntity Db3WateringPump => new(_haContext, "automation.db3_watering_pump");
        ///<summary>Db3 Watering Pump </summary>
        public AutomationEntity Db3WateringPump2 => new(_haContext, "automation.db3_watering_pump_2");
        ///<summary>Db4 Watering Pump </summary>
        public AutomationEntity Db4WateringPump => new(_haContext, "automation.db4_watering_pump");
        ///<summary>Db6 Watering Pump</summary>
        public AutomationEntity Db6WateringPump => new(_haContext, "automation.db6_watering_pump");
        ///<summary>Heater Try 2</summary>
        public AutomationEntity HeaterTry2 => new(_haContext, "automation.heater_try_2");
        ///<summary>Octoprint Notification</summary>
        public AutomationEntity OctoprintNotification => new(_haContext, "automation.octoprint_notification");
        ///<summary>Temporary Co2 and hear</summary>
        public AutomationEntity TemporaryCo2AndHear => new(_haContext, "automation.temporary_co2_and_hear");
        ///<summary>test</summary>
        public AutomationEntity Test => new(_haContext, "automation.test");
        ///<summary>Turn Off Co2</summary>
        public AutomationEntity TurnOffCo2 => new(_haContext, "automation.turn_off_co2");
        ///<summary>Turn off Grow Light at night</summary>
        public AutomationEntity TurnOffGrowLight => new(_haContext, "automation.turn_off_grow_light");
        ///<summary>Turn Off Grow Light in the Mornining</summary>
        public AutomationEntity TurnOffGrowLightInTheMornining => new(_haContext, "automation.turn_off_grow_light_in_the_mornining");
        ///<summary>Turn on Circulating Fan ever 4 hours</summary>
        public AutomationEntity TurnOnCirculatingFanEver4Hours => new(_haContext, "automation.turn_on_circulating_fan_ever_4_hours");
        ///<summary>Turn on DB2 pump every hour for 7.5 min</summary>
        public AutomationEntity TurnOnDb2PumpEvery4Hours => new(_haContext, "automation.turn_on_db2_pump_every_4_hours");
        ///<summary>Turn on Grow Light in the Morning</summary>
        public AutomationEntity TurnOnGrowLight => new(_haContext, "automation.turn_on_grow_light");
        ///<summary>Turn on Grow Light 4 before Sunset</summary>
        public AutomationEntity TurnOnGrowLight42 => new(_haContext, "automation.turn_on_grow_light_4_2");
        ///<summary>Turn on Grow Light DB1 and 2 before Sunset</summary>
        public AutomationEntity TurnOnGrowLightDb1And2BeforeSunset => new(_haContext, "automation.turn_on_grow_light_db1_and_2_before_sunset");
        ///<summary>Turn on nft pump every 2 hours</summary>
        public AutomationEntity TurnOnNftPump => new(_haContext, "automation.turn_on_nft_pump");
        ///<summary>Watermeterkit Meter Value</summary>
        public AutomationEntity WatermeterkitMeterValue => new(_haContext, "automation.watermeterkit_meter_value");
        ///<summary>Write Stepper Value to ESP</summary>
        public AutomationEntity WriteStepperValueToEsp => new(_haContext, "automation.write_stepper_value_to_esp");
    }

    public partial class BinarySensorEntities
    {
        private readonly IHaContext _haContext;
        public BinarySensorEntities(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>auto_off_for_water_filler</summary>
        public BinarySensorEntity AutoOffForWaterFiller => new(_haContext, "binary_sensor.auto_off_for_water_filler");
        ///<summary>auto_off_for_water_filler</summary>
        public BinarySensorEntity AutoOffForWaterFiller2 => new(_haContext, "binary_sensor.auto_off_for_water_filler_2");
        ///<summary>auto_off_for_water_filler</summary>
        public BinarySensorEntity AutoOffForWaterFiller3 => new(_haContext, "binary_sensor.auto_off_for_water_filler_3");
        ///<summary>Back bushes Station Running</summary>
        public BinarySensorEntity BackBushesStationRunning => new(_haContext, "binary_sensor.back_bushes_station_running");
        ///<summary>Back Light Status</summary>
        public BinarySensorEntity BackLightStatus => new(_haContext, "binary_sensor.back_light_status");
        ///<summary>Backyard Access Point</summary>
        public BinarySensorEntity BackyardAccessPoint => new(_haContext, "binary_sensor.backyard_access_point");
        ///<summary>Berries Station Running</summary>
        public BinarySensorEntity BerriesStationRunning => new(_haContext, "binary_sensor.berries_station_running");
        ///<summary>DB1 Res Empty</summary>
        public BinarySensorEntity Db1ResEmpty => new(_haContext, "binary_sensor.db1_res_empty");
        ///<summary>DB1 Res Full</summary>
        public BinarySensorEntity Db1ResFull => new(_haContext, "binary_sensor.db1_res_full");
        ///<summary>DB1 Res Medium</summary>
        public BinarySensorEntity Db1ResMedium => new(_haContext, "binary_sensor.db1_res_medium");
        ///<summary>DB1 Water Level Status</summary>
        public BinarySensorEntity Db1WaterLevelStatus => new(_haContext, "binary_sensor.db1_water_level_status");
        ///<summary>DB2 Res Empty</summary>
        public BinarySensorEntity Db2ResEmpty => new(_haContext, "binary_sensor.db2_res_empty");
        ///<summary>DB2 Res Full</summary>
        public BinarySensorEntity Db2ResFull => new(_haContext, "binary_sensor.db2_res_full");
        ///<summary>DB2 Res Medium</summary>
        public BinarySensorEntity Db2ResMedium => new(_haContext, "binary_sensor.db2_res_medium");
        ///<summary>DB2 Water Level Status</summary>
        public BinarySensorEntity Db2WaterLevelStatus => new(_haContext, "binary_sensor.db2_water_level_status");
        ///<summary>DB3 Res Empty</summary>
        public BinarySensorEntity Db3ResEmpty => new(_haContext, "binary_sensor.db3_res_empty");
        ///<summary>DB3 Res Full</summary>
        public BinarySensorEntity Db3ResFull => new(_haContext, "binary_sensor.db3_res_full");
        ///<summary>DB3 Res Medium</summary>
        public BinarySensorEntity Db3ResMedium => new(_haContext, "binary_sensor.db3_res_medium");
        ///<summary>DB3 Water Level Status</summary>
        public BinarySensorEntity Db3WaterLevelStatus => new(_haContext, "binary_sensor.db3_water_level_status");
        ///<summary>DB4 Res Empty</summary>
        public BinarySensorEntity Db4ResEmpty => new(_haContext, "binary_sensor.db4_res_empty");
        ///<summary>DB4 Res Full</summary>
        public BinarySensorEntity Db4ResFull => new(_haContext, "binary_sensor.db4_res_full");
        ///<summary>DB4 Res Medium</summary>
        public BinarySensorEntity Db4ResMedium => new(_haContext, "binary_sensor.db4_res_medium");
        ///<summary>DB4 Water Level Status</summary>
        public BinarySensorEntity Db4WaterLevelStatus => new(_haContext, "binary_sensor.db4_water_level_status");
        ///<summary>DB5 Res Empty</summary>
        public BinarySensorEntity Db5ResEmpty => new(_haContext, "binary_sensor.db5_res_empty");
        ///<summary>DB5 Res Full</summary>
        public BinarySensorEntity Db5ResFull => new(_haContext, "binary_sensor.db5_res_full");
        ///<summary>DB5 Res Medium</summary>
        public BinarySensorEntity Db5ResMedium => new(_haContext, "binary_sensor.db5_res_medium");
        ///<summary>DB5 Water Level Status</summary>
        public BinarySensorEntity Db5WaterLevelStatus => new(_haContext, "binary_sensor.db5_water_level_status");
        ///<summary>DB6 Res Empty</summary>
        public BinarySensorEntity Db6ResEmpty => new(_haContext, "binary_sensor.db6_res_empty");
        ///<summary>DB6 Res Full</summary>
        public BinarySensorEntity Db6ResFull => new(_haContext, "binary_sensor.db6_res_full");
        ///<summary>DB6 Res Medium</summary>
        public BinarySensorEntity Db6ResMedium => new(_haContext, "binary_sensor.db6_res_medium");
        ///<summary>DB6 Water Level Status</summary>
        public BinarySensorEntity Db6WaterLevelStatus => new(_haContext, "binary_sensor.db6_water_level_status");
        ///<summary>espcam01_button</summary>
        public BinarySensorEntity Espcam01Button => new(_haContext, "binary_sensor.espcam01_button");
        ///<summary>espcam01_pir</summary>
        public BinarySensorEntity Espcam01Pir => new(_haContext, "binary_sensor.espcam01_pir");
        ///<summary>Family Room Access Point</summary>
        public BinarySensorEntity FamilyRoomAccessPoint => new(_haContext, "binary_sensor.family_room_access_point");
        ///<summary>Fan Button</summary>
        public BinarySensorEntity FanButton => new(_haContext, "binary_sensor.fan_button");
        ///<summary>Fan Status</summary>
        public BinarySensorEntity FanStatus => new(_haContext, "binary_sensor.fan_status");
        ///<summary>First half Program Running</summary>
        public BinarySensorEntity FirstHalfProgramRunning => new(_haContext, "binary_sensor.first_half_program_running");
        ///<summary>Fresh Res Empty</summary>
        public BinarySensorEntity FreshResEmpty => new(_haContext, "binary_sensor.fresh_res_empty");
        ///<summary>Fresh Res Full</summary>
        public BinarySensorEntity FreshResFull => new(_haContext, "binary_sensor.fresh_res_full");
        ///<summary>Fresh Res Medium</summary>
        public BinarySensorEntity FreshResMedium => new(_haContext, "binary_sensor.fresh_res_medium");
        ///<summary>Fresh Res Water Level Status</summary>
        public BinarySensorEntity FreshResWaterLevelStatus => new(_haContext, "binary_sensor.fresh_res_water_level_status");
        ///<summary>Fresh Water Empty</summary>
        public BinarySensorEntity FreshWaterEmpty => new(_haContext, "binary_sensor.fresh_water_empty");
        ///<summary>Fresh Water Full</summary>
        public BinarySensorEntity FreshWaterFull => new(_haContext, "binary_sensor.fresh_water_full");
        ///<summary>Fresh Water Level State</summary>
        public BinarySensorEntity FreshWaterLevelState => new(_haContext, "binary_sensor.fresh_water_level_state");
        ///<summary>Fresh Water Medium</summary>
        public BinarySensorEntity FreshWaterMedium => new(_haContext, "binary_sensor.fresh_water_medium");
        ///<summary>Front Field Station Running</summary>
        public BinarySensorEntity FrontFieldStationRunning => new(_haContext, "binary_sensor.front_field_station_running");
        ///<summary>Front flower sprinkler Station Running</summary>
        public BinarySensorEntity FrontFlowerSprinklerStationRunning => new(_haContext, "binary_sensor.front_flower_sprinkler_station_running");
        ///<summary>Front Light Button</summary>
        public BinarySensorEntity FrontLightButton => new(_haContext, "binary_sensor.front_light_button");
        ///<summary>Front Light Status</summary>
        public BinarySensorEntity FrontLightStatus => new(_haContext, "binary_sensor.front_light_status");
        ///<summary>Fruit trees Station Running</summary>
        public BinarySensorEntity FruitTreesStationRunning => new(_haContext, "binary_sensor.fruit_trees_station_running");
        ///<summary>Garage Access Point</summary>
        public BinarySensorEntity GarageAccessPoint => new(_haContext, "binary_sensor.garage_access_point");
        ///<summary>GH Back Light State</summary>
        public BinarySensorEntity GhBackLightState => new(_haContext, "binary_sensor.gh_back_light_state");
        ///<summary>Google Wifi System AAAAABycHeI</summary>
        public BinarySensorEntity GoogleWifiSystemAaaaabychei => new(_haContext, "binary_sensor.google_wifi_system_aaaaabychei");
        ///<summary>Home assistant beans  Station Running</summary>
        public BinarySensorEntity HomeAssistantBeansStationRunning => new(_haContext, "binary_sensor.home_assistant_beans_station_running");
        ///<summary>Marla Bin Full</summary>
        public BinarySensorEntity MarlaBinFull => new(_haContext, "binary_sensor.marla_bin_full");
        ///<summary>Master Bedroom Access Point</summary>
        public BinarySensorEntity MasterBedroomAccessPoint => new(_haContext, "binary_sensor.master_bedroom_access_point");
        ///<summary>Nature sprinkler Station Running</summary>
        public BinarySensorEntity NatureSprinklerStationRunning => new(_haContext, "binary_sensor.nature_sprinkler_station_running");
        ///<summary>NFT Res Empty</summary>
        public BinarySensorEntity NftResEmpty => new(_haContext, "binary_sensor.nft_res_empty");
        ///<summary>NFT Res Empty</summary>
        public BinarySensorEntity NftResEmpty2 => new(_haContext, "binary_sensor.nft_res_empty_2");
        ///<summary>NFT Res Full</summary>
        public BinarySensorEntity NftResFull => new(_haContext, "binary_sensor.nft_res_full");
        ///<summary>NFT Res Full</summary>
        public BinarySensorEntity NftResFull2 => new(_haContext, "binary_sensor.nft_res_full_2");
        ///<summary>NFT Res Medium</summary>
        public BinarySensorEntity NftResMedium => new(_haContext, "binary_sensor.nft_res_medium");
        ///<summary>NFT Res Medium</summary>
        public BinarySensorEntity NftResMedium2 => new(_haContext, "binary_sensor.nft_res_medium_2");
        ///<summary>NFT Water Level Status</summary>
        public BinarySensorEntity NftWaterLevelStatus => new(_haContext, "binary_sensor.nft_water_level_status");
        ///<summary>NFT Water Level Status</summary>
        public BinarySensorEntity NftWaterLevelStatus2 => new(_haContext, "binary_sensor.nft_water_level_status_2");
        ///<summary>OctoPrint Printing</summary>
        public BinarySensorEntity OctoprintPrinting => new(_haContext, "binary_sensor.octoprint_printing");
        ///<summary>OctoPrint Printing Error</summary>
        public BinarySensorEntity OctoprintPrintingError => new(_haContext, "binary_sensor.octoprint_printing_error");
        ///<summary>Office Access Point</summary>
        public BinarySensorEntity OfficeAccessPoint => new(_haContext, "binary_sensor.office_access_point");
        ///<summary>Open Sprinkler Rain Delay Active</summary>
        public BinarySensorEntity OpenSprinklerRainDelayActive => new(_haContext, "binary_sensor.open_sprinkler_rain_delay_active");
        ///<summary>Open Sprinkler Sensor 1 Active</summary>
        public BinarySensorEntity OpenSprinklerSensor1Active => new(_haContext, "binary_sensor.open_sprinkler_sensor_1_active");
        ///<summary>Open Sprinkler Sensor 2 Active</summary>
        public BinarySensorEntity OpenSprinklerSensor2Active => new(_haContext, "binary_sensor.open_sprinkler_sensor_2_active");
        ///<summary>Power Strip 1 Button</summary>
        public BinarySensorEntity PowerStrip1Button => new(_haContext, "binary_sensor.power_strip_1_button");
        ///<summary>Power Strip 1 Server Status</summary>
        public BinarySensorEntity PowerStrip1ServerStatus => new(_haContext, "binary_sensor.power_strip_1_server_status");
        ///<summary>Remote UI</summary>
        public BinarySensorEntity RemoteUi => new(_haContext, "binary_sensor.remote_ui");
        ///<summary>S07 Station Running</summary>
        public BinarySensorEntity S07StationRunning => new(_haContext, "binary_sensor.s07_station_running");
        ///<summary>S08 Station Running</summary>
        public BinarySensorEntity S08StationRunning => new(_haContext, "binary_sensor.s08_station_running");
        ///<summary>S14 Station Running</summary>
        public BinarySensorEntity S14StationRunning => new(_haContext, "binary_sensor.s14_station_running");
        ///<summary>S15 Station Running</summary>
        public BinarySensorEntity S15StationRunning => new(_haContext, "binary_sensor.s15_station_running");
        ///<summary>S16 Station Running</summary>
        public BinarySensorEntity S16StationRunning => new(_haContext, "binary_sensor.s16_station_running");
        ///<summary>S17 Station Running</summary>
        public BinarySensorEntity S17StationRunning => new(_haContext, "binary_sensor.s17_station_running");
        ///<summary>S18 Station Running</summary>
        public BinarySensorEntity S18StationRunning => new(_haContext, "binary_sensor.s18_station_running");
        ///<summary>S19 Station Running</summary>
        public BinarySensorEntity S19StationRunning => new(_haContext, "binary_sensor.s19_station_running");
        ///<summary>S20 Station Running</summary>
        public BinarySensorEntity S20StationRunning => new(_haContext, "binary_sensor.s20_station_running");
        ///<summary>S21 Station Running</summary>
        public BinarySensorEntity S21StationRunning => new(_haContext, "binary_sensor.s21_station_running");
        ///<summary>S22 Station Running</summary>
        public BinarySensorEntity S22StationRunning => new(_haContext, "binary_sensor.s22_station_running");
        ///<summary>S23 Station Running</summary>
        public BinarySensorEntity S23StationRunning => new(_haContext, "binary_sensor.s23_station_running");
        ///<summary>S24 Station Running</summary>
        public BinarySensorEntity S24StationRunning => new(_haContext, "binary_sensor.s24_station_running");
        ///<summary>SamsungFlex Is Charging</summary>
        public BinarySensorEntity SamsungflexIsCharging => new(_haContext, "binary_sensor.samsungflex_is_charging");
        ///<summary>Second half Program Running</summary>
        public BinarySensorEntity SecondHalfProgramRunning => new(_haContext, "binary_sensor.second_half_program_running");
        ///<summary>Side back grass Station Running</summary>
        public BinarySensorEntity SideBackGrassStationRunning => new(_haContext, "binary_sensor.side_back_grass_station_running");
        ///<summary>Snap peas and sunflowers Station Running</summary>
        public BinarySensorEntity SnapPeasAndSunflowersStationRunning => new(_haContext, "binary_sensor.snap_peas_and_sunflowers_station_running");
        ///<summary>Station 1 Status</summary>
        public BinarySensorEntity Station1Status => new(_haContext, "binary_sensor.station_1_status");
        ///<summary>Station 2 Status</summary>
        public BinarySensorEntity Station2Status => new(_haContext, "binary_sensor.station_2_status");
        ///<summary>Station 3 Status</summary>
        public BinarySensorEntity Station3Status => new(_haContext, "binary_sensor.station_3_status");
        ///<summary>Station 4 Status</summary>
        public BinarySensorEntity Station4Status => new(_haContext, "binary_sensor.station_4_status");
        ///<summary>Station 4 Status</summary>
        public BinarySensorEntity Station4Status2 => new(_haContext, "binary_sensor.station_4_status_2");
        ///<summary>Swp Cool W Level Status</summary>
        public BinarySensorEntity SwpCoolWLevelStatus => new(_haContext, "binary_sensor.swp_cool_w_level_status");
        ///<summary>Swp Cool Water Level Status</summary>
        public BinarySensorEntity SwpCoolWaterLevelStatus => new(_haContext, "binary_sensor.swp_cool_water_level_status");
        ///<summary>SWP Res Empty</summary>
        public BinarySensorEntity SwpResEmpty => new(_haContext, "binary_sensor.swp_res_empty");
        ///<summary>SWP Res Full</summary>
        public BinarySensorEntity SwpResFull => new(_haContext, "binary_sensor.swp_res_full");
        ///<summary>SWP Res Medium</summary>
        public BinarySensorEntity SwpResMedium => new(_haContext, "binary_sensor.swp_res_medium");
        ///<summary>Test Node W Level Status</summary>
        public BinarySensorEntity TestNodeWLevelStatus => new(_haContext, "binary_sensor.test_node_w_level_status");
        ///<summary>Testing Bucket 4ch Status</summary>
        public BinarySensorEntity TestingBucket4chStatus => new(_haContext, "binary_sensor.testing_bucket_4ch_status");
        ///<summary>Tn Res Empty</summary>
        public BinarySensorEntity TnResEmpty => new(_haContext, "binary_sensor.tn_res_empty");
        ///<summary>Tn Res Full</summary>
        public BinarySensorEntity TnResFull => new(_haContext, "binary_sensor.tn_res_full");
        ///<summary>Tn Res Medium</summary>
        public BinarySensorEntity TnResMedium => new(_haContext, "binary_sensor.tn_res_medium");
        ///<summary>Updater</summary>
        public BinarySensorEntity Updater => new(_haContext, "binary_sensor.updater");
        ///<summary>Valve 2 Closed</summary>
        public BinarySensorEntity Valve2Closed => new(_haContext, "binary_sensor.valve_2_closed");
        ///<summary>Valve 2 Open</summary>
        public BinarySensorEntity Valve2Open => new(_haContext, "binary_sensor.valve_2_open");
        ///<summary>Valve Closed</summary>
        public BinarySensorEntity ValveClosed => new(_haContext, "binary_sensor.valve_closed");
        ///<summary>Valve Open</summary>
        public BinarySensorEntity ValveOpen => new(_haContext, "binary_sensor.valve_open");
        ///<summary>Well P&Ts and a A Station Running</summary>
        public BinarySensorEntity WellPTsAndAAStationRunning => new(_haContext, "binary_sensor.well_p_ts_and_a_a_station_running");
        ///<summary>Wonder strawberries Station Running</summary>
        public BinarySensorEntity WonderStrawberriesStationRunning => new(_haContext, "binary_sensor.wonder_strawberries_station_running");
    }

    public partial class ButtonEntities
    {
        private readonly IHaContext _haContext;
        public ButtonEntities(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>OctoPrint Pause Job</summary>
        public ButtonEntity OctoprintPauseJob => new(_haContext, "button.octoprint_pause_job");
        ///<summary>OctoPrint Resume Job</summary>
        public ButtonEntity OctoprintResumeJob => new(_haContext, "button.octoprint_resume_job");
        ///<summary>OctoPrint Stop Job</summary>
        public ButtonEntity OctoprintStopJob => new(_haContext, "button.octoprint_stop_job");
    }

    public partial class CameraEntities
    {
        private readonly IHaContext _haContext;
        public CameraEntities(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>espcam01</summary>
        public CameraEntity Espcam01 => new(_haContext, "camera.espcam01");
        ///<summary>OctoPrint</summary>
        public CameraEntity Octoprint => new(_haContext, "camera.octoprint");
    }

    public partial class ClimateEntities
    {
        private readonly IHaContext _haContext;
        public ClimateEntities(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Home</summary>
        public ClimateEntity Home => new(_haContext, "climate.home");
    }

    public partial class DeviceTrackerEntities
    {
        private readonly IHaContext _haContext;
        public DeviceTrackerEntities(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>amazon-a2bc345cb (Amazon Android device)</summary>
        public DeviceTrackerEntity AmazonA2bc345cbAmazonAndroidDevice => new(_haContext, "device_tracker.amazon_a2bc345cb_amazon_android_device");
        ///<summary>amazon-a2bc345cb-lan (Amazon Android device)</summary>
        public DeviceTrackerEntity AmazonA2bc345cbLanAmazonAndroidDevice => new(_haContext, "device_tracker.amazon_a2bc345cb_lan_amazon_android_device");
        ///<summary>Amazon Kindle (Amazon)</summary>
        public DeviceTrackerEntity AmazonKindleAmazon => new(_haContext, "device_tracker.amazon_kindle_amazon");
        ///<summary>Android-2</summary>
        public DeviceTrackerEntity Android2 => new(_haContext, "device_tracker.android_2");
        ///<summary>co2sensor</summary>
        public DeviceTrackerEntity Co2sensor => new(_haContext, "device_tracker.co2sensor");
        ///<summary>Cody</summary>
        public DeviceTrackerEntity Cody => new(_haContext, "device_tracker.cody");
        ///<summary>db1_water_level</summary>
        public DeviceTrackerEntity Db1WaterLevel => new(_haContext, "device_tracker.db1_water_level");
        ///<summary>db2_water_level</summary>
        public DeviceTrackerEntity Db2WaterLevel => new(_haContext, "device_tracker.db2_water_level");
        ///<summary>db3_water_level</summary>
        public DeviceTrackerEntity Db3WaterLevel => new(_haContext, "device_tracker.db3_water_level");
        ///<summary>db4_water_level</summary>
        public DeviceTrackerEntity Db4WaterLevel => new(_haContext, "device_tracker.db4_water_level");
        ///<summary>db5_water_level</summary>
        public DeviceTrackerEntity Db5WaterLevel => new(_haContext, "device_tracker.db5_water_level");
        ///<summary>db6_water_level</summary>
        public DeviceTrackerEntity Db6WaterLevel => new(_haContext, "device_tracker.db6_water_level");
        ///<summary>EPSOND97AE7 (Epson Printer)</summary>
        public DeviceTrackerEntity Epsond97ae7EpsonPrinter => new(_haContext, "device_tracker.epsond97ae7_epson_printer");
        ///<summary>ESP_76FAF5</summary>
        public DeviceTrackerEntity Esp76faf5 => new(_haContext, "device_tracker.esp_76faf5");
        ///<summary>fresh_res_water_level</summary>
        public DeviceTrackerEntity FreshResWaterLevel => new(_haContext, "device_tracker.fresh_res_water_level");
        ///<summary>gh_camera</summary>
        public DeviceTrackerEntity GhCamera => new(_haContext, "device_tracker.gh_camera");
        ///<summary>ghbacklight</summary>
        public DeviceTrackerEntity Ghbacklight => new(_haContext, "device_tracker.ghbacklight");
        ///<summary>ghlightfront</summary>
        public DeviceTrackerEntity Ghlightfront => new(_haContext, "device_tracker.ghlightfront");
        ///<summary>ghtemp2</summary>
        public DeviceTrackerEntity Ghtemp2 => new(_haContext, "device_tracker.ghtemp2");
        ///<summary>greenhousetemp</summary>
        public DeviceTrackerEntity Greenhousetemp => new(_haContext, "device_tracker.greenhousetemp");
        ///<summary>homeassistant (Raspberry Pi)</summary>
        public DeviceTrackerEntity HomeassistantRaspberryPi => new(_haContext, "device_tracker.homeassistant_raspberry_pi");
        ///<summary>L08779 (Windows device)</summary>
        public DeviceTrackerEntity L08779WindowsDevice => new(_haContext, "device_tracker.l08779_windows_device");
        ///<summary>LG</summary>
        public DeviceTrackerEntity Lg => new(_haContext, "device_tracker.lg");
        ///<summary>Master (Chromecast)</summary>
        public DeviceTrackerEntity MasterChromecast => new(_haContext, "device_tracker.master_chromecast");
        ///<summary>Microsoft</summary>
        public DeviceTrackerEntity Microsoft => new(_haContext, "device_tracker.microsoft");
        ///<summary>Mollys-iPad</summary>
        public DeviceTrackerEntity MollysIpad => new(_haContext, "device_tracker.mollys_ipad");
        ///<summary>Mollys-iPhone</summary>
        public DeviceTrackerEntity MollysIphone => new(_haContext, "device_tracker.mollys_iphone");
        ///<summary>Motorola Android device (Motorola)</summary>
        public DeviceTrackerEntity MotorolaAndroidDeviceMotorola => new(_haContext, "device_tracker.motorola_android_device_motorola");
        ///<summary>Motorola Android device (Motorola)</summary>
        public DeviceTrackerEntity MotorolaAndroidDeviceMotorola2 => new(_haContext, "device_tracker.motorola_android_device_motorola_2");
        ///<summary>myx_00186156838* (Ooma)</summary>
        public DeviceTrackerEntity Myx00186156838Ooma => new(_haContext, "device_tracker.myx_00186156838_ooma");
        ///<summary>Nest Thermostat (Google)</summary>
        public DeviceTrackerEntity NestThermostatGoogle => new(_haContext, "device_tracker.nest_thermostat_google");
        ///<summary>nft_water_level</summary>
        public DeviceTrackerEntity NftWaterLevel => new(_haContext, "device_tracker.nft_water_level");
        ///<summary>NGELOTTE10LT (Dell)</summary>
        public DeviceTrackerEntity Ngelotte10ltDell => new(_haContext, "device_tracker.ngelotte10lt_dell");
        ///<summary>NGELOTTE10LT (Dell)</summary>
        public DeviceTrackerEntity Ngelotte10ltDell2 => new(_haContext, "device_tracker.ngelotte10lt_dell_2");
        ///<summary>NGELOTTE10LT (Windows device)</summary>
        public DeviceTrackerEntity Ngelotte10ltWindowsDevice => new(_haContext, "device_tracker.ngelotte10lt_windows_device");
        ///<summary>Nicholas's Fire TV (AFTMM)</summary>
        public DeviceTrackerEntity NicholasSFireTvAftmm => new(_haContext, "device_tracker.nicholas_s_fire_tv_aftmm");
        ///<summary>Nintendo Switch (Nintendo)</summary>
        public DeviceTrackerEntity NintendoSwitchNintendo => new(_haContext, "device_tracker.nintendo_switch_nintendo");
        ///<summary>Nuheat</summary>
        public DeviceTrackerEntity Nuheat => new(_haContext, "device_tracker.nuheat");
        ///<summary>octopi (Raspberry Pi)</summary>
        public DeviceTrackerEntity OctopiRaspberryPi => new(_haContext, "device_tracker.octopi_raspberry_pi");
        ///<summary>octopi (Raspberry Pi)</summary>
        public DeviceTrackerEntity OctopiRaspberryPi2 => new(_haContext, "device_tracker.octopi_raspberry_pi_2");
        ///<summary>peristalticnutrients</summary>
        public DeviceTrackerEntity Peristalticnutrients => new(_haContext, "device_tracker.peristalticnutrients");
        ///<summary>powerstrip_mid</summary>
        public DeviceTrackerEntity PowerstripMid => new(_haContext, "device_tracker.powerstrip_mid");
        ///<summary>powerstripne</summary>
        public DeviceTrackerEntity Powerstripne => new(_haContext, "device_tracker.powerstripne");
        ///<summary>powerstriptestzone</summary>
        public DeviceTrackerEntity Powerstriptestzone => new(_haContext, "device_tracker.powerstriptestzone");
        ///<summary>pwstrip1</summary>
        public DeviceTrackerEntity Pwstrip1 => new(_haContext, "device_tracker.pwstrip1");
        ///<summary>Samsung</summary>
        public DeviceTrackerEntity Samsung => new(_haContext, "device_tracker.samsung");
        ///<summary>Samsung</summary>
        public DeviceTrackerEntity Samsung2 => new(_haContext, "device_tracker.samsung_2");
        ///<summary>Samsung flex</summary>
        public DeviceTrackerEntity SamsungFlex => new(_haContext, "device_tracker.samsung_flex");
        ///<summary>SamsungFlex</summary>
        public DeviceTrackerEntity Samsungflex => new(_haContext, "device_tracker.samsungflex");
        ///<summary>sbasic1</summary>
        public DeviceTrackerEntity Sbasic1 => new(_haContext, "device_tracker.sbasic1");
        ///<summary>sonoff4chz1</summary>
        public DeviceTrackerEntity Sonoff4chz1 => new(_haContext, "device_tracker.sonoff4chz1");
        ///<summary>sonoff4chz2</summary>
        public DeviceTrackerEntity Sonoff4chz2 => new(_haContext, "device_tracker.sonoff4chz2");
        ///<summary>sonoff4chz3</summary>
        public DeviceTrackerEntity Sonoff4chz3 => new(_haContext, "device_tracker.sonoff4chz3");
        ///<summary>station4</summary>
        public DeviceTrackerEntity Station4 => new(_haContext, "device_tracker.station4");
        ///<summary>swp_cool_water_level</summary>
        public DeviceTrackerEntity SwpCoolWaterLevel => new(_haContext, "device_tracker.swp_cool_water_level");
        ///<summary>test_node_water_level</summary>
        public DeviceTrackerEntity TestNodeWaterLevel => new(_haContext, "device_tracker.test_node_water_level");
        ///<summary>testingbucketsf4ch</summary>
        public DeviceTrackerEntity Testingbucketsf4ch => new(_haContext, "device_tracker.testingbucketsf4ch");
        ///<summary>Unnamed device</summary>
        public DeviceTrackerEntity UnnamedDevice => new(_haContext, "device_tracker.unnamed_device");
        ///<summary>Unnamed device</summary>
        public DeviceTrackerEntity UnnamedDevice2 => new(_haContext, "device_tracker.unnamed_device_2");
        ///<summary>VMB4000 (Netgear)</summary>
        public DeviceTrackerEntity Vmb4000Netgear => new(_haContext, "device_tracker.vmb4000_netgear");
        ///<summary>watermonitor</summary>
        public DeviceTrackerEntity Watermonitor => new(_haContext, "device_tracker.watermonitor");
        ///<summary>Windows device</summary>
        public DeviceTrackerEntity WindowsDevice => new(_haContext, "device_tracker.windows_device");
        ///<summary>Xbox-SystemOS (Xbox One)</summary>
        public DeviceTrackerEntity XboxSystemosXboxOne => new(_haContext, "device_tracker.xbox_systemos_xbox_one");
    }

    public partial class InputBooleanEntities
    {
        private readonly IHaContext _haContext;
        public InputBooleanEntities(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>dev_netdaemon_app_model_hello_yaml_app</summary>
        public InputBooleanEntity DevNetdaemonAppModelHelloYamlApp => new(_haContext, "input_boolean.dev_netdaemon_app_model_hello_yaml_app");
        ///<summary>dev_netdaemon_extensions_scheduling_scheduling_app</summary>
        public InputBooleanEntity DevNetdaemonExtensionsSchedulingSchedulingApp => new(_haContext, "input_boolean.dev_netdaemon_extensions_scheduling_scheduling_app");
        ///<summary>dev_netdaemon_hass_model_hello_world_app</summary>
        public InputBooleanEntity DevNetdaemonHassModelHelloWorldApp => new(_haContext, "input_boolean.dev_netdaemon_hass_model_hello_world_app");
        ///<summary>dev_netdaemon_hass_model_light_on_movement</summary>
        public InputBooleanEntity DevNetdaemonHassModelLightOnMovement => new(_haContext, "input_boolean.dev_netdaemon_hass_model_light_on_movement");
        ///<summary>Testing Tank Hold</summary>
        public InputBooleanEntity TestingTankHold => new(_haContext, "input_boolean.testing_tank_hold");
    }

    public partial class InputNumberEntities
    {
        private readonly IHaContext _haContext;
        public InputNumberEntities(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>NutrientUnitsToAdd</summary>
        public InputNumberEntity Nutrientunitstoadd => new(_haContext, "input_number.nutrientunitstoadd");
    }

    public partial class InputSelectEntities
    {
        private readonly IHaContext _haContext;
        public InputSelectEntities(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Reservoir_reservation</summary>
        public InputSelectEntity ReservoirRes => new(_haContext, "input_select.reservoir_res");
    }

    public partial class LightEntities
    {
        private readonly IHaContext _haContext;
        public LightEntities(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Backyard Access Point</summary>
        public LightEntity BackyardAccessPoint => new(_haContext, "light.backyard_access_point");
        ///<summary>Family Room Access Point</summary>
        public LightEntity FamilyRoomAccessPoint => new(_haContext, "light.family_room_access_point");
        ///<summary>Garage Access Point</summary>
        public LightEntity GarageAccessPoint => new(_haContext, "light.garage_access_point");
        ///<summary>Master Bedroom Access Point</summary>
        public LightEntity MasterBedroomAccessPoint => new(_haContext, "light.master_bedroom_access_point");
        ///<summary>Office Access Point</summary>
        public LightEntity OfficeAccessPoint => new(_haContext, "light.office_access_point");
    }

    public partial class PersonEntities
    {
        private readonly IHaContext _haContext;
        public PersonEntities(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Nick Gelotte</summary>
        public PersonEntity NickGelotte => new(_haContext, "person.nick_gelotte");
    }

    public partial class ScriptEntities
    {
        private readonly IHaContext _haContext;
        public ScriptEntities(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Add dose to current zone</summary>
        public ScriptEntity AddDoseToCurrentZone => new(_haContext, "script.add_dose_to_current_zone");
        ///<summary>Move Pump 1</summary>
        public ScriptEntity MovePump1 => new(_haContext, "script.move_pump_1");
        ///<summary>Move Pump 2</summary>
        public ScriptEntity MovePump2 => new(_haContext, "script.move_pump_2");
        ///<summary>Move Pump 3</summary>
        public ScriptEntity MovePump3 => new(_haContext, "script.move_pump_3");
        ///<summary>Refill Current Bucket</summary>
        public ScriptEntity RefillCurrentBucket => new(_haContext, "script.refill_current_bucket");
        ///<summary>Refill Fresh Water Tank</summary>
        public ScriptEntity RefillFreshWaterTank => new(_haContext, "script.refill_fresh_water_tank");
        ///<summary>Refill Swp Cooler</summary>
        public ScriptEntity RefillSwpCooler => new(_haContext, "script.refill_swp_cooler");
    }

    public partial class SensorEntities
    {
        private readonly IHaContext _haContext;
        public SensorEntities(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Back bushes Station Status</summary>
        public SensorEntity BackBushesStationStatus => new(_haContext, "sensor.back_bushes_station_status");
        ///<summary>Berries Station Status</summary>
        public SensorEntity BerriesStationStatus => new(_haContext, "sensor.berries_station_status");
        ///<summary>ble mac 71B2F81728754835A94EF9B6C31A5A24</summary>
        public SensorEntity BleMac71b2f81728754835a94ef9b6c31a5a24 => new(_haContext, "sensor.ble_mac_71b2f81728754835a94ef9b6c31a5a24");
        ///<summary>ble mac 74278BDAB64445208F0C720EAF059935</summary>
        public SensorEntity BleMac74278bdab64445208f0c720eaf059935 => new(_haContext, "sensor.ble_mac_74278bdab64445208f0c720eaf059935");
        ///<summary>ble major 71B2F81728754835A94EF9B6C31A5A24</summary>
        public SensorEntity BleMajor71b2f81728754835a94ef9b6c31a5a24 => new(_haContext, "sensor.ble_major_71b2f81728754835a94ef9b6c31a5a24");
        ///<summary>ble major 74278BDAB64445208F0C720EAF059935</summary>
        public SensorEntity BleMajor74278bdab64445208f0c720eaf059935 => new(_haContext, "sensor.ble_major_74278bdab64445208f0c720eaf059935");
        ///<summary>ble minor 71B2F81728754835A94EF9B6C31A5A24</summary>
        public SensorEntity BleMinor71b2f81728754835a94ef9b6c31a5a24 => new(_haContext, "sensor.ble_minor_71b2f81728754835a94ef9b6c31a5a24");
        ///<summary>ble minor 74278BDAB64445208F0C720EAF059935</summary>
        public SensorEntity BleMinor74278bdab64445208f0c720eaf059935 => new(_haContext, "sensor.ble_minor_74278bdab64445208f0c720eaf059935");
        ///<summary>DB1 EC</summary>
        public SensorEntity Db1Ec => new(_haContext, "sensor.db1_ec");
        ///<summary>DB1 temp</summary>
        public SensorEntity Db1Temp => new(_haContext, "sensor.db1_temp");
        ///<summary>DB1 Water Level State</summary>
        public SensorEntity Db1WaterLevelState => new(_haContext, "sensor.db1_water_level_state");
        ///<summary>DB2 EC</summary>
        public SensorEntity Db2Ec => new(_haContext, "sensor.db2_ec");
        ///<summary>DB2 Temp</summary>
        public SensorEntity Db2Temp => new(_haContext, "sensor.db2_temp");
        ///<summary>DB2 Water Level State</summary>
        public SensorEntity Db2WaterLevelState => new(_haContext, "sensor.db2_water_level_state");
        ///<summary>DB3 EC</summary>
        public SensorEntity Db3Ec => new(_haContext, "sensor.db3_ec");
        ///<summary>DB3 Temp</summary>
        public SensorEntity Db3Temp => new(_haContext, "sensor.db3_temp");
        ///<summary>DB3 Water Level State</summary>
        public SensorEntity Db3WaterLevelState => new(_haContext, "sensor.db3_water_level_state");
        ///<summary>DB4 EC</summary>
        public SensorEntity Db4Ec => new(_haContext, "sensor.db4_ec");
        ///<summary>DB4 Temp</summary>
        public SensorEntity Db4Temp => new(_haContext, "sensor.db4_temp");
        ///<summary>DB4 Water Level State</summary>
        public SensorEntity Db4WaterLevelState => new(_haContext, "sensor.db4_water_level_state");
        ///<summary>DB5 EC</summary>
        public SensorEntity Db5Ec => new(_haContext, "sensor.db5_ec");
        ///<summary>DB5 Temp</summary>
        public SensorEntity Db5Temp => new(_haContext, "sensor.db5_temp");
        ///<summary>DB5 Water Level State</summary>
        public SensorEntity Db5WaterLevelState => new(_haContext, "sensor.db5_water_level_state");
        ///<summary>DB6 EC</summary>
        public SensorEntity Db6Ec => new(_haContext, "sensor.db6_ec");
        ///<summary>DB6 Temp</summary>
        public SensorEntity Db6Temp => new(_haContext, "sensor.db6_temp");
        ///<summary>DB6 Water Level State</summary>
        public SensorEntity Db6WaterLevelState => new(_haContext, "sensor.db6_water_level_state");
        ///<summary>Fresh Res Water Level State</summary>
        public SensorEntity FreshResWaterLevelState => new(_haContext, "sensor.fresh_res_water_level_state");
        ///<summary>Front Field Station Status</summary>
        public SensorEntity FrontFieldStationStatus => new(_haContext, "sensor.front_field_station_status");
        ///<summary>Front flower sprinkler Station Status</summary>
        public SensorEntity FrontFlowerSprinklerStationStatus => new(_haContext, "sensor.front_flower_sprinkler_station_status");
        ///<summary>Fruit trees Station Status</summary>
        public SensorEntity FruitTreesStationStatus => new(_haContext, "sensor.fruit_trees_station_status");
        ///<summary>Home assistant beans  Station Status</summary>
        public SensorEntity HomeAssistantBeansStationStatus => new(_haContext, "sensor.home_assistant_beans_station_status");
        ///<summary>local_ip</summary>
        public SensorEntity LocalIp => new(_haContext, "sensor.local_ip");
        ///<summary>Nature sprinkler Station Status</summary>
        public SensorEntity NatureSprinklerStationStatus => new(_haContext, "sensor.nature_sprinkler_station_status");
        ///<summary>netdaemon_status</summary>
        public SensorEntity NetdaemonStatus => new(_haContext, "sensor.netdaemon_status");
        ///<summary>nft EC</summary>
        public SensorEntity NftEc => new(_haContext, "sensor.nft_ec");
        ///<summary>NFT Temp</summary>
        public SensorEntity NftTemp => new(_haContext, "sensor.nft_temp");
        ///<summary>NFT Water Level</summary>
        public SensorEntity NftWaterLevelState => new(_haContext, "sensor.nft_water_level_state");
        ///<summary>NFT Water Level State</summary>
        public SensorEntity NftWaterLevelState2 => new(_haContext, "sensor.nft_water_level_state_2");
        ///<summary>OctoPrint Current State</summary>
        public SensorEntity OctoprintCurrentState => new(_haContext, "sensor.octoprint_current_state");
        ///<summary>OctoPrint Estimated Finish Time</summary>
        public SensorEntity OctoprintEstimatedFinishTime => new(_haContext, "sensor.octoprint_estimated_finish_time");
        ///<summary>OctoPrint Start Time</summary>
        public SensorEntity OctoprintStartTime => new(_haContext, "sensor.octoprint_start_time");
        ///<summary>Open Sprinkler Last Run</summary>
        public SensorEntity OpenSprinklerLastRun => new(_haContext, "sensor.open_sprinkler_last_run");
        ///<summary>Open Sprinkler Rain Delay Stop Time</summary>
        public SensorEntity OpenSprinklerRainDelayStopTime => new(_haContext, "sensor.open_sprinkler_rain_delay_stop_time");
        ///<summary>OpenWeatherMap Condition</summary>
        public SensorEntity OpenweathermapCondition => new(_haContext, "sensor.openweathermap_condition");
        ///<summary>OpenWeatherMap Forecast Condition</summary>
        public SensorEntity OpenweathermapForecastCondition => new(_haContext, "sensor.openweathermap_forecast_condition");
        ///<summary>OpenWeatherMap Forecast Time</summary>
        public SensorEntity OpenweathermapForecastTime => new(_haContext, "sensor.openweathermap_forecast_time");
        ///<summary>OpenWeatherMap Precipitation kind</summary>
        public SensorEntity OpenweathermapPrecipitationKind => new(_haContext, "sensor.openweathermap_precipitation_kind");
        ///<summary>OpenWeatherMap Weather</summary>
        public SensorEntity OpenweathermapWeather => new(_haContext, "sensor.openweathermap_weather");
        ///<summary>OpenWeatherMap Weather Code</summary>
        public SensorEntity OpenweathermapWeatherCode => new(_haContext, "sensor.openweathermap_weather_code");
        ///<summary>S07 Station Status</summary>
        public SensorEntity S07StationStatus => new(_haContext, "sensor.s07_station_status");
        ///<summary>S08 Station Status</summary>
        public SensorEntity S08StationStatus => new(_haContext, "sensor.s08_station_status");
        ///<summary>S14 Station Status</summary>
        public SensorEntity S14StationStatus => new(_haContext, "sensor.s14_station_status");
        ///<summary>S15 Station Status</summary>
        public SensorEntity S15StationStatus => new(_haContext, "sensor.s15_station_status");
        ///<summary>S16 Station Status</summary>
        public SensorEntity S16StationStatus => new(_haContext, "sensor.s16_station_status");
        ///<summary>S17 Station Status</summary>
        public SensorEntity S17StationStatus => new(_haContext, "sensor.s17_station_status");
        ///<summary>S18 Station Status</summary>
        public SensorEntity S18StationStatus => new(_haContext, "sensor.s18_station_status");
        ///<summary>S19 Station Status</summary>
        public SensorEntity S19StationStatus => new(_haContext, "sensor.s19_station_status");
        ///<summary>S20 Station Status</summary>
        public SensorEntity S20StationStatus => new(_haContext, "sensor.s20_station_status");
        ///<summary>S21 Station Status</summary>
        public SensorEntity S21StationStatus => new(_haContext, "sensor.s21_station_status");
        ///<summary>S22 Station Status</summary>
        public SensorEntity S22StationStatus => new(_haContext, "sensor.s22_station_status");
        ///<summary>S23 Station Status</summary>
        public SensorEntity S23StationStatus => new(_haContext, "sensor.s23_station_status");
        ///<summary>S24 Station Status</summary>
        public SensorEntity S24StationStatus => new(_haContext, "sensor.s24_station_status");
        ///<summary>SamsungFlex Battery Health</summary>
        public SensorEntity SamsungflexBatteryHealth => new(_haContext, "sensor.samsungflex_battery_health");
        ///<summary>SamsungFlex Battery State</summary>
        public SensorEntity SamsungflexBatteryState => new(_haContext, "sensor.samsungflex_battery_state");
        ///<summary>SamsungFlex Charger Type</summary>
        public SensorEntity SamsungflexChargerType => new(_haContext, "sensor.samsungflex_charger_type");
        ///<summary>Side back grass Station Status</summary>
        public SensorEntity SideBackGrassStationStatus => new(_haContext, "sensor.side_back_grass_station_status");
        ///<summary>Snap peas and sunflowers Station Status</summary>
        public SensorEntity SnapPeasAndSunflowersStationStatus => new(_haContext, "sensor.snap_peas_and_sunflowers_station_status");
        ///<summary>Swp Cool W Level State</summary>
        public SensorEntity SwpCoolWLevelState => new(_haContext, "sensor.swp_cool_w_level_state");
        ///<summary>SWP Cooler Water Level</summary>
        public SensorEntity SwpCoolWaterLevelState => new(_haContext, "sensor.swp_cool_water_level_state");
        ///<summary>Test Node W Level State</summary>
        public SensorEntity TestNodeWLevelState => new(_haContext, "sensor.test_node_w_level_state");
        ///<summary>Well P&Ts and a A Station Status</summary>
        public SensorEntity WellPTsAndAAStationStatus => new(_haContext, "sensor.well_p_ts_and_a_a_station_status");
        ///<summary>Wonder strawberries Station Status</summary>
        public SensorEntity WonderStrawberriesStationStatus => new(_haContext, "sensor.wonder_strawberries_station_status");
        ///<summary>ble battery A4C13818A9E5</summary>
        public NumericSensorEntity BleBatteryA4c13818a9e5 => new(_haContext, "sensor.ble_battery_a4c13818a9e5");
        ///<summary>ble battery GH_Indoor_Temp</summary>
        public NumericSensorEntity BleBatteryGhIndoorTemp => new(_haContext, "sensor.ble_battery_gh_indoor_temp");
        ///<summary>ble battery Gh_Temp_External</summary>
        public NumericSensorEntity BleBatteryGhTempExternal => new(_haContext, "sensor.ble_battery_gh_temp_external");
        ///<summary>ble humidity A4C13818A9E5</summary>
        public NumericSensorEntity BleHumidityA4c13818a9e5 => new(_haContext, "sensor.ble_humidity_a4c13818a9e5");
        ///<summary>Ext hum ble</summary>
        public NumericSensorEntity BleHumidityGhExternal => new(_haContext, "sensor.ble_humidity_gh_external");
        ///<summary>Ind h ble</summary>
        public NumericSensorEntity BleHumidityGhIndoorTemp => new(_haContext, "sensor.ble_humidity_gh_indoor_temp");
        ///<summary>ble humidity outdoor A4C13818A9E5</summary>
        public NumericSensorEntity BleHumidityOutdoorA4c13818a9e5 => new(_haContext, "sensor.ble_humidity_outdoor_a4c13818a9e5");
        ///<summary>ble measured power 71B2F81728754835A94EF9B6C31A5A24</summary>
        public NumericSensorEntity BleMeasuredPower71b2f81728754835a94ef9b6c31a5a24 => new(_haContext, "sensor.ble_measured_power_71b2f81728754835a94ef9b6c31a5a24");
        ///<summary>ble measured power 74278BDAB64445208F0C720EAF059935</summary>
        public NumericSensorEntity BleMeasuredPower74278bdab64445208f0c720eaf059935 => new(_haContext, "sensor.ble_measured_power_74278bdab64445208f0c720eaf059935");
        ///<summary>ble rssi 71B2F81728754835A94EF9B6C31A5A24</summary>
        public NumericSensorEntity BleRssi71b2f81728754835a94ef9b6c31a5a24 => new(_haContext, "sensor.ble_rssi_71b2f81728754835a94ef9b6c31a5a24");
        ///<summary>ble rssi 74278BDAB64445208F0C720EAF059935</summary>
        public NumericSensorEntity BleRssi74278bdab64445208f0c720eaf059935 => new(_haContext, "sensor.ble_rssi_74278bdab64445208f0c720eaf059935");
        ///<summary>ble rssi A4C13818A9E5</summary>
        public NumericSensorEntity BleRssiA4c13818a9e5 => new(_haContext, "sensor.ble_rssi_a4c13818a9e5");
        ///<summary>ble rssi A4C138A467C1</summary>
        public NumericSensorEntity BleRssiA4c138a467c1 => new(_haContext, "sensor.ble_rssi_a4c138a467c1");
        ///<summary>ble rssi A4C138D39A2A</summary>
        public NumericSensorEntity BleRssiA4c138d39a2a => new(_haContext, "sensor.ble_rssi_a4c138d39a2a");
        ///<summary>ble temperature A4C13818A9E5</summary>
        public NumericSensorEntity BleTemperatureA4c13818a9e5 => new(_haContext, "sensor.ble_temperature_a4c13818a9e5");
        ///<summary>Int temp ble</summary>
        public NumericSensorEntity BleTemperatureGhIndoorTemp => new(_haContext, "sensor.ble_temperature_gh_indoor_temp");
        ///<summary>Ext temp ble</summary>
        public NumericSensorEntity BleTemperatureGhTempExternal => new(_haContext, "sensor.ble_temperature_gh_temp_external");
        ///<summary>ble temperature outdoor A4C13818A9E5</summary>
        public NumericSensorEntity BleTemperatureOutdoorA4c13818a9e5 => new(_haContext, "sensor.ble_temperature_outdoor_a4c13818a9e5");
        ///<summary>ble voltage GH_Indoor_Temp</summary>
        public NumericSensorEntity BleVoltageGhIndoorTemp => new(_haContext, "sensor.ble_voltage_gh_indoor_temp");
        ///<summary>ble voltage Gh_Temp_External</summary>
        public NumericSensorEntity BleVoltageGhTempExternal => new(_haContext, "sensor.ble_voltage_gh_temp_external");
        ///<summary>daily_energy</summary>
        public NumericSensorEntity DailyEnergy => new(_haContext, "sensor.daily_energy");
        ///<summary>EC Sensor</summary>
        public NumericSensorEntity EcSensor => new(_haContext, "sensor.ec_sensor");
        ///<summary>Ext Hum</summary>
        public NumericSensorEntity ExteriorHumidity => new(_haContext, "sensor.exterior_humidity");
        ///<summary>Ext Temp</summary>
        public NumericSensorEntity ExteriorTemperature => new(_haContext, "sensor.exterior_temperature");
        ///<summary>GH Interal Protected Humidity</summary>
        public NumericSensorEntity GhInteralProtectedHumidity => new(_haContext, "sensor.gh_interal_protected_humidity");
        ///<summary>GH Interal Protected Temp</summary>
        public NumericSensorEntity GhInteralProtectedTemp => new(_haContext, "sensor.gh_interal_protected_temp");
        ///<summary>Google Wifi System AAAAABycHeI Connected Devices</summary>
        public NumericSensorEntity GoogleWifiSystemAaaaabycheiConnectedDevices => new(_haContext, "sensor.google_wifi_system_aaaaabychei_connected_devices");
        ///<summary>Google Wifi System AAAAABycHeI Download Speed</summary>
        public NumericSensorEntity GoogleWifiSystemAaaaabycheiDownloadSpeed => new(_haContext, "sensor.google_wifi_system_aaaaabychei_download_speed");
        ///<summary>Google Wifi System AAAAABycHeI Download Traffic</summary>
        public NumericSensorEntity GoogleWifiSystemAaaaabycheiDownloadTraffic => new(_haContext, "sensor.google_wifi_system_aaaaabychei_download_traffic");
        ///<summary>Google Wifi System AAAAABycHeI Guest Devices</summary>
        public NumericSensorEntity GoogleWifiSystemAaaaabycheiGuestDevices => new(_haContext, "sensor.google_wifi_system_aaaaabychei_guest_devices");
        ///<summary>Google Wifi System AAAAABycHeI Total Devices</summary>
        public NumericSensorEntity GoogleWifiSystemAaaaabycheiTotalDevices => new(_haContext, "sensor.google_wifi_system_aaaaabychei_total_devices");
        ///<summary>Google Wifi System AAAAABycHeI Upload Speed</summary>
        public NumericSensorEntity GoogleWifiSystemAaaaabycheiUploadSpeed => new(_haContext, "sensor.google_wifi_system_aaaaabychei_upload_speed");
        ///<summary>Google Wifi System AAAAABycHeI Upload Traffic</summary>
        public NumericSensorEntity GoogleWifiSystemAaaaabycheiUploadTraffic => new(_haContext, "sensor.google_wifi_system_aaaaabychei_upload_traffic");
        ///<summary>Greenhosue CO2 Temp</summary>
        public NumericSensorEntity GreenhosueCo2Temp => new(_haContext, "sensor.greenhosue_co2_temp");
        ///<summary>Greenhouse CO2</summary>
        public NumericSensorEntity GreenhouseCo2 => new(_haContext, "sensor.greenhouse_co2");
        ///<summary>Greenhouse CO2 Hum</summary>
        public NumericSensorEntity GreenhouseCo2Hum => new(_haContext, "sensor.greenhouse_co2_hum");
        ///<summary>GreenHouse humidity</summary>
        public NumericSensorEntity GreenhouseHumidity => new(_haContext, "sensor.greenhouse_humidity");
        ///<summary>Int Hum</summary>
        public NumericSensorEntity GreenhouseInternalHumidity => new(_haContext, "sensor.greenhouse_internal_humidity");
        ///<summary>Int Temp</summary>
        public NumericSensorEntity GreenhouseInternalTemperature => new(_haContext, "sensor.greenhouse_internal_temperature");
        ///<summary>GreenHouse temp</summary>
        public NumericSensorEntity GreenhouseTemp => new(_haContext, "sensor.greenhouse_temp");
        ///<summary>hacs</summary>
        public NumericSensorEntity Hacs => new(_haContext, "sensor.hacs");
        ///<summary>Indoor Temperature</summary>
        public NumericSensorEntity IndoorTemperature => new(_haContext, "sensor.indoor_temperature");
        ///<summary>Marla Battery Level</summary>
        public NumericSensorEntity MarlaBatteryLevel => new(_haContext, "sensor.marla_battery_level");
        ///<summary>monthly_energy</summary>
        public NumericSensorEntity MonthlyEnergy => new(_haContext, "sensor.monthly_energy");
        ///<summary>OctoPrint actual bed temp</summary>
        public NumericSensorEntity OctoprintActualBedTemp => new(_haContext, "sensor.octoprint_actual_bed_temp");
        ///<summary>OctoPrint actual tool0 temp</summary>
        public NumericSensorEntity OctoprintActualTool0Temp => new(_haContext, "sensor.octoprint_actual_tool0_temp");
        ///<summary>OctoPrint Job Percentage</summary>
        public NumericSensorEntity OctoprintJobPercentage => new(_haContext, "sensor.octoprint_job_percentage");
        ///<summary>OctoPrint target bed temp</summary>
        public NumericSensorEntity OctoprintTargetBedTemp => new(_haContext, "sensor.octoprint_target_bed_temp");
        ///<summary>OctoPrint target tool0 temp</summary>
        public NumericSensorEntity OctoprintTargetTool0Temp => new(_haContext, "sensor.octoprint_target_tool0_temp");
        ///<summary>Open Sprinkler Flow Rate</summary>
        public NumericSensorEntity OpenSprinklerFlowRate => new(_haContext, "sensor.open_sprinkler_flow_rate");
        ///<summary>Open Sprinkler Water Level</summary>
        public NumericSensorEntity OpenSprinklerWaterLevel => new(_haContext, "sensor.open_sprinkler_water_level");
        ///<summary>OpenWeatherMap Cloud coverage</summary>
        public NumericSensorEntity OpenweathermapCloudCoverage => new(_haContext, "sensor.openweathermap_cloud_coverage");
        ///<summary>OpenWeatherMap Dew Point</summary>
        public NumericSensorEntity OpenweathermapDewPoint => new(_haContext, "sensor.openweathermap_dew_point");
        ///<summary>OpenWeatherMap Feels like temperature</summary>
        public NumericSensorEntity OpenweathermapFeelsLikeTemperature => new(_haContext, "sensor.openweathermap_feels_like_temperature");
        ///<summary>OpenWeatherMap Forecast Cloud coverage</summary>
        public NumericSensorEntity OpenweathermapForecastCloudCoverage => new(_haContext, "sensor.openweathermap_forecast_cloud_coverage");
        ///<summary>OpenWeatherMap Forecast Precipitation</summary>
        public NumericSensorEntity OpenweathermapForecastPrecipitation => new(_haContext, "sensor.openweathermap_forecast_precipitation");
        ///<summary>OpenWeatherMap Forecast Precipitation probability</summary>
        public NumericSensorEntity OpenweathermapForecastPrecipitationProbability => new(_haContext, "sensor.openweathermap_forecast_precipitation_probability");
        ///<summary>OpenWeatherMap Forecast Pressure</summary>
        public NumericSensorEntity OpenweathermapForecastPressure => new(_haContext, "sensor.openweathermap_forecast_pressure");
        ///<summary>OpenWeatherMap Forecast Temperature</summary>
        public NumericSensorEntity OpenweathermapForecastTemperature => new(_haContext, "sensor.openweathermap_forecast_temperature");
        ///<summary>OpenWeatherMap Forecast Temperature Low</summary>
        public NumericSensorEntity OpenweathermapForecastTemperatureLow => new(_haContext, "sensor.openweathermap_forecast_temperature_low");
        ///<summary>OpenWeatherMap Forecast Wind bearing</summary>
        public NumericSensorEntity OpenweathermapForecastWindBearing => new(_haContext, "sensor.openweathermap_forecast_wind_bearing");
        ///<summary>OpenWeatherMap Forecast Wind speed</summary>
        public NumericSensorEntity OpenweathermapForecastWindSpeed => new(_haContext, "sensor.openweathermap_forecast_wind_speed");
        ///<summary>OpenWeatherMap Humidity</summary>
        public NumericSensorEntity OpenweathermapHumidity => new(_haContext, "sensor.openweathermap_humidity");
        ///<summary>OpenWeatherMap Pressure</summary>
        public NumericSensorEntity OpenweathermapPressure => new(_haContext, "sensor.openweathermap_pressure");
        ///<summary>OpenWeatherMap Rain</summary>
        public NumericSensorEntity OpenweathermapRain => new(_haContext, "sensor.openweathermap_rain");
        ///<summary>OpenWeatherMap Snow</summary>
        public NumericSensorEntity OpenweathermapSnow => new(_haContext, "sensor.openweathermap_snow");
        ///<summary>OpenWeatherMap Temperature</summary>
        public NumericSensorEntity OpenweathermapTemperature => new(_haContext, "sensor.openweathermap_temperature");
        ///<summary>OpenWeatherMap UV Index</summary>
        public NumericSensorEntity OpenweathermapUvIndex => new(_haContext, "sensor.openweathermap_uv_index");
        ///<summary>OpenWeatherMap Visibility</summary>
        public NumericSensorEntity OpenweathermapVisibility => new(_haContext, "sensor.openweathermap_visibility");
        ///<summary>OpenWeatherMap Wind bearing</summary>
        public NumericSensorEntity OpenweathermapWindBearing => new(_haContext, "sensor.openweathermap_wind_bearing");
        ///<summary>OpenWeatherMap Wind speed</summary>
        public NumericSensorEntity OpenweathermapWindSpeed => new(_haContext, "sensor.openweathermap_wind_speed");
        ///<summary>Outdoor Temperature</summary>
        public NumericSensorEntity OutdoorTemperature => new(_haContext, "sensor.outdoor_temperature");
        ///<summary>Power Strip 1 WiFi Status</summary>
        public NumericSensorEntity PowerStrip1WifiStatus => new(_haContext, "sensor.power_strip_1_wifi_status");
        ///<summary>Power Strip Mid WiFi Status</summary>
        public NumericSensorEntity PowerStripMidWifiStatus => new(_haContext, "sensor.power_strip_mid_wifi_status");
        ///<summary>Power Strip Test Zone WiFi Status</summary>
        public NumericSensorEntity PowerStripTestZoneWifiStatus => new(_haContext, "sensor.power_strip_test_zone_wifi_status");
        ///<summary>PowerStripNE WiFi Status</summary>
        public NumericSensorEntity PowerstripneWifiStatus => new(_haContext, "sensor.powerstripne_wifi_status");
        ///<summary>SamsungFlex Battery Level</summary>
        public NumericSensorEntity SamsungflexBatteryLevel => new(_haContext, "sensor.samsungflex_battery_level");
        ///<summary>SamsungFlex Battery Temperature</summary>
        public NumericSensorEntity SamsungflexBatteryTemperature => new(_haContext, "sensor.samsungflex_battery_temperature");
        ///<summary>Water Temperature</summary>
        public NumericSensorEntity WaterTemperature => new(_haContext, "sensor.water_temperature");
        ///<summary>Water Temperature</summary>
        public NumericSensorEntity WaterTemperature2 => new(_haContext, "sensor.water_temperature_2");
    }

    public partial class SunEntities
    {
        private readonly IHaContext _haContext;
        public SunEntities(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Sun</summary>
        public SunEntity Sun => new(_haContext, "sun.sun");
    }

    public partial class SwitchEntities
    {
        private readonly IHaContext _haContext;
        public SwitchEntities(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>amazon-a2bc345cb (Amazon Android device)</summary>
        public SwitchEntity AmazonA2bc345cbAmazonAndroidDevice => new(_haContext, "switch.amazon_a2bc345cb_amazon_android_device");
        ///<summary>amazon-a2bc345cb-lan (Amazon Android device)</summary>
        public SwitchEntity AmazonA2bc345cbLanAmazonAndroidDevice => new(_haContext, "switch.amazon_a2bc345cb_lan_amazon_android_device");
        ///<summary>Amazon Kindle (Amazon)</summary>
        public SwitchEntity AmazonKindleAmazon => new(_haContext, "switch.amazon_kindle_amazon");
        ///<summary>Android-2</summary>
        public SwitchEntity Android2 => new(_haContext, "switch.android_2");
        ///<summary>Back bushes Station Enabled</summary>
        public SwitchEntity BackBushesStationEnabled => new(_haContext, "switch.back_bushes_station_enabled");
        ///<summary>Berries Station Enabled</summary>
        public SwitchEntity BerriesStationEnabled => new(_haContext, "switch.berries_station_enabled");
        ///<summary>co2sensor</summary>
        public SwitchEntity Co2sensor => new(_haContext, "switch.co2sensor");
        ///<summary>Cody</summary>
        public SwitchEntity Cody => new(_haContext, "switch.cody");
        ///<summary>db1_water_level</summary>
        public SwitchEntity Db1WaterLevel => new(_haContext, "switch.db1_water_level");
        ///<summary>db2_water_level</summary>
        public SwitchEntity Db2WaterLevel => new(_haContext, "switch.db2_water_level");
        ///<summary>db3_water_level</summary>
        public SwitchEntity Db3WaterLevel => new(_haContext, "switch.db3_water_level");
        ///<summary>db4_water_level</summary>
        public SwitchEntity Db4WaterLevel => new(_haContext, "switch.db4_water_level");
        ///<summary>db5_water_level</summary>
        public SwitchEntity Db5WaterLevel => new(_haContext, "switch.db5_water_level");
        ///<summary>db6_water_level</summary>
        public SwitchEntity Db6WaterLevel => new(_haContext, "switch.db6_water_level");
        ///<summary>EnablePumps</summary>
        public SwitchEntity Enablepumps => new(_haContext, "switch.enablepumps");
        ///<summary>EPSOND97AE7 (Epson Printer)</summary>
        public SwitchEntity Epsond97ae7EpsonPrinter => new(_haContext, "switch.epsond97ae7_epson_printer");
        ///<summary>ESP_76FAF5</summary>
        public SwitchEntity Esp76faf5 => new(_haContext, "switch.esp_76faf5");
        ///<summary>Fan</summary>
        public SwitchEntity Fan => new(_haContext, "switch.fan");
        ///<summary>First half Program Enabled</summary>
        public SwitchEntity FirstHalfProgramEnabled => new(_haContext, "switch.first_half_program_enabled");
        ///<summary>fresh_res_water_level</summary>
        public SwitchEntity FreshResWaterLevel => new(_haContext, "switch.fresh_res_water_level");
        ///<summary>Front Field Station Enabled</summary>
        public SwitchEntity FrontFieldStationEnabled => new(_haContext, "switch.front_field_station_enabled");
        ///<summary>Front flower sprinkler Station Enabled</summary>
        public SwitchEntity FrontFlowerSprinklerStationEnabled => new(_haContext, "switch.front_flower_sprinkler_station_enabled");
        ///<summary>Fruit trees Station Enabled</summary>
        public SwitchEntity FruitTreesStationEnabled => new(_haContext, "switch.fruit_trees_station_enabled");
        ///<summary>GH Back Light</summary>
        public SwitchEntity GhBackLight => new(_haContext, "switch.gh_back_light");
        ///<summary>gh_camera</summary>
        public SwitchEntity GhCamera => new(_haContext, "switch.gh_camera");
        ///<summary>GH Front Light Switch</summary>
        public SwitchEntity GhFrontLightSwitch => new(_haContext, "switch.gh_front_light_switch");
        ///<summary>GH Interior and Exterior Temp Restart</summary>
        public SwitchEntity GhInteriorAndExteriorTempRestart => new(_haContext, "switch.gh_interior_and_exterior_temp_restart");
        ///<summary>GH Protected Restart</summary>
        public SwitchEntity GhProtectedRestart => new(_haContext, "switch.gh_protected_restart");
        ///<summary>ghbacklight</summary>
        public SwitchEntity Ghbacklight => new(_haContext, "switch.ghbacklight");
        ///<summary>ghlightfront</summary>
        public SwitchEntity Ghlightfront => new(_haContext, "switch.ghlightfront");
        ///<summary>ghtemp2</summary>
        public SwitchEntity Ghtemp2 => new(_haContext, "switch.ghtemp2");
        ///<summary>greenhousetemp</summary>
        public SwitchEntity Greenhousetemp => new(_haContext, "switch.greenhousetemp");
        ///<summary>Home assistant beans  Station Enabled</summary>
        public SwitchEntity HomeAssistantBeansStationEnabled => new(_haContext, "switch.home_assistant_beans_station_enabled");
        ///<summary>homeassistant (Raspberry Pi)</summary>
        public SwitchEntity HomeassistantRaspberryPi => new(_haContext, "switch.homeassistant_raspberry_pi");
        ///<summary>L08779 (Windows device)</summary>
        public SwitchEntity L08779WindowsDevice => new(_haContext, "switch.l08779_windows_device");
        ///<summary>LG</summary>
        public SwitchEntity Lg => new(_haContext, "switch.lg");
        ///<summary>Master (Chromecast)</summary>
        public SwitchEntity MasterChromecast => new(_haContext, "switch.master_chromecast");
        ///<summary>Microsoft</summary>
        public SwitchEntity Microsoft => new(_haContext, "switch.microsoft");
        ///<summary>Mollys-iPad</summary>
        public SwitchEntity MollysIpad => new(_haContext, "switch.mollys_ipad");
        ///<summary>Mollys-iPhone</summary>
        public SwitchEntity MollysIphone => new(_haContext, "switch.mollys_iphone");
        ///<summary>Motorola Android device (Motorola)</summary>
        public SwitchEntity MotorolaAndroidDeviceMotorola => new(_haContext, "switch.motorola_android_device_motorola");
        ///<summary>Motorola Android device (Motorola)</summary>
        public SwitchEntity MotorolaAndroidDeviceMotorola2 => new(_haContext, "switch.motorola_android_device_motorola_2");
        ///<summary>myx_00186156838* (Ooma)</summary>
        public SwitchEntity Myx00186156838Ooma => new(_haContext, "switch.myx_00186156838_ooma");
        ///<summary>Nature sprinkler Station Enabled</summary>
        public SwitchEntity NatureSprinklerStationEnabled => new(_haContext, "switch.nature_sprinkler_station_enabled");
        ///<summary>Nest Thermostat (Google)</summary>
        public SwitchEntity NestThermostatGoogle => new(_haContext, "switch.nest_thermostat_google");
        ///<summary>netdaemon_dehumidifier_app</summary>
        public SwitchEntity NetdaemonDehumidifierApp => new(_haContext, "switch.netdaemon_dehumidifier_app");
        ///<summary>netdaemon_envcontrols_app</summary>
        public SwitchEntity NetdaemonEnvcontrolsApp => new(_haContext, "switch.netdaemon_envcontrols_app");
        ///<summary>netdaemon_environemtnapp</summary>
        public SwitchEntity NetdaemonEnvironemtnapp => new(_haContext, "switch.netdaemon_environemtnapp");
        ///<summary>netdaemon_generatedappbase</summary>
        public SwitchEntity NetdaemonGeneratedappbase => new(_haContext, "switch.netdaemon_generatedappbase");
        ///<summary>netdaemon_growlight_app</summary>
        public SwitchEntity NetdaemonGrowlightApp => new(_haContext, "switch.netdaemon_growlight_app");
        ///<summary>netdaemon_growlightapp</summary>
        public SwitchEntity NetdaemonGrowlightapp => new(_haContext, "switch.netdaemon_growlightapp");
        ///<summary>netdaemon_heatandco2app</summary>
        public SwitchEntity NetdaemonHeatandco2app => new(_haContext, "switch.netdaemon_heatandco2app");
        ///<summary>netdaemon_helloworldapp</summary>
        public SwitchEntity NetdaemonHelloworldapp => new(_haContext, "switch.netdaemon_helloworldapp");
        ///<summary>netdaemon_netdaemon_app</summary>
        public SwitchEntity NetdaemonNetdaemonApp => new(_haContext, "switch.netdaemon_netdaemon_app");
        ///<summary>netdaemon_nutrients_app</summary>
        public SwitchEntity NetdaemonNutrientsApp => new(_haContext, "switch.netdaemon_nutrients_app");
        ///<summary>netdaemon_nutrientsapp</summary>
        public SwitchEntity NetdaemonNutrientsapp => new(_haContext, "switch.netdaemon_nutrientsapp");
        ///<summary>netdaemon_pirlights_app</summary>
        public SwitchEntity NetdaemonPirlightsApp => new(_haContext, "switch.netdaemon_pirlights_app");
        ///<summary>netdaemon_pirlightsapp</summary>
        public SwitchEntity NetdaemonPirlightsapp => new(_haContext, "switch.netdaemon_pirlightsapp");
        ///<summary>netdaemon_refill_app</summary>
        public SwitchEntity NetdaemonRefillApp => new(_haContext, "switch.netdaemon_refill_app");
        ///<summary>netdaemon_refillapp</summary>
        public SwitchEntity NetdaemonRefillapp => new(_haContext, "switch.netdaemon_refillapp");
        ///<summary>nft_water_level</summary>
        public SwitchEntity NftWaterLevel => new(_haContext, "switch.nft_water_level");
        ///<summary>NGELOTTE10LT (Dell)</summary>
        public SwitchEntity Ngelotte10ltDell => new(_haContext, "switch.ngelotte10lt_dell");
        ///<summary>NGELOTTE10LT (Dell)</summary>
        public SwitchEntity Ngelotte10ltDell2 => new(_haContext, "switch.ngelotte10lt_dell_2");
        ///<summary>NGELOTTE10LT (Windows device)</summary>
        public SwitchEntity Ngelotte10ltWindowsDevice => new(_haContext, "switch.ngelotte10lt_windows_device");
        ///<summary>Nicholas's Fire TV (AFTMM)</summary>
        public SwitchEntity NicholasSFireTvAftmm => new(_haContext, "switch.nicholas_s_fire_tv_aftmm");
        ///<summary>Nintendo Switch (Nintendo)</summary>
        public SwitchEntity NintendoSwitchNintendo => new(_haContext, "switch.nintendo_switch_nintendo");
        ///<summary>Nuheat</summary>
        public SwitchEntity Nuheat => new(_haContext, "switch.nuheat");
        ///<summary>octopi (Raspberry Pi)</summary>
        public SwitchEntity OctopiRaspberryPi => new(_haContext, "switch.octopi_raspberry_pi");
        ///<summary>octopi (Raspberry Pi)</summary>
        public SwitchEntity OctopiRaspberryPi2 => new(_haContext, "switch.octopi_raspberry_pi_2");
        ///<summary>Open Sprinkler Enabled</summary>
        public SwitchEntity OpenSprinklerEnabled => new(_haContext, "switch.open_sprinkler_enabled");
        ///<summary>peristalticnutrients</summary>
        public SwitchEntity Peristalticnutrients => new(_haContext, "switch.peristalticnutrients");
        ///<summary>DB Grow Lights</summary>
        public SwitchEntity PowerStrip1Outlet1 => new(_haContext, "switch.power_strip_1_outlet_1");
        ///<summary>Power Strip 1 outlet 2</summary>
        public SwitchEntity PowerStrip1Outlet2 => new(_haContext, "switch.power_strip_1_outlet_2");
        ///<summary>Power Strip 1 outlet 3</summary>
        public SwitchEntity PowerStrip1Outlet3 => new(_haContext, "switch.power_strip_1_outlet_3");
        ///<summary>greenhouse heat and co2</summary>
        public SwitchEntity PowerStrip1Outlet4 => new(_haContext, "switch.power_strip_1_outlet_4");
        ///<summary>DB Water Levels - USB</summary>
        public SwitchEntity PowerStrip1Usb => new(_haContext, "switch.power_strip_1_usb");
        ///<summary>Power Strip Mid outlet 1</summary>
        public SwitchEntity PowerStripMidOutlet1 => new(_haContext, "switch.power_strip_mid_outlet_1");
        ///<summary>Power Strip Mid outlet 2</summary>
        public SwitchEntity PowerStripMidOutlet2 => new(_haContext, "switch.power_strip_mid_outlet_2");
        ///<summary>DB6 Testing Zone Pump</summary>
        public SwitchEntity PowerStripMidOutlet3 => new(_haContext, "switch.power_strip_mid_outlet_3");
        ///<summary>DB6 Main Pump</summary>
        public SwitchEntity PowerStripMidOutlet4 => new(_haContext, "switch.power_strip_mid_outlet_4");
        ///<summary>Power Strip Mid USB</summary>
        public SwitchEntity PowerStripMidUsb => new(_haContext, "switch.power_strip_mid_usb");
        ///<summary>Tz heat</summary>
        public SwitchEntity PowerStripTestZoneOutlet1 => new(_haContext, "switch.power_strip_test_zone_outlet_1");
        ///<summary>Ec probs</summary>
        public SwitchEntity PowerStripTestZoneOutlet2 => new(_haContext, "switch.power_strip_test_zone_outlet_2");
        ///<summary>Waste tank</summary>
        public SwitchEntity PowerStripTestZoneOutlet3 => new(_haContext, "switch.power_strip_test_zone_outlet_3");
        ///<summary>Nutrient power</summary>
        public SwitchEntity PowerStripTestZoneOutlet4 => new(_haContext, "switch.power_strip_test_zone_outlet_4");
        ///<summary>Power Strip Test Zone USB</summary>
        public SwitchEntity PowerStripTestZoneUsb => new(_haContext, "switch.power_strip_test_zone_usb");
        ///<summary>powerstrip_mid</summary>
        public SwitchEntity PowerstripMid => new(_haContext, "switch.powerstrip_mid");
        ///<summary>powerstripne</summary>
        public SwitchEntity Powerstripne => new(_haContext, "switch.powerstripne");
        ///<summary>PowerStripNE outlet 1</summary>
        public SwitchEntity PowerstripneOutlet1 => new(_haContext, "switch.powerstripne_outlet_1");
        ///<summary>PowerStripNE outlet 2</summary>
        public SwitchEntity PowerstripneOutlet2 => new(_haContext, "switch.powerstripne_outlet_2");
        ///<summary>Main Water Refill</summary>
        public SwitchEntity PowerstripneOutlet3 => new(_haContext, "switch.powerstripne_outlet_3");
        ///<summary>West Grow Lights</summary>
        public SwitchEntity PowerstripneOutlet4 => new(_haContext, "switch.powerstripne_outlet_4");
        ///<summary>PowerStripNE USB</summary>
        public SwitchEntity PowerstripneUsb => new(_haContext, "switch.powerstripne_usb");
        ///<summary>powerstriptestzone</summary>
        public SwitchEntity Powerstriptestzone => new(_haContext, "switch.powerstriptestzone");
        ///<summary>pwstrip1</summary>
        public SwitchEntity Pwstrip1 => new(_haContext, "switch.pwstrip1");
        ///<summary>Restart DB1 Water Level</summary>
        public SwitchEntity RestartDb1WaterLevel => new(_haContext, "switch.restart_db1_water_level");
        ///<summary>Restart DB2 Water Level</summary>
        public SwitchEntity RestartDb2WaterLevel => new(_haContext, "switch.restart_db2_water_level");
        ///<summary>Restart DB3 Water Level</summary>
        public SwitchEntity RestartDb3WaterLevel => new(_haContext, "switch.restart_db3_water_level");
        ///<summary>Restart DB4 Water Level</summary>
        public SwitchEntity RestartDb4WaterLevel => new(_haContext, "switch.restart_db4_water_level");
        ///<summary>Restart DB5 Water Level</summary>
        public SwitchEntity RestartDb5WaterLevel => new(_haContext, "switch.restart_db5_water_level");
        ///<summary>Restart DB6 Water Level</summary>
        public SwitchEntity RestartDb6WaterLevel => new(_haContext, "switch.restart_db6_water_level");
        ///<summary>Restart EC Sensor</summary>
        public SwitchEntity RestartEcSensor => new(_haContext, "switch.restart_ec_sensor");
        ///<summary>Restart Fresh Res Water Level</summary>
        public SwitchEntity RestartFreshResWaterLevel => new(_haContext, "switch.restart_fresh_res_water_level");
        ///<summary>Restart Fresh Water Level</summary>
        public SwitchEntity RestartFreshWaterLevel => new(_haContext, "switch.restart_fresh_water_level");
        ///<summary>Restart NFT Water Level</summary>
        public SwitchEntity RestartNftWaterLevel => new(_haContext, "switch.restart_nft_water_level");
        ///<summary>Restart NFT Water Level</summary>
        public SwitchEntity RestartNftWaterLevel2 => new(_haContext, "switch.restart_nft_water_level_2");
        ///<summary>Restart Swp Cool W Level</summary>
        public SwitchEntity RestartSwpCoolWLevel => new(_haContext, "switch.restart_swp_cool_w_level");
        ///<summary>Restart Swp Cool Water Level</summary>
        public SwitchEntity RestartSwpCoolWaterLevel => new(_haContext, "switch.restart_swp_cool_water_level");
        ///<summary>Restart Test Node W Level</summary>
        public SwitchEntity RestartTestNodeWLevel => new(_haContext, "switch.restart_test_node_w_level");
        ///<summary>S07 Station Enabled</summary>
        public SwitchEntity S07StationEnabled => new(_haContext, "switch.s07_station_enabled");
        ///<summary>S08 Station Enabled</summary>
        public SwitchEntity S08StationEnabled => new(_haContext, "switch.s08_station_enabled");
        ///<summary>S14 Station Enabled</summary>
        public SwitchEntity S14StationEnabled => new(_haContext, "switch.s14_station_enabled");
        ///<summary>S15 Station Enabled</summary>
        public SwitchEntity S15StationEnabled => new(_haContext, "switch.s15_station_enabled");
        ///<summary>S16 Station Enabled</summary>
        public SwitchEntity S16StationEnabled => new(_haContext, "switch.s16_station_enabled");
        ///<summary>S17 Station Enabled</summary>
        public SwitchEntity S17StationEnabled => new(_haContext, "switch.s17_station_enabled");
        ///<summary>S18 Station Enabled</summary>
        public SwitchEntity S18StationEnabled => new(_haContext, "switch.s18_station_enabled");
        ///<summary>S19 Station Enabled</summary>
        public SwitchEntity S19StationEnabled => new(_haContext, "switch.s19_station_enabled");
        ///<summary>S20 Station Enabled</summary>
        public SwitchEntity S20StationEnabled => new(_haContext, "switch.s20_station_enabled");
        ///<summary>S21 Station Enabled</summary>
        public SwitchEntity S21StationEnabled => new(_haContext, "switch.s21_station_enabled");
        ///<summary>S22 Station Enabled</summary>
        public SwitchEntity S22StationEnabled => new(_haContext, "switch.s22_station_enabled");
        ///<summary>S23 Station Enabled</summary>
        public SwitchEntity S23StationEnabled => new(_haContext, "switch.s23_station_enabled");
        ///<summary>S24 Station Enabled</summary>
        public SwitchEntity S24StationEnabled => new(_haContext, "switch.s24_station_enabled");
        ///<summary>Samsung</summary>
        public SwitchEntity Samsung => new(_haContext, "switch.samsung");
        ///<summary>Samsung</summary>
        public SwitchEntity Samsung2 => new(_haContext, "switch.samsung_2");
        ///<summary>Samsung flex</summary>
        public SwitchEntity SamsungFlex => new(_haContext, "switch.samsung_flex");
        ///<summary>sbasic1</summary>
        public SwitchEntity Sbasic1 => new(_haContext, "switch.sbasic1");
        ///<summary>Second half Program Enabled</summary>
        public SwitchEntity SecondHalfProgramEnabled => new(_haContext, "switch.second_half_program_enabled");
        ///<summary>Side back grass Station Enabled</summary>
        public SwitchEntity SideBackGrassStationEnabled => new(_haContext, "switch.side_back_grass_station_enabled");
        ///<summary>Snap peas and sunflowers Station Enabled</summary>
        public SwitchEntity SnapPeasAndSunflowersStationEnabled => new(_haContext, "switch.snap_peas_and_sunflowers_station_enabled");
        ///<summary>sonoff4chz1</summary>
        public SwitchEntity Sonoff4chz1 => new(_haContext, "switch.sonoff4chz1");
        ///<summary>sonoff4chz2</summary>
        public SwitchEntity Sonoff4chz2 => new(_haContext, "switch.sonoff4chz2");
        ///<summary>sonoff4chz3</summary>
        public SwitchEntity Sonoff4chz3 => new(_haContext, "switch.sonoff4chz3");
        ///<summary>DB5 Main Pump</summary>
        public SwitchEntity St1p1 => new(_haContext, "switch.st1p1");
        ///<summary>Db5 Testing Zone Pump</summary>
        public SwitchEntity St1p2 => new(_haContext, "switch.st1p2");
        ///<summary>ST1P3</summary>
        public SwitchEntity St1p3 => new(_haContext, "switch.st1p3");
        ///<summary>ST1P4</summary>
        public SwitchEntity St1p4 => new(_haContext, "switch.st1p4");
        ///<summary>Db1 Testing Zone Pump</summary>
        public SwitchEntity St2p1 => new(_haContext, "switch.st2p1");
        ///<summary>Db2 Main Pump</summary>
        public SwitchEntity St2p2 => new(_haContext, "switch.st2p2");
        ///<summary>Db1 Main Pump</summary>
        public SwitchEntity St2p3 => new(_haContext, "switch.st2p3");
        ///<summary>DB2 Testing Zone Pump</summary>
        public SwitchEntity St2p4 => new(_haContext, "switch.st2p4");
        ///<summary>DB4 Main Pump</summary>
        public SwitchEntity St3p1 => new(_haContext, "switch.st3p1");
        ///<summary>Db3 main pump</summary>
        public SwitchEntity St3p2 => new(_haContext, "switch.st3p2");
        ///<summary>Db4 Testing Zone Pump</summary>
        public SwitchEntity St3p3 => new(_haContext, "switch.st3p3");
        ///<summary>Db3 Testing Zone Pump</summary>
        public SwitchEntity St3p4 => new(_haContext, "switch.st3p4");
        ///<summary>Nft testing pump</summary>
        public SwitchEntity St4p1 => new(_haContext, "switch.st4p1");
        ///<summary>Floor fan</summary>
        public SwitchEntity St4p2 => new(_haContext, "switch.st4p2");
        ///<summary>Swp Cool</summary>
        public SwitchEntity St4p3 => new(_haContext, "switch.st4p3");
        ///<summary>Grow Lights</summary>
        public SwitchEntity St4p4 => new(_haContext, "switch.st4p4");
        ///<summary>station4</summary>
        public SwitchEntity Station4 => new(_haContext, "switch.station4");
        ///<summary>swp_cool_water_level</summary>
        public SwitchEntity SwpCoolWaterLevel => new(_haContext, "switch.swp_cool_water_level");
        ///<summary>tb2P1</summary>
        public SwitchEntity Tb2p1 => new(_haContext, "switch.tb2p1");
        ///<summary>tb2P2</summary>
        public SwitchEntity Tb2p2 => new(_haContext, "switch.tb2p2");
        ///<summary>tb2P3</summary>
        public SwitchEntity Tb2p3 => new(_haContext, "switch.tb2p3");
        ///<summary>Fresh water</summary>
        public SwitchEntity Tb2p4 => new(_haContext, "switch.tb2p4");
        ///<summary>Dehumidifier</summary>
        public SwitchEntity Tb4p2 => new(_haContext, "switch.tb4p2");
        ///<summary>Refill SWP cooler</summary>
        public SwitchEntity Tb4p3 => new(_haContext, "switch.tb4p3");
        ///<summary>Fresh Water</summary>
        public SwitchEntity Tb4p4 => new(_haContext, "switch.tb4p4");
        ///<summary>Testing to waste tank</summary>
        public SwitchEntity Tbp1 => new(_haContext, "switch.tbp1");
        ///<summary>test_node_water_level</summary>
        public SwitchEntity TestNodeWaterLevel => new(_haContext, "switch.test_node_water_level");
        ///<summary>testingbucketsf4ch</summary>
        public SwitchEntity Testingbucketsf4ch => new(_haContext, "switch.testingbucketsf4ch");
        ///<summary>Unnamed device</summary>
        public SwitchEntity UnnamedDevice => new(_haContext, "switch.unnamed_device");
        ///<summary>Unnamed device</summary>
        public SwitchEntity UnnamedDevice2 => new(_haContext, "switch.unnamed_device_2");
        ///<summary>Valve</summary>
        public SwitchEntity Valve => new(_haContext, "switch.valve");
        ///<summary>Valve 2</summary>
        public SwitchEntity Valve2 => new(_haContext, "switch.valve_2");
        ///<summary>VMB4000 (Netgear)</summary>
        public SwitchEntity Vmb4000Netgear => new(_haContext, "switch.vmb4000_netgear");
        ///<summary>watermonitor</summary>
        public SwitchEntity Watermonitor => new(_haContext, "switch.watermonitor");
        ///<summary>Well P&Ts and a A Station Enabled</summary>
        public SwitchEntity WellPTsAndAAStationEnabled => new(_haContext, "switch.well_p_ts_and_a_a_station_enabled");
        ///<summary>Windows device</summary>
        public SwitchEntity WindowsDevice => new(_haContext, "switch.windows_device");
        ///<summary>Wonder strawberries Station Enabled</summary>
        public SwitchEntity WonderStrawberriesStationEnabled => new(_haContext, "switch.wonder_strawberries_station_enabled");
        ///<summary>Xbox-SystemOS (Xbox One)</summary>
        public SwitchEntity XboxSystemosXboxOne => new(_haContext, "switch.xbox_systemos_xbox_one");
    }

    public partial class UpdateEntities
    {
        private readonly IHaContext _haContext;
        public UpdateEntities(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>ESPHome: Update</summary>
        public UpdateEntity EsphomeUpdate => new(_haContext, "update.esphome_update");
        ///<summary>File editor: Update</summary>
        public UpdateEntity FileEditorUpdate => new(_haContext, "update.file_editor_update");
        ///<summary>Grafana: Update</summary>
        public UpdateEntity GrafanaUpdate => new(_haContext, "update.grafana_update");
        ///<summary>Home Assistant Core: Update</summary>
        public UpdateEntity HomeAssistantCoreUpdate => new(_haContext, "update.home_assistant_core_update");
        ///<summary>Home Assistant Operating System: Update</summary>
        public UpdateEntity HomeAssistantOperatingSystemUpdate => new(_haContext, "update.home_assistant_operating_system_update");
        ///<summary>Home Assistant Supervisor: Update</summary>
        public UpdateEntity HomeAssistantSupervisorUpdate => new(_haContext, "update.home_assistant_supervisor_update");
        ///<summary>InfluxDB: Update</summary>
        public UpdateEntity InfluxdbUpdate => new(_haContext, "update.influxdb_update");
        ///<summary>MariaDB: Update</summary>
        public UpdateEntity MariadbUpdate => new(_haContext, "update.mariadb_update");
        ///<summary>Mosquitto broker: Update</summary>
        public UpdateEntity MosquittoBrokerUpdate => new(_haContext, "update.mosquitto_broker_update");
        ///<summary>NetDaemon V2: Update</summary>
        public UpdateEntity NetdaemonV2Update => new(_haContext, "update.netdaemon_v2_update");
        ///<summary>Node-RED: Update</summary>
        public UpdateEntity NodeRedUpdate => new(_haContext, "update.node_red_update");
        ///<summary>Samba share: Update</summary>
        public UpdateEntity SambaShareUpdate => new(_haContext, "update.samba_share_update");
        ///<summary>Terminal & SSH: Update</summary>
        public UpdateEntity TerminalSshUpdate => new(_haContext, "update.terminal_ssh_update");
    }

    public partial class VacuumEntities
    {
        private readonly IHaContext _haContext;
        public VacuumEntities(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Marla</summary>
        public VacuumEntity Marla => new(_haContext, "vacuum.marla");
    }

    public partial class WeatherEntities
    {
        private readonly IHaContext _haContext;
        public WeatherEntities(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Home</summary>
        public WeatherEntity Home => new(_haContext, "weather.home");
        ///<summary>OpenWeatherMap</summary>
        public WeatherEntity Openweathermap => new(_haContext, "weather.openweathermap");
    }

    public partial class ZoneEntities
    {
        private readonly IHaContext _haContext;
        public ZoneEntities(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Home</summary>
        public ZoneEntity Home => new(_haContext, "zone.home");
    }

    public partial record AutomationEntity : Entity<AutomationEntity, EntityState<AutomationAttributes>, AutomationAttributes>
    {
        public AutomationEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public AutomationEntity(Entity entity) : base(entity)
        {
        }
    }

    public record AutomationAttributes
    {
        [JsonPropertyName("current")]
        public double? Current { get; init; }

        [JsonPropertyName("friendly_name")]
        public string? FriendlyName { get; init; }

        [JsonPropertyName("id")]
        public string? Id { get; init; }

        [JsonPropertyName("last_triggered")]
        public string? LastTriggered { get; init; }

        [JsonPropertyName("mode")]
        public string? Mode { get; init; }

        [JsonPropertyName("restored")]
        public bool? Restored { get; init; }

        [JsonPropertyName("supported_features")]
        public double? SupportedFeatures { get; init; }
    }

    public partial record BinarySensorEntity : Entity<BinarySensorEntity, EntityState<BinarySensorAttributes>, BinarySensorAttributes>
    {
        public BinarySensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public BinarySensorEntity(Entity entity) : base(entity)
        {
        }
    }

    public record BinarySensorAttributes
    {
        [JsonPropertyName("device_class")]
        public string? DeviceClass { get; init; }

        [JsonPropertyName("friendly_name")]
        public string? FriendlyName { get; init; }

        [JsonPropertyName("icon")]
        public string? Icon { get; init; }

        [JsonPropertyName("restored")]
        public bool? Restored { get; init; }

        [JsonPropertyName("supported_features")]
        public double? SupportedFeatures { get; init; }

        [JsonPropertyName("system")]
        public string? System { get; init; }
    }

    public partial record ButtonEntity : Entity<ButtonEntity, EntityState<ButtonAttributes>, ButtonAttributes>
    {
        public ButtonEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public ButtonEntity(Entity entity) : base(entity)
        {
        }
    }

    public record ButtonAttributes
    {
        [JsonPropertyName("friendly_name")]
        public string? FriendlyName { get; init; }

        [JsonPropertyName("restored")]
        public bool? Restored { get; init; }

        [JsonPropertyName("supported_features")]
        public double? SupportedFeatures { get; init; }
    }

    public partial record CameraEntity : Entity<CameraEntity, EntityState<CameraAttributes>, CameraAttributes>
    {
        public CameraEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public CameraEntity(Entity entity) : base(entity)
        {
        }
    }

    public record CameraAttributes
    {
        [JsonPropertyName("access_token")]
        public string? AccessToken { get; init; }

        [JsonPropertyName("entity_picture")]
        public string? EntityPicture { get; init; }

        [JsonPropertyName("friendly_name")]
        public string? FriendlyName { get; init; }

        [JsonPropertyName("supported_features")]
        public double? SupportedFeatures { get; init; }
    }

    public partial record ClimateEntity : Entity<ClimateEntity, EntityState<ClimateAttributes>, ClimateAttributes>
    {
        public ClimateEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public ClimateEntity(Entity entity) : base(entity)
        {
        }
    }

    public record ClimateAttributes
    {
        [JsonPropertyName("current_temperature")]
        public double? CurrentTemperature { get; init; }

        [JsonPropertyName("friendly_name")]
        public string? FriendlyName { get; init; }

        [JsonPropertyName("hvac_action")]
        public string? HvacAction { get; init; }

        [JsonPropertyName("hvac_modes")]
        public object? HvacModes { get; init; }

        [JsonPropertyName("max_temp")]
        public double? MaxTemp { get; init; }

        [JsonPropertyName("min_temp")]
        public double? MinTemp { get; init; }

        [JsonPropertyName("supported_features")]
        public double? SupportedFeatures { get; init; }

        [JsonPropertyName("target_temp_high")]
        public object? TargetTempHigh { get; init; }

        [JsonPropertyName("target_temp_low")]
        public object? TargetTempLow { get; init; }

        [JsonPropertyName("temperature")]
        public double? Temperature { get; init; }
    }

    public partial record DeviceTrackerEntity : Entity<DeviceTrackerEntity, EntityState<DeviceTrackerAttributes>, DeviceTrackerAttributes>
    {
        public DeviceTrackerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public DeviceTrackerEntity(Entity entity) : base(entity)
        {
        }
    }

    public record DeviceTrackerAttributes
    {
        [JsonPropertyName("connected_ap")]
        public string? ConnectedAp { get; init; }

        [JsonPropertyName("friendly_name")]
        public string? FriendlyName { get; init; }

        [JsonPropertyName("icon")]
        public string? Icon { get; init; }

        [JsonPropertyName("ip_address")]
        public string? IpAddress { get; init; }

        [JsonPropertyName("mac")]
        public string? Mac { get; init; }

        [JsonPropertyName("source_type")]
        public string? SourceType { get; init; }

        [JsonPropertyName("system")]
        public string? System { get; init; }
    }

    public partial record InputBooleanEntity : Entity<InputBooleanEntity, EntityState<InputBooleanAttributes>, InputBooleanAttributes>
    {
        public InputBooleanEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public InputBooleanEntity(Entity entity) : base(entity)
        {
        }
    }

    public record InputBooleanAttributes
    {
        [JsonPropertyName("editable")]
        public bool? Editable { get; init; }

        [JsonPropertyName("friendly_name")]
        public string? FriendlyName { get; init; }
    }

    public partial record InputNumberEntity : NumericEntity<InputNumberEntity, NumericEntityState<InputNumberAttributes>, InputNumberAttributes>
    {
        public InputNumberEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public InputNumberEntity(Entity entity) : base(entity)
        {
        }
    }

    public record InputNumberAttributes
    {
        [JsonPropertyName("editable")]
        public bool? Editable { get; init; }

        [JsonPropertyName("friendly_name")]
        public string? FriendlyName { get; init; }

        [JsonPropertyName("initial")]
        public object? Initial { get; init; }

        [JsonPropertyName("max")]
        public double? Max { get; init; }

        [JsonPropertyName("min")]
        public double? Min { get; init; }

        [JsonPropertyName("mode")]
        public string? Mode { get; init; }

        [JsonPropertyName("step")]
        public double? Step { get; init; }
    }

    public partial record InputSelectEntity : Entity<InputSelectEntity, EntityState<InputSelectAttributes>, InputSelectAttributes>
    {
        public InputSelectEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public InputSelectEntity(Entity entity) : base(entity)
        {
        }
    }

    public record InputSelectAttributes
    {
        [JsonPropertyName("editable")]
        public bool? Editable { get; init; }

        [JsonPropertyName("friendly_name")]
        public string? FriendlyName { get; init; }

        [JsonPropertyName("options")]
        public object? Options { get; init; }
    }

    public partial record LightEntity : Entity<LightEntity, EntityState<LightAttributes>, LightAttributes>
    {
        public LightEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public LightEntity(Entity entity) : base(entity)
        {
        }
    }

    public record LightAttributes
    {
        [JsonPropertyName("brightness")]
        public double? Brightness { get; init; }

        [JsonPropertyName("color_mode")]
        public string? ColorMode { get; init; }

        [JsonPropertyName("friendly_name")]
        public string? FriendlyName { get; init; }

        [JsonPropertyName("icon")]
        public string? Icon { get; init; }

        [JsonPropertyName("supported_color_modes")]
        public object? SupportedColorModes { get; init; }

        [JsonPropertyName("supported_features")]
        public double? SupportedFeatures { get; init; }

        [JsonPropertyName("system")]
        public string? System { get; init; }
    }

    public partial record PersonEntity : Entity<PersonEntity, EntityState<PersonAttributes>, PersonAttributes>
    {
        public PersonEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public PersonEntity(Entity entity) : base(entity)
        {
        }
    }

    public record PersonAttributes
    {
        [JsonPropertyName("editable")]
        public bool? Editable { get; init; }

        [JsonPropertyName("friendly_name")]
        public string? FriendlyName { get; init; }

        [JsonPropertyName("id")]
        public string? Id { get; init; }

        [JsonPropertyName("user_id")]
        public string? UserId { get; init; }
    }

    public partial record ScriptEntity : Entity<ScriptEntity, EntityState<ScriptAttributes>, ScriptAttributes>
    {
        public ScriptEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public ScriptEntity(Entity entity) : base(entity)
        {
        }
    }

    public record ScriptAttributes
    {
        [JsonPropertyName("current")]
        public double? Current { get; init; }

        [JsonPropertyName("friendly_name")]
        public string? FriendlyName { get; init; }

        [JsonPropertyName("icon")]
        public string? Icon { get; init; }

        [JsonPropertyName("last_triggered")]
        public string? LastTriggered { get; init; }

        [JsonPropertyName("mode")]
        public string? Mode { get; init; }
    }

    public partial record SensorEntity : Entity<SensorEntity, EntityState<SensorAttributes>, SensorAttributes>
    {
        public SensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public SensorEntity(Entity entity) : base(entity)
        {
        }
    }

    public record SensorAttributes
    {
        [JsonPropertyName("attribution")]
        public string? Attribution { get; init; }

        [JsonPropertyName("device_class")]
        public string? DeviceClass { get; init; }

        [JsonPropertyName("firmware")]
        public string? Firmware { get; init; }

        [JsonPropertyName("friendly_name")]
        public string? FriendlyName { get; init; }

        [JsonPropertyName("icon")]
        public string? Icon { get; init; }

        [JsonPropertyName("last_packet_id")]
        public string? LastPacketId { get; init; }

        [JsonPropertyName("mac_address")]
        public string? MacAddress { get; init; }

        [JsonPropertyName("restored")]
        public bool? Restored { get; init; }

        [JsonPropertyName("rssi")]
        public double? Rssi { get; init; }

        [JsonPropertyName("sensor_type")]
        public string? SensorType { get; init; }

        [JsonPropertyName("supported_features")]
        public double? SupportedFeatures { get; init; }

        [JsonPropertyName("uuid")]
        public string? Uuid { get; init; }
    }

    public partial record NumericSensorEntity : NumericEntity<NumericSensorEntity, NumericEntityState<NumericSensorAttributes>, NumericSensorAttributes>
    {
        public NumericSensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public NumericSensorEntity(Entity entity) : base(entity)
        {
        }
    }

    public record NumericSensorAttributes
    {
        [JsonPropertyName("attribution")]
        public string? Attribution { get; init; }

        [JsonPropertyName("battery_level")]
        public double? BatteryLevel { get; init; }

        [JsonPropertyName("cron pattern")]
        public string? Cronpattern { get; init; }

        [JsonPropertyName("device_class")]
        public string? DeviceClass { get; init; }

        [JsonPropertyName("firmware")]
        public string? Firmware { get; init; }

        [JsonPropertyName("friendly_name")]
        public string? FriendlyName { get; init; }

        [JsonPropertyName("icon")]
        public string? Icon { get; init; }

        [JsonPropertyName("last_median_of")]
        public double? LastMedianOf { get; init; }

        [JsonPropertyName("last_packet_id")]
        public object? LastPacketId { get; init; }

        [JsonPropertyName("last_period")]
        public string? LastPeriod { get; init; }

        [JsonPropertyName("last_reset")]
        public string? LastReset { get; init; }

        [JsonPropertyName("mac_address")]
        public string? MacAddress { get; init; }

        [JsonPropertyName("mean")]
        public double? Mean { get; init; }

        [JsonPropertyName("median")]
        public double? Median { get; init; }

        [JsonPropertyName("meter_period")]
        public string? MeterPeriod { get; init; }

        [JsonPropertyName("repositories")]
        public object? Repositories { get; init; }

        [JsonPropertyName("restored")]
        public bool? Restored { get; init; }

        [JsonPropertyName("rssi")]
        public double? Rssi { get; init; }

        [JsonPropertyName("sensor_type")]
        public string? SensorType { get; init; }

        [JsonPropertyName("source")]
        public string? Source { get; init; }

        [JsonPropertyName("state_class")]
        public string? StateClass { get; init; }

        [JsonPropertyName("status")]
        public string? Status { get; init; }

        [JsonPropertyName("supported_features")]
        public double? SupportedFeatures { get; init; }

        [JsonPropertyName("system")]
        public string? System { get; init; }

        [JsonPropertyName("unit_of_measurement")]
        public string? UnitOfMeasurement { get; init; }

        [JsonPropertyName("uuid")]
        public string? Uuid { get; init; }
    }

    public partial record SunEntity : Entity<SunEntity, EntityState<SunAttributes>, SunAttributes>
    {
        public SunEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public SunEntity(Entity entity) : base(entity)
        {
        }
    }

    public record SunAttributes
    {
        [JsonPropertyName("azimuth")]
        public double? Azimuth { get; init; }

        [JsonPropertyName("elevation")]
        public double? Elevation { get; init; }

        [JsonPropertyName("friendly_name")]
        public string? FriendlyName { get; init; }

        [JsonPropertyName("next_dawn")]
        public string? NextDawn { get; init; }

        [JsonPropertyName("next_dusk")]
        public string? NextDusk { get; init; }

        [JsonPropertyName("next_midnight")]
        public string? NextMidnight { get; init; }

        [JsonPropertyName("next_noon")]
        public string? NextNoon { get; init; }

        [JsonPropertyName("next_rising")]
        public string? NextRising { get; init; }

        [JsonPropertyName("next_setting")]
        public string? NextSetting { get; init; }

        [JsonPropertyName("rising")]
        public bool? Rising { get; init; }
    }

    public partial record SwitchEntity : Entity<SwitchEntity, EntityState<SwitchAttributes>, SwitchAttributes>
    {
        public SwitchEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public SwitchEntity(Entity entity) : base(entity)
        {
        }
    }

    public record SwitchAttributes
    {
        [JsonPropertyName("friendly_name")]
        public string? FriendlyName { get; init; }

        [JsonPropertyName("icon")]
        public string? Icon { get; init; }

        [JsonPropertyName("ip")]
        public string? Ip { get; init; }

        [JsonPropertyName("mac")]
        public string? Mac { get; init; }

        [JsonPropertyName("network")]
        public string? Network { get; init; }

        [JsonPropertyName("prioritized")]
        public bool? Prioritized { get; init; }

        [JsonPropertyName("prioritized_end")]
        public string? PrioritizedEnd { get; init; }

        [JsonPropertyName("receive_speed_mbitps")]
        public double? ReceiveSpeedMbitps { get; init; }

        [JsonPropertyName("restored")]
        public bool? Restored { get; init; }

        [JsonPropertyName("supported_features")]
        public double? SupportedFeatures { get; init; }

        [JsonPropertyName("system")]
        public string? System { get; init; }

        [JsonPropertyName("transmit_speed_mbitps")]
        public double? TransmitSpeedMbitps { get; init; }
    }

    public partial record UpdateEntity : Entity<UpdateEntity, EntityState<UpdateAttributes>, UpdateAttributes>
    {
        public UpdateEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public UpdateEntity(Entity entity) : base(entity)
        {
        }
    }

    public record UpdateAttributes
    {
        [JsonPropertyName("auto_update")]
        public bool? AutoUpdate { get; init; }

        [JsonPropertyName("entity_picture")]
        public string? EntityPicture { get; init; }

        [JsonPropertyName("friendly_name")]
        public string? FriendlyName { get; init; }

        [JsonPropertyName("in_progress")]
        public bool? InProgress { get; init; }

        [JsonPropertyName("installed_version")]
        public string? InstalledVersion { get; init; }

        [JsonPropertyName("latest_version")]
        public string? LatestVersion { get; init; }

        [JsonPropertyName("release_summary")]
        public string? ReleaseSummary { get; init; }

        [JsonPropertyName("release_url")]
        public string? ReleaseUrl { get; init; }

        [JsonPropertyName("skipped_version")]
        public object? SkippedVersion { get; init; }

        [JsonPropertyName("supported_features")]
        public double? SupportedFeatures { get; init; }

        [JsonPropertyName("title")]
        public string? Title { get; init; }
    }

    public partial record VacuumEntity : Entity<VacuumEntity, EntityState<VacuumAttributes>, VacuumAttributes>
    {
        public VacuumEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public VacuumEntity(Entity entity) : base(entity)
        {
        }
    }

    public record VacuumAttributes
    {
        [JsonPropertyName("battery_icon")]
        public string? BatteryIcon { get; init; }

        [JsonPropertyName("battery_level")]
        public double? BatteryLevel { get; init; }

        [JsonPropertyName("bin_full")]
        public bool? BinFull { get; init; }

        [JsonPropertyName("bin_present")]
        public bool? BinPresent { get; init; }

        [JsonPropertyName("error")]
        public string? Error { get; init; }

        [JsonPropertyName("error_code")]
        public double? ErrorCode { get; init; }

        [JsonPropertyName("friendly_name")]
        public string? FriendlyName { get; init; }

        [JsonPropertyName("position")]
        public string? Position { get; init; }

        [JsonPropertyName("software_version")]
        public string? SoftwareVersion { get; init; }

        [JsonPropertyName("status")]
        public string? Status { get; init; }

        [JsonPropertyName("supported_features")]
        public double? SupportedFeatures { get; init; }
    }

    public partial record WeatherEntity : Entity<WeatherEntity, EntityState<WeatherAttributes>, WeatherAttributes>
    {
        public WeatherEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public WeatherEntity(Entity entity) : base(entity)
        {
        }
    }

    public record WeatherAttributes
    {
        [JsonPropertyName("attribution")]
        public string? Attribution { get; init; }

        [JsonPropertyName("forecast")]
        public object? Forecast { get; init; }

        [JsonPropertyName("friendly_name")]
        public string? FriendlyName { get; init; }

        [JsonPropertyName("humidity")]
        public double? Humidity { get; init; }

        [JsonPropertyName("pressure")]
        public double? Pressure { get; init; }

        [JsonPropertyName("temperature")]
        public double? Temperature { get; init; }

        [JsonPropertyName("wind_bearing")]
        public double? WindBearing { get; init; }

        [JsonPropertyName("wind_speed")]
        public double? WindSpeed { get; init; }
    }

    public partial record ZoneEntity : Entity<ZoneEntity, EntityState<ZoneAttributes>, ZoneAttributes>
    {
        public ZoneEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public ZoneEntity(Entity entity) : base(entity)
        {
        }
    }

    public record ZoneAttributes
    {
        [JsonPropertyName("editable")]
        public bool? Editable { get; init; }

        [JsonPropertyName("friendly_name")]
        public string? FriendlyName { get; init; }

        [JsonPropertyName("icon")]
        public string? Icon { get; init; }

        [JsonPropertyName("latitude")]
        public double? Latitude { get; init; }

        [JsonPropertyName("longitude")]
        public double? Longitude { get; init; }

        [JsonPropertyName("passive")]
        public bool? Passive { get; init; }

        [JsonPropertyName("persons")]
        public object? Persons { get; init; }

        [JsonPropertyName("radius")]
        public double? Radius { get; init; }
    }

    public interface IServices
    {
        AlarmControlPanelServices AlarmControlPanel { get; }

        AutomationServices Automation { get; }

        BleMonitorServices BleMonitor { get; }

        ButtonServices Button { get; }

        CameraServices Camera { get; }

        ClimateServices Climate { get; }

        CloudServices Cloud { get; }

        CounterServices Counter { get; }

        CoverServices Cover { get; }

        DeviceTrackerServices DeviceTracker { get; }

        EsphomeServices Esphome { get; }

        FanServices Fan { get; }

        FrontendServices Frontend { get; }

        GooglewifiServices Googlewifi { get; }

        GroupServices Group { get; }

        HassioServices Hassio { get; }

        HomeassistantServices Homeassistant { get; }

        HumidifierServices Humidifier { get; }

        InputBooleanServices InputBoolean { get; }

        InputButtonServices InputButton { get; }

        InputDatetimeServices InputDatetime { get; }

        InputNumberServices InputNumber { get; }

        InputSelectServices InputSelect { get; }

        InputTextServices InputText { get; }

        LightServices Light { get; }

        LockServices Lock { get; }

        LogbookServices Logbook { get; }

        LyricServices Lyric { get; }

        MqttServices Mqtt { get; }

        NetdaemonServices Netdaemon { get; }

        NotifyServices Notify { get; }

        NumberServices Number { get; }

        PersistentNotificationServices PersistentNotification { get; }

        PersonServices Person { get; }

        RecorderServices Recorder { get; }

        SceneServices Scene { get; }

        ScriptServices Script { get; }

        SelectServices Select { get; }

        ShoppingListServices ShoppingList { get; }

        SirenServices Siren { get; }

        SwitchServices Switch { get; }

        SystemLogServices SystemLog { get; }

        TemplateServices Template { get; }

        TimerServices Timer { get; }

        TtsServices Tts { get; }

        UpdateServices Update { get; }

        UtilityMeterServices UtilityMeter { get; }

        VacuumServices Vacuum { get; }

        ZoneServices Zone { get; }
    }

    public class Services : IServices
    {
        private readonly IHaContext _haContext;
        public Services(IHaContext haContext)
        {
            _haContext = haContext;
        }

        public AlarmControlPanelServices AlarmControlPanel => new(_haContext);
        public AutomationServices Automation => new(_haContext);
        public BleMonitorServices BleMonitor => new(_haContext);
        public ButtonServices Button => new(_haContext);
        public CameraServices Camera => new(_haContext);
        public ClimateServices Climate => new(_haContext);
        public CloudServices Cloud => new(_haContext);
        public CounterServices Counter => new(_haContext);
        public CoverServices Cover => new(_haContext);
        public DeviceTrackerServices DeviceTracker => new(_haContext);
        public EsphomeServices Esphome => new(_haContext);
        public FanServices Fan => new(_haContext);
        public FrontendServices Frontend => new(_haContext);
        public GooglewifiServices Googlewifi => new(_haContext);
        public GroupServices Group => new(_haContext);
        public HassioServices Hassio => new(_haContext);
        public HomeassistantServices Homeassistant => new(_haContext);
        public HumidifierServices Humidifier => new(_haContext);
        public InputBooleanServices InputBoolean => new(_haContext);
        public InputButtonServices InputButton => new(_haContext);
        public InputDatetimeServices InputDatetime => new(_haContext);
        public InputNumberServices InputNumber => new(_haContext);
        public InputSelectServices InputSelect => new(_haContext);
        public InputTextServices InputText => new(_haContext);
        public LightServices Light => new(_haContext);
        public LockServices Lock => new(_haContext);
        public LogbookServices Logbook => new(_haContext);
        public LyricServices Lyric => new(_haContext);
        public MqttServices Mqtt => new(_haContext);
        public NetdaemonServices Netdaemon => new(_haContext);
        public NotifyServices Notify => new(_haContext);
        public NumberServices Number => new(_haContext);
        public PersistentNotificationServices PersistentNotification => new(_haContext);
        public PersonServices Person => new(_haContext);
        public RecorderServices Recorder => new(_haContext);
        public SceneServices Scene => new(_haContext);
        public ScriptServices Script => new(_haContext);
        public SelectServices Select => new(_haContext);
        public ShoppingListServices ShoppingList => new(_haContext);
        public SirenServices Siren => new(_haContext);
        public SwitchServices Switch => new(_haContext);
        public SystemLogServices SystemLog => new(_haContext);
        public TemplateServices Template => new(_haContext);
        public TimerServices Timer => new(_haContext);
        public TtsServices Tts => new(_haContext);
        public UpdateServices Update => new(_haContext);
        public UtilityMeterServices UtilityMeter => new(_haContext);
        public VacuumServices Vacuum => new(_haContext);
        public ZoneServices Zone => new(_haContext);
    }

    public class AlarmControlPanelServices
    {
        private readonly IHaContext _haContext;
        public AlarmControlPanelServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Send the alarm the command for arm away.</summary>
        ///<param name="target">The target for this service call</param>
        public void AlarmArmAway(ServiceTarget target, AlarmControlPanelAlarmArmAwayParameters data)
        {
            _haContext.CallService("alarm_control_panel", "alarm_arm_away", target, data);
        }

        ///<summary>Send the alarm the command for arm away.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="code">An optional code to arm away the alarm control panel with. eg: 1234</param>
        public void AlarmArmAway(ServiceTarget target, string? @code = null)
        {
            _haContext.CallService("alarm_control_panel", "alarm_arm_away", target, new AlarmControlPanelAlarmArmAwayParameters { Code = @code });
        }

        ///<summary>Send arm custom bypass command.</summary>
        ///<param name="target">The target for this service call</param>
        public void AlarmArmCustomBypass(ServiceTarget target, AlarmControlPanelAlarmArmCustomBypassParameters data)
        {
            _haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, data);
        }

        ///<summary>Send arm custom bypass command.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="code">An optional code to arm custom bypass the alarm control panel with. eg: 1234</param>
        public void AlarmArmCustomBypass(ServiceTarget target, string? @code = null)
        {
            _haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, new AlarmControlPanelAlarmArmCustomBypassParameters { Code = @code });
        }

        ///<summary>Send the alarm the command for arm home.</summary>
        ///<param name="target">The target for this service call</param>
        public void AlarmArmHome(ServiceTarget target, AlarmControlPanelAlarmArmHomeParameters data)
        {
            _haContext.CallService("alarm_control_panel", "alarm_arm_home", target, data);
        }

        ///<summary>Send the alarm the command for arm home.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="code">An optional code to arm home the alarm control panel with. eg: 1234</param>
        public void AlarmArmHome(ServiceTarget target, string? @code = null)
        {
            _haContext.CallService("alarm_control_panel", "alarm_arm_home", target, new AlarmControlPanelAlarmArmHomeParameters { Code = @code });
        }

        ///<summary>Send the alarm the command for arm night.</summary>
        ///<param name="target">The target for this service call</param>
        public void AlarmArmNight(ServiceTarget target, AlarmControlPanelAlarmArmNightParameters data)
        {
            _haContext.CallService("alarm_control_panel", "alarm_arm_night", target, data);
        }

        ///<summary>Send the alarm the command for arm night.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="code">An optional code to arm night the alarm control panel with. eg: 1234</param>
        public void AlarmArmNight(ServiceTarget target, string? @code = null)
        {
            _haContext.CallService("alarm_control_panel", "alarm_arm_night", target, new AlarmControlPanelAlarmArmNightParameters { Code = @code });
        }

        ///<summary>Send the alarm the command for arm vacation.</summary>
        ///<param name="target">The target for this service call</param>
        public void AlarmArmVacation(ServiceTarget target, AlarmControlPanelAlarmArmVacationParameters data)
        {
            _haContext.CallService("alarm_control_panel", "alarm_arm_vacation", target, data);
        }

        ///<summary>Send the alarm the command for arm vacation.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="code">An optional code to arm vacation the alarm control panel with. eg: 1234</param>
        public void AlarmArmVacation(ServiceTarget target, string? @code = null)
        {
            _haContext.CallService("alarm_control_panel", "alarm_arm_vacation", target, new AlarmControlPanelAlarmArmVacationParameters { Code = @code });
        }

        ///<summary>Send the alarm the command for disarm.</summary>
        ///<param name="target">The target for this service call</param>
        public void AlarmDisarm(ServiceTarget target, AlarmControlPanelAlarmDisarmParameters data)
        {
            _haContext.CallService("alarm_control_panel", "alarm_disarm", target, data);
        }

        ///<summary>Send the alarm the command for disarm.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="code">An optional code to disarm the alarm control panel with. eg: 1234</param>
        public void AlarmDisarm(ServiceTarget target, string? @code = null)
        {
            _haContext.CallService("alarm_control_panel", "alarm_disarm", target, new AlarmControlPanelAlarmDisarmParameters { Code = @code });
        }

        ///<summary>Send the alarm the command for trigger.</summary>
        ///<param name="target">The target for this service call</param>
        public void AlarmTrigger(ServiceTarget target, AlarmControlPanelAlarmTriggerParameters data)
        {
            _haContext.CallService("alarm_control_panel", "alarm_trigger", target, data);
        }

        ///<summary>Send the alarm the command for trigger.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="code">An optional code to trigger the alarm control panel with. eg: 1234</param>
        public void AlarmTrigger(ServiceTarget target, string? @code = null)
        {
            _haContext.CallService("alarm_control_panel", "alarm_trigger", target, new AlarmControlPanelAlarmTriggerParameters { Code = @code });
        }
    }

    public record AlarmControlPanelAlarmArmAwayParameters
    {
        ///<summary>An optional code to arm away the alarm control panel with. eg: 1234</summary>
        [JsonPropertyName("code")]
        public string? Code { get; init; }
    }

    public record AlarmControlPanelAlarmArmCustomBypassParameters
    {
        ///<summary>An optional code to arm custom bypass the alarm control panel with. eg: 1234</summary>
        [JsonPropertyName("code")]
        public string? Code { get; init; }
    }

    public record AlarmControlPanelAlarmArmHomeParameters
    {
        ///<summary>An optional code to arm home the alarm control panel with. eg: 1234</summary>
        [JsonPropertyName("code")]
        public string? Code { get; init; }
    }

    public record AlarmControlPanelAlarmArmNightParameters
    {
        ///<summary>An optional code to arm night the alarm control panel with. eg: 1234</summary>
        [JsonPropertyName("code")]
        public string? Code { get; init; }
    }

    public record AlarmControlPanelAlarmArmVacationParameters
    {
        ///<summary>An optional code to arm vacation the alarm control panel with. eg: 1234</summary>
        [JsonPropertyName("code")]
        public string? Code { get; init; }
    }

    public record AlarmControlPanelAlarmDisarmParameters
    {
        ///<summary>An optional code to disarm the alarm control panel with. eg: 1234</summary>
        [JsonPropertyName("code")]
        public string? Code { get; init; }
    }

    public record AlarmControlPanelAlarmTriggerParameters
    {
        ///<summary>An optional code to trigger the alarm control panel with. eg: 1234</summary>
        [JsonPropertyName("code")]
        public string? Code { get; init; }
    }

    public class AutomationServices
    {
        private readonly IHaContext _haContext;
        public AutomationServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Reload the automation configuration.</summary>
        public void Reload()
        {
            _haContext.CallService("automation", "reload", null);
        }

        ///<summary>Toggle (enable / disable) an automation.</summary>
        ///<param name="target">The target for this service call</param>
        public void Toggle(ServiceTarget target)
        {
            _haContext.CallService("automation", "toggle", target);
        }

        ///<summary>Trigger the actions of an automation.</summary>
        ///<param name="target">The target for this service call</param>
        public void Trigger(ServiceTarget target, AutomationTriggerParameters data)
        {
            _haContext.CallService("automation", "trigger", target, data);
        }

        ///<summary>Trigger the actions of an automation.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
        public void Trigger(ServiceTarget target, bool? @skipCondition = null)
        {
            _haContext.CallService("automation", "trigger", target, new AutomationTriggerParameters { SkipCondition = @skipCondition });
        }

        ///<summary>Disable an automation.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOff(ServiceTarget target, AutomationTurnOffParameters data)
        {
            _haContext.CallService("automation", "turn_off", target, data);
        }

        ///<summary>Disable an automation.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="stopActions">Stop currently running actions.</param>
        public void TurnOff(ServiceTarget target, bool? @stopActions = null)
        {
            _haContext.CallService("automation", "turn_off", target, new AutomationTurnOffParameters { StopActions = @stopActions });
        }

        ///<summary>Enable an automation.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOn(ServiceTarget target)
        {
            _haContext.CallService("automation", "turn_on", target);
        }
    }

    public record AutomationTriggerParameters
    {
        ///<summary>Whether or not the conditions will be skipped.</summary>
        [JsonPropertyName("skip_condition")]
        public bool? SkipCondition { get; init; }
    }

    public record AutomationTurnOffParameters
    {
        ///<summary>Stop currently running actions.</summary>
        [JsonPropertyName("stop_actions")]
        public bool? StopActions { get; init; }
    }

    public class BleMonitorServices
    {
        private readonly IHaContext _haContext;
        public BleMonitorServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Clean up of dangling devices of the BLE Montitor integration.</summary>
        public void CleanupEntries()
        {
            _haContext.CallService("ble_monitor", "cleanup_entries", null);
        }

        ///<summary>Send RAW HCI packet data to the BLE Montitor integration.</summary>
        public void ParseData(BleMonitorParseDataParameters data)
        {
            _haContext.CallService("ble_monitor", "parse_data", null, data);
        }

        ///<summary>Send RAW HCI packet data to the BLE Montitor integration.</summary>
        ///<param name="packet">RAW HCI packet data hex eg: 043E2B02010000123456789ABC1F12161A1819416538C1A41B073915810B529F0F0B094154435F363534313139AA</param>
        ///<param name="gatewayId">Identifier of the gateway that transmits the packet (only for device_tracker). eg: esp32_gateway</param>
        public void ParseData(string @packet, string? @gatewayId = null)
        {
            _haContext.CallService("ble_monitor", "parse_data", null, new BleMonitorParseDataParameters { Packet = @packet, GatewayId = @gatewayId });
        }
    }

    public record BleMonitorParseDataParameters
    {
        ///<summary>RAW HCI packet data hex eg: 043E2B02010000123456789ABC1F12161A1819416538C1A41B073915810B529F0F0B094154435F363534313139AA</summary>
        [JsonPropertyName("packet")]
        public string? Packet { get; init; }

        ///<summary>Identifier of the gateway that transmits the packet (only for device_tracker). eg: esp32_gateway</summary>
        [JsonPropertyName("gateway_id")]
        public string? GatewayId { get; init; }
    }

    public class ButtonServices
    {
        private readonly IHaContext _haContext;
        public ButtonServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Press the button entity.</summary>
        ///<param name="target">The target for this service call</param>
        public void Press(ServiceTarget target)
        {
            _haContext.CallService("button", "press", target);
        }
    }

    public class CameraServices
    {
        private readonly IHaContext _haContext;
        public CameraServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Disable the motion detection in a camera.</summary>
        ///<param name="target">The target for this service call</param>
        public void DisableMotionDetection(ServiceTarget target)
        {
            _haContext.CallService("camera", "disable_motion_detection", target);
        }

        ///<summary>Enable the motion detection in a camera.</summary>
        ///<param name="target">The target for this service call</param>
        public void EnableMotionDetection(ServiceTarget target)
        {
            _haContext.CallService("camera", "enable_motion_detection", target);
        }

        ///<summary>Play camera stream on supported media player.</summary>
        ///<param name="target">The target for this service call</param>
        public void PlayStream(ServiceTarget target, CameraPlayStreamParameters data)
        {
            _haContext.CallService("camera", "play_stream", target, data);
        }

        ///<summary>Play camera stream on supported media player.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
        ///<param name="format">Stream format supported by media player.</param>
        public void PlayStream(ServiceTarget target, string @mediaPlayer, object? @format = null)
        {
            _haContext.CallService("camera", "play_stream", target, new CameraPlayStreamParameters { MediaPlayer = @mediaPlayer, Format = @format });
        }

        ///<summary>Record live camera feed.</summary>
        ///<param name="target">The target for this service call</param>
        public void Record(ServiceTarget target, CameraRecordParameters data)
        {
            _haContext.CallService("camera", "record", target, data);
        }

        ///<summary>Record live camera feed.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
        ///<param name="duration">Target recording length.</param>
        ///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
        public void Record(ServiceTarget target, string @filename, long? @duration = null, long? @lookback = null)
        {
            _haContext.CallService("camera", "record", target, new CameraRecordParameters { Filename = @filename, Duration = @duration, Lookback = @lookback });
        }

        ///<summary>Take a snapshot from a camera.</summary>
        ///<param name="target">The target for this service call</param>
        public void Snapshot(ServiceTarget target, CameraSnapshotParameters data)
        {
            _haContext.CallService("camera", "snapshot", target, data);
        }

        ///<summary>Take a snapshot from a camera.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
        public void Snapshot(ServiceTarget target, string @filename)
        {
            _haContext.CallService("camera", "snapshot", target, new CameraSnapshotParameters { Filename = @filename });
        }

        ///<summary>Turn off camera.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOff(ServiceTarget target)
        {
            _haContext.CallService("camera", "turn_off", target);
        }

        ///<summary>Turn on camera.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOn(ServiceTarget target)
        {
            _haContext.CallService("camera", "turn_on", target);
        }
    }

    public record CameraPlayStreamParameters
    {
        ///<summary>Name(s) of media player to stream to.</summary>
        [JsonPropertyName("media_player")]
        public string? MediaPlayer { get; init; }

        ///<summary>Stream format supported by media player.</summary>
        [JsonPropertyName("format")]
        public object? Format { get; init; }
    }

    public record CameraRecordParameters
    {
        ///<summary>Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</summary>
        [JsonPropertyName("filename")]
        public string? Filename { get; init; }

        ///<summary>Target recording length.</summary>
        [JsonPropertyName("duration")]
        public long? Duration { get; init; }

        ///<summary>Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</summary>
        [JsonPropertyName("lookback")]
        public long? Lookback { get; init; }
    }

    public record CameraSnapshotParameters
    {
        ///<summary>Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</summary>
        [JsonPropertyName("filename")]
        public string? Filename { get; init; }
    }

    public class ClimateServices
    {
        private readonly IHaContext _haContext;
        public ClimateServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Turn auxiliary heater on/off for climate device.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetAuxHeat(ServiceTarget target, ClimateSetAuxHeatParameters data)
        {
            _haContext.CallService("climate", "set_aux_heat", target, data);
        }

        ///<summary>Turn auxiliary heater on/off for climate device.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="auxHeat">New value of auxiliary heater.</param>
        public void SetAuxHeat(ServiceTarget target, bool @auxHeat)
        {
            _haContext.CallService("climate", "set_aux_heat", target, new ClimateSetAuxHeatParameters { AuxHeat = @auxHeat });
        }

        ///<summary>Set fan operation for climate device.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetFanMode(ServiceTarget target, ClimateSetFanModeParameters data)
        {
            _haContext.CallService("climate", "set_fan_mode", target, data);
        }

        ///<summary>Set fan operation for climate device.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="fanMode">New value of fan mode. eg: low</param>
        public void SetFanMode(ServiceTarget target, string @fanMode)
        {
            _haContext.CallService("climate", "set_fan_mode", target, new ClimateSetFanModeParameters { FanMode = @fanMode });
        }

        ///<summary>Set target humidity of climate device.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetHumidity(ServiceTarget target, ClimateSetHumidityParameters data)
        {
            _haContext.CallService("climate", "set_humidity", target, data);
        }

        ///<summary>Set target humidity of climate device.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="humidity">New target humidity for climate device.</param>
        public void SetHumidity(ServiceTarget target, long @humidity)
        {
            _haContext.CallService("climate", "set_humidity", target, new ClimateSetHumidityParameters { Humidity = @humidity });
        }

        ///<summary>Set HVAC operation mode for climate device.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetHvacMode(ServiceTarget target, ClimateSetHvacModeParameters data)
        {
            _haContext.CallService("climate", "set_hvac_mode", target, data);
        }

        ///<summary>Set HVAC operation mode for climate device.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="hvacMode">New value of operation mode.</param>
        public void SetHvacMode(ServiceTarget target, object? @hvacMode = null)
        {
            _haContext.CallService("climate", "set_hvac_mode", target, new ClimateSetHvacModeParameters { HvacMode = @hvacMode });
        }

        ///<summary>Set preset mode for climate device.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetPresetMode(ServiceTarget target, ClimateSetPresetModeParameters data)
        {
            _haContext.CallService("climate", "set_preset_mode", target, data);
        }

        ///<summary>Set preset mode for climate device.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="presetMode">New value of preset mode. eg: away</param>
        public void SetPresetMode(ServiceTarget target, string @presetMode)
        {
            _haContext.CallService("climate", "set_preset_mode", target, new ClimateSetPresetModeParameters { PresetMode = @presetMode });
        }

        ///<summary>Set swing operation for climate device.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetSwingMode(ServiceTarget target, ClimateSetSwingModeParameters data)
        {
            _haContext.CallService("climate", "set_swing_mode", target, data);
        }

        ///<summary>Set swing operation for climate device.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="swingMode">New value of swing mode. eg: horizontal</param>
        public void SetSwingMode(ServiceTarget target, string @swingMode)
        {
            _haContext.CallService("climate", "set_swing_mode", target, new ClimateSetSwingModeParameters { SwingMode = @swingMode });
        }

        ///<summary>Set target temperature of climate device.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetTemperature(ServiceTarget target, ClimateSetTemperatureParameters data)
        {
            _haContext.CallService("climate", "set_temperature", target, data);
        }

        ///<summary>Set target temperature of climate device.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="temperature">New target temperature for HVAC.</param>
        ///<param name="targetTempHigh">New target high temperature for HVAC.</param>
        ///<param name="targetTempLow">New target low temperature for HVAC.</param>
        ///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
        public void SetTemperature(ServiceTarget target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, object? @hvacMode = null)
        {
            _haContext.CallService("climate", "set_temperature", target, new ClimateSetTemperatureParameters { Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode });
        }

        ///<summary>Turn climate device off.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOff(ServiceTarget target)
        {
            _haContext.CallService("climate", "turn_off", target);
        }

        ///<summary>Turn climate device on.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOn(ServiceTarget target)
        {
            _haContext.CallService("climate", "turn_on", target);
        }
    }

    public record ClimateSetAuxHeatParameters
    {
        ///<summary>New value of auxiliary heater.</summary>
        [JsonPropertyName("aux_heat")]
        public bool? AuxHeat { get; init; }
    }

    public record ClimateSetFanModeParameters
    {
        ///<summary>New value of fan mode. eg: low</summary>
        [JsonPropertyName("fan_mode")]
        public string? FanMode { get; init; }
    }

    public record ClimateSetHumidityParameters
    {
        ///<summary>New target humidity for climate device.</summary>
        [JsonPropertyName("humidity")]
        public long? Humidity { get; init; }
    }

    public record ClimateSetHvacModeParameters
    {
        ///<summary>New value of operation mode.</summary>
        [JsonPropertyName("hvac_mode")]
        public object? HvacMode { get; init; }
    }

    public record ClimateSetPresetModeParameters
    {
        ///<summary>New value of preset mode. eg: away</summary>
        [JsonPropertyName("preset_mode")]
        public string? PresetMode { get; init; }
    }

    public record ClimateSetSwingModeParameters
    {
        ///<summary>New value of swing mode. eg: horizontal</summary>
        [JsonPropertyName("swing_mode")]
        public string? SwingMode { get; init; }
    }

    public record ClimateSetTemperatureParameters
    {
        ///<summary>New target temperature for HVAC.</summary>
        [JsonPropertyName("temperature")]
        public double? Temperature { get; init; }

        ///<summary>New target high temperature for HVAC.</summary>
        [JsonPropertyName("target_temp_high")]
        public double? TargetTempHigh { get; init; }

        ///<summary>New target low temperature for HVAC.</summary>
        [JsonPropertyName("target_temp_low")]
        public double? TargetTempLow { get; init; }

        ///<summary>HVAC operation mode to set temperature to.</summary>
        [JsonPropertyName("hvac_mode")]
        public object? HvacMode { get; init; }
    }

    public class CloudServices
    {
        private readonly IHaContext _haContext;
        public CloudServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Make instance UI available outside over NabuCasa cloud</summary>
        public void RemoteConnect()
        {
            _haContext.CallService("cloud", "remote_connect", null);
        }

        ///<summary>Disconnect UI from NabuCasa cloud</summary>
        public void RemoteDisconnect()
        {
            _haContext.CallService("cloud", "remote_disconnect", null);
        }
    }

    public class CounterServices
    {
        private readonly IHaContext _haContext;
        public CounterServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Change counter parameters.</summary>
        ///<param name="target">The target for this service call</param>
        public void Configure(ServiceTarget target, CounterConfigureParameters data)
        {
            _haContext.CallService("counter", "configure", target, data);
        }

        ///<summary>Change counter parameters.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="minimum">New minimum value for the counter or None to remove minimum.</param>
        ///<param name="maximum">New maximum value for the counter or None to remove maximum.</param>
        ///<param name="step">New value for step.</param>
        ///<param name="initial">New value for initial.</param>
        ///<param name="value">New state value.</param>
        public void Configure(ServiceTarget target, long? @minimum = null, long? @maximum = null, long? @step = null, long? @initial = null, long? @value = null)
        {
            _haContext.CallService("counter", "configure", target, new CounterConfigureParameters { Minimum = @minimum, Maximum = @maximum, Step = @step, Initial = @initial, Value = @value });
        }

        ///<summary>Decrement a counter.</summary>
        ///<param name="target">The target for this service call</param>
        public void Decrement(ServiceTarget target)
        {
            _haContext.CallService("counter", "decrement", target);
        }

        ///<summary>Increment a counter.</summary>
        ///<param name="target">The target for this service call</param>
        public void Increment(ServiceTarget target)
        {
            _haContext.CallService("counter", "increment", target);
        }

        ///<summary>Reset a counter.</summary>
        ///<param name="target">The target for this service call</param>
        public void Reset(ServiceTarget target)
        {
            _haContext.CallService("counter", "reset", target);
        }
    }

    public record CounterConfigureParameters
    {
        ///<summary>New minimum value for the counter or None to remove minimum.</summary>
        [JsonPropertyName("minimum")]
        public long? Minimum { get; init; }

        ///<summary>New maximum value for the counter or None to remove maximum.</summary>
        [JsonPropertyName("maximum")]
        public long? Maximum { get; init; }

        ///<summary>New value for step.</summary>
        [JsonPropertyName("step")]
        public long? Step { get; init; }

        ///<summary>New value for initial.</summary>
        [JsonPropertyName("initial")]
        public long? Initial { get; init; }

        ///<summary>New state value.</summary>
        [JsonPropertyName("value")]
        public long? Value { get; init; }
    }

    public class CoverServices
    {
        private readonly IHaContext _haContext;
        public CoverServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Close all or specified cover.</summary>
        ///<param name="target">The target for this service call</param>
        public void CloseCover(ServiceTarget target)
        {
            _haContext.CallService("cover", "close_cover", target);
        }

        ///<summary>Close all or specified cover tilt.</summary>
        ///<param name="target">The target for this service call</param>
        public void CloseCoverTilt(ServiceTarget target)
        {
            _haContext.CallService("cover", "close_cover_tilt", target);
        }

        ///<summary>Open all or specified cover.</summary>
        ///<param name="target">The target for this service call</param>
        public void OpenCover(ServiceTarget target)
        {
            _haContext.CallService("cover", "open_cover", target);
        }

        ///<summary>Open all or specified cover tilt.</summary>
        ///<param name="target">The target for this service call</param>
        public void OpenCoverTilt(ServiceTarget target)
        {
            _haContext.CallService("cover", "open_cover_tilt", target);
        }

        ///<summary>Move to specific position all or specified cover.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetCoverPosition(ServiceTarget target, CoverSetCoverPositionParameters data)
        {
            _haContext.CallService("cover", "set_cover_position", target, data);
        }

        ///<summary>Move to specific position all or specified cover.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="position">Position of the cover</param>
        public void SetCoverPosition(ServiceTarget target, long @position)
        {
            _haContext.CallService("cover", "set_cover_position", target, new CoverSetCoverPositionParameters { Position = @position });
        }

        ///<summary>Move to specific position all or specified cover tilt.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetCoverTiltPosition(ServiceTarget target, CoverSetCoverTiltPositionParameters data)
        {
            _haContext.CallService("cover", "set_cover_tilt_position", target, data);
        }

        ///<summary>Move to specific position all or specified cover tilt.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="tiltPosition">Tilt position of the cover.</param>
        public void SetCoverTiltPosition(ServiceTarget target, long @tiltPosition)
        {
            _haContext.CallService("cover", "set_cover_tilt_position", target, new CoverSetCoverTiltPositionParameters { TiltPosition = @tiltPosition });
        }

        ///<summary>Stop all or specified cover.</summary>
        ///<param name="target">The target for this service call</param>
        public void StopCover(ServiceTarget target)
        {
            _haContext.CallService("cover", "stop_cover", target);
        }

        ///<summary>Stop all or specified cover.</summary>
        ///<param name="target">The target for this service call</param>
        public void StopCoverTilt(ServiceTarget target)
        {
            _haContext.CallService("cover", "stop_cover_tilt", target);
        }

        ///<summary>Toggle a cover open/closed.</summary>
        ///<param name="target">The target for this service call</param>
        public void Toggle(ServiceTarget target)
        {
            _haContext.CallService("cover", "toggle", target);
        }

        ///<summary>Toggle a cover tilt open/closed.</summary>
        ///<param name="target">The target for this service call</param>
        public void ToggleCoverTilt(ServiceTarget target)
        {
            _haContext.CallService("cover", "toggle_cover_tilt", target);
        }
    }

    public record CoverSetCoverPositionParameters
    {
        ///<summary>Position of the cover</summary>
        [JsonPropertyName("position")]
        public long? Position { get; init; }
    }

    public record CoverSetCoverTiltPositionParameters
    {
        ///<summary>Tilt position of the cover.</summary>
        [JsonPropertyName("tilt_position")]
        public long? TiltPosition { get; init; }
    }

    public class DeviceTrackerServices
    {
        private readonly IHaContext _haContext;
        public DeviceTrackerServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Control tracked device.</summary>
        public void See(DeviceTrackerSeeParameters data)
        {
            _haContext.CallService("device_tracker", "see", null, data);
        }

        ///<summary>Control tracked device.</summary>
        ///<param name="mac">MAC address of device eg: FF:FF:FF:FF:FF:FF</param>
        ///<param name="devId">Id of device (find id in known_devices.yaml). eg: phonedave</param>
        ///<param name="hostName">Hostname of device eg: Dave</param>
        ///<param name="locationName">Name of location where device is located (not_home is away). eg: home</param>
        ///<param name="gps">GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</param>
        ///<param name="gpsAccuracy">Accuracy of GPS coordinates.</param>
        ///<param name="battery">Battery level of device.</param>
        public void See(string? @mac = null, string? @devId = null, string? @hostName = null, string? @locationName = null, object? @gps = null, long? @gpsAccuracy = null, long? @battery = null)
        {
            _haContext.CallService("device_tracker", "see", null, new DeviceTrackerSeeParameters { Mac = @mac, DevId = @devId, HostName = @hostName, LocationName = @locationName, Gps = @gps, GpsAccuracy = @gpsAccuracy, Battery = @battery });
        }
    }

    public record DeviceTrackerSeeParameters
    {
        ///<summary>MAC address of device eg: FF:FF:FF:FF:FF:FF</summary>
        [JsonPropertyName("mac")]
        public string? Mac { get; init; }

        ///<summary>Id of device (find id in known_devices.yaml). eg: phonedave</summary>
        [JsonPropertyName("dev_id")]
        public string? DevId { get; init; }

        ///<summary>Hostname of device eg: Dave</summary>
        [JsonPropertyName("host_name")]
        public string? HostName { get; init; }

        ///<summary>Name of location where device is located (not_home is away). eg: home</summary>
        [JsonPropertyName("location_name")]
        public string? LocationName { get; init; }

        ///<summary>GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</summary>
        [JsonPropertyName("gps")]
        public object? Gps { get; init; }

        ///<summary>Accuracy of GPS coordinates.</summary>
        [JsonPropertyName("gps_accuracy")]
        public long? GpsAccuracy { get; init; }

        ///<summary>Battery level of device.</summary>
        [JsonPropertyName("battery")]
        public long? Battery { get; init; }
    }

    public class EsphomeServices
    {
        private readonly IHaContext _haContext;
        public EsphomeServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Calls the service nutrientpump1 of the node peristalticnutrients</summary>
        public void PeristalticnutrientsNutrientpump1(EsphomePeristalticnutrientsNutrientpump1Parameters data)
        {
            _haContext.CallService("esphome", "peristalticnutrients_nutrientpump1", null, data);
        }

        ///<summary>Calls the service nutrientpump1 of the node peristalticnutrients</summary>
        ///<param name="target"> eg: 42</param>
        public void PeristalticnutrientsNutrientpump1(long @target)
        {
            _haContext.CallService("esphome", "peristalticnutrients_nutrientpump1", null, new EsphomePeristalticnutrientsNutrientpump1Parameters { Target = @target });
        }

        ///<summary>Calls the service nutrientpump2 of the node peristalticnutrients</summary>
        public void PeristalticnutrientsNutrientpump2(EsphomePeristalticnutrientsNutrientpump2Parameters data)
        {
            _haContext.CallService("esphome", "peristalticnutrients_nutrientpump2", null, data);
        }

        ///<summary>Calls the service nutrientpump2 of the node peristalticnutrients</summary>
        ///<param name="target"> eg: 42</param>
        public void PeristalticnutrientsNutrientpump2(long @target)
        {
            _haContext.CallService("esphome", "peristalticnutrients_nutrientpump2", null, new EsphomePeristalticnutrientsNutrientpump2Parameters { Target = @target });
        }

        ///<summary>Calls the service nutrientpump3 of the node peristalticnutrients</summary>
        public void PeristalticnutrientsNutrientpump3(EsphomePeristalticnutrientsNutrientpump3Parameters data)
        {
            _haContext.CallService("esphome", "peristalticnutrients_nutrientpump3", null, data);
        }

        ///<summary>Calls the service nutrientpump3 of the node peristalticnutrients</summary>
        ///<param name="target"> eg: 42</param>
        public void PeristalticnutrientsNutrientpump3(long @target)
        {
            _haContext.CallService("esphome", "peristalticnutrients_nutrientpump3", null, new EsphomePeristalticnutrientsNutrientpump3Parameters { Target = @target });
        }
    }

    public record EsphomePeristalticnutrientsNutrientpump1Parameters
    {
        ///<summary> eg: 42</summary>
        [JsonPropertyName("target")]
        public long? Target { get; init; }
    }

    public record EsphomePeristalticnutrientsNutrientpump2Parameters
    {
        ///<summary> eg: 42</summary>
        [JsonPropertyName("target")]
        public long? Target { get; init; }
    }

    public record EsphomePeristalticnutrientsNutrientpump3Parameters
    {
        ///<summary> eg: 42</summary>
        [JsonPropertyName("target")]
        public long? Target { get; init; }
    }

    public class FanServices
    {
        private readonly IHaContext _haContext;
        public FanServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
        ///<param name="target">The target for this service call</param>
        public void DecreaseSpeed(ServiceTarget target, FanDecreaseSpeedParameters data)
        {
            _haContext.CallService("fan", "decrease_speed", target, data);
        }

        ///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="percentageStep">Decrease speed by a percentage.</param>
        public void DecreaseSpeed(ServiceTarget target, long? @percentageStep = null)
        {
            _haContext.CallService("fan", "decrease_speed", target, new FanDecreaseSpeedParameters { PercentageStep = @percentageStep });
        }

        ///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
        ///<param name="target">The target for this service call</param>
        public void IncreaseSpeed(ServiceTarget target, FanIncreaseSpeedParameters data)
        {
            _haContext.CallService("fan", "increase_speed", target, data);
        }

        ///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="percentageStep">Increase speed by a percentage.</param>
        public void IncreaseSpeed(ServiceTarget target, long? @percentageStep = null)
        {
            _haContext.CallService("fan", "increase_speed", target, new FanIncreaseSpeedParameters { PercentageStep = @percentageStep });
        }

        ///<summary>Oscillate the fan.</summary>
        ///<param name="target">The target for this service call</param>
        public void Oscillate(ServiceTarget target, FanOscillateParameters data)
        {
            _haContext.CallService("fan", "oscillate", target, data);
        }

        ///<summary>Oscillate the fan.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="oscillating">Flag to turn on/off oscillation.</param>
        public void Oscillate(ServiceTarget target, bool @oscillating)
        {
            _haContext.CallService("fan", "oscillate", target, new FanOscillateParameters { Oscillating = @oscillating });
        }

        ///<summary>Set the fan rotation.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetDirection(ServiceTarget target, FanSetDirectionParameters data)
        {
            _haContext.CallService("fan", "set_direction", target, data);
        }

        ///<summary>Set the fan rotation.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="direction">The direction to rotate.</param>
        public void SetDirection(ServiceTarget target, object @direction)
        {
            _haContext.CallService("fan", "set_direction", target, new FanSetDirectionParameters { Direction = @direction });
        }

        ///<summary>Set fan speed percentage.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetPercentage(ServiceTarget target, FanSetPercentageParameters data)
        {
            _haContext.CallService("fan", "set_percentage", target, data);
        }

        ///<summary>Set fan speed percentage.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="percentage">Percentage speed setting.</param>
        public void SetPercentage(ServiceTarget target, long @percentage)
        {
            _haContext.CallService("fan", "set_percentage", target, new FanSetPercentageParameters { Percentage = @percentage });
        }

        ///<summary>Set preset mode for a fan device.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetPresetMode(ServiceTarget target, FanSetPresetModeParameters data)
        {
            _haContext.CallService("fan", "set_preset_mode", target, data);
        }

        ///<summary>Set preset mode for a fan device.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="presetMode">New value of preset mode. eg: auto</param>
        public void SetPresetMode(ServiceTarget target, string @presetMode)
        {
            _haContext.CallService("fan", "set_preset_mode", target, new FanSetPresetModeParameters { PresetMode = @presetMode });
        }

        ///<summary>Toggle the fan on/off.</summary>
        ///<param name="target">The target for this service call</param>
        public void Toggle(ServiceTarget target)
        {
            _haContext.CallService("fan", "toggle", target);
        }

        ///<summary>Turn fan off.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOff(ServiceTarget target)
        {
            _haContext.CallService("fan", "turn_off", target);
        }

        ///<summary>Turn fan on.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOn(ServiceTarget target, FanTurnOnParameters data)
        {
            _haContext.CallService("fan", "turn_on", target, data);
        }

        ///<summary>Turn fan on.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="speed">Speed setting. eg: high</param>
        ///<param name="percentage">Percentage speed setting.</param>
        ///<param name="presetMode">Preset mode setting. eg: auto</param>
        public void TurnOn(ServiceTarget target, string? @speed = null, long? @percentage = null, string? @presetMode = null)
        {
            _haContext.CallService("fan", "turn_on", target, new FanTurnOnParameters { Speed = @speed, Percentage = @percentage, PresetMode = @presetMode });
        }
    }

    public record FanDecreaseSpeedParameters
    {
        ///<summary>Decrease speed by a percentage.</summary>
        [JsonPropertyName("percentage_step")]
        public long? PercentageStep { get; init; }
    }

    public record FanIncreaseSpeedParameters
    {
        ///<summary>Increase speed by a percentage.</summary>
        [JsonPropertyName("percentage_step")]
        public long? PercentageStep { get; init; }
    }

    public record FanOscillateParameters
    {
        ///<summary>Flag to turn on/off oscillation.</summary>
        [JsonPropertyName("oscillating")]
        public bool? Oscillating { get; init; }
    }

    public record FanSetDirectionParameters
    {
        ///<summary>The direction to rotate.</summary>
        [JsonPropertyName("direction")]
        public object? Direction { get; init; }
    }

    public record FanSetPercentageParameters
    {
        ///<summary>Percentage speed setting.</summary>
        [JsonPropertyName("percentage")]
        public long? Percentage { get; init; }
    }

    public record FanSetPresetModeParameters
    {
        ///<summary>New value of preset mode. eg: auto</summary>
        [JsonPropertyName("preset_mode")]
        public string? PresetMode { get; init; }
    }

    public record FanTurnOnParameters
    {
        ///<summary>Speed setting. eg: high</summary>
        [JsonPropertyName("speed")]
        public string? Speed { get; init; }

        ///<summary>Percentage speed setting.</summary>
        [JsonPropertyName("percentage")]
        public long? Percentage { get; init; }

        ///<summary>Preset mode setting. eg: auto</summary>
        [JsonPropertyName("preset_mode")]
        public string? PresetMode { get; init; }
    }

    public class FrontendServices
    {
        private readonly IHaContext _haContext;
        public FrontendServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Reload themes from YAML configuration.</summary>
        public void ReloadThemes()
        {
            _haContext.CallService("frontend", "reload_themes", null);
        }

        ///<summary>Set a theme unless the client selected per-device theme.</summary>
        public void SetTheme(FrontendSetThemeParameters data)
        {
            _haContext.CallService("frontend", "set_theme", null, data);
        }

        ///<summary>Set a theme unless the client selected per-device theme.</summary>
        ///<param name="name">Name of a predefined theme eg: default</param>
        ///<param name="mode">The mode the theme is for.</param>
        public void SetTheme(object @name, object? @mode = null)
        {
            _haContext.CallService("frontend", "set_theme", null, new FrontendSetThemeParameters { Name = @name, Mode = @mode });
        }
    }

    public record FrontendSetThemeParameters
    {
        ///<summary>Name of a predefined theme eg: default</summary>
        [JsonPropertyName("name")]
        public object? Name { get; init; }

        ///<summary>The mode the theme is for.</summary>
        [JsonPropertyName("mode")]
        public object? Mode { get; init; }
    }

    public class GooglewifiServices
    {
        private readonly IHaContext _haContext;
        public GooglewifiServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Prioritize a Google Wifi Client Device for x hours</summary>
        public void Prioritize(GooglewifiPrioritizeParameters data)
        {
            _haContext.CallService("googlewifi", "prioritize", null, data);
        }

        ///<summary>Prioritize a Google Wifi Client Device for x hours</summary>
        ///<param name="entityId">The entity ID of the device you would like to prioritize. eg: switch.iPhone</param>
        ///<param name="duration">The duration in hours that you would like the prioritization to last. eg: 4</param>
        public void Prioritize(object? @entityId = null, object? @duration = null)
        {
            _haContext.CallService("googlewifi", "prioritize", null, new GooglewifiPrioritizeParameters { EntityId = @entityId, Duration = @duration });
        }

        ///<summary>Clear any device prioritizations on the Google Wifi system.</summary>
        public void PrioritizeReset(GooglewifiPrioritizeResetParameters data)
        {
            _haContext.CallService("googlewifi", "prioritize_reset", null, data);
        }

        ///<summary>Clear any device prioritizations on the Google Wifi system.</summary>
        ///<param name="entityId">A switch entity ID from the Google Wifi System you want to clear. eg: switch.iPhone</param>
        public void PrioritizeReset(object? @entityId = null)
        {
            _haContext.CallService("googlewifi", "prioritize_reset", null, new GooglewifiPrioritizeResetParameters { EntityId = @entityId });
        }

        ///<summary>Reset a Google Wifi Access Point or the System</summary>
        public void Reset(GooglewifiResetParameters data)
        {
            _haContext.CallService("googlewifi", "reset", null, data);
        }

        ///<summary>Reset a Google Wifi Access Point or the System</summary>
        ///<param name="entityId">Access point or system to restart eg: binary_sensor.this_access_point</param>
        public void Reset(object? @entityId = null)
        {
            _haContext.CallService("googlewifi", "reset", null, new GooglewifiResetParameters { EntityId = @entityId });
        }

        ///<summary>Run a WLAN speed test on the Google Wifi system.</summary>
        public void SpeedTest(GooglewifiSpeedTestParameters data)
        {
            _haContext.CallService("googlewifi", "speed_test", null, data);
        }

        ///<summary>Run a WLAN speed test on the Google Wifi system.</summary>
        ///<param name="entityId">The entity id of a speed sensor on the system you want to test. eg: sensor.googlewifi_system_upload_speed</param>
        public void SpeedTest(object? @entityId = null)
        {
            _haContext.CallService("googlewifi", "speed_test", null, new GooglewifiSpeedTestParameters { EntityId = @entityId });
        }
    }

    public record GooglewifiPrioritizeParameters
    {
        ///<summary>The entity ID of the device you would like to prioritize. eg: switch.iPhone</summary>
        [JsonPropertyName("entity_id")]
        public object? EntityId { get; init; }

        ///<summary>The duration in hours that you would like the prioritization to last. eg: 4</summary>
        [JsonPropertyName("duration")]
        public object? Duration { get; init; }
    }

    public record GooglewifiPrioritizeResetParameters
    {
        ///<summary>A switch entity ID from the Google Wifi System you want to clear. eg: switch.iPhone</summary>
        [JsonPropertyName("entity_id")]
        public object? EntityId { get; init; }
    }

    public record GooglewifiResetParameters
    {
        ///<summary>Access point or system to restart eg: binary_sensor.this_access_point</summary>
        [JsonPropertyName("entity_id")]
        public object? EntityId { get; init; }
    }

    public record GooglewifiSpeedTestParameters
    {
        ///<summary>The entity id of a speed sensor on the system you want to test. eg: sensor.googlewifi_system_upload_speed</summary>
        [JsonPropertyName("entity_id")]
        public object? EntityId { get; init; }
    }

    public class GroupServices
    {
        private readonly IHaContext _haContext;
        public GroupServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Reload group configuration, entities, and notify services.</summary>
        public void Reload()
        {
            _haContext.CallService("group", "reload", null);
        }

        ///<summary>Remove a user group.</summary>
        public void Remove(GroupRemoveParameters data)
        {
            _haContext.CallService("group", "remove", null, data);
        }

        ///<summary>Remove a user group.</summary>
        ///<param name="objectId">Group id and part of entity id. eg: test_group</param>
        public void Remove(object @objectId)
        {
            _haContext.CallService("group", "remove", null, new GroupRemoveParameters { ObjectId = @objectId });
        }

        ///<summary>Create/Update a user group.</summary>
        public void Set(GroupSetParameters data)
        {
            _haContext.CallService("group", "set", null, data);
        }

        ///<summary>Create/Update a user group.</summary>
        ///<param name="objectId">Group id and part of entity id. eg: test_group</param>
        ///<param name="name">Name of group eg: My test group</param>
        ///<param name="icon">Name of icon for the group. eg: mdi:camera</param>
        ///<param name="entities">List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1, domain.entity_id2</param>
        ///<param name="addEntities">List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</param>
        ///<param name="all">Enable this option if the group should only turn on when all entities are on.</param>
        public void Set(string @objectId, string? @name = null, object? @icon = null, object? @entities = null, object? @addEntities = null, bool? @all = null)
        {
            _haContext.CallService("group", "set", null, new GroupSetParameters { ObjectId = @objectId, Name = @name, Icon = @icon, Entities = @entities, AddEntities = @addEntities, All = @all });
        }
    }

    public record GroupRemoveParameters
    {
        ///<summary>Group id and part of entity id. eg: test_group</summary>
        [JsonPropertyName("object_id")]
        public object? ObjectId { get; init; }
    }

    public record GroupSetParameters
    {
        ///<summary>Group id and part of entity id. eg: test_group</summary>
        [JsonPropertyName("object_id")]
        public string? ObjectId { get; init; }

        ///<summary>Name of group eg: My test group</summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        ///<summary>Name of icon for the group. eg: mdi:camera</summary>
        [JsonPropertyName("icon")]
        public object? Icon { get; init; }

        ///<summary>List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1, domain.entity_id2</summary>
        [JsonPropertyName("entities")]
        public object? Entities { get; init; }

        ///<summary>List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</summary>
        [JsonPropertyName("add_entities")]
        public object? AddEntities { get; init; }

        ///<summary>Enable this option if the group should only turn on when all entities are on.</summary>
        [JsonPropertyName("all")]
        public bool? All { get; init; }
    }

    public class HassioServices
    {
        private readonly IHaContext _haContext;
        public HassioServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Restart add-on.</summary>
        public void AddonRestart(HassioAddonRestartParameters data)
        {
            _haContext.CallService("hassio", "addon_restart", null, data);
        }

        ///<summary>Restart add-on.</summary>
        ///<param name="addon">The add-on slug. eg: core_ssh</param>
        public void AddonRestart(string @addon)
        {
            _haContext.CallService("hassio", "addon_restart", null, new HassioAddonRestartParameters { Addon = @addon });
        }

        ///<summary>Start add-on.</summary>
        public void AddonStart(HassioAddonStartParameters data)
        {
            _haContext.CallService("hassio", "addon_start", null, data);
        }

        ///<summary>Start add-on.</summary>
        ///<param name="addon">The add-on slug. eg: core_ssh</param>
        public void AddonStart(string @addon)
        {
            _haContext.CallService("hassio", "addon_start", null, new HassioAddonStartParameters { Addon = @addon });
        }

        ///<summary>Write data to add-on stdin.</summary>
        public void AddonStdin(HassioAddonStdinParameters data)
        {
            _haContext.CallService("hassio", "addon_stdin", null, data);
        }

        ///<summary>Write data to add-on stdin.</summary>
        ///<param name="addon">The add-on slug. eg: core_ssh</param>
        public void AddonStdin(string @addon)
        {
            _haContext.CallService("hassio", "addon_stdin", null, new HassioAddonStdinParameters { Addon = @addon });
        }

        ///<summary>Stop add-on.</summary>
        public void AddonStop(HassioAddonStopParameters data)
        {
            _haContext.CallService("hassio", "addon_stop", null, data);
        }

        ///<summary>Stop add-on.</summary>
        ///<param name="addon">The add-on slug. eg: core_ssh</param>
        public void AddonStop(string @addon)
        {
            _haContext.CallService("hassio", "addon_stop", null, new HassioAddonStopParameters { Addon = @addon });
        }

        ///<summary>Update add-on. This service should be used with caution since add-on updates can contain breaking changes. It is highly recommended that you review release notes/change logs before updating an add-on.</summary>
        public void AddonUpdate(HassioAddonUpdateParameters data)
        {
            _haContext.CallService("hassio", "addon_update", null, data);
        }

        ///<summary>Update add-on. This service should be used with caution since add-on updates can contain breaking changes. It is highly recommended that you review release notes/change logs before updating an add-on.</summary>
        ///<param name="addon">The add-on slug. eg: core_ssh</param>
        public void AddonUpdate(string @addon)
        {
            _haContext.CallService("hassio", "addon_update", null, new HassioAddonUpdateParameters { Addon = @addon });
        }

        ///<summary>Create a full backup.</summary>
        public void BackupFull(HassioBackupFullParameters data)
        {
            _haContext.CallService("hassio", "backup_full", null, data);
        }

        ///<summary>Create a full backup.</summary>
        ///<param name="name">Optional (default = current date and time). eg: Backup 1</param>
        ///<param name="password">Optional password. eg: password</param>
        ///<param name="compressed">Use compressed archives</param>
        public void BackupFull(string? @name = null, string? @password = null, bool? @compressed = null)
        {
            _haContext.CallService("hassio", "backup_full", null, new HassioBackupFullParameters { Name = @name, Password = @password, Compressed = @compressed });
        }

        ///<summary>Create a partial backup.</summary>
        public void BackupPartial(HassioBackupPartialParameters data)
        {
            _haContext.CallService("hassio", "backup_partial", null, data);
        }

        ///<summary>Create a partial backup.</summary>
        ///<param name="homeassistant">Backup Home Assistant settings</param>
        ///<param name="addons">Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</param>
        ///<param name="folders">Optional list of directories. eg: ["homeassistant","share"]</param>
        ///<param name="name">Optional (default = current date and time). eg: Partial backup 1</param>
        ///<param name="password">Optional password. eg: password</param>
        ///<param name="compressed">Use compressed archives</param>
        public void BackupPartial(bool? @homeassistant = null, object? @addons = null, object? @folders = null, string? @name = null, string? @password = null, bool? @compressed = null)
        {
            _haContext.CallService("hassio", "backup_partial", null, new HassioBackupPartialParameters { Homeassistant = @homeassistant, Addons = @addons, Folders = @folders, Name = @name, Password = @password, Compressed = @compressed });
        }

        ///<summary>Reboot the host system.</summary>
        public void HostReboot()
        {
            _haContext.CallService("hassio", "host_reboot", null);
        }

        ///<summary>Poweroff the host system.</summary>
        public void HostShutdown()
        {
            _haContext.CallService("hassio", "host_shutdown", null);
        }

        ///<summary>Restore from full backup.</summary>
        public void RestoreFull(HassioRestoreFullParameters data)
        {
            _haContext.CallService("hassio", "restore_full", null, data);
        }

        ///<summary>Restore from full backup.</summary>
        ///<param name="slug">Slug of backup to restore from.</param>
        ///<param name="password">Optional password. eg: password</param>
        public void RestoreFull(string @slug, string? @password = null)
        {
            _haContext.CallService("hassio", "restore_full", null, new HassioRestoreFullParameters { Slug = @slug, Password = @password });
        }

        ///<summary>Restore from partial backup.</summary>
        public void RestorePartial(HassioRestorePartialParameters data)
        {
            _haContext.CallService("hassio", "restore_partial", null, data);
        }

        ///<summary>Restore from partial backup.</summary>
        ///<param name="slug">Slug of backup to restore from.</param>
        ///<param name="homeassistant">Restore Home Assistant</param>
        ///<param name="folders">Optional list of directories. eg: ["homeassistant","share"]</param>
        ///<param name="addons">Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</param>
        ///<param name="password">Optional password. eg: password</param>
        public void RestorePartial(string @slug, bool? @homeassistant = null, object? @folders = null, object? @addons = null, string? @password = null)
        {
            _haContext.CallService("hassio", "restore_partial", null, new HassioRestorePartialParameters { Slug = @slug, Homeassistant = @homeassistant, Folders = @folders, Addons = @addons, Password = @password });
        }
    }

    public record HassioAddonRestartParameters
    {
        ///<summary>The add-on slug. eg: core_ssh</summary>
        [JsonPropertyName("addon")]
        public string? Addon { get; init; }
    }

    public record HassioAddonStartParameters
    {
        ///<summary>The add-on slug. eg: core_ssh</summary>
        [JsonPropertyName("addon")]
        public string? Addon { get; init; }
    }

    public record HassioAddonStdinParameters
    {
        ///<summary>The add-on slug. eg: core_ssh</summary>
        [JsonPropertyName("addon")]
        public string? Addon { get; init; }
    }

    public record HassioAddonStopParameters
    {
        ///<summary>The add-on slug. eg: core_ssh</summary>
        [JsonPropertyName("addon")]
        public string? Addon { get; init; }
    }

    public record HassioAddonUpdateParameters
    {
        ///<summary>The add-on slug. eg: core_ssh</summary>
        [JsonPropertyName("addon")]
        public string? Addon { get; init; }
    }

    public record HassioBackupFullParameters
    {
        ///<summary>Optional (default = current date and time). eg: Backup 1</summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        ///<summary>Optional password. eg: password</summary>
        [JsonPropertyName("password")]
        public string? Password { get; init; }

        ///<summary>Use compressed archives</summary>
        [JsonPropertyName("compressed")]
        public bool? Compressed { get; init; }
    }

    public record HassioBackupPartialParameters
    {
        ///<summary>Backup Home Assistant settings</summary>
        [JsonPropertyName("homeassistant")]
        public bool? Homeassistant { get; init; }

        ///<summary>Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</summary>
        [JsonPropertyName("addons")]
        public object? Addons { get; init; }

        ///<summary>Optional list of directories. eg: ["homeassistant","share"]</summary>
        [JsonPropertyName("folders")]
        public object? Folders { get; init; }

        ///<summary>Optional (default = current date and time). eg: Partial backup 1</summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        ///<summary>Optional password. eg: password</summary>
        [JsonPropertyName("password")]
        public string? Password { get; init; }

        ///<summary>Use compressed archives</summary>
        [JsonPropertyName("compressed")]
        public bool? Compressed { get; init; }
    }

    public record HassioRestoreFullParameters
    {
        ///<summary>Slug of backup to restore from.</summary>
        [JsonPropertyName("slug")]
        public string? Slug { get; init; }

        ///<summary>Optional password. eg: password</summary>
        [JsonPropertyName("password")]
        public string? Password { get; init; }
    }

    public record HassioRestorePartialParameters
    {
        ///<summary>Slug of backup to restore from.</summary>
        [JsonPropertyName("slug")]
        public string? Slug { get; init; }

        ///<summary>Restore Home Assistant</summary>
        [JsonPropertyName("homeassistant")]
        public bool? Homeassistant { get; init; }

        ///<summary>Optional list of directories. eg: ["homeassistant","share"]</summary>
        [JsonPropertyName("folders")]
        public object? Folders { get; init; }

        ///<summary>Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</summary>
        [JsonPropertyName("addons")]
        public object? Addons { get; init; }

        ///<summary>Optional password. eg: password</summary>
        [JsonPropertyName("password")]
        public string? Password { get; init; }
    }

    public class HomeassistantServices
    {
        private readonly IHaContext _haContext;
        public HomeassistantServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Check the Home Assistant configuration files for errors. Errors will be displayed in the Home Assistant log.</summary>
        public void CheckConfig()
        {
            _haContext.CallService("homeassistant", "check_config", null);
        }

        ///<summary>Reload a config entry that matches a target.</summary>
        ///<param name="target">The target for this service call</param>
        public void ReloadConfigEntry(ServiceTarget target, HomeassistantReloadConfigEntryParameters data)
        {
            _haContext.CallService("homeassistant", "reload_config_entry", target, data);
        }

        ///<summary>Reload a config entry that matches a target.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="entryId">A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</param>
        public void ReloadConfigEntry(ServiceTarget target, string? @entryId = null)
        {
            _haContext.CallService("homeassistant", "reload_config_entry", target, new HomeassistantReloadConfigEntryParameters { EntryId = @entryId });
        }

        ///<summary>Reload the core configuration.</summary>
        public void ReloadCoreConfig()
        {
            _haContext.CallService("homeassistant", "reload_core_config", null);
        }

        ///<summary>Restart the Home Assistant service.</summary>
        public void Restart()
        {
            _haContext.CallService("homeassistant", "restart", null);
        }

        ///<summary>Save the persistent states (for entities derived from RestoreEntity) immediately. Maintain the normal periodic saving interval.</summary>
        public void SavePersistentStates()
        {
            _haContext.CallService("homeassistant", "save_persistent_states", null);
        }

        ///<summary>Update the Home Assistant location.</summary>
        public void SetLocation(HomeassistantSetLocationParameters data)
        {
            _haContext.CallService("homeassistant", "set_location", null, data);
        }

        ///<summary>Update the Home Assistant location.</summary>
        ///<param name="latitude">Latitude of your location. eg: 32.87336</param>
        ///<param name="longitude">Longitude of your location. eg: 117.22743</param>
        public void SetLocation(string @latitude, string @longitude)
        {
            _haContext.CallService("homeassistant", "set_location", null, new HomeassistantSetLocationParameters { Latitude = @latitude, Longitude = @longitude });
        }

        ///<summary>Stop the Home Assistant service.</summary>
        public void Stop()
        {
            _haContext.CallService("homeassistant", "stop", null);
        }

        ///<summary>Generic service to toggle devices on/off under any domain</summary>
        ///<param name="target">The target for this service call</param>
        public void Toggle(ServiceTarget target)
        {
            _haContext.CallService("homeassistant", "toggle", target);
        }

        ///<summary>Generic service to turn devices off under any domain.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOff(ServiceTarget target)
        {
            _haContext.CallService("homeassistant", "turn_off", target);
        }

        ///<summary>Generic service to turn devices on under any domain.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOn(ServiceTarget target)
        {
            _haContext.CallService("homeassistant", "turn_on", target);
        }

        ///<summary>Force one or more entities to update its data</summary>
        ///<param name="target">The target for this service call</param>
        public void UpdateEntity(ServiceTarget target)
        {
            _haContext.CallService("homeassistant", "update_entity", target);
        }
    }

    public record HomeassistantReloadConfigEntryParameters
    {
        ///<summary>A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</summary>
        [JsonPropertyName("entry_id")]
        public string? EntryId { get; init; }
    }

    public record HomeassistantSetLocationParameters
    {
        ///<summary>Latitude of your location. eg: 32.87336</summary>
        [JsonPropertyName("latitude")]
        public string? Latitude { get; init; }

        ///<summary>Longitude of your location. eg: 117.22743</summary>
        [JsonPropertyName("longitude")]
        public string? Longitude { get; init; }
    }

    public class HumidifierServices
    {
        private readonly IHaContext _haContext;
        public HumidifierServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Set target humidity of humidifier device.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetHumidity(ServiceTarget target, HumidifierSetHumidityParameters data)
        {
            _haContext.CallService("humidifier", "set_humidity", target, data);
        }

        ///<summary>Set target humidity of humidifier device.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="humidity">New target humidity for humidifier device.</param>
        public void SetHumidity(ServiceTarget target, long @humidity)
        {
            _haContext.CallService("humidifier", "set_humidity", target, new HumidifierSetHumidityParameters { Humidity = @humidity });
        }

        ///<summary>Set mode for humidifier device.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetMode(ServiceTarget target, HumidifierSetModeParameters data)
        {
            _haContext.CallService("humidifier", "set_mode", target, data);
        }

        ///<summary>Set mode for humidifier device.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="mode">New mode eg: away</param>
        public void SetMode(ServiceTarget target, string @mode)
        {
            _haContext.CallService("humidifier", "set_mode", target, new HumidifierSetModeParameters { Mode = @mode });
        }

        ///<summary>Toggles a humidifier device.</summary>
        ///<param name="target">The target for this service call</param>
        public void Toggle(ServiceTarget target)
        {
            _haContext.CallService("humidifier", "toggle", target);
        }

        ///<summary>Turn humidifier device off.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOff(ServiceTarget target)
        {
            _haContext.CallService("humidifier", "turn_off", target);
        }

        ///<summary>Turn humidifier device on.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOn(ServiceTarget target)
        {
            _haContext.CallService("humidifier", "turn_on", target);
        }
    }

    public record HumidifierSetHumidityParameters
    {
        ///<summary>New target humidity for humidifier device.</summary>
        [JsonPropertyName("humidity")]
        public long? Humidity { get; init; }
    }

    public record HumidifierSetModeParameters
    {
        ///<summary>New mode eg: away</summary>
        [JsonPropertyName("mode")]
        public string? Mode { get; init; }
    }

    public class InputBooleanServices
    {
        private readonly IHaContext _haContext;
        public InputBooleanServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Reload the input_boolean configuration</summary>
        public void Reload()
        {
            _haContext.CallService("input_boolean", "reload", null);
        }

        ///<summary>Toggle an input boolean</summary>
        ///<param name="target">The target for this service call</param>
        public void Toggle(ServiceTarget target)
        {
            _haContext.CallService("input_boolean", "toggle", target);
        }

        ///<summary>Turn off an input boolean</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOff(ServiceTarget target)
        {
            _haContext.CallService("input_boolean", "turn_off", target);
        }

        ///<summary>Turn on an input boolean</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOn(ServiceTarget target)
        {
            _haContext.CallService("input_boolean", "turn_on", target);
        }
    }

    public class InputButtonServices
    {
        private readonly IHaContext _haContext;
        public InputButtonServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Press the input button entity.</summary>
        ///<param name="target">The target for this service call</param>
        public void Press(ServiceTarget target)
        {
            _haContext.CallService("input_button", "press", target);
        }

        public void Reload()
        {
            _haContext.CallService("input_button", "reload", null);
        }
    }

    public class InputDatetimeServices
    {
        private readonly IHaContext _haContext;
        public InputDatetimeServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Reload the input_datetime configuration.</summary>
        public void Reload()
        {
            _haContext.CallService("input_datetime", "reload", null);
        }

        ///<summary>This can be used to dynamically set the date and/or time.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetDatetime(ServiceTarget target, InputDatetimeSetDatetimeParameters data)
        {
            _haContext.CallService("input_datetime", "set_datetime", target, data);
        }

        ///<summary>This can be used to dynamically set the date and/or time.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
        ///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
        ///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
        ///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
        public void SetDatetime(ServiceTarget target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
        {
            _haContext.CallService("input_datetime", "set_datetime", target, new InputDatetimeSetDatetimeParameters { Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp });
        }
    }

    public record InputDatetimeSetDatetimeParameters
    {
        ///<summary>The target date the entity should be set to. eg: "2019-04-20"</summary>
        [JsonPropertyName("date")]
        public string? Date { get; init; }

        ///<summary>The target time the entity should be set to. eg: "05:04:20"</summary>
        [JsonPropertyName("time")]
        public DateTime? Time { get; init; }

        ///<summary>The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</summary>
        [JsonPropertyName("datetime")]
        public string? Datetime { get; init; }

        ///<summary>The target date & time the entity should be set to as expressed by a UNIX timestamp.</summary>
        [JsonPropertyName("timestamp")]
        public long? Timestamp { get; init; }
    }

    public class InputNumberServices
    {
        private readonly IHaContext _haContext;
        public InputNumberServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Decrement the value of an input number entity by its stepping.</summary>
        ///<param name="target">The target for this service call</param>
        public void Decrement(ServiceTarget target)
        {
            _haContext.CallService("input_number", "decrement", target);
        }

        ///<summary>Increment the value of an input number entity by its stepping.</summary>
        ///<param name="target">The target for this service call</param>
        public void Increment(ServiceTarget target)
        {
            _haContext.CallService("input_number", "increment", target);
        }

        ///<summary>Reload the input_number configuration.</summary>
        public void Reload()
        {
            _haContext.CallService("input_number", "reload", null);
        }

        ///<summary>Set the value of an input number entity.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetValue(ServiceTarget target, InputNumberSetValueParameters data)
        {
            _haContext.CallService("input_number", "set_value", target, data);
        }

        ///<summary>Set the value of an input number entity.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="value">The target value the entity should be set to.</param>
        public void SetValue(ServiceTarget target, double @value)
        {
            _haContext.CallService("input_number", "set_value", target, new InputNumberSetValueParameters { Value = @value });
        }
    }

    public record InputNumberSetValueParameters
    {
        ///<summary>The target value the entity should be set to.</summary>
        [JsonPropertyName("value")]
        public double? Value { get; init; }
    }

    public class InputSelectServices
    {
        private readonly IHaContext _haContext;
        public InputSelectServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Reload the input_select configuration.</summary>
        public void Reload()
        {
            _haContext.CallService("input_select", "reload", null);
        }

        ///<summary>Select the first option of an input select entity.</summary>
        ///<param name="target">The target for this service call</param>
        public void SelectFirst(ServiceTarget target)
        {
            _haContext.CallService("input_select", "select_first", target);
        }

        ///<summary>Select the last option of an input select entity.</summary>
        ///<param name="target">The target for this service call</param>
        public void SelectLast(ServiceTarget target)
        {
            _haContext.CallService("input_select", "select_last", target);
        }

        ///<summary>Select the next options of an input select entity.</summary>
        ///<param name="target">The target for this service call</param>
        public void SelectNext(ServiceTarget target, InputSelectSelectNextParameters data)
        {
            _haContext.CallService("input_select", "select_next", target, data);
        }

        ///<summary>Select the next options of an input select entity.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="cycle">If the option should cycle from the last to the first.</param>
        public void SelectNext(ServiceTarget target, bool? @cycle = null)
        {
            _haContext.CallService("input_select", "select_next", target, new InputSelectSelectNextParameters { Cycle = @cycle });
        }

        ///<summary>Select an option of an input select entity.</summary>
        ///<param name="target">The target for this service call</param>
        public void SelectOption(ServiceTarget target, InputSelectSelectOptionParameters data)
        {
            _haContext.CallService("input_select", "select_option", target, data);
        }

        ///<summary>Select an option of an input select entity.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="option">Option to be selected. eg: "Item A"</param>
        public void SelectOption(ServiceTarget target, string @option)
        {
            _haContext.CallService("input_select", "select_option", target, new InputSelectSelectOptionParameters { Option = @option });
        }

        ///<summary>Select the previous options of an input select entity.</summary>
        ///<param name="target">The target for this service call</param>
        public void SelectPrevious(ServiceTarget target, InputSelectSelectPreviousParameters data)
        {
            _haContext.CallService("input_select", "select_previous", target, data);
        }

        ///<summary>Select the previous options of an input select entity.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="cycle">If the option should cycle from the first to the last.</param>
        public void SelectPrevious(ServiceTarget target, bool? @cycle = null)
        {
            _haContext.CallService("input_select", "select_previous", target, new InputSelectSelectPreviousParameters { Cycle = @cycle });
        }

        ///<summary>Set the options of an input select entity.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetOptions(ServiceTarget target, InputSelectSetOptionsParameters data)
        {
            _haContext.CallService("input_select", "set_options", target, data);
        }

        ///<summary>Set the options of an input select entity.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
        public void SetOptions(ServiceTarget target, object @options)
        {
            _haContext.CallService("input_select", "set_options", target, new InputSelectSetOptionsParameters { Options = @options });
        }
    }

    public record InputSelectSelectNextParameters
    {
        ///<summary>If the option should cycle from the last to the first.</summary>
        [JsonPropertyName("cycle")]
        public bool? Cycle { get; init; }
    }

    public record InputSelectSelectOptionParameters
    {
        ///<summary>Option to be selected. eg: "Item A"</summary>
        [JsonPropertyName("option")]
        public string? Option { get; init; }
    }

    public record InputSelectSelectPreviousParameters
    {
        ///<summary>If the option should cycle from the first to the last.</summary>
        [JsonPropertyName("cycle")]
        public bool? Cycle { get; init; }
    }

    public record InputSelectSetOptionsParameters
    {
        ///<summary>Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</summary>
        [JsonPropertyName("options")]
        public object? Options { get; init; }
    }

    public class InputTextServices
    {
        private readonly IHaContext _haContext;
        public InputTextServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Reload the input_text configuration.</summary>
        public void Reload()
        {
            _haContext.CallService("input_text", "reload", null);
        }

        ///<summary>Set the value of an input text entity.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetValue(ServiceTarget target, InputTextSetValueParameters data)
        {
            _haContext.CallService("input_text", "set_value", target, data);
        }

        ///<summary>Set the value of an input text entity.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="value">The target value the entity should be set to. eg: This is an example text</param>
        public void SetValue(ServiceTarget target, string @value)
        {
            _haContext.CallService("input_text", "set_value", target, new InputTextSetValueParameters { Value = @value });
        }
    }

    public record InputTextSetValueParameters
    {
        ///<summary>The target value the entity should be set to. eg: This is an example text</summary>
        [JsonPropertyName("value")]
        public string? Value { get; init; }
    }

    public class LightServices
    {
        private readonly IHaContext _haContext;
        public LightServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
        ///<param name="target">The target for this service call</param>
        public void Toggle(ServiceTarget target, LightToggleParameters data)
        {
            _haContext.CallService("light", "toggle", target, data);
        }

        ///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="transition">Duration it takes to get to next state.</param>
        ///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
        ///<param name="colorName">A human readable color name.</param>
        ///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
        ///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
        ///<param name="colorTemp">Color temperature for the light in mireds.</param>
        ///<param name="kelvin">Color temperature for the light in Kelvin.</param>
        ///<param name="whiteValue">Number indicating level of white.</param>
        ///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
        ///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
        ///<param name="profile">Name of a light profile to use. eg: relax</param>
        ///<param name="flash">If the light should flash.</param>
        ///<param name="effect">Light effect.</param>
        public void Toggle(ServiceTarget target, long? @transition = null, object? @rgbColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, object? @flash = null, string? @effect = null)
        {
            _haContext.CallService("light", "toggle", target, new LightToggleParameters { Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect });
        }

        ///<summary>Turns off one or more lights.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOff(ServiceTarget target, LightTurnOffParameters data)
        {
            _haContext.CallService("light", "turn_off", target, data);
        }

        ///<summary>Turns off one or more lights.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="transition">Duration it takes to get to next state.</param>
        ///<param name="flash">If the light should flash.</param>
        public void TurnOff(ServiceTarget target, long? @transition = null, object? @flash = null)
        {
            _haContext.CallService("light", "turn_off", target, new LightTurnOffParameters { Transition = @transition, Flash = @flash });
        }

        ///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOn(ServiceTarget target, LightTurnOnParameters data)
        {
            _haContext.CallService("light", "turn_on", target, data);
        }

        ///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="transition">Duration it takes to get to next state.</param>
        ///<param name="rgbColor">The color for the light (based on RGB - red, green, blue).</param>
        ///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
        ///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
        ///<param name="colorName">A human readable color name.</param>
        ///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
        ///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
        ///<param name="colorTemp">Color temperature for the light in mireds.</param>
        ///<param name="kelvin">Color temperature for the light in Kelvin.</param>
        ///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
        ///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
        ///<param name="brightnessStep">Change brightness by an amount.</param>
        ///<param name="brightnessStepPct">Change brightness by a percentage.</param>
        ///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
        ///<param name="profile">Name of a light profile to use. eg: relax</param>
        ///<param name="flash">If the light should flash.</param>
        ///<param name="effect">Light effect.</param>
        public void TurnOn(ServiceTarget target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, object? @flash = null, string? @effect = null)
        {
            _haContext.CallService("light", "turn_on", target, new LightTurnOnParameters { Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect });
        }
    }

    public record LightToggleParameters
    {
        ///<summary>Duration it takes to get to next state.</summary>
        [JsonPropertyName("transition")]
        public long? Transition { get; init; }

        ///<summary>Color for the light in RGB-format. eg: [255, 100, 100]</summary>
        [JsonPropertyName("rgb_color")]
        public object? RgbColor { get; init; }

        ///<summary>A human readable color name.</summary>
        [JsonPropertyName("color_name")]
        public object? ColorName { get; init; }

        ///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
        [JsonPropertyName("hs_color")]
        public object? HsColor { get; init; }

        ///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
        [JsonPropertyName("xy_color")]
        public object? XyColor { get; init; }

        ///<summary>Color temperature for the light in mireds.</summary>
        [JsonPropertyName("color_temp")]
        public object? ColorTemp { get; init; }

        ///<summary>Color temperature for the light in Kelvin.</summary>
        [JsonPropertyName("kelvin")]
        public long? Kelvin { get; init; }

        ///<summary>Number indicating level of white.</summary>
        [JsonPropertyName("white_value")]
        public long? WhiteValue { get; init; }

        ///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
        [JsonPropertyName("brightness")]
        public long? Brightness { get; init; }

        ///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
        [JsonPropertyName("brightness_pct")]
        public long? BrightnessPct { get; init; }

        ///<summary>Name of a light profile to use. eg: relax</summary>
        [JsonPropertyName("profile")]
        public string? Profile { get; init; }

        ///<summary>If the light should flash.</summary>
        [JsonPropertyName("flash")]
        public object? Flash { get; init; }

        ///<summary>Light effect.</summary>
        [JsonPropertyName("effect")]
        public string? Effect { get; init; }
    }

    public record LightTurnOffParameters
    {
        ///<summary>Duration it takes to get to next state.</summary>
        [JsonPropertyName("transition")]
        public long? Transition { get; init; }

        ///<summary>If the light should flash.</summary>
        [JsonPropertyName("flash")]
        public object? Flash { get; init; }
    }

    public record LightTurnOnParameters
    {
        ///<summary>Duration it takes to get to next state.</summary>
        [JsonPropertyName("transition")]
        public long? Transition { get; init; }

        ///<summary>The color for the light (based on RGB - red, green, blue).</summary>
        [JsonPropertyName("rgb_color")]
        public object? RgbColor { get; init; }

        ///<summary>A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</summary>
        [JsonPropertyName("rgbw_color")]
        public object? RgbwColor { get; init; }

        ///<summary>A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</summary>
        [JsonPropertyName("rgbww_color")]
        public object? RgbwwColor { get; init; }

        ///<summary>A human readable color name.</summary>
        [JsonPropertyName("color_name")]
        public object? ColorName { get; init; }

        ///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
        [JsonPropertyName("hs_color")]
        public object? HsColor { get; init; }

        ///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
        [JsonPropertyName("xy_color")]
        public object? XyColor { get; init; }

        ///<summary>Color temperature for the light in mireds.</summary>
        [JsonPropertyName("color_temp")]
        public object? ColorTemp { get; init; }

        ///<summary>Color temperature for the light in Kelvin.</summary>
        [JsonPropertyName("kelvin")]
        public long? Kelvin { get; init; }

        ///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
        [JsonPropertyName("brightness")]
        public long? Brightness { get; init; }

        ///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
        [JsonPropertyName("brightness_pct")]
        public long? BrightnessPct { get; init; }

        ///<summary>Change brightness by an amount.</summary>
        [JsonPropertyName("brightness_step")]
        public long? BrightnessStep { get; init; }

        ///<summary>Change brightness by a percentage.</summary>
        [JsonPropertyName("brightness_step_pct")]
        public long? BrightnessStepPct { get; init; }

        ///<summary>Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
        [JsonPropertyName("white")]
        public long? White { get; init; }

        ///<summary>Name of a light profile to use. eg: relax</summary>
        [JsonPropertyName("profile")]
        public string? Profile { get; init; }

        ///<summary>If the light should flash.</summary>
        [JsonPropertyName("flash")]
        public object? Flash { get; init; }

        ///<summary>Light effect.</summary>
        [JsonPropertyName("effect")]
        public string? Effect { get; init; }
    }

    public class LockServices
    {
        private readonly IHaContext _haContext;
        public LockServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Lock all or specified locks.</summary>
        ///<param name="target">The target for this service call</param>
        public void Lock(ServiceTarget target, LockLockParameters data)
        {
            _haContext.CallService("lock", "lock", target, data);
        }

        ///<summary>Lock all or specified locks.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="code">An optional code to lock the lock with. eg: 1234</param>
        public void Lock(ServiceTarget target, string? @code = null)
        {
            _haContext.CallService("lock", "lock", target, new LockLockParameters { Code = @code });
        }

        ///<summary>Open all or specified locks.</summary>
        ///<param name="target">The target for this service call</param>
        public void Open(ServiceTarget target, LockOpenParameters data)
        {
            _haContext.CallService("lock", "open", target, data);
        }

        ///<summary>Open all or specified locks.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="code">An optional code to open the lock with. eg: 1234</param>
        public void Open(ServiceTarget target, string? @code = null)
        {
            _haContext.CallService("lock", "open", target, new LockOpenParameters { Code = @code });
        }

        ///<summary>Unlock all or specified locks.</summary>
        ///<param name="target">The target for this service call</param>
        public void Unlock(ServiceTarget target, LockUnlockParameters data)
        {
            _haContext.CallService("lock", "unlock", target, data);
        }

        ///<summary>Unlock all or specified locks.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="code">An optional code to unlock the lock with. eg: 1234</param>
        public void Unlock(ServiceTarget target, string? @code = null)
        {
            _haContext.CallService("lock", "unlock", target, new LockUnlockParameters { Code = @code });
        }
    }

    public record LockLockParameters
    {
        ///<summary>An optional code to lock the lock with. eg: 1234</summary>
        [JsonPropertyName("code")]
        public string? Code { get; init; }
    }

    public record LockOpenParameters
    {
        ///<summary>An optional code to open the lock with. eg: 1234</summary>
        [JsonPropertyName("code")]
        public string? Code { get; init; }
    }

    public record LockUnlockParameters
    {
        ///<summary>An optional code to unlock the lock with. eg: 1234</summary>
        [JsonPropertyName("code")]
        public string? Code { get; init; }
    }

    public class LogbookServices
    {
        private readonly IHaContext _haContext;
        public LogbookServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Create a custom entry in your logbook.</summary>
        public void Log(LogbookLogParameters data)
        {
            _haContext.CallService("logbook", "log", null, data);
        }

        ///<summary>Create a custom entry in your logbook.</summary>
        ///<param name="name">Custom name for an entity, can be referenced with entity_id. eg: Kitchen</param>
        ///<param name="message">Message of the custom logbook entry. eg: is being used</param>
        ///<param name="entityId">Entity to reference in custom logbook entry.</param>
        ///<param name="domain">Icon of domain to display in custom logbook entry. eg: light</param>
        public void Log(string @name, string @message, string? @entityId = null, string? @domain = null)
        {
            _haContext.CallService("logbook", "log", null, new LogbookLogParameters { Name = @name, Message = @message, EntityId = @entityId, Domain = @domain });
        }
    }

    public record LogbookLogParameters
    {
        ///<summary>Custom name for an entity, can be referenced with entity_id. eg: Kitchen</summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        ///<summary>Message of the custom logbook entry. eg: is being used</summary>
        [JsonPropertyName("message")]
        public string? Message { get; init; }

        ///<summary>Entity to reference in custom logbook entry.</summary>
        [JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }

        ///<summary>Icon of domain to display in custom logbook entry. eg: light</summary>
        [JsonPropertyName("domain")]
        public string? Domain { get; init; }
    }

    public class LyricServices
    {
        private readonly IHaContext _haContext;
        public LyricServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Sets the time to hold until</summary>
        ///<param name="target">The target for this service call</param>
        public void SetHoldTime(ServiceTarget target, LyricSetHoldTimeParameters data)
        {
            _haContext.CallService("lyric", "set_hold_time", target, data);
        }

        ///<summary>Sets the time to hold until</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="timePeriod">Time to hold until eg: 01:00:00</param>
        public void SetHoldTime(ServiceTarget target, string @timePeriod)
        {
            _haContext.CallService("lyric", "set_hold_time", target, new LyricSetHoldTimeParameters { TimePeriod = @timePeriod });
        }
    }

    public record LyricSetHoldTimeParameters
    {
        ///<summary>Time to hold until eg: 01:00:00</summary>
        [JsonPropertyName("time_period")]
        public string? TimePeriod { get; init; }
    }

    public class MqttServices
    {
        private readonly IHaContext _haContext;
        public MqttServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Dump messages on a topic selector to the 'mqtt_dump.txt' file in your configuration folder.</summary>
        public void Dump(MqttDumpParameters data)
        {
            _haContext.CallService("mqtt", "dump", null, data);
        }

        ///<summary>Dump messages on a topic selector to the 'mqtt_dump.txt' file in your configuration folder.</summary>
        ///<param name="topic">topic to listen to eg: OpenZWave/#</param>
        ///<param name="duration">how long we should listen for messages in seconds</param>
        public void Dump(string? @topic = null, long? @duration = null)
        {
            _haContext.CallService("mqtt", "dump", null, new MqttDumpParameters { Topic = @topic, Duration = @duration });
        }

        ///<summary>Publish a message to an MQTT topic.</summary>
        public void Publish(MqttPublishParameters data)
        {
            _haContext.CallService("mqtt", "publish", null, data);
        }

        ///<summary>Publish a message to an MQTT topic.</summary>
        ///<param name="topic">Topic to publish payload. eg: /homeassistant/hello</param>
        ///<param name="payload">Payload to publish. eg: This is great</param>
        ///<param name="payloadTemplate">Template to render as payload value. Ignored if payload given. eg: {{ states('sensor.temperature') }}</param>
        ///<param name="qos">Quality of Service to use.</param>
        ///<param name="retain">If message should have the retain flag set.</param>
        public void Publish(string @topic, string? @payload = null, object? @payloadTemplate = null, object? @qos = null, bool? @retain = null)
        {
            _haContext.CallService("mqtt", "publish", null, new MqttPublishParameters { Topic = @topic, Payload = @payload, PayloadTemplate = @payloadTemplate, Qos = @qos, Retain = @retain });
        }
    }

    public record MqttDumpParameters
    {
        ///<summary>topic to listen to eg: OpenZWave/#</summary>
        [JsonPropertyName("topic")]
        public string? Topic { get; init; }

        ///<summary>how long we should listen for messages in seconds</summary>
        [JsonPropertyName("duration")]
        public long? Duration { get; init; }
    }

    public record MqttPublishParameters
    {
        ///<summary>Topic to publish payload. eg: /homeassistant/hello</summary>
        [JsonPropertyName("topic")]
        public string? Topic { get; init; }

        ///<summary>Payload to publish. eg: This is great</summary>
        [JsonPropertyName("payload")]
        public string? Payload { get; init; }

        ///<summary>Template to render as payload value. Ignored if payload given. eg: {{ states('sensor.temperature') }}</summary>
        [JsonPropertyName("payload_template")]
        public object? PayloadTemplate { get; init; }

        ///<summary>Quality of Service to use.</summary>
        [JsonPropertyName("qos")]
        public object? Qos { get; init; }

        ///<summary>If message should have the retain flag set.</summary>
        [JsonPropertyName("retain")]
        public bool? Retain { get; init; }
    }

    public class NetdaemonServices
    {
        private readonly IHaContext _haContext;
        public NetdaemonServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Create an entity</summary>
        public void EntityCreate(NetdaemonEntityCreateParameters data)
        {
            _haContext.CallService("netdaemon", "entity_create", null, data);
        }

        ///<summary>Create an entity</summary>
        ///<param name="entityId">The entity ID of the entity eg: sensor.awesome</param>
        ///<param name="state">The state of the entity eg: Lorem ipsum</param>
        ///<param name="icon">The icon for the entity eg: mdi:rocket-launch-outline</param>
        ///<param name="unit">The unit of measurement for the entity</param>
        ///<param name="attributes">The attributes of the entity</param>
        public void EntityCreate(object? @entityId = null, object? @state = null, object? @icon = null, object? @unit = null, object? @attributes = null)
        {
            _haContext.CallService("netdaemon", "entity_create", null, new NetdaemonEntityCreateParameters { EntityId = @entityId, State = @state, Icon = @icon, Unit = @unit, Attributes = @attributes });
        }

        ///<summary>Remove an entity</summary>
        public void EntityRemove(NetdaemonEntityRemoveParameters data)
        {
            _haContext.CallService("netdaemon", "entity_remove", null, data);
        }

        ///<summary>Remove an entity</summary>
        ///<param name="entityId">The entity ID of the entity eg: sensor.awesome</param>
        public void EntityRemove(object? @entityId = null)
        {
            _haContext.CallService("netdaemon", "entity_remove", null, new NetdaemonEntityRemoveParameters { EntityId = @entityId });
        }

        ///<summary>Update an entity</summary>
        public void EntityUpdate(NetdaemonEntityUpdateParameters data)
        {
            _haContext.CallService("netdaemon", "entity_update", null, data);
        }

        ///<summary>Update an entity</summary>
        ///<param name="entityId">The entity ID of the entity eg: sensor.awesome</param>
        ///<param name="state">The state of the entity eg: Lorem ipsum</param>
        ///<param name="icon">The icon for the entity eg: mdi:rocket-launch-outline</param>
        ///<param name="unit">The unit of measurement for the entity</param>
        ///<param name="attributes">The attributes of the entity</param>
        public void EntityUpdate(object? @entityId = null, object? @state = null, object? @icon = null, object? @unit = null, object? @attributes = null)
        {
            _haContext.CallService("netdaemon", "entity_update", null, new NetdaemonEntityUpdateParameters { EntityId = @entityId, State = @state, Icon = @icon, Unit = @unit, Attributes = @attributes });
        }

        public void NutrientsAddnutrient()
        {
            _haContext.CallService("netdaemon", "nutrients_addnutrient", null);
        }

        public void NutrientsAddonedosetocurrentzone()
        {
            _haContext.CallService("netdaemon", "nutrients_addonedosetocurrentzone", null);
        }

        public void RefillRefillcurrentzone()
        {
            _haContext.CallService("netdaemon", "refill_refillcurrentzone", null);
        }

        public void RefillRefillwatertank()
        {
            _haContext.CallService("netdaemon", "refill_refillwatertank", null);
        }

        ///<summary>Register a new service for netdaemon, used by the daemon and not to be used by users</summary>
        public void RegisterService(NetdaemonRegisterServiceParameters data)
        {
            _haContext.CallService("netdaemon", "register_service", null, data);
        }

        ///<summary>Register a new service for netdaemon, used by the daemon and not to be used by users</summary>
        ///<param name="class">The class that implements the service call</param>
        ///<param name="method">The method to call</param>
        public void RegisterService(object? @class = null, object? @method = null)
        {
            _haContext.CallService("netdaemon", "register_service", null, new NetdaemonRegisterServiceParameters { Class = @class, Method = @method });
        }

        public void ReloadApps()
        {
            _haContext.CallService("netdaemon", "reload_apps", null);
        }
    }

    public record NetdaemonEntityCreateParameters
    {
        ///<summary>The entity ID of the entity eg: sensor.awesome</summary>
        [JsonPropertyName("entity_id")]
        public object? EntityId { get; init; }

        ///<summary>The state of the entity eg: Lorem ipsum</summary>
        [JsonPropertyName("state")]
        public object? State { get; init; }

        ///<summary>The icon for the entity eg: mdi:rocket-launch-outline</summary>
        [JsonPropertyName("icon")]
        public object? Icon { get; init; }

        ///<summary>The unit of measurement for the entity</summary>
        [JsonPropertyName("unit")]
        public object? Unit { get; init; }

        ///<summary>The attributes of the entity</summary>
        [JsonPropertyName("attributes")]
        public object? Attributes { get; init; }
    }

    public record NetdaemonEntityRemoveParameters
    {
        ///<summary>The entity ID of the entity eg: sensor.awesome</summary>
        [JsonPropertyName("entity_id")]
        public object? EntityId { get; init; }
    }

    public record NetdaemonEntityUpdateParameters
    {
        ///<summary>The entity ID of the entity eg: sensor.awesome</summary>
        [JsonPropertyName("entity_id")]
        public object? EntityId { get; init; }

        ///<summary>The state of the entity eg: Lorem ipsum</summary>
        [JsonPropertyName("state")]
        public object? State { get; init; }

        ///<summary>The icon for the entity eg: mdi:rocket-launch-outline</summary>
        [JsonPropertyName("icon")]
        public object? Icon { get; init; }

        ///<summary>The unit of measurement for the entity</summary>
        [JsonPropertyName("unit")]
        public object? Unit { get; init; }

        ///<summary>The attributes of the entity</summary>
        [JsonPropertyName("attributes")]
        public object? Attributes { get; init; }
    }

    public record NetdaemonRegisterServiceParameters
    {
        ///<summary>The class that implements the service call</summary>
        [JsonPropertyName("class")]
        public object? Class { get; init; }

        ///<summary>The method to call</summary>
        [JsonPropertyName("method")]
        public object? Method { get; init; }
    }

    public class NotifyServices
    {
        private readonly IHaContext _haContext;
        public NotifyServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Sends a notification message using the mobile_app_samsungflex integration.</summary>
        public void MobileAppSamsungflex(NotifyMobileAppSamsungflexParameters data)
        {
            _haContext.CallService("notify", "mobile_app_samsungflex", null, data);
        }

        ///<summary>Sends a notification message using the mobile_app_samsungflex integration.</summary>
        ///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
        ///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
        ///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
        ///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
        public void MobileAppSamsungflex(string @message, string? @title = null, object? @target = null, object? @data = null)
        {
            _haContext.CallService("notify", "mobile_app_samsungflex", null, new NotifyMobileAppSamsungflexParameters { Message = @message, Title = @title, Target = @target, Data = @data });
        }

        ///<summary>Sends a notification message using the notify service.</summary>
        public void Notify(NotifyNotifyParameters data)
        {
            _haContext.CallService("notify", "notify", null, data);
        }

        ///<summary>Sends a notification message using the notify service.</summary>
        ///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
        ///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
        ///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
        ///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
        public void Notify(string @message, string? @title = null, object? @target = null, object? @data = null)
        {
            _haContext.CallService("notify", "notify", null, new NotifyNotifyParameters { Message = @message, Title = @title, Target = @target, Data = @data });
        }

        ///<summary>Sends a notification that is visible in the front-end.</summary>
        public void PersistentNotification(NotifyPersistentNotificationParameters data)
        {
            _haContext.CallService("notify", "persistent_notification", null, data);
        }

        ///<summary>Sends a notification that is visible in the front-end.</summary>
        ///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
        ///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
        public void PersistentNotification(string @message, string? @title = null)
        {
            _haContext.CallService("notify", "persistent_notification", null, new NotifyPersistentNotificationParameters { Message = @message, Title = @title });
        }
    }

    public record NotifyMobileAppSamsungflexParameters
    {
        ///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
        [JsonPropertyName("message")]
        public string? Message { get; init; }

        ///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
        [JsonPropertyName("title")]
        public string? Title { get; init; }

        ///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
        [JsonPropertyName("target")]
        public object? Target { get; init; }

        ///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
        [JsonPropertyName("data")]
        public object? Data { get; init; }
    }

    public record NotifyNotifyParameters
    {
        ///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
        [JsonPropertyName("message")]
        public string? Message { get; init; }

        ///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
        [JsonPropertyName("title")]
        public string? Title { get; init; }

        ///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
        [JsonPropertyName("target")]
        public object? Target { get; init; }

        ///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
        [JsonPropertyName("data")]
        public object? Data { get; init; }
    }

    public record NotifyPersistentNotificationParameters
    {
        ///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
        [JsonPropertyName("message")]
        public string? Message { get; init; }

        ///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
        [JsonPropertyName("title")]
        public string? Title { get; init; }
    }

    public class NumberServices
    {
        private readonly IHaContext _haContext;
        public NumberServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Set the value of a Number entity.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetValue(ServiceTarget target, NumberSetValueParameters data)
        {
            _haContext.CallService("number", "set_value", target, data);
        }

        ///<summary>Set the value of a Number entity.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="value">The target value the entity should be set to. eg: 42</param>
        public void SetValue(ServiceTarget target, string? @value = null)
        {
            _haContext.CallService("number", "set_value", target, new NumberSetValueParameters { Value = @value });
        }
    }

    public record NumberSetValueParameters
    {
        ///<summary>The target value the entity should be set to. eg: 42</summary>
        [JsonPropertyName("value")]
        public string? Value { get; init; }
    }

    public class PersistentNotificationServices
    {
        private readonly IHaContext _haContext;
        public PersistentNotificationServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Show a notification in the frontend.</summary>
        public void Create(PersistentNotificationCreateParameters data)
        {
            _haContext.CallService("persistent_notification", "create", null, data);
        }

        ///<summary>Show a notification in the frontend.</summary>
        ///<param name="message">Message body of the notification. [Templates accepted] eg: Please check your configuration.yaml.</param>
        ///<param name="title">Optional title for your notification. [Templates accepted] eg: Test notification</param>
        ///<param name="notificationId">Target ID of the notification, will replace a notification with the same ID. eg: 1234</param>
        public void Create(string @message, string? @title = null, string? @notificationId = null)
        {
            _haContext.CallService("persistent_notification", "create", null, new PersistentNotificationCreateParameters { Message = @message, Title = @title, NotificationId = @notificationId });
        }

        ///<summary>Remove a notification from the frontend.</summary>
        public void Dismiss(PersistentNotificationDismissParameters data)
        {
            _haContext.CallService("persistent_notification", "dismiss", null, data);
        }

        ///<summary>Remove a notification from the frontend.</summary>
        ///<param name="notificationId">Target ID of the notification, which should be removed. eg: 1234</param>
        public void Dismiss(string @notificationId)
        {
            _haContext.CallService("persistent_notification", "dismiss", null, new PersistentNotificationDismissParameters { NotificationId = @notificationId });
        }

        ///<summary>Mark a notification read.</summary>
        public void MarkRead(PersistentNotificationMarkReadParameters data)
        {
            _haContext.CallService("persistent_notification", "mark_read", null, data);
        }

        ///<summary>Mark a notification read.</summary>
        ///<param name="notificationId">Target ID of the notification, which should be mark read. eg: 1234</param>
        public void MarkRead(string @notificationId)
        {
            _haContext.CallService("persistent_notification", "mark_read", null, new PersistentNotificationMarkReadParameters { NotificationId = @notificationId });
        }
    }

    public record PersistentNotificationCreateParameters
    {
        ///<summary>Message body of the notification. [Templates accepted] eg: Please check your configuration.yaml.</summary>
        [JsonPropertyName("message")]
        public string? Message { get; init; }

        ///<summary>Optional title for your notification. [Templates accepted] eg: Test notification</summary>
        [JsonPropertyName("title")]
        public string? Title { get; init; }

        ///<summary>Target ID of the notification, will replace a notification with the same ID. eg: 1234</summary>
        [JsonPropertyName("notification_id")]
        public string? NotificationId { get; init; }
    }

    public record PersistentNotificationDismissParameters
    {
        ///<summary>Target ID of the notification, which should be removed. eg: 1234</summary>
        [JsonPropertyName("notification_id")]
        public string? NotificationId { get; init; }
    }

    public record PersistentNotificationMarkReadParameters
    {
        ///<summary>Target ID of the notification, which should be mark read. eg: 1234</summary>
        [JsonPropertyName("notification_id")]
        public string? NotificationId { get; init; }
    }

    public class PersonServices
    {
        private readonly IHaContext _haContext;
        public PersonServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Reload the person configuration.</summary>
        public void Reload()
        {
            _haContext.CallService("person", "reload", null);
        }
    }

    public class RecorderServices
    {
        private readonly IHaContext _haContext;
        public RecorderServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Stop the recording of events and state changes</summary>
        public void Disable()
        {
            _haContext.CallService("recorder", "disable", null);
        }

        ///<summary>Start the recording of events and state changes</summary>
        public void Enable()
        {
            _haContext.CallService("recorder", "enable", null);
        }

        ///<summary>Start purge task - to clean up old data from your database.</summary>
        public void Purge(RecorderPurgeParameters data)
        {
            _haContext.CallService("recorder", "purge", null, data);
        }

        ///<summary>Start purge task - to clean up old data from your database.</summary>
        ///<param name="keepDays">Number of history days to keep in database after purge.</param>
        ///<param name="repack">Attempt to save disk space by rewriting the entire database file.</param>
        ///<param name="applyFilter">Apply entity_id and event_type filter in addition to time based purge.</param>
        public void Purge(long? @keepDays = null, bool? @repack = null, bool? @applyFilter = null)
        {
            _haContext.CallService("recorder", "purge", null, new RecorderPurgeParameters { KeepDays = @keepDays, Repack = @repack, ApplyFilter = @applyFilter });
        }

        ///<summary>Start purge task to remove specific entities from your database.</summary>
        ///<param name="target">The target for this service call</param>
        public void PurgeEntities(ServiceTarget target, RecorderPurgeEntitiesParameters data)
        {
            _haContext.CallService("recorder", "purge_entities", target, data);
        }

        ///<summary>Start purge task to remove specific entities from your database.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="domains">List the domains that need to be removed from the recorder database. eg: sun</param>
        ///<param name="entityGlobs">List the glob patterns to select entities for removal from the recorder database. eg: domain*.object_id*</param>
        public void PurgeEntities(ServiceTarget target, object? @domains = null, object? @entityGlobs = null)
        {
            _haContext.CallService("recorder", "purge_entities", target, new RecorderPurgeEntitiesParameters { Domains = @domains, EntityGlobs = @entityGlobs });
        }
    }

    public record RecorderPurgeParameters
    {
        ///<summary>Number of history days to keep in database after purge.</summary>
        [JsonPropertyName("keep_days")]
        public long? KeepDays { get; init; }

        ///<summary>Attempt to save disk space by rewriting the entire database file.</summary>
        [JsonPropertyName("repack")]
        public bool? Repack { get; init; }

        ///<summary>Apply entity_id and event_type filter in addition to time based purge.</summary>
        [JsonPropertyName("apply_filter")]
        public bool? ApplyFilter { get; init; }
    }

    public record RecorderPurgeEntitiesParameters
    {
        ///<summary>List the domains that need to be removed from the recorder database. eg: sun</summary>
        [JsonPropertyName("domains")]
        public object? Domains { get; init; }

        ///<summary>List the glob patterns to select entities for removal from the recorder database. eg: domain*.object_id*</summary>
        [JsonPropertyName("entity_globs")]
        public object? EntityGlobs { get; init; }
    }

    public class SceneServices
    {
        private readonly IHaContext _haContext;
        public SceneServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Activate a scene with configuration.</summary>
        public void Apply(SceneApplyParameters data)
        {
            _haContext.CallService("scene", "apply", null, data);
        }

        ///<summary>Activate a scene with configuration.</summary>
        ///<param name="entities">The entities and the state that they need to be. eg: {"light.kitchen":"on","light.ceiling":{"state":"on","brightness":80}}</param>
        ///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
        public void Apply(object @entities, long? @transition = null)
        {
            _haContext.CallService("scene", "apply", null, new SceneApplyParameters { Entities = @entities, Transition = @transition });
        }

        ///<summary>Creates a new scene.</summary>
        public void Create(SceneCreateParameters data)
        {
            _haContext.CallService("scene", "create", null, data);
        }

        ///<summary>Creates a new scene.</summary>
        ///<param name="sceneId">The entity_id of the new scene. eg: all_lights</param>
        ///<param name="entities">The entities to control with the scene. eg: {"light.tv_back_light":"on","light.ceiling":{"state":"on","brightness":200}}</param>
        ///<param name="snapshotEntities">The entities of which a snapshot is to be taken eg: ["light.ceiling","light.kitchen"]</param>
        public void Create(string @sceneId, object? @entities = null, object? @snapshotEntities = null)
        {
            _haContext.CallService("scene", "create", null, new SceneCreateParameters { SceneId = @sceneId, Entities = @entities, SnapshotEntities = @snapshotEntities });
        }

        ///<summary>Reload the scene configuration.</summary>
        public void Reload()
        {
            _haContext.CallService("scene", "reload", null);
        }

        ///<summary>Activate a scene.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOn(ServiceTarget target, SceneTurnOnParameters data)
        {
            _haContext.CallService("scene", "turn_on", target, data);
        }

        ///<summary>Activate a scene.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
        public void TurnOn(ServiceTarget target, long? @transition = null)
        {
            _haContext.CallService("scene", "turn_on", target, new SceneTurnOnParameters { Transition = @transition });
        }
    }

    public record SceneApplyParameters
    {
        ///<summary>The entities and the state that they need to be. eg: {"light.kitchen":"on","light.ceiling":{"state":"on","brightness":80}}</summary>
        [JsonPropertyName("entities")]
        public object? Entities { get; init; }

        ///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
        [JsonPropertyName("transition")]
        public long? Transition { get; init; }
    }

    public record SceneCreateParameters
    {
        ///<summary>The entity_id of the new scene. eg: all_lights</summary>
        [JsonPropertyName("scene_id")]
        public string? SceneId { get; init; }

        ///<summary>The entities to control with the scene. eg: {"light.tv_back_light":"on","light.ceiling":{"state":"on","brightness":200}}</summary>
        [JsonPropertyName("entities")]
        public object? Entities { get; init; }

        ///<summary>The entities of which a snapshot is to be taken eg: ["light.ceiling","light.kitchen"]</summary>
        [JsonPropertyName("snapshot_entities")]
        public object? SnapshotEntities { get; init; }
    }

    public record SceneTurnOnParameters
    {
        ///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
        [JsonPropertyName("transition")]
        public long? Transition { get; init; }
    }

    public class ScriptServices
    {
        private readonly IHaContext _haContext;
        public ScriptServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        public void AddDoseToCurrentZone()
        {
            _haContext.CallService("script", "add_dose_to_current_zone", null);
        }

        public void MovePump1()
        {
            _haContext.CallService("script", "move_pump_1", null);
        }

        public void MovePump2()
        {
            _haContext.CallService("script", "move_pump_2", null);
        }

        public void MovePump3()
        {
            _haContext.CallService("script", "move_pump_3", null);
        }

        public void RefillCurrentBucket()
        {
            _haContext.CallService("script", "refill_current_bucket", null);
        }

        public void RefillFreshWaterTank()
        {
            _haContext.CallService("script", "refill_fresh_water_tank", null);
        }

        public void RefillSwpCooler()
        {
            _haContext.CallService("script", "refill_swp_cooler", null);
        }

        ///<summary>Reload all the available scripts</summary>
        public void Reload()
        {
            _haContext.CallService("script", "reload", null);
        }

        ///<summary>Toggle script</summary>
        ///<param name="target">The target for this service call</param>
        public void Toggle(ServiceTarget target)
        {
            _haContext.CallService("script", "toggle", target);
        }

        ///<summary>Turn off script</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOff(ServiceTarget target)
        {
            _haContext.CallService("script", "turn_off", target);
        }

        ///<summary>Turn on script</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOn(ServiceTarget target)
        {
            _haContext.CallService("script", "turn_on", target);
        }
    }

    public class SelectServices
    {
        private readonly IHaContext _haContext;
        public SelectServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Select an option of an select entity.</summary>
        ///<param name="target">The target for this service call</param>
        public void SelectOption(ServiceTarget target, SelectSelectOptionParameters data)
        {
            _haContext.CallService("select", "select_option", target, data);
        }

        ///<summary>Select an option of an select entity.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="option">Option to be selected. eg: "Item A"</param>
        public void SelectOption(ServiceTarget target, string @option)
        {
            _haContext.CallService("select", "select_option", target, new SelectSelectOptionParameters { Option = @option });
        }
    }

    public record SelectSelectOptionParameters
    {
        ///<summary>Option to be selected. eg: "Item A"</summary>
        [JsonPropertyName("option")]
        public string? Option { get; init; }
    }

    public class ShoppingListServices
    {
        private readonly IHaContext _haContext;
        public ShoppingListServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Add an item to the shopping list.</summary>
        public void AddItem(ShoppingListAddItemParameters data)
        {
            _haContext.CallService("shopping_list", "add_item", null, data);
        }

        ///<summary>Add an item to the shopping list.</summary>
        ///<param name="name">The name of the item to add. eg: Beer</param>
        public void AddItem(string @name)
        {
            _haContext.CallService("shopping_list", "add_item", null, new ShoppingListAddItemParameters { Name = @name });
        }

        ///<summary>Clear completed items from the shopping list.</summary>
        public void ClearCompletedItems()
        {
            _haContext.CallService("shopping_list", "clear_completed_items", null);
        }

        ///<summary>Marks all items as completed in the shopping list. It does not remove the items.</summary>
        public void CompleteAll()
        {
            _haContext.CallService("shopping_list", "complete_all", null);
        }

        ///<summary>Mark an item as completed in the shopping list.</summary>
        public void CompleteItem(ShoppingListCompleteItemParameters data)
        {
            _haContext.CallService("shopping_list", "complete_item", null, data);
        }

        ///<summary>Mark an item as completed in the shopping list.</summary>
        ///<param name="name">The name of the item to mark as completed (without removing). eg: Beer</param>
        public void CompleteItem(string @name)
        {
            _haContext.CallService("shopping_list", "complete_item", null, new ShoppingListCompleteItemParameters { Name = @name });
        }

        ///<summary>Marks all items as incomplete in the shopping list.</summary>
        public void IncompleteAll()
        {
            _haContext.CallService("shopping_list", "incomplete_all", null);
        }

        ///<summary>Marks an item as incomplete in the shopping list.</summary>
        public void IncompleteItem(ShoppingListIncompleteItemParameters data)
        {
            _haContext.CallService("shopping_list", "incomplete_item", null, data);
        }

        ///<summary>Marks an item as incomplete in the shopping list.</summary>
        ///<param name="name">The name of the item to mark as incomplete. eg: Beer</param>
        public void IncompleteItem(string @name)
        {
            _haContext.CallService("shopping_list", "incomplete_item", null, new ShoppingListIncompleteItemParameters { Name = @name });
        }
    }

    public record ShoppingListAddItemParameters
    {
        ///<summary>The name of the item to add. eg: Beer</summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }
    }

    public record ShoppingListCompleteItemParameters
    {
        ///<summary>The name of the item to mark as completed (without removing). eg: Beer</summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }
    }

    public record ShoppingListIncompleteItemParameters
    {
        ///<summary>The name of the item to mark as incomplete. eg: Beer</summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }
    }

    public class SirenServices
    {
        private readonly IHaContext _haContext;
        public SirenServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Toggles a siren.</summary>
        ///<param name="target">The target for this service call</param>
        public void Toggle(ServiceTarget target)
        {
            _haContext.CallService("siren", "toggle", target);
        }

        ///<summary>Turn siren off.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOff(ServiceTarget target)
        {
            _haContext.CallService("siren", "turn_off", target);
        }

        ///<summary>Turn siren on.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOn(ServiceTarget target, SirenTurnOnParameters data)
        {
            _haContext.CallService("siren", "turn_on", target, data);
        }

        ///<summary>Turn siren on.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="tone">The tone to emit when turning the siren on. When `available_tones` property is a map, either the key or the value can be used. Must be supported by the integration. eg: fire</param>
        ///<param name="volumeLevel">The volume level of the noise to emit when turning the siren on. Must be supported by the integration. eg: 0.5</param>
        ///<param name="duration">The duration in seconds of the noise to emit when turning the siren on. Must be supported by the integration. eg: 15</param>
        public void TurnOn(ServiceTarget target, string? @tone = null, double? @volumeLevel = null, string? @duration = null)
        {
            _haContext.CallService("siren", "turn_on", target, new SirenTurnOnParameters { Tone = @tone, VolumeLevel = @volumeLevel, Duration = @duration });
        }
    }

    public record SirenTurnOnParameters
    {
        ///<summary>The tone to emit when turning the siren on. When `available_tones` property is a map, either the key or the value can be used. Must be supported by the integration. eg: fire</summary>
        [JsonPropertyName("tone")]
        public string? Tone { get; init; }

        ///<summary>The volume level of the noise to emit when turning the siren on. Must be supported by the integration. eg: 0.5</summary>
        [JsonPropertyName("volume_level")]
        public double? VolumeLevel { get; init; }

        ///<summary>The duration in seconds of the noise to emit when turning the siren on. Must be supported by the integration. eg: 15</summary>
        [JsonPropertyName("duration")]
        public string? Duration { get; init; }
    }

    public class SwitchServices
    {
        private readonly IHaContext _haContext;
        public SwitchServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Toggles a switch state</summary>
        ///<param name="target">The target for this service call</param>
        public void Toggle(ServiceTarget target)
        {
            _haContext.CallService("switch", "toggle", target);
        }

        ///<summary>Turn a switch off</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOff(ServiceTarget target)
        {
            _haContext.CallService("switch", "turn_off", target);
        }

        ///<summary>Turn a switch on</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOn(ServiceTarget target)
        {
            _haContext.CallService("switch", "turn_on", target);
        }
    }

    public class SystemLogServices
    {
        private readonly IHaContext _haContext;
        public SystemLogServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Clear all log entries.</summary>
        public void Clear()
        {
            _haContext.CallService("system_log", "clear", null);
        }

        ///<summary>Write log entry.</summary>
        public void Write(SystemLogWriteParameters data)
        {
            _haContext.CallService("system_log", "write", null, data);
        }

        ///<summary>Write log entry.</summary>
        ///<param name="message">Message to log. eg: Something went wrong</param>
        ///<param name="level">Log level.</param>
        ///<param name="logger">Logger name under which to log the message. Defaults to 'system_log.external'. eg: mycomponent.myplatform</param>
        public void Write(string @message, object? @level = null, string? @logger = null)
        {
            _haContext.CallService("system_log", "write", null, new SystemLogWriteParameters { Message = @message, Level = @level, Logger = @logger });
        }
    }

    public record SystemLogWriteParameters
    {
        ///<summary>Message to log. eg: Something went wrong</summary>
        [JsonPropertyName("message")]
        public string? Message { get; init; }

        ///<summary>Log level.</summary>
        [JsonPropertyName("level")]
        public object? Level { get; init; }

        ///<summary>Logger name under which to log the message. Defaults to 'system_log.external'. eg: mycomponent.myplatform</summary>
        [JsonPropertyName("logger")]
        public string? Logger { get; init; }
    }

    public class TemplateServices
    {
        private readonly IHaContext _haContext;
        public TemplateServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Reload all template entities.</summary>
        public void Reload()
        {
            _haContext.CallService("template", "reload", null);
        }
    }

    public class TimerServices
    {
        private readonly IHaContext _haContext;
        public TimerServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Cancel a timer.</summary>
        ///<param name="target">The target for this service call</param>
        public void Cancel(ServiceTarget target)
        {
            _haContext.CallService("timer", "cancel", target);
        }

        ///<summary>Finish a timer.</summary>
        ///<param name="target">The target for this service call</param>
        public void Finish(ServiceTarget target)
        {
            _haContext.CallService("timer", "finish", target);
        }

        ///<summary>Pause a timer.</summary>
        ///<param name="target">The target for this service call</param>
        public void Pause(ServiceTarget target)
        {
            _haContext.CallService("timer", "pause", target);
        }

        public void Reload()
        {
            _haContext.CallService("timer", "reload", null);
        }

        ///<summary>Start a timer</summary>
        ///<param name="target">The target for this service call</param>
        public void Start(ServiceTarget target, TimerStartParameters data)
        {
            _haContext.CallService("timer", "start", target, data);
        }

        ///<summary>Start a timer</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="duration">Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</param>
        public void Start(ServiceTarget target, string? @duration = null)
        {
            _haContext.CallService("timer", "start", target, new TimerStartParameters { Duration = @duration });
        }
    }

    public record TimerStartParameters
    {
        ///<summary>Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</summary>
        [JsonPropertyName("duration")]
        public string? Duration { get; init; }
    }

    public class TtsServices
    {
        private readonly IHaContext _haContext;
        public TtsServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Remove all text-to-speech cache files and RAM cache.</summary>
        public void ClearCache()
        {
            _haContext.CallService("tts", "clear_cache", null);
        }

        ///<summary>Say something using text-to-speech on a media player with cloud.</summary>
        public void CloudSay(TtsCloudSayParameters data)
        {
            _haContext.CallService("tts", "cloud_say", null, data);
        }

        ///<summary>Say something using text-to-speech on a media player with cloud.</summary>
        ///<param name="entityId">Name(s) of media player entities.</param>
        ///<param name="message">Text to speak on devices. eg: My name is hanna</param>
        ///<param name="cache">Control file cache of this message.</param>
        ///<param name="language">Language to use for speech generation. eg: ru</param>
        ///<param name="options">A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</param>
        public void CloudSay(string @entityId, string @message, bool? @cache = null, string? @language = null, object? @options = null)
        {
            _haContext.CallService("tts", "cloud_say", null, new TtsCloudSayParameters { EntityId = @entityId, Message = @message, Cache = @cache, Language = @language, Options = @options });
        }

        ///<summary>Say something using text-to-speech on a media player with google_translate.</summary>
        public void GoogleTranslateSay(TtsGoogleTranslateSayParameters data)
        {
            _haContext.CallService("tts", "google_translate_say", null, data);
        }

        ///<summary>Say something using text-to-speech on a media player with google_translate.</summary>
        ///<param name="entityId">Name(s) of media player entities.</param>
        ///<param name="message">Text to speak on devices. eg: My name is hanna</param>
        ///<param name="cache">Control file cache of this message.</param>
        ///<param name="language">Language to use for speech generation. eg: ru</param>
        ///<param name="options">A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</param>
        public void GoogleTranslateSay(string @entityId, string @message, bool? @cache = null, string? @language = null, object? @options = null)
        {
            _haContext.CallService("tts", "google_translate_say", null, new TtsGoogleTranslateSayParameters { EntityId = @entityId, Message = @message, Cache = @cache, Language = @language, Options = @options });
        }
    }

    public record TtsCloudSayParameters
    {
        ///<summary>Name(s) of media player entities.</summary>
        [JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }

        ///<summary>Text to speak on devices. eg: My name is hanna</summary>
        [JsonPropertyName("message")]
        public string? Message { get; init; }

        ///<summary>Control file cache of this message.</summary>
        [JsonPropertyName("cache")]
        public bool? Cache { get; init; }

        ///<summary>Language to use for speech generation. eg: ru</summary>
        [JsonPropertyName("language")]
        public string? Language { get; init; }

        ///<summary>A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</summary>
        [JsonPropertyName("options")]
        public object? Options { get; init; }
    }

    public record TtsGoogleTranslateSayParameters
    {
        ///<summary>Name(s) of media player entities.</summary>
        [JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }

        ///<summary>Text to speak on devices. eg: My name is hanna</summary>
        [JsonPropertyName("message")]
        public string? Message { get; init; }

        ///<summary>Control file cache of this message.</summary>
        [JsonPropertyName("cache")]
        public bool? Cache { get; init; }

        ///<summary>Language to use for speech generation. eg: ru</summary>
        [JsonPropertyName("language")]
        public string? Language { get; init; }

        ///<summary>A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</summary>
        [JsonPropertyName("options")]
        public object? Options { get; init; }
    }

    public class UpdateServices
    {
        private readonly IHaContext _haContext;
        public UpdateServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Removes the skipped version marker from an update.</summary>
        ///<param name="target">The target for this service call</param>
        public void ClearSkipped(ServiceTarget target)
        {
            _haContext.CallService("update", "clear_skipped", target);
        }

        ///<summary>Install an update for this device or service</summary>
        ///<param name="target">The target for this service call</param>
        public void Install(ServiceTarget target, UpdateInstallParameters data)
        {
            _haContext.CallService("update", "install", target, data);
        }

        ///<summary>Install an update for this device or service</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="version">Version to install, if omitted, the latest version will be installed. eg: 1.0.0</param>
        ///<param name="backup">Backup before installing the update, if supported by the integration.</param>
        public void Install(ServiceTarget target, string? @version = null, bool? @backup = null)
        {
            _haContext.CallService("update", "install", target, new UpdateInstallParameters { Version = @version, Backup = @backup });
        }

        ///<summary>Mark currently available update as skipped.</summary>
        ///<param name="target">The target for this service call</param>
        public void Skip(ServiceTarget target)
        {
            _haContext.CallService("update", "skip", target);
        }
    }

    public record UpdateInstallParameters
    {
        ///<summary>Version to install, if omitted, the latest version will be installed. eg: 1.0.0</summary>
        [JsonPropertyName("version")]
        public string? Version { get; init; }

        ///<summary>Backup before installing the update, if supported by the integration.</summary>
        [JsonPropertyName("backup")]
        public bool? Backup { get; init; }
    }

    public class UtilityMeterServices
    {
        private readonly IHaContext _haContext;
        public UtilityMeterServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Calibrates a utility meter sensor.</summary>
        ///<param name="target">The target for this service call</param>
        public void Calibrate(ServiceTarget target, UtilityMeterCalibrateParameters data)
        {
            _haContext.CallService("utility_meter", "calibrate", target, data);
        }

        ///<summary>Calibrates a utility meter sensor.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="value">Value to which set the meter eg: 100</param>
        public void Calibrate(ServiceTarget target, string @value)
        {
            _haContext.CallService("utility_meter", "calibrate", target, new UtilityMeterCalibrateParameters { Value = @value });
        }

        ///<summary>Resets all counters of a utility meter.</summary>
        ///<param name="target">The target for this service call</param>
        public void Reset(ServiceTarget target)
        {
            _haContext.CallService("utility_meter", "reset", target);
        }
    }

    public record UtilityMeterCalibrateParameters
    {
        ///<summary>Value to which set the meter eg: 100</summary>
        [JsonPropertyName("value")]
        public string? Value { get; init; }
    }

    public class VacuumServices
    {
        private readonly IHaContext _haContext;
        public VacuumServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
        ///<param name="target">The target for this service call</param>
        public void CleanSpot(ServiceTarget target)
        {
            _haContext.CallService("vacuum", "clean_spot", target);
        }

        ///<summary>Locate the vacuum cleaner robot.</summary>
        ///<param name="target">The target for this service call</param>
        public void Locate(ServiceTarget target)
        {
            _haContext.CallService("vacuum", "locate", target);
        }

        ///<summary>Pause the cleaning task.</summary>
        ///<param name="target">The target for this service call</param>
        public void Pause(ServiceTarget target)
        {
            _haContext.CallService("vacuum", "pause", target);
        }

        ///<summary>Tell the vacuum cleaner to return to its dock.</summary>
        ///<param name="target">The target for this service call</param>
        public void ReturnToBase(ServiceTarget target)
        {
            _haContext.CallService("vacuum", "return_to_base", target);
        }

        ///<summary>Send a raw command to the vacuum cleaner.</summary>
        ///<param name="target">The target for this service call</param>
        public void SendCommand(ServiceTarget target, VacuumSendCommandParameters data)
        {
            _haContext.CallService("vacuum", "send_command", target, data);
        }

        ///<summary>Send a raw command to the vacuum cleaner.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="command">Command to execute. eg: set_dnd_timer</param>
        ///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
        public void SendCommand(ServiceTarget target, string @command, object? @params = null)
        {
            _haContext.CallService("vacuum", "send_command", target, new VacuumSendCommandParameters { Command = @command, Params = @params });
        }

        ///<summary>Set the fan speed of the vacuum cleaner.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetFanSpeed(ServiceTarget target, VacuumSetFanSpeedParameters data)
        {
            _haContext.CallService("vacuum", "set_fan_speed", target, data);
        }

        ///<summary>Set the fan speed of the vacuum cleaner.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
        public void SetFanSpeed(ServiceTarget target, string @fanSpeed)
        {
            _haContext.CallService("vacuum", "set_fan_speed", target, new VacuumSetFanSpeedParameters { FanSpeed = @fanSpeed });
        }

        ///<summary>Start or resume the cleaning task.</summary>
        ///<param name="target">The target for this service call</param>
        public void Start(ServiceTarget target)
        {
            _haContext.CallService("vacuum", "start", target);
        }

        ///<summary>Start, pause, or resume the cleaning task.</summary>
        ///<param name="target">The target for this service call</param>
        public void StartPause(ServiceTarget target)
        {
            _haContext.CallService("vacuum", "start_pause", target);
        }

        ///<summary>Stop the current cleaning task.</summary>
        ///<param name="target">The target for this service call</param>
        public void Stop(ServiceTarget target)
        {
            _haContext.CallService("vacuum", "stop", target);
        }

        public void Toggle()
        {
            _haContext.CallService("vacuum", "toggle", null);
        }

        ///<summary>Stop the current cleaning task and return to home.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOff(ServiceTarget target)
        {
            _haContext.CallService("vacuum", "turn_off", target);
        }

        ///<summary>Start a new cleaning task.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOn(ServiceTarget target)
        {
            _haContext.CallService("vacuum", "turn_on", target);
        }
    }

    public record VacuumSendCommandParameters
    {
        ///<summary>Command to execute. eg: set_dnd_timer</summary>
        [JsonPropertyName("command")]
        public string? Command { get; init; }

        ///<summary>Parameters for the command. eg: { "key": "value" }</summary>
        [JsonPropertyName("params")]
        public object? Params { get; init; }
    }

    public record VacuumSetFanSpeedParameters
    {
        ///<summary>Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</summary>
        [JsonPropertyName("fan_speed")]
        public string? FanSpeed { get; init; }
    }

    public class ZoneServices
    {
        private readonly IHaContext _haContext;
        public ZoneServices(IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Reload the YAML-based zone configuration.</summary>
        public void Reload()
        {
            _haContext.CallService("zone", "reload", null);
        }
    }

    public static class AutomationEntityExtensionMethods
    {
        ///<summary>Toggle (enable / disable) an automation.</summary>
        public static void Toggle(this AutomationEntity target)
        {
            target.CallService("toggle");
        }

        ///<summary>Toggle (enable / disable) an automation.</summary>
        public static void Toggle(this IEnumerable<AutomationEntity> target)
        {
            target.CallService("toggle");
        }

        ///<summary>Trigger the actions of an automation.</summary>
        public static void Trigger(this AutomationEntity target, AutomationTriggerParameters data)
        {
            target.CallService("trigger", data);
        }

        ///<summary>Trigger the actions of an automation.</summary>
        public static void Trigger(this IEnumerable<AutomationEntity> target, AutomationTriggerParameters data)
        {
            target.CallService("trigger", data);
        }

        ///<summary>Trigger the actions of an automation.</summary>
        ///<param name="target">The AutomationEntity to call this service for</param>
        ///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
        public static void Trigger(this AutomationEntity target, bool? @skipCondition = null)
        {
            target.CallService("trigger", new AutomationTriggerParameters { SkipCondition = @skipCondition });
        }

        ///<summary>Trigger the actions of an automation.</summary>
        ///<param name="target">The IEnumerable<AutomationEntity> to call this service for</param>
        ///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
        public static void Trigger(this IEnumerable<AutomationEntity> target, bool? @skipCondition = null)
        {
            target.CallService("trigger", new AutomationTriggerParameters { SkipCondition = @skipCondition });
        }

        ///<summary>Disable an automation.</summary>
        public static void TurnOff(this AutomationEntity target, AutomationTurnOffParameters data)
        {
            target.CallService("turn_off", data);
        }

        ///<summary>Disable an automation.</summary>
        public static void TurnOff(this IEnumerable<AutomationEntity> target, AutomationTurnOffParameters data)
        {
            target.CallService("turn_off", data);
        }

        ///<summary>Disable an automation.</summary>
        ///<param name="target">The AutomationEntity to call this service for</param>
        ///<param name="stopActions">Stop currently running actions.</param>
        public static void TurnOff(this AutomationEntity target, bool? @stopActions = null)
        {
            target.CallService("turn_off", new AutomationTurnOffParameters { StopActions = @stopActions });
        }

        ///<summary>Disable an automation.</summary>
        ///<param name="target">The IEnumerable<AutomationEntity> to call this service for</param>
        ///<param name="stopActions">Stop currently running actions.</param>
        public static void TurnOff(this IEnumerable<AutomationEntity> target, bool? @stopActions = null)
        {
            target.CallService("turn_off", new AutomationTurnOffParameters { StopActions = @stopActions });
        }

        ///<summary>Enable an automation.</summary>
        public static void TurnOn(this AutomationEntity target)
        {
            target.CallService("turn_on");
        }

        ///<summary>Enable an automation.</summary>
        public static void TurnOn(this IEnumerable<AutomationEntity> target)
        {
            target.CallService("turn_on");
        }
    }

    public static class ButtonEntityExtensionMethods
    {
        ///<summary>Press the button entity.</summary>
        public static void Press(this ButtonEntity target)
        {
            target.CallService("press");
        }

        ///<summary>Press the button entity.</summary>
        public static void Press(this IEnumerable<ButtonEntity> target)
        {
            target.CallService("press");
        }
    }

    public static class CameraEntityExtensionMethods
    {
        ///<summary>Disable the motion detection in a camera.</summary>
        public static void DisableMotionDetection(this CameraEntity target)
        {
            target.CallService("disable_motion_detection");
        }

        ///<summary>Disable the motion detection in a camera.</summary>
        public static void DisableMotionDetection(this IEnumerable<CameraEntity> target)
        {
            target.CallService("disable_motion_detection");
        }

        ///<summary>Enable the motion detection in a camera.</summary>
        public static void EnableMotionDetection(this CameraEntity target)
        {
            target.CallService("enable_motion_detection");
        }

        ///<summary>Enable the motion detection in a camera.</summary>
        public static void EnableMotionDetection(this IEnumerable<CameraEntity> target)
        {
            target.CallService("enable_motion_detection");
        }

        ///<summary>Play camera stream on supported media player.</summary>
        public static void PlayStream(this CameraEntity target, CameraPlayStreamParameters data)
        {
            target.CallService("play_stream", data);
        }

        ///<summary>Play camera stream on supported media player.</summary>
        public static void PlayStream(this IEnumerable<CameraEntity> target, CameraPlayStreamParameters data)
        {
            target.CallService("play_stream", data);
        }

        ///<summary>Play camera stream on supported media player.</summary>
        ///<param name="target">The CameraEntity to call this service for</param>
        ///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
        ///<param name="format">Stream format supported by media player.</param>
        public static void PlayStream(this CameraEntity target, string @mediaPlayer, object? @format = null)
        {
            target.CallService("play_stream", new CameraPlayStreamParameters { MediaPlayer = @mediaPlayer, Format = @format });
        }

        ///<summary>Play camera stream on supported media player.</summary>
        ///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
        ///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
        ///<param name="format">Stream format supported by media player.</param>
        public static void PlayStream(this IEnumerable<CameraEntity> target, string @mediaPlayer, object? @format = null)
        {
            target.CallService("play_stream", new CameraPlayStreamParameters { MediaPlayer = @mediaPlayer, Format = @format });
        }

        ///<summary>Record live camera feed.</summary>
        public static void Record(this CameraEntity target, CameraRecordParameters data)
        {
            target.CallService("record", data);
        }

        ///<summary>Record live camera feed.</summary>
        public static void Record(this IEnumerable<CameraEntity> target, CameraRecordParameters data)
        {
            target.CallService("record", data);
        }

        ///<summary>Record live camera feed.</summary>
        ///<param name="target">The CameraEntity to call this service for</param>
        ///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
        ///<param name="duration">Target recording length.</param>
        ///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
        public static void Record(this CameraEntity target, string @filename, long? @duration = null, long? @lookback = null)
        {
            target.CallService("record", new CameraRecordParameters { Filename = @filename, Duration = @duration, Lookback = @lookback });
        }

        ///<summary>Record live camera feed.</summary>
        ///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
        ///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
        ///<param name="duration">Target recording length.</param>
        ///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
        public static void Record(this IEnumerable<CameraEntity> target, string @filename, long? @duration = null, long? @lookback = null)
        {
            target.CallService("record", new CameraRecordParameters { Filename = @filename, Duration = @duration, Lookback = @lookback });
        }

        ///<summary>Take a snapshot from a camera.</summary>
        public static void Snapshot(this CameraEntity target, CameraSnapshotParameters data)
        {
            target.CallService("snapshot", data);
        }

        ///<summary>Take a snapshot from a camera.</summary>
        public static void Snapshot(this IEnumerable<CameraEntity> target, CameraSnapshotParameters data)
        {
            target.CallService("snapshot", data);
        }

        ///<summary>Take a snapshot from a camera.</summary>
        ///<param name="target">The CameraEntity to call this service for</param>
        ///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
        public static void Snapshot(this CameraEntity target, string @filename)
        {
            target.CallService("snapshot", new CameraSnapshotParameters { Filename = @filename });
        }

        ///<summary>Take a snapshot from a camera.</summary>
        ///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
        ///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
        public static void Snapshot(this IEnumerable<CameraEntity> target, string @filename)
        {
            target.CallService("snapshot", new CameraSnapshotParameters { Filename = @filename });
        }

        ///<summary>Turn off camera.</summary>
        public static void TurnOff(this CameraEntity target)
        {
            target.CallService("turn_off");
        }

        ///<summary>Turn off camera.</summary>
        public static void TurnOff(this IEnumerable<CameraEntity> target)
        {
            target.CallService("turn_off");
        }

        ///<summary>Turn on camera.</summary>
        public static void TurnOn(this CameraEntity target)
        {
            target.CallService("turn_on");
        }

        ///<summary>Turn on camera.</summary>
        public static void TurnOn(this IEnumerable<CameraEntity> target)
        {
            target.CallService("turn_on");
        }
    }

    public static class ClimateEntityExtensionMethods
    {
        ///<summary>Turn auxiliary heater on/off for climate device.</summary>
        public static void SetAuxHeat(this ClimateEntity target, ClimateSetAuxHeatParameters data)
        {
            target.CallService("set_aux_heat", data);
        }

        ///<summary>Turn auxiliary heater on/off for climate device.</summary>
        public static void SetAuxHeat(this IEnumerable<ClimateEntity> target, ClimateSetAuxHeatParameters data)
        {
            target.CallService("set_aux_heat", data);
        }

        ///<summary>Turn auxiliary heater on/off for climate device.</summary>
        ///<param name="target">The ClimateEntity to call this service for</param>
        ///<param name="auxHeat">New value of auxiliary heater.</param>
        public static void SetAuxHeat(this ClimateEntity target, bool @auxHeat)
        {
            target.CallService("set_aux_heat", new ClimateSetAuxHeatParameters { AuxHeat = @auxHeat });
        }

        ///<summary>Turn auxiliary heater on/off for climate device.</summary>
        ///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
        ///<param name="auxHeat">New value of auxiliary heater.</param>
        public static void SetAuxHeat(this IEnumerable<ClimateEntity> target, bool @auxHeat)
        {
            target.CallService("set_aux_heat", new ClimateSetAuxHeatParameters { AuxHeat = @auxHeat });
        }

        ///<summary>Set fan operation for climate device.</summary>
        public static void SetFanMode(this ClimateEntity target, ClimateSetFanModeParameters data)
        {
            target.CallService("set_fan_mode", data);
        }

        ///<summary>Set fan operation for climate device.</summary>
        public static void SetFanMode(this IEnumerable<ClimateEntity> target, ClimateSetFanModeParameters data)
        {
            target.CallService("set_fan_mode", data);
        }

        ///<summary>Set fan operation for climate device.</summary>
        ///<param name="target">The ClimateEntity to call this service for</param>
        ///<param name="fanMode">New value of fan mode. eg: low</param>
        public static void SetFanMode(this ClimateEntity target, string @fanMode)
        {
            target.CallService("set_fan_mode", new ClimateSetFanModeParameters { FanMode = @fanMode });
        }

        ///<summary>Set fan operation for climate device.</summary>
        ///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
        ///<param name="fanMode">New value of fan mode. eg: low</param>
        public static void SetFanMode(this IEnumerable<ClimateEntity> target, string @fanMode)
        {
            target.CallService("set_fan_mode", new ClimateSetFanModeParameters { FanMode = @fanMode });
        }

        ///<summary>Set target humidity of climate device.</summary>
        public static void SetHumidity(this ClimateEntity target, ClimateSetHumidityParameters data)
        {
            target.CallService("set_humidity", data);
        }

        ///<summary>Set target humidity of climate device.</summary>
        public static void SetHumidity(this IEnumerable<ClimateEntity> target, ClimateSetHumidityParameters data)
        {
            target.CallService("set_humidity", data);
        }

        ///<summary>Set target humidity of climate device.</summary>
        ///<param name="target">The ClimateEntity to call this service for</param>
        ///<param name="humidity">New target humidity for climate device.</param>
        public static void SetHumidity(this ClimateEntity target, long @humidity)
        {
            target.CallService("set_humidity", new ClimateSetHumidityParameters { Humidity = @humidity });
        }

        ///<summary>Set target humidity of climate device.</summary>
        ///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
        ///<param name="humidity">New target humidity for climate device.</param>
        public static void SetHumidity(this IEnumerable<ClimateEntity> target, long @humidity)
        {
            target.CallService("set_humidity", new ClimateSetHumidityParameters { Humidity = @humidity });
        }

        ///<summary>Set HVAC operation mode for climate device.</summary>
        public static void SetHvacMode(this ClimateEntity target, ClimateSetHvacModeParameters data)
        {
            target.CallService("set_hvac_mode", data);
        }

        ///<summary>Set HVAC operation mode for climate device.</summary>
        public static void SetHvacMode(this IEnumerable<ClimateEntity> target, ClimateSetHvacModeParameters data)
        {
            target.CallService("set_hvac_mode", data);
        }

        ///<summary>Set HVAC operation mode for climate device.</summary>
        ///<param name="target">The ClimateEntity to call this service for</param>
        ///<param name="hvacMode">New value of operation mode.</param>
        public static void SetHvacMode(this ClimateEntity target, object? @hvacMode = null)
        {
            target.CallService("set_hvac_mode", new ClimateSetHvacModeParameters { HvacMode = @hvacMode });
        }

        ///<summary>Set HVAC operation mode for climate device.</summary>
        ///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
        ///<param name="hvacMode">New value of operation mode.</param>
        public static void SetHvacMode(this IEnumerable<ClimateEntity> target, object? @hvacMode = null)
        {
            target.CallService("set_hvac_mode", new ClimateSetHvacModeParameters { HvacMode = @hvacMode });
        }

        ///<summary>Set preset mode for climate device.</summary>
        public static void SetPresetMode(this ClimateEntity target, ClimateSetPresetModeParameters data)
        {
            target.CallService("set_preset_mode", data);
        }

        ///<summary>Set preset mode for climate device.</summary>
        public static void SetPresetMode(this IEnumerable<ClimateEntity> target, ClimateSetPresetModeParameters data)
        {
            target.CallService("set_preset_mode", data);
        }

        ///<summary>Set preset mode for climate device.</summary>
        ///<param name="target">The ClimateEntity to call this service for</param>
        ///<param name="presetMode">New value of preset mode. eg: away</param>
        public static void SetPresetMode(this ClimateEntity target, string @presetMode)
        {
            target.CallService("set_preset_mode", new ClimateSetPresetModeParameters { PresetMode = @presetMode });
        }

        ///<summary>Set preset mode for climate device.</summary>
        ///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
        ///<param name="presetMode">New value of preset mode. eg: away</param>
        public static void SetPresetMode(this IEnumerable<ClimateEntity> target, string @presetMode)
        {
            target.CallService("set_preset_mode", new ClimateSetPresetModeParameters { PresetMode = @presetMode });
        }

        ///<summary>Set swing operation for climate device.</summary>
        public static void SetSwingMode(this ClimateEntity target, ClimateSetSwingModeParameters data)
        {
            target.CallService("set_swing_mode", data);
        }

        ///<summary>Set swing operation for climate device.</summary>
        public static void SetSwingMode(this IEnumerable<ClimateEntity> target, ClimateSetSwingModeParameters data)
        {
            target.CallService("set_swing_mode", data);
        }

        ///<summary>Set swing operation for climate device.</summary>
        ///<param name="target">The ClimateEntity to call this service for</param>
        ///<param name="swingMode">New value of swing mode. eg: horizontal</param>
        public static void SetSwingMode(this ClimateEntity target, string @swingMode)
        {
            target.CallService("set_swing_mode", new ClimateSetSwingModeParameters { SwingMode = @swingMode });
        }

        ///<summary>Set swing operation for climate device.</summary>
        ///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
        ///<param name="swingMode">New value of swing mode. eg: horizontal</param>
        public static void SetSwingMode(this IEnumerable<ClimateEntity> target, string @swingMode)
        {
            target.CallService("set_swing_mode", new ClimateSetSwingModeParameters { SwingMode = @swingMode });
        }

        ///<summary>Set target temperature of climate device.</summary>
        public static void SetTemperature(this ClimateEntity target, ClimateSetTemperatureParameters data)
        {
            target.CallService("set_temperature", data);
        }

        ///<summary>Set target temperature of climate device.</summary>
        public static void SetTemperature(this IEnumerable<ClimateEntity> target, ClimateSetTemperatureParameters data)
        {
            target.CallService("set_temperature", data);
        }

        ///<summary>Set target temperature of climate device.</summary>
        ///<param name="target">The ClimateEntity to call this service for</param>
        ///<param name="temperature">New target temperature for HVAC.</param>
        ///<param name="targetTempHigh">New target high temperature for HVAC.</param>
        ///<param name="targetTempLow">New target low temperature for HVAC.</param>
        ///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
        public static void SetTemperature(this ClimateEntity target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, object? @hvacMode = null)
        {
            target.CallService("set_temperature", new ClimateSetTemperatureParameters { Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode });
        }

        ///<summary>Set target temperature of climate device.</summary>
        ///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
        ///<param name="temperature">New target temperature for HVAC.</param>
        ///<param name="targetTempHigh">New target high temperature for HVAC.</param>
        ///<param name="targetTempLow">New target low temperature for HVAC.</param>
        ///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
        public static void SetTemperature(this IEnumerable<ClimateEntity> target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, object? @hvacMode = null)
        {
            target.CallService("set_temperature", new ClimateSetTemperatureParameters { Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode });
        }

        ///<summary>Turn climate device off.</summary>
        public static void TurnOff(this ClimateEntity target)
        {
            target.CallService("turn_off");
        }

        ///<summary>Turn climate device off.</summary>
        public static void TurnOff(this IEnumerable<ClimateEntity> target)
        {
            target.CallService("turn_off");
        }

        ///<summary>Turn climate device on.</summary>
        public static void TurnOn(this ClimateEntity target)
        {
            target.CallService("turn_on");
        }

        ///<summary>Turn climate device on.</summary>
        public static void TurnOn(this IEnumerable<ClimateEntity> target)
        {
            target.CallService("turn_on");
        }
    }

    public static class InputBooleanEntityExtensionMethods
    {
        ///<summary>Toggle an input boolean</summary>
        public static void Toggle(this InputBooleanEntity target)
        {
            target.CallService("toggle");
        }

        ///<summary>Toggle an input boolean</summary>
        public static void Toggle(this IEnumerable<InputBooleanEntity> target)
        {
            target.CallService("toggle");
        }

        ///<summary>Turn off an input boolean</summary>
        public static void TurnOff(this InputBooleanEntity target)
        {
            target.CallService("turn_off");
        }

        ///<summary>Turn off an input boolean</summary>
        public static void TurnOff(this IEnumerable<InputBooleanEntity> target)
        {
            target.CallService("turn_off");
        }

        ///<summary>Turn on an input boolean</summary>
        public static void TurnOn(this InputBooleanEntity target)
        {
            target.CallService("turn_on");
        }

        ///<summary>Turn on an input boolean</summary>
        public static void TurnOn(this IEnumerable<InputBooleanEntity> target)
        {
            target.CallService("turn_on");
        }
    }

    public static class InputNumberEntityExtensionMethods
    {
        ///<summary>Decrement the value of an input number entity by its stepping.</summary>
        public static void Decrement(this InputNumberEntity target)
        {
            target.CallService("decrement");
        }

        ///<summary>Decrement the value of an input number entity by its stepping.</summary>
        public static void Decrement(this IEnumerable<InputNumberEntity> target)
        {
            target.CallService("decrement");
        }

        ///<summary>Increment the value of an input number entity by its stepping.</summary>
        public static void Increment(this InputNumberEntity target)
        {
            target.CallService("increment");
        }

        ///<summary>Increment the value of an input number entity by its stepping.</summary>
        public static void Increment(this IEnumerable<InputNumberEntity> target)
        {
            target.CallService("increment");
        }

        ///<summary>Set the value of an input number entity.</summary>
        public static void SetValue(this InputNumberEntity target, InputNumberSetValueParameters data)
        {
            target.CallService("set_value", data);
        }

        ///<summary>Set the value of an input number entity.</summary>
        public static void SetValue(this IEnumerable<InputNumberEntity> target, InputNumberSetValueParameters data)
        {
            target.CallService("set_value", data);
        }

        ///<summary>Set the value of an input number entity.</summary>
        ///<param name="target">The InputNumberEntity to call this service for</param>
        ///<param name="value">The target value the entity should be set to.</param>
        public static void SetValue(this InputNumberEntity target, double @value)
        {
            target.CallService("set_value", new InputNumberSetValueParameters { Value = @value });
        }

        ///<summary>Set the value of an input number entity.</summary>
        ///<param name="target">The IEnumerable<InputNumberEntity> to call this service for</param>
        ///<param name="value">The target value the entity should be set to.</param>
        public static void SetValue(this IEnumerable<InputNumberEntity> target, double @value)
        {
            target.CallService("set_value", new InputNumberSetValueParameters { Value = @value });
        }
    }

    public static class InputSelectEntityExtensionMethods
    {
        ///<summary>Select the first option of an input select entity.</summary>
        public static void SelectFirst(this InputSelectEntity target)
        {
            target.CallService("select_first");
        }

        ///<summary>Select the first option of an input select entity.</summary>
        public static void SelectFirst(this IEnumerable<InputSelectEntity> target)
        {
            target.CallService("select_first");
        }

        ///<summary>Select the last option of an input select entity.</summary>
        public static void SelectLast(this InputSelectEntity target)
        {
            target.CallService("select_last");
        }

        ///<summary>Select the last option of an input select entity.</summary>
        public static void SelectLast(this IEnumerable<InputSelectEntity> target)
        {
            target.CallService("select_last");
        }

        ///<summary>Select the next options of an input select entity.</summary>
        public static void SelectNext(this InputSelectEntity target, InputSelectSelectNextParameters data)
        {
            target.CallService("select_next", data);
        }

        ///<summary>Select the next options of an input select entity.</summary>
        public static void SelectNext(this IEnumerable<InputSelectEntity> target, InputSelectSelectNextParameters data)
        {
            target.CallService("select_next", data);
        }

        ///<summary>Select the next options of an input select entity.</summary>
        ///<param name="target">The InputSelectEntity to call this service for</param>
        ///<param name="cycle">If the option should cycle from the last to the first.</param>
        public static void SelectNext(this InputSelectEntity target, bool? @cycle = null)
        {
            target.CallService("select_next", new InputSelectSelectNextParameters { Cycle = @cycle });
        }

        ///<summary>Select the next options of an input select entity.</summary>
        ///<param name="target">The IEnumerable<InputSelectEntity> to call this service for</param>
        ///<param name="cycle">If the option should cycle from the last to the first.</param>
        public static void SelectNext(this IEnumerable<InputSelectEntity> target, bool? @cycle = null)
        {
            target.CallService("select_next", new InputSelectSelectNextParameters { Cycle = @cycle });
        }

        ///<summary>Select an option of an input select entity.</summary>
        public static void SelectOption(this InputSelectEntity target, InputSelectSelectOptionParameters data)
        {
            target.CallService("select_option", data);
        }

        ///<summary>Select an option of an input select entity.</summary>
        public static void SelectOption(this IEnumerable<InputSelectEntity> target, InputSelectSelectOptionParameters data)
        {
            target.CallService("select_option", data);
        }

        ///<summary>Select an option of an input select entity.</summary>
        ///<param name="target">The InputSelectEntity to call this service for</param>
        ///<param name="option">Option to be selected. eg: "Item A"</param>
        public static void SelectOption(this InputSelectEntity target, string @option)
        {
            target.CallService("select_option", new InputSelectSelectOptionParameters { Option = @option });
        }

        ///<summary>Select an option of an input select entity.</summary>
        ///<param name="target">The IEnumerable<InputSelectEntity> to call this service for</param>
        ///<param name="option">Option to be selected. eg: "Item A"</param>
        public static void SelectOption(this IEnumerable<InputSelectEntity> target, string @option)
        {
            target.CallService("select_option", new InputSelectSelectOptionParameters { Option = @option });
        }

        ///<summary>Select the previous options of an input select entity.</summary>
        public static void SelectPrevious(this InputSelectEntity target, InputSelectSelectPreviousParameters data)
        {
            target.CallService("select_previous", data);
        }

        ///<summary>Select the previous options of an input select entity.</summary>
        public static void SelectPrevious(this IEnumerable<InputSelectEntity> target, InputSelectSelectPreviousParameters data)
        {
            target.CallService("select_previous", data);
        }

        ///<summary>Select the previous options of an input select entity.</summary>
        ///<param name="target">The InputSelectEntity to call this service for</param>
        ///<param name="cycle">If the option should cycle from the first to the last.</param>
        public static void SelectPrevious(this InputSelectEntity target, bool? @cycle = null)
        {
            target.CallService("select_previous", new InputSelectSelectPreviousParameters { Cycle = @cycle });
        }

        ///<summary>Select the previous options of an input select entity.</summary>
        ///<param name="target">The IEnumerable<InputSelectEntity> to call this service for</param>
        ///<param name="cycle">If the option should cycle from the first to the last.</param>
        public static void SelectPrevious(this IEnumerable<InputSelectEntity> target, bool? @cycle = null)
        {
            target.CallService("select_previous", new InputSelectSelectPreviousParameters { Cycle = @cycle });
        }

        ///<summary>Set the options of an input select entity.</summary>
        public static void SetOptions(this InputSelectEntity target, InputSelectSetOptionsParameters data)
        {
            target.CallService("set_options", data);
        }

        ///<summary>Set the options of an input select entity.</summary>
        public static void SetOptions(this IEnumerable<InputSelectEntity> target, InputSelectSetOptionsParameters data)
        {
            target.CallService("set_options", data);
        }

        ///<summary>Set the options of an input select entity.</summary>
        ///<param name="target">The InputSelectEntity to call this service for</param>
        ///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
        public static void SetOptions(this InputSelectEntity target, object @options)
        {
            target.CallService("set_options", new InputSelectSetOptionsParameters { Options = @options });
        }

        ///<summary>Set the options of an input select entity.</summary>
        ///<param name="target">The IEnumerable<InputSelectEntity> to call this service for</param>
        ///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
        public static void SetOptions(this IEnumerable<InputSelectEntity> target, object @options)
        {
            target.CallService("set_options", new InputSelectSetOptionsParameters { Options = @options });
        }
    }

    public static class LightEntityExtensionMethods
    {
        ///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
        public static void Toggle(this LightEntity target, LightToggleParameters data)
        {
            target.CallService("toggle", data);
        }

        ///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
        public static void Toggle(this IEnumerable<LightEntity> target, LightToggleParameters data)
        {
            target.CallService("toggle", data);
        }

        ///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
        ///<param name="target">The LightEntity to call this service for</param>
        ///<param name="transition">Duration it takes to get to next state.</param>
        ///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
        ///<param name="colorName">A human readable color name.</param>
        ///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
        ///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
        ///<param name="colorTemp">Color temperature for the light in mireds.</param>
        ///<param name="kelvin">Color temperature for the light in Kelvin.</param>
        ///<param name="whiteValue">Number indicating level of white.</param>
        ///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
        ///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
        ///<param name="profile">Name of a light profile to use. eg: relax</param>
        ///<param name="flash">If the light should flash.</param>
        ///<param name="effect">Light effect.</param>
        public static void Toggle(this LightEntity target, long? @transition = null, object? @rgbColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, object? @flash = null, string? @effect = null)
        {
            target.CallService("toggle", new LightToggleParameters { Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect });
        }

        ///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
        ///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
        ///<param name="transition">Duration it takes to get to next state.</param>
        ///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
        ///<param name="colorName">A human readable color name.</param>
        ///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
        ///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
        ///<param name="colorTemp">Color temperature for the light in mireds.</param>
        ///<param name="kelvin">Color temperature for the light in Kelvin.</param>
        ///<param name="whiteValue">Number indicating level of white.</param>
        ///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
        ///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
        ///<param name="profile">Name of a light profile to use. eg: relax</param>
        ///<param name="flash">If the light should flash.</param>
        ///<param name="effect">Light effect.</param>
        public static void Toggle(this IEnumerable<LightEntity> target, long? @transition = null, object? @rgbColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, object? @flash = null, string? @effect = null)
        {
            target.CallService("toggle", new LightToggleParameters { Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect });
        }

        ///<summary>Turns off one or more lights.</summary>
        public static void TurnOff(this LightEntity target, LightTurnOffParameters data)
        {
            target.CallService("turn_off", data);
        }

        ///<summary>Turns off one or more lights.</summary>
        public static void TurnOff(this IEnumerable<LightEntity> target, LightTurnOffParameters data)
        {
            target.CallService("turn_off", data);
        }

        ///<summary>Turns off one or more lights.</summary>
        ///<param name="target">The LightEntity to call this service for</param>
        ///<param name="transition">Duration it takes to get to next state.</param>
        ///<param name="flash">If the light should flash.</param>
        public static void TurnOff(this LightEntity target, long? @transition = null, object? @flash = null)
        {
            target.CallService("turn_off", new LightTurnOffParameters { Transition = @transition, Flash = @flash });
        }

        ///<summary>Turns off one or more lights.</summary>
        ///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
        ///<param name="transition">Duration it takes to get to next state.</param>
        ///<param name="flash">If the light should flash.</param>
        public static void TurnOff(this IEnumerable<LightEntity> target, long? @transition = null, object? @flash = null)
        {
            target.CallService("turn_off", new LightTurnOffParameters { Transition = @transition, Flash = @flash });
        }

        ///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
        public static void TurnOn(this LightEntity target, LightTurnOnParameters data)
        {
            target.CallService("turn_on", data);
        }

        ///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
        public static void TurnOn(this IEnumerable<LightEntity> target, LightTurnOnParameters data)
        {
            target.CallService("turn_on", data);
        }

        ///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
        ///<param name="target">The LightEntity to call this service for</param>
        ///<param name="transition">Duration it takes to get to next state.</param>
        ///<param name="rgbColor">The color for the light (based on RGB - red, green, blue).</param>
        ///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
        ///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
        ///<param name="colorName">A human readable color name.</param>
        ///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
        ///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
        ///<param name="colorTemp">Color temperature for the light in mireds.</param>
        ///<param name="kelvin">Color temperature for the light in Kelvin.</param>
        ///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
        ///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
        ///<param name="brightnessStep">Change brightness by an amount.</param>
        ///<param name="brightnessStepPct">Change brightness by a percentage.</param>
        ///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
        ///<param name="profile">Name of a light profile to use. eg: relax</param>
        ///<param name="flash">If the light should flash.</param>
        ///<param name="effect">Light effect.</param>
        public static void TurnOn(this LightEntity target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, object? @flash = null, string? @effect = null)
        {
            target.CallService("turn_on", new LightTurnOnParameters { Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect });
        }

        ///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
        ///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
        ///<param name="transition">Duration it takes to get to next state.</param>
        ///<param name="rgbColor">The color for the light (based on RGB - red, green, blue).</param>
        ///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
        ///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
        ///<param name="colorName">A human readable color name.</param>
        ///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
        ///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
        ///<param name="colorTemp">Color temperature for the light in mireds.</param>
        ///<param name="kelvin">Color temperature for the light in Kelvin.</param>
        ///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
        ///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
        ///<param name="brightnessStep">Change brightness by an amount.</param>
        ///<param name="brightnessStepPct">Change brightness by a percentage.</param>
        ///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
        ///<param name="profile">Name of a light profile to use. eg: relax</param>
        ///<param name="flash">If the light should flash.</param>
        ///<param name="effect">Light effect.</param>
        public static void TurnOn(this IEnumerable<LightEntity> target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, object? @flash = null, string? @effect = null)
        {
            target.CallService("turn_on", new LightTurnOnParameters { Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect });
        }
    }

    public static class LyricEntityExtensionMethods
    {
        ///<summary>Sets the time to hold until</summary>
        public static void SetHoldTime(this ClimateEntity target, LyricSetHoldTimeParameters data)
        {
            target.CallService("set_hold_time", data);
        }

        ///<summary>Sets the time to hold until</summary>
        public static void SetHoldTime(this IEnumerable<ClimateEntity> target, LyricSetHoldTimeParameters data)
        {
            target.CallService("set_hold_time", data);
        }

        ///<summary>Sets the time to hold until</summary>
        ///<param name="target">The ClimateEntity to call this service for</param>
        ///<param name="timePeriod">Time to hold until eg: 01:00:00</param>
        public static void SetHoldTime(this ClimateEntity target, string @timePeriod)
        {
            target.CallService("set_hold_time", new LyricSetHoldTimeParameters { TimePeriod = @timePeriod });
        }

        ///<summary>Sets the time to hold until</summary>
        ///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
        ///<param name="timePeriod">Time to hold until eg: 01:00:00</param>
        public static void SetHoldTime(this IEnumerable<ClimateEntity> target, string @timePeriod)
        {
            target.CallService("set_hold_time", new LyricSetHoldTimeParameters { TimePeriod = @timePeriod });
        }
    }

    public static class ScriptEntityExtensionMethods
    {
        ///<summary>Toggle script</summary>
        public static void Toggle(this ScriptEntity target)
        {
            target.CallService("toggle");
        }

        ///<summary>Toggle script</summary>
        public static void Toggle(this IEnumerable<ScriptEntity> target)
        {
            target.CallService("toggle");
        }

        ///<summary>Turn off script</summary>
        public static void TurnOff(this ScriptEntity target)
        {
            target.CallService("turn_off");
        }

        ///<summary>Turn off script</summary>
        public static void TurnOff(this IEnumerable<ScriptEntity> target)
        {
            target.CallService("turn_off");
        }

        ///<summary>Turn on script</summary>
        public static void TurnOn(this ScriptEntity target)
        {
            target.CallService("turn_on");
        }

        ///<summary>Turn on script</summary>
        public static void TurnOn(this IEnumerable<ScriptEntity> target)
        {
            target.CallService("turn_on");
        }
    }

    public static class SwitchEntityExtensionMethods
    {
        ///<summary>Toggles a switch state</summary>
        public static void Toggle(this SwitchEntity target)
        {
            target.CallService("toggle");
        }

        ///<summary>Toggles a switch state</summary>
        public static void Toggle(this IEnumerable<SwitchEntity> target)
        {
            target.CallService("toggle");
        }

        ///<summary>Turn a switch off</summary>
        public static void TurnOff(this SwitchEntity target)
        {
            target.CallService("turn_off");
        }

        ///<summary>Turn a switch off</summary>
        public static void TurnOff(this IEnumerable<SwitchEntity> target)
        {
            target.CallService("turn_off");
        }

        ///<summary>Turn a switch on</summary>
        public static void TurnOn(this SwitchEntity target)
        {
            target.CallService("turn_on");
        }

        ///<summary>Turn a switch on</summary>
        public static void TurnOn(this IEnumerable<SwitchEntity> target)
        {
            target.CallService("turn_on");
        }
    }

    public static class UpdateEntityExtensionMethods
    {
        ///<summary>Removes the skipped version marker from an update.</summary>
        public static void ClearSkipped(this UpdateEntity target)
        {
            target.CallService("clear_skipped");
        }

        ///<summary>Removes the skipped version marker from an update.</summary>
        public static void ClearSkipped(this IEnumerable<UpdateEntity> target)
        {
            target.CallService("clear_skipped");
        }

        ///<summary>Install an update for this device or service</summary>
        public static void Install(this UpdateEntity target, UpdateInstallParameters data)
        {
            target.CallService("install", data);
        }

        ///<summary>Install an update for this device or service</summary>
        public static void Install(this IEnumerable<UpdateEntity> target, UpdateInstallParameters data)
        {
            target.CallService("install", data);
        }

        ///<summary>Install an update for this device or service</summary>
        ///<param name="target">The UpdateEntity to call this service for</param>
        ///<param name="version">Version to install, if omitted, the latest version will be installed. eg: 1.0.0</param>
        ///<param name="backup">Backup before installing the update, if supported by the integration.</param>
        public static void Install(this UpdateEntity target, string? @version = null, bool? @backup = null)
        {
            target.CallService("install", new UpdateInstallParameters { Version = @version, Backup = @backup });
        }

        ///<summary>Install an update for this device or service</summary>
        ///<param name="target">The IEnumerable<UpdateEntity> to call this service for</param>
        ///<param name="version">Version to install, if omitted, the latest version will be installed. eg: 1.0.0</param>
        ///<param name="backup">Backup before installing the update, if supported by the integration.</param>
        public static void Install(this IEnumerable<UpdateEntity> target, string? @version = null, bool? @backup = null)
        {
            target.CallService("install", new UpdateInstallParameters { Version = @version, Backup = @backup });
        }

        ///<summary>Mark currently available update as skipped.</summary>
        public static void Skip(this UpdateEntity target)
        {
            target.CallService("skip");
        }

        ///<summary>Mark currently available update as skipped.</summary>
        public static void Skip(this IEnumerable<UpdateEntity> target)
        {
            target.CallService("skip");
        }
    }

    public static class UtilityMeterEntityExtensionMethods
    {
        ///<summary>Calibrates a utility meter sensor.</summary>
        public static void Calibrate(this SensorEntity target, UtilityMeterCalibrateParameters data)
        {
            target.CallService("calibrate", data);
        }

        ///<summary>Calibrates a utility meter sensor.</summary>
        public static void Calibrate(this IEnumerable<SensorEntity> target, UtilityMeterCalibrateParameters data)
        {
            target.CallService("calibrate", data);
        }

        ///<summary>Calibrates a utility meter sensor.</summary>
        ///<param name="target">The SensorEntity to call this service for</param>
        ///<param name="value">Value to which set the meter eg: 100</param>
        public static void Calibrate(this SensorEntity target, string @value)
        {
            target.CallService("calibrate", new UtilityMeterCalibrateParameters { Value = @value });
        }

        ///<summary>Calibrates a utility meter sensor.</summary>
        ///<param name="target">The IEnumerable<SensorEntity> to call this service for</param>
        ///<param name="value">Value to which set the meter eg: 100</param>
        public static void Calibrate(this IEnumerable<SensorEntity> target, string @value)
        {
            target.CallService("calibrate", new UtilityMeterCalibrateParameters { Value = @value });
        }

    }

    public static class VacuumEntityExtensionMethods
    {
        ///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
        public static void CleanSpot(this VacuumEntity target)
        {
            target.CallService("clean_spot");
        }

        ///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
        public static void CleanSpot(this IEnumerable<VacuumEntity> target)
        {
            target.CallService("clean_spot");
        }

        ///<summary>Locate the vacuum cleaner robot.</summary>
        public static void Locate(this VacuumEntity target)
        {
            target.CallService("locate");
        }

        ///<summary>Locate the vacuum cleaner robot.</summary>
        public static void Locate(this IEnumerable<VacuumEntity> target)
        {
            target.CallService("locate");
        }

        ///<summary>Pause the cleaning task.</summary>
        public static void Pause(this VacuumEntity target)
        {
            target.CallService("pause");
        }

        ///<summary>Pause the cleaning task.</summary>
        public static void Pause(this IEnumerable<VacuumEntity> target)
        {
            target.CallService("pause");
        }

        ///<summary>Tell the vacuum cleaner to return to its dock.</summary>
        public static void ReturnToBase(this VacuumEntity target)
        {
            target.CallService("return_to_base");
        }

        ///<summary>Tell the vacuum cleaner to return to its dock.</summary>
        public static void ReturnToBase(this IEnumerable<VacuumEntity> target)
        {
            target.CallService("return_to_base");
        }

        ///<summary>Send a raw command to the vacuum cleaner.</summary>
        public static void SendCommand(this VacuumEntity target, VacuumSendCommandParameters data)
        {
            target.CallService("send_command", data);
        }

        ///<summary>Send a raw command to the vacuum cleaner.</summary>
        public static void SendCommand(this IEnumerable<VacuumEntity> target, VacuumSendCommandParameters data)
        {
            target.CallService("send_command", data);
        }

        ///<summary>Send a raw command to the vacuum cleaner.</summary>
        ///<param name="target">The VacuumEntity to call this service for</param>
        ///<param name="command">Command to execute. eg: set_dnd_timer</param>
        ///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
        public static void SendCommand(this VacuumEntity target, string @command, object? @params = null)
        {
            target.CallService("send_command", new VacuumSendCommandParameters { Command = @command, Params = @params });
        }

        ///<summary>Send a raw command to the vacuum cleaner.</summary>
        ///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
        ///<param name="command">Command to execute. eg: set_dnd_timer</param>
        ///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
        public static void SendCommand(this IEnumerable<VacuumEntity> target, string @command, object? @params = null)
        {
            target.CallService("send_command", new VacuumSendCommandParameters { Command = @command, Params = @params });
        }

        ///<summary>Set the fan speed of the vacuum cleaner.</summary>
        public static void SetFanSpeed(this VacuumEntity target, VacuumSetFanSpeedParameters data)
        {
            target.CallService("set_fan_speed", data);
        }

        ///<summary>Set the fan speed of the vacuum cleaner.</summary>
        public static void SetFanSpeed(this IEnumerable<VacuumEntity> target, VacuumSetFanSpeedParameters data)
        {
            target.CallService("set_fan_speed", data);
        }

        ///<summary>Set the fan speed of the vacuum cleaner.</summary>
        ///<param name="target">The VacuumEntity to call this service for</param>
        ///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
        public static void SetFanSpeed(this VacuumEntity target, string @fanSpeed)
        {
            target.CallService("set_fan_speed", new VacuumSetFanSpeedParameters { FanSpeed = @fanSpeed });
        }

        ///<summary>Set the fan speed of the vacuum cleaner.</summary>
        ///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
        ///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
        public static void SetFanSpeed(this IEnumerable<VacuumEntity> target, string @fanSpeed)
        {
            target.CallService("set_fan_speed", new VacuumSetFanSpeedParameters { FanSpeed = @fanSpeed });
        }

        ///<summary>Start or resume the cleaning task.</summary>
        public static void Start(this VacuumEntity target)
        {
            target.CallService("start");
        }

        ///<summary>Start or resume the cleaning task.</summary>
        public static void Start(this IEnumerable<VacuumEntity> target)
        {
            target.CallService("start");
        }

        ///<summary>Start, pause, or resume the cleaning task.</summary>
        public static void StartPause(this VacuumEntity target)
        {
            target.CallService("start_pause");
        }

        ///<summary>Start, pause, or resume the cleaning task.</summary>
        public static void StartPause(this IEnumerable<VacuumEntity> target)
        {
            target.CallService("start_pause");
        }

        ///<summary>Stop the current cleaning task.</summary>
        public static void Stop(this VacuumEntity target)
        {
            target.CallService("stop");
        }

        ///<summary>Stop the current cleaning task.</summary>
        public static void Stop(this IEnumerable<VacuumEntity> target)
        {
            target.CallService("stop");
        }

        ///<summary>Stop the current cleaning task and return to home.</summary>
        public static void TurnOff(this VacuumEntity target)
        {
            target.CallService("turn_off");
        }

        ///<summary>Stop the current cleaning task and return to home.</summary>
        public static void TurnOff(this IEnumerable<VacuumEntity> target)
        {
            target.CallService("turn_off");
        }

        ///<summary>Start a new cleaning task.</summary>
        public static void TurnOn(this VacuumEntity target)
        {
            target.CallService("turn_on");
        }

        ///<summary>Start a new cleaning task.</summary>
        public static void TurnOn(this IEnumerable<VacuumEntity> target)
        {
            target.CallService("turn_on");
        }
    }
}