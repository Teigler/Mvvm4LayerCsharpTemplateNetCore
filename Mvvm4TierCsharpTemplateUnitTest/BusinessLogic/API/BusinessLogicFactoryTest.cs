using Mvvm4TierCsharpTemplate.BusinessLogic.API;
using NUnit.Framework;

namespace Mvvm4TierCsharpTemplateUnitTest.BusinessLogic.API
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