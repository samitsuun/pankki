using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PankkitiliSovellus
{
    public class Pankkitili
    {
        public Pankkitili(int alkusaldo)
        {
            Saldo = alkusaldo;
        }


        public int Saldo { get; set; }

        public void Talleta(int maara)
        {
            Saldo += maara;
            // sama kuin (Saldo = Saldo + maara).
        }

        public void NostaRahaa (int maara)
        {
            Saldo -= maara;
        }
    }
}
