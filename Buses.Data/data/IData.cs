using static System.Collections.Specialized.BitVector32;
using System.IO;
using Buses.Core.classes;
using Microsoft.EntityFrameworkCore;
namespace Buses.Data.data
{
    public interface IData
    {
        public DbSet<Bus> buses { get; set; }

        public DbSet<Street> streets { get; set; }

        public DbSet<Station> stations { get; set; }
    }
}
