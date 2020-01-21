namespace EnvironmentOverview.Model.Classes
{
    public class DeviceType : BaseEntity
    {
        // Attributes
        private string name;
        private string description;

        // Properties
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }

        // Constructor
        public DeviceType(int id, string name, string description) : base(id)
        {
            Name = name;
            Description = description;
        }
    }
}