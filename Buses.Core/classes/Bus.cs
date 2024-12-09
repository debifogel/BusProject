namespace Buses.Core.classes
{

}

namespace Buses.Core.classes
{
    public enum CompanyName
    {
        Dan, Afikim, Eged
    };
    //להוסיף  enum ושמות ליעד ומוצא
    public class Bus
    {
        static int countBuses = 0;
        public int Id { get; set; }
        public string BusName { get; set; }
        public string Destination { get; set; }
        public string Source { get; set; }
        public List<StationAndi> Listofstation { get; set; }
        public CompanyName Company { get; set; }
        public TimeOfBus Timings { get; set; }
        public bool IsActive { get; set; }
        public Bus()
        {
            Listofstation= new List<StationAndi>();
            Id = ++countBuses;
        }


    }
}
