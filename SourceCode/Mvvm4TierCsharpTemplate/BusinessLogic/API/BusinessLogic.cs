using Mvvm4TierCsharpTemplate.DataAccess.API;

namespace Mvvm4TierCsharpTemplate.BusinessLogic.API
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
