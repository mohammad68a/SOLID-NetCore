using NUnit.Framework;

namespace DIP.Controller
{
    [TestFixture]
    class DinnerControllerTest
    {
        [Test]
        public void GetByIdTest()
        {
            DinnersController dinnersController = new DinnersController();
            Assert.That(dinnersController.GetById(1).Name, Is.EqualTo("cumpleaños"));
        }
    }
}
