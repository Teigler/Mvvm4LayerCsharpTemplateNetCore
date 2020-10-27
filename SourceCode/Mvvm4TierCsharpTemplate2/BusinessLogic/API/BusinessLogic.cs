using Mvvm4TierCsharpTemplate2.DataAccess.API;
using Mvvm4TierCsharpTemplate2.PresentationLogic.API;

namespace Mvvm4TierCsharpTemplate2.BusinessLogic.API
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
