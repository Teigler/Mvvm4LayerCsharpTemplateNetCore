
namespace Mvvm4TierCsharpTemplate2.DataAccess.API
{
    internal static class DataAccessFactory
    {
        internal static DataAccess CreateDataAccess()
        {
            return new DataAccess();
        }
    }
}