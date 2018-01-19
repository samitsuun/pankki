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

        public Pankkitili tili1;

        // OneTimeSetUp
        // OneTimeTearDown
        // TearDown 
        [SetUp]
        public void TestienAlustaja()
        {
            this.tili1 = new Pankkitili(100);
        }

        [Test]
        public void LuoPankkitili()
        {
            // Testataan olion luokan tyyppi
            Assert.IsInstanceOf<Pankkitili>(tili1);
        }

        [Test]
        public void AsetaPankkitililleAlkusaldo()
        {
            Assert.That(100, Is.EqualTo(tili1.Saldo));
        }

        [Test]
        public void TalletaRahaaPankkitilille()
        {
            // Talletetaan rahaa tilille.
            tili1.Talleta(134);

            // Testataan arvon yhtäsuuruutta.
            Assert.That(234, Is.EqualTo(tili1.Saldo));
        }

        [Test]
        public void NostaRahaaPankkitililta()
        {
            // Nostetaan tilitä 50.
            tili1.NostaRahaa(50);

            Assert.That(50, Is.EqualTo(tili1.Saldo));
        }

        [Test]
        public void TiliEiMiinukselle()
        {
            // Testataan antaako ohjelma halutun virhetyypin.
            Assert.Throws<ArgumentException>(() => tili1.NostaRahaa(125));
            // Vaikka virhe sattuu niin raheita ei menetetä.
            // Pitäisi olla loppusaldon kanssa sama.
            Assert.That(100, Is.EqualTo(tili1.Saldo));
        }

    }
}
