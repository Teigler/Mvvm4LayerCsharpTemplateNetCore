using Mvvm4TierCsharpTemplate.DataAccess.API;

namespace Mvvm4TierCsharpTemplate.BusinessLogic.API
{
    internal static class BusinessLogicFactory
    {
        internal static IBusinessLogic CreateBusinessLogic()
        {
            var dataAccess = DataAccessFactory.CreateDataAccess();
            return new Mvvm4TierCsharpTemplate.BusinessLogic.API.BusinessLogic(dataAccess);
        }
    }
}