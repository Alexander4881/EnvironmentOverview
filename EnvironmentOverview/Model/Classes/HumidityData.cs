using System;

namespace EnvironmentOverview.Model.Classes
{
    public class HumidityData : BaseEntity
    {
        // Attributes
        private float data;
        private DateTime updated;

        // Properties
        public float Data { get => data; set => data = value; }
        public DateTime Updated { get => updated; set => updated = value; }

        // Constructor
        public HumidityData(int id, float data, DateTime updated) : base(id)
        {
            Data = data;
            Updated = updated;
        }
    }
}