using $safeprojectname$.DataAccess.API;

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
