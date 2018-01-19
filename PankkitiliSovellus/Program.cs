using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PankkitiliSovellus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PankkitiliSovellus v1");

            Console.WriteLine("Anna alkusaldon määrä: ");

            string alkusaldo = Console.ReadLine();

            Pankkitili pankkitili1 = new Pankkitili(int.Parse(alkusaldo));

            Console.WriteLine("Tilin 01 alkusaldo on: " + pankkitili1.Saldo);


        }
    }
}
