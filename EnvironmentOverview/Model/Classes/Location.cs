namespace EnvironmentOverview.Model.Classes
{
    public class Location : BaseEntity
    {
        // Attributes
        private string country;
        private string town;
        private string roomLocation;

        // Properties
        public string Country { get => country; set => country = value; }
        public string Town { get => town; set => town = value; }
        public string RoomLocation { get => roomLocation; set => roomLocation = value; }

        // Constructor
        public Location(int id, string country, string town, string roomLocation) : base(id)
        {
            Country = country;
            Town = town;
            RoomLocation = roomLocation;
        }
    }
}