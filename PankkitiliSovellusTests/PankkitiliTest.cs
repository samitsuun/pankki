using NUnit.Framework;
using PankkitiliSovellus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PankkitiliSovellusTests
{
    [TestFixture]
    public class PankkitiliTest
    {
        /* PankkitiliSovellus sisältää:
         *
         *  Luokka, jonka nimi on Pankkitili.
         *  Pankkitilissä on kolme toimintoa.
         *  
         *  -Tallettaa rahaa
         *  -Nostaa rahaa
         *  -- Tarkistetaan ettei tili mene miinukselle
         *  -Siirtää rahaa tililtä toiselle
         *  -- Tarkistetaan ettei tili mene miinukselle
         *  
         */

        [Test]
        public void LuoPankkitili()
        {
            Pankkitili tili1 = new Pankkitili(0);

            // Testataan olion luokan tyyppi
            Assert.IsInstanceOf<Pankkitili>(tili1);
        }

        [Test]
        public void AsetaPankkitililleAlkusaldo()
        {
            Pankkitili tili1 = new Pankkitili(500);

            Assert.That(500, Is.EqualTo(tili1.Saldo));
        }

    }
}
