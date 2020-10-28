using $safeprojectname$.DataAccess.API;
using $safeprojectname$.PresentationLogic.API;

namespace $safeprojectname$.BusinessLogic.API
{
    internal static class BusinessLogicFactory
    {
        internal static IBusinessLogic CreateBusinessLogic()
        {
            var dataAccess = DataAccessFactory.CreateDataAccess();
            return new $safeprojectname$.BusinessLogic.API.BusinessLogic(dataAccess);
        }
    }
}