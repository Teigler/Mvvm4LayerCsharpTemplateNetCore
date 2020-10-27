using Mvvm4TierCsharpTemplate.DataAccess.API;
using NSubstitute;
using NUnit.Framework;

namespace Mvvm4TierCsharpTemplateUnitTest.BusinessLogic.API
{
    [TestFixture]
    public class BusinessLogicTest
    {
        [Test]
        public void BusinessLogic_Standard_AllPropertiesInitialized()
        {
            var mockDataAccess = Substitute.For<IDataAccess>();
            var systemUnderTest = CreateBusinessLogic(mockDataAccess);
           
            Assert.AreEqual(mockDataAccess, systemUnderTest.DataAccess, "Property: \"" + nameof(systemUnderTest.DataAccess) + "\" was NOT initialized correctly!");
        }


        private Mvvm4TierCsharpTemplate.BusinessLogic.API.BusinessLogic CreateBusinessLogic(IDataAccess fakeDataAccess = null)
        {
            fakeDataAccess ??= Substitute.For<IDataAccess>();
            return new Mvvm4TierCsharpTemplate.BusinessLogic.API.BusinessLogic(fakeDataAccess);
        }
    }
}