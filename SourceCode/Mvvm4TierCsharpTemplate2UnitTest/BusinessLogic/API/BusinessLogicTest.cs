using Mvvm4TierCsharpTemplate2.BusinessLogic.API;
using NSubstitute;
using NUnit.Framework;

namespace Mvvm4TierCsharpTemplate2UnitTest.BusinessLogic.API
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


        private Mvvm4TierCsharpTemplate2.BusinessLogic.API.BusinessLogic CreateBusinessLogic(IDataAccess fakeDataAccess = null)
        {
            fakeDataAccess ??= Substitute.For<IDataAccess>();
            return new Mvvm4TierCsharpTemplate2.BusinessLogic.API.BusinessLogic(fakeDataAccess);
        }
    }
}