using Mvvm4TierCsharpTemplate2.DataAccess.API;
using NUnit.Framework;

namespace Mvvm4TierCsharpTemplate2UnitTest.DataAccess.API
{
    [TestFixture]
    public class DataAccessFactoryTest
    {
        [Test]
        public void CreateDataAccess_ReturnNewDataAccessCorrectType_Returned()
        {
            
            Assert.That(DataAccessFactory.CreateDataAccess(), Is.InstanceOf(typeof(Mvvm4TierCsharpTemplate2.DataAccess.API.DataAccess)));
        }
    }
}