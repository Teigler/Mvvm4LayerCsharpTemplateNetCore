using Mvvm4TierCsharpTemplate.PresentationLogic.API;
using NUnit.Framework;

namespace Mvvm4TierCsharpTemplateUnitTest.PresentationLogic.API
{
    [TestFixture]
    public class PresentationLogicFactoryTest
    {
        [Test]
        public void CreatePresentationLogic_ReturnNewBusinessLogicCorrectType_Returned()
        {
            Assert.That(PresentationLogicFactory.CreatePresentationLogic(), Is.InstanceOf(typeof(IPresentationLogic)));
        }
    }
}