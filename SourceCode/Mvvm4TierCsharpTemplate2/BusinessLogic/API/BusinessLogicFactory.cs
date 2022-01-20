using Mvvm4TierCsharpTemplate2.DataAccess.API;


namespace Mvvm4TierCsharpTemplate2.BusinessLogic.API
{
    internal static class BusinessLogicFactory
    {
        internal static BusinessLogic CreateBusinessLogic()
        {
            var dataAccess = DataAccessFactory.CreateDataAccess();
            return new Mvvm4TierCsharpTemplate2.BusinessLogic.API.BusinessLogic(dataAccess);
        }
    }
}