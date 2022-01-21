using Mvvm4TierCsharpTemplate2.BusinessLogic.API;

namespace Mvvm4TierCsharpTemplate2.PresentationLogic.API
{
    internal static class PresentationLogicFactory
    {
        internal static IPresentationLogic CreatePresentationLogic()
        {
            var businessLogic = BusinessLogicFactory.CreateBusinessLogic();
            return new PresentationLogic(businessLogic);
        }
    }
}