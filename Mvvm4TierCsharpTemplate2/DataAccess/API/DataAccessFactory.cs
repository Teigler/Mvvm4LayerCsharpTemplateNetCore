using Mvvm4TierCsharpTemplate2.BusinessLogic.API;

namespace Mvvm4TierCsharpTemplate2.DataAccess.API
{
    internal static class DataAccessFactory
    {
        internal static IDataAccess CreateDataAccess()
        {
            return new Mvvm4TierCsharpTemplate2.DataAccess.API.DataAccess();
        }
    }
}