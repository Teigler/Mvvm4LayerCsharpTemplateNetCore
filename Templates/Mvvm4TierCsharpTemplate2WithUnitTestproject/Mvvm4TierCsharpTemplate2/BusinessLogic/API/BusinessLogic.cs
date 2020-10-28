using $safeprojectname$.DataAccess.API;
using $safeprojectname$.PresentationLogic.API;

namespace $safeprojectname$.BusinessLogic.API
{
    internal class BusinessLogic : IBusinessLogic
    {

        internal BusinessLogic(IDataAccess dataAccess)
        {
            DataAccess = dataAccess;
        }


        internal IDataAccess DataAccess { get; private set; }

    }
}
