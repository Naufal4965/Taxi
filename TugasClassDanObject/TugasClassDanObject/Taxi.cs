using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasClassDanObject
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public Boolean OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("\n Taxi Info \n");
            Console.WriteLine("Nama Driver: {0}", DriverName);

            if(OnDuty==true)
            {
                Console.WriteLine("Kerja : Iya", OnDuty);
            }
            else
            {
                Console.WriteLine("Kerja : Tidak", OnDuty);
            }
            Console.WriteLine("Nomor Pelanggan : {0}", NumPassenger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
    }
}
