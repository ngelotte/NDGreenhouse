

using HomeAssistantGenerated;
using System.Collections.Generic;

namespace NdGreenhouse
{

    public class GHMain
    {
        public SwitchEntity TestingTankHeater { get; set; } = default!;
        public NumericSensorEntity TestingTankTemp { get; set; } = default!;
        public BinarySensorEntity? TestingZoneLow { get; set; }
        public BinarySensorEntity? TestingZoneMedium { get; set; }
        public BinarySensorEntity? TestingZoneHigh { get; set; }
        public SwitchEntity MainFan { get; set; } = default!;
        public SwitchEntity HomeDamper { get; set; } = default!;
        public SwitchEntity? FreshWaterPump { get; set; }
        public SwitchEntity? WaterTankRefill { get; set; }
        public BinarySensorEntity? LowFreshWaterTank { get; set; }
        public BinarySensorEntity? MediumFreshWaterTank { get; set; }
        public BinarySensorEntity? HighFreshWaterTank { get; set; }
        public decimal SecondsFromLowToMediumOnTestingZone { get; set; }
        public string NutrientPump1Name { get; set; } = "";
        public string NutrientPump2Name { get; set; } = "";
        public string NutrientPump3Name { get; set; } = "";
        public SwitchEntity Dehumidfier { get; set; } = default!;
        public SwitchEntity SwampCooler { get; set; } = default!;
        public BinarySensorEntity? LowSwampCoolerTank { get; set; }
        public BinarySensorEntity? MediumSwampCoolerTank { get; set; }
        public BinarySensorEntity? HighSwampCoolerTank { get; set; }
        public SwitchEntity SwampCoolerRefillPump { get; set; } = default!;
        public SwitchEntity DumpToWastePump { get; set; } = default!;
        //These need to just become ordered lists.
        public List<NumericSensorEntity> InternalTempSensors { get; set; } = new List<NumericSensorEntity>();
        public List<NumericSensorEntity> ExternalTempSensors { get; set; } = new List<NumericSensorEntity>();
        public List<NumericSensorEntity> ExternalHumiditySensors { get; set; } = new List<NumericSensorEntity>();
        public List<NumericSensorEntity> InternalHumidtySensors { get; set; } = new List<NumericSensorEntity>();

        public double? InternalTemp
        {
            get
            {

                foreach (var sensor in InternalTempSensors)
                {
                    return sensor.State;
                }
                return null;

            }
        }
        public double? ExternalTemp
        {
            get
            {

                foreach (var sensor in ExternalTempSensors)
                {
                    return sensor.State; ;
                }
                return null;

            }
        }

        public double? InternalHumidity
        {
            get
            {

                foreach (var sensor in InternalHumidtySensors)
                {
                    return sensor.State; ;
                }
                return null;

            }
        }

        public double? ExternalHumidty
        {
            get
            {

                foreach (var sensor in ExternalHumiditySensors)
                {
                    return sensor.State; ;
                }
                return null;

            }
        }

    }
    public class GhZone
    {
        public SwitchEntity? WateringPump { get; set; }
        public SwitchEntity? TestingPump { get; set; }
        public BinarySensorEntity? LowWater { get; set; }
        public BinarySensorEntity? MediumWater { get; set; }
        public BinarySensorEntity? HighWater { get; set; }
        public NutrientMixes NutrientMix { get; set; }
        public string SelectorName { get; set; }
        public decimal SecondsFromLowToMediumOnTestingZone { get; set; }
        public decimal SecondsFromHighToMediumOnBucket { get; set; }

        public GhZone()
        {
            SelectorName = "";
        }

        public (int pump1, int pump2, int pump3) NutrientFormula()
        {
            int pump1 = 0;
            int pump2 = 0;
            int pump3 = 0;
            int baseStepCount = 300;
            switch (NutrientMix)
            {
                case NutrientMixes.CuttingsAndSeedlings:
                    pump1 = baseStepCount / 4;
                    pump2 = baseStepCount / 4;
                    pump3 = baseStepCount / 4;
                    break;
                case NutrientMixes.MildVegatativeGrowth:
                    pump1 = baseStepCount;
                    pump2 = baseStepCount;
                    pump3 = baseStepCount;
                    break;
                case NutrientMixes.AggressiveVegetativeGrowth:
                    pump1 = baseStepCount * 3;
                    pump2 = baseStepCount * 2;
                    pump3 = baseStepCount;
                    break;
                case NutrientMixes.TransitionToBloom:
                    pump1 = baseStepCount * 2;
                    pump2 = baseStepCount * 2;
                    pump3 = baseStepCount * 2;
                    break;
                case NutrientMixes.BloomingAndRipening:
                    pump1 = baseStepCount * 1;
                    pump2 = baseStepCount * 2;
                    pump3 = baseStepCount * 3;
                    break;
            }

            return (pump1, pump2, pump3);

        }

    }

    public enum NutrientMixes
    {
        CuttingsAndSeedlings = 1,
        MildVegatativeGrowth = 2,
        AggressiveVegetativeGrowth = 3,
        TransitionToBloom = 4,
        BloomingAndRipening = 5

    }

    public class GhConfig
    {
        private IHaContext _app;
        private ILogger _logger;
        public GhConfig(IHaContext app, ILogger logger)
        {
            _app = app;
            _logger = logger;
        }

        public GHMain GhMain()
        {
            BinarySensorEntities bse = new(_app);
            SwitchEntities sw = new(_app);
            SensorEntities se = new(_app);
            GHMain gHMain = new GHMain();
            gHMain.TestingZoneLow = bse.TnResEmpty;
            gHMain.TestingZoneMedium = bse.TnResMedium;
            gHMain.TestingZoneHigh = bse.TnResFull;
            gHMain.FreshWaterPump = sw.Tb2p4; 
            gHMain.SecondsFromLowToMediumOnTestingZone = 8.68M;
            gHMain.Dehumidfier = sw.PowerStripTestZoneOutlet2;
            gHMain.SwampCooler = sw.St4p3;
            gHMain.NutrientPump1Name = "peristalticnutrients_nutrientpump1";
            gHMain.NutrientPump2Name = "peristalticnutrients_nutrientpump2";
            gHMain.NutrientPump3Name = "peristalticnutrients_nutrientpump3";
            gHMain.InternalTempSensors.Add(se.GoveeIndoorTempTemperature);
            gHMain.InternalTempSensors.Add(se.GhInteralProtectedTemp);
            gHMain.ExternalTempSensors.Add(se.ExteriorTemperature);
            gHMain.InternalHumidtySensors.Add(se.GoveeIndoorTempHumidity);
            gHMain.InternalHumidtySensors.Add(se.GhInteralProtectedHumidity);
            gHMain.ExternalHumiditySensors.Add(se.ExteriorHumidity);
            gHMain.MainFan = sw.Fan;
            gHMain.WaterTankRefill = sw.PowerstripneOutlet3;
            gHMain.LowFreshWaterTank = bse.FreshResEmpty;
            gHMain.MediumFreshWaterTank = bse.FreshResMedium;
            gHMain.HighFreshWaterTank = bse.FreshResFull;
            gHMain.LowSwampCoolerTank = bse.SwpResEmpty;
            gHMain.MediumSwampCoolerTank = bse.SwpResMedium;
            gHMain.HighSwampCoolerTank = bse.SwpResFull;
            gHMain.DumpToWastePump = sw.Tbp1;
            gHMain.HomeDamper = sw.PowerStrip1Outlet4;
            gHMain.TestingTankHeater = sw.PowerStripTestZoneOutlet1;
            gHMain.TestingTankTemp = se.WaterTemperature;
            return gHMain;
        }
        public GhZone CurrentZone()
        {
            GhZone CurrentZone = new GhZone();
            SwitchEntities sw = new SwitchEntities(_app);
            BinarySensorEntities bse = new BinarySensorEntities(_app);
            InputSelectEntities ise = new InputSelectEntities(_app);
            if (ise.ReservoirRes.State == "DB1")
            {
                CurrentZone.LowWater = bse.Db1ResEmpty;
                CurrentZone.MediumWater = bse.Db1ResMedium;
                CurrentZone.HighWater = bse.Db1ResFull;
                CurrentZone.WateringPump = sw.St2p3;
                CurrentZone.SelectorName = "DB1";
                CurrentZone.TestingPump = sw.St2p1;
                CurrentZone.SecondsFromLowToMediumOnTestingZone = 10.57M;
                CurrentZone.SecondsFromHighToMediumOnBucket = 31.88M; ///Copied from Zone 2
                CurrentZone.NutrientMix = NutrientMixes.BloomingAndRipening;
                return CurrentZone;
            }
            if (ise.ReservoirRes.State == "DB2")
            {
                CurrentZone.LowWater = bse.Db2ResEmpty;
                CurrentZone.MediumWater = bse.Db2ResMedium;
                CurrentZone.HighWater = bse.Db2ResFull;
                CurrentZone.WateringPump = sw.St2p2;
                CurrentZone.SelectorName = "DB2";
                CurrentZone.TestingPump = sw.St2p4;
                CurrentZone.SecondsFromLowToMediumOnTestingZone = 8.868M;
                CurrentZone.SecondsFromHighToMediumOnBucket = 31.88M;
                CurrentZone.NutrientMix = NutrientMixes.BloomingAndRipening;
                return CurrentZone;
            }
            if (ise.ReservoirRes.State == "DB3")
            {
                CurrentZone.LowWater = bse.Db5ResEmpty;
                CurrentZone.MediumWater = bse.Db5ResMedium;
                CurrentZone.HighWater = bse.Db5ResFull;
                CurrentZone.WateringPump = sw.St3p2;
                CurrentZone.SelectorName = "DB3";
                CurrentZone.TestingPump = sw.St3p4;
                CurrentZone.SecondsFromLowToMediumOnTestingZone = 10.477M;
                CurrentZone.SecondsFromHighToMediumOnBucket = 44.66M;
                CurrentZone.NutrientMix = NutrientMixes.BloomingAndRipening;
                return CurrentZone;
            }
            if (ise.ReservoirRes.State == "DB4")
            {
                CurrentZone.LowWater = bse.Db4ResEmpty;
                CurrentZone.MediumWater = bse.Db4ResMedium;
                CurrentZone.HighWater = bse.Db4ResFull;
                CurrentZone.WateringPump = sw.St3p1;
                CurrentZone.SelectorName = "DB4";
                CurrentZone.TestingPump = sw.St3p3;
                CurrentZone.SecondsFromLowToMediumOnTestingZone = 10.896M;
                CurrentZone.SecondsFromHighToMediumOnBucket = 41.53M;
                CurrentZone.NutrientMix = NutrientMixes.BloomingAndRipening;
                return CurrentZone;
            }
            if (ise.ReservoirRes.State == "DB5")
            {
                CurrentZone.LowWater = bse.Db3ResEmpty;
                CurrentZone.MediumWater = bse.Db3ResMedium;
                CurrentZone.HighWater = bse.Db3ResFull;
                CurrentZone.WateringPump = sw.St1p1;
                CurrentZone.SelectorName = "DB5";
                CurrentZone.TestingPump = sw.PowerStrip1Outlet3;
                CurrentZone.SecondsFromLowToMediumOnTestingZone = 11.08M;
                CurrentZone.SecondsFromHighToMediumOnBucket = 45.45M;
                CurrentZone.NutrientMix = NutrientMixes.BloomingAndRipening;
                return CurrentZone;
            }
            if (ise.ReservoirRes.State == "DB6")
            {
                CurrentZone.LowWater = bse.Db6ResEmpty;
                CurrentZone.MediumWater = bse.Db6ResMedium;
                CurrentZone.HighWater = bse.Db6ResFull;
                CurrentZone.WateringPump = sw.St1p3;
                CurrentZone.SelectorName = "DB6";
                CurrentZone.TestingPump = sw.PowerStripMidOutlet3;
                CurrentZone.SecondsFromHighToMediumOnBucket = 51.656M;
                CurrentZone.SecondsFromLowToMediumOnTestingZone = 12.465M;
                CurrentZone.NutrientMix = NutrientMixes.BloomingAndRipening;
                return CurrentZone;
            }
            if (ise.ReservoirRes.State == "NFT")
            {
                CurrentZone.LowWater = bse.NftResEmpty;
                CurrentZone.MediumWater = bse.NftResMedium;
                CurrentZone.HighWater = bse.NftResFull;
                CurrentZone.WateringPump = null;
                CurrentZone.SelectorName = "NFT";
                CurrentZone.TestingPump = null;
                CurrentZone.SecondsFromHighToMediumOnBucket = 0;
                CurrentZone.SecondsFromLowToMediumOnTestingZone = 0;
                CurrentZone.NutrientMix = NutrientMixes.MildVegatativeGrowth;
                return CurrentZone;
            }
            else
            {
                _logger.LogError("No Zone is currently Selected");
                return CurrentZone;
            }


        }
    }


}