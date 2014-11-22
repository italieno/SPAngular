using System.Linq;
using NUnit.Framework;
using SPA.Infra.Services;

namespace SPA.Unit.Test.Services
{
    [TestFixture]
    public class DoSomehtingServiceTest
    {
        private IDoSomethingService _doSomethingService;

        [SetUp]
        public void GivenADoSomethingService()
        {
            _doSomethingService = new DoSomethingService();
        }

        [Test]
        public void ItShouldReturnACollectionOfItem()
        {
            var items = _doSomethingService.ReturnSomething();
            Assert.IsTrue(items.Any());
        }

    }
}