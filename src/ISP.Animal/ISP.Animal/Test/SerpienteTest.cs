using ISP.Animal.Model;
using NUnit.Framework;

namespace ISP.Animal.Test
{
    [TestFixture]
    class SerpienteTest
    {
        [Test]
        public void sinAlimentar()
        {
            Serpiente s = new Serpiente();
            Assert.That(s.GetEstado(), Is.EqualTo("quiero una rata"));
        }

        [Test]
        public void alimentado()
        {
            Serpiente s = new Serpiente();
            s.Alimentar();
            Assert.That(s.GetEstado(), Is.EqualTo("no quiero una rata"));
        }
    }
}
