using Mvvm4TierCsharpTemplate.DataAccess.API;
using NUnit.Framework;

namespace Mvvm4TierCsharpTemplateUnitTest.DataAccess.API
{
    [TestFixture]
    public class DataAccessFactoryTest
    {
        [Test]
        public void CreateDataAccess_ReturnNewDataAccessCorrectType_Returned()
        {
            Assert.That(DataAccessFactory.CreateDataAccess(), Is.InstanceOf(typeof(IDataAccess)));
        }
    }
}