using Mvvm4TierCsharpTemplate2.PresentationLogic.API;
using NSubstitute;
using NUnit.Framework;

namespace $safeprojectname$.PresentationLogic.API
{
    [TestFixture]
    public class PresentationLogicTest
    {
        [Test]
        public void PresentationLogic_Standard_AllPropertiesInitialized()
        {
            var mockBusinessLogic = Substitute.For<IBusinessLogic>();
            var systemUnderTest = CreatePresentationLogic(mockBusinessLogic);
           
            Assert.AreEqual(mockBusinessLogic, systemUnderTest.BusinessLogic, "Property: \"" + nameof(systemUnderTest.BusinessLogic) + "\" was NOT initialized correctly!");
        }


        private Mvvm4TierCsharpTemplate2.PresentationLogic.API.PresentationLogic CreatePresentationLogic(IBusinessLogic fakeBusinessLogic = null)
        {
            fakeBusinessLogic ??= Substitute.For<IBusinessLogic>();
            return new Mvvm4TierCsharpTemplate2.PresentationLogic.API.PresentationLogic(fakeBusinessLogic);
        }
    }
}