using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buses.Core.classes
{
    public enum StatusOfStation
    {
        הורדה,
        עליה,
        רגיל
    }
    public class StationAndi
    {
        public Station BusStop { get; set; }
        public int Id { get; set; }
        public StatusOfStation Status { get; set; }
        public StationAndi()
        {
        }

        public StationAndi(Station busStop, int id,StatusOfStation status)
        {
            BusStop = busStop;
            Id = id;
            Status = status;
        }

        

    }
}
