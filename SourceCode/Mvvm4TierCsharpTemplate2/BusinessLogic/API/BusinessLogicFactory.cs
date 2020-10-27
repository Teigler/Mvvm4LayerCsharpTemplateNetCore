using Mvvm4TierCsharpTemplate2.DataAccess.API;
using Mvvm4TierCsharpTemplate2.PresentationLogic.API;

namespace Mvvm4TierCsharpTemplate2.BusinessLogic.API
{
    internal static class BusinessLogicFactory
    {
        internal static IBusinessLogic CreateBusinessLogic()
        {
            var dataAccess = DataAccessFactory.CreateDataAccess();
            return new Mvvm4TierCsharpTemplate2.BusinessLogic.API.BusinessLogic(dataAccess);
        }
    }
}