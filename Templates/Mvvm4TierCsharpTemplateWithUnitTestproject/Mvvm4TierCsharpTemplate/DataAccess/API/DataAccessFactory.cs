namespace $safeprojectname$.DataAccess.API
{
    internal static class DataAccessFactory
    {
        internal static IDataAccess CreateDataAccess()
        {
            return new $safeprojectname$.DataAccess.API.DataAccess();
        }
    }
}