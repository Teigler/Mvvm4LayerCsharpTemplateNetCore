using Mvvm4TierCsharpTemplate.BusinessLogic.API;
using NSubstitute;
using NUnit.Framework;

namespace Mvvm4TierCsharpTemplateUnitTest.PresentationLogic.API
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


        private Mvvm4TierCsharpTemplate.PresentationLogic.API.PresentationLogic CreatePresentationLogic(IBusinessLogic fakeBusinessLogic = null)
        {
            fakeBusinessLogic ??= Substitute.For<IBusinessLogic>();
            return new Mvvm4TierCsharpTemplate.PresentationLogic.API.PresentationLogic(fakeBusinessLogic);
        }
    }
}