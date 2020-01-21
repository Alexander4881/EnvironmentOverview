using System;

namespace EnvironmentOverview.Model.Classes
{
    public class TemperatureData : BaseEntity
    {
        // Attributes
        private float data;
        private DateTime updated;

        // Properties
        public float Data { get => data; set => data = value; }
        public DateTime Updated { get => updated; set => updated = value; }
        
        // Constructor
        public TemperatureData(int id, float data, DateTime updated) : base(id)
        {
            Data = data;
            Updated = updated;
        }

    }
}