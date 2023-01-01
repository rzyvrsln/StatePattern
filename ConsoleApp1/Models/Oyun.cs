using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Oyun
    {
        public Interface1 interface1;


        public Oyun()
        {
            Console.WriteLine("Oyun basladi..");

            interface1 = new Hucum();
        }

        public void ucbucaqaBas()
        {
            interface1.UcbucaqaBas();
        }
        public void dordbucaqBas()
        {
            interface1.DordbucaqaBas();
        }
        public void yumruyaBas()
        {
            interface1.YumruyaBas();
        }
        public void XBas()
        {
            interface1.XBas();
        }

        public void TopuEleKecir()
        {
            Console.WriteLine("Top ele kecirildi. Hucuma kecirilir..");
            interface1 = new Hucum();
        }
        public void TopItirildi()
        {
            Console.WriteLine("Oyuncular mudafieye cekilirler..");
            interface1 = new Mudafie();
        }

    }
}
