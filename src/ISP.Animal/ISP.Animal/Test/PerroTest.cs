using ISP.Animal.Model;
using NUnit.Framework;

namespace ISP.Animal.Test
{
    [TestFixture]
    class PerroTest
    {
        [Test]
        public void sinAlimentarNiAcariciar()
        {
            Perro p = new Perro();
            Assert.That(p.GetEstado(), Is.EqualTo("quiero un hueso y quiero jugar"));
        }

        [Test]
        public void alimentado()
        {
            Perro p = new Perro();
            p.Alimentar();
            Assert.That(p.GetEstado(), Is.EqualTo("no quiero un hueso y quiero jugar"));
        }

        [Test]
        public void alimentadoYacariciado()
        {
            Perro p = new Perro();
            p.Alimentar();
            p.Acariciar();
            Assert.That(p.GetEstado(), Is.EqualTo("no quiero un hueso"));
        }
    }
}
