using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnvironmentOverview.Model.Classes
{
    public class FullDevice : Device
    {
        // Attributes
        private List<HumidityData> humidityData;
        private List<TemperatureData> temperatureData;
        private List<NoiseData> noiseData;
        private List<LuminateData> luminateData;

        // Propterties
        public List<LuminateData> LuminateData { get => luminateData; set => luminateData = value; }
        public List<NoiseData> NoiseData { get => noiseData; set => noiseData = value; }
        public List<TemperatureData> TemperatureData { get => temperatureData; set => temperatureData = value; }
        public List<HumidityData> HumidityData { get => humidityData; set => humidityData = value; }

        // Constructor
        public FullDevice(int id, string name, DateTime lastPing, string description, DeviceType deviceType, Location location, List<LuminateData> luminateData, List<NoiseData> noiseData, List<TemperatureData> temperatureData, List<HumidityData> humidityData) : base(id, name, lastPing, description, deviceType, location)
        {
            LuminateData = luminateData;
            NoiseData = noiseData;
            TemperatureData = temperatureData;
            HumidityData = humidityData;
        }
    }
}
