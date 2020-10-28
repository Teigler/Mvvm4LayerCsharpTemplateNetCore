using Mvvm4TierCsharpTemplate2.PresentationLogic.API;
using NUnit.Framework;

namespace $safeprojectname$.PresentationLogic.API
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