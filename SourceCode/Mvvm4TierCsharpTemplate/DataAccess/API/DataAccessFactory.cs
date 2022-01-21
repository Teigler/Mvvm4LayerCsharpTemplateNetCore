namespace Mvvm4TierCsharpTemplate.DataAccess.API
{
    internal static class DataAccessFactory
    {
        internal static IDataAccess CreateDataAccess()
        {
            return new DataAccess();
        }
    }
}