using System.ComponentModel.DataAnnotations.Schema;

namespace Buses.Core.classes
{
    //1-א-ה
    //2-ו
    //3-מוצש
    public class TimeOfBus
    {
        [NotMapped]
        public int[,] Schedule { get; set; }
        public TimeOfBus()
        {
            Schedule=new int[3,3];
        }

    }
}
