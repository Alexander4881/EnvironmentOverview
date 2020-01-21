using System;

namespace EnvironmentOverview.Model.Classes
{
    public class LuminateData : BaseEntity
    {
        // Attributes
        private int data;
        private DateTime updated;

        // Properties
        public int Data { get => data; set => data = value; }
        public DateTime Updated { get => updated; set => updated = value; }

        // Constructor
        public LuminateData(int id, int data, DateTime updated) : base(id)
        {
            Data = data;
            Updated = updated;
        }
    }
}