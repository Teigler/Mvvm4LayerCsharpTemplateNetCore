using Mvvm4TierCsharpTemplate2.BusinessLogic.API;
using Mvvm4TierCsharpTemplate2.PresentationLogic.API;
using NUnit.Framework;

namespace Mvvm4TierCsharpTemplate2UnitTest.BusinessLogic.API
{
    [TestFixture]
    public class BusinessLogicFactoryTest
    {
        [Test]
        public void CreateBusinessLogic_ReturnNewBusinessLogicCorrectType_Returned()
        {
            Assert.That(BusinessLogicFactory.CreateBusinessLogic(), Is.InstanceOf(typeof(IBusinessLogic)));
        }

       
    }
}