using Mvvm4TierCsharpTemplate.BusinessLogic.API;

namespace Mvvm4TierCsharpTemplate.PresentationLogic.API
{
    internal class PresentationLogic : IPresentationLogic
    {
        internal PresentationLogic(IBusinessLogic businessLogic)
        {
            BusinessLogic = businessLogic;
        }

        internal IBusinessLogic BusinessLogic { get; private set; }
    }
}
