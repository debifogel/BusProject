namespace Buses.Core.classes
{
    public class Street
    {
        static int count = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public List<Station> ListOfStation { get; set; }
        public Street(string name, string city)
        {
            Id = count++;
            Name = name;
            City = city;
            ListOfStation = new List<Station>();
        }
    }
}
