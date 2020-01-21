using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnvironmentOverview.Model.Classes
{
    public class Device : BaseEntity
    {
        // Attributes
        private string name;
        private DateTime lastPing;
        private string description;
        private DeviceType deviceType;
        private Location location;

        // Properties
        public string Name { get => name; set => name = value; }
        public DateTime LastPing { get => lastPing; set => lastPing = value; }
        public string Description { get => description; set => description = value; }
        public DeviceType DeviceType { get => deviceType; set => deviceType = value; }
        public Location Location { get => location; set => location = value; }

        //Constructor
        public Device(int id, string name, DateTime lastPing, string description, DeviceType deviceType, Location location) : base(id)
        {
            Name = name;
            LastPing = lastPing;
            Description = description;
        }
    }
}
