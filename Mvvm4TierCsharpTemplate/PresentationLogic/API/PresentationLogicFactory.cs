using Mvvm4TierCsharpTemplate.BusinessLogic.API;

namespace Mvvm4TierCsharpTemplate.PresentationLogic.API
{
    internal static class PresentationLogicFactory
    {
        internal static IPresentationLogic CreatePresentationLogic()
        {
            var businessLogic = BusinessLogicFactory.CreateBusinessLogic();
            return new Mvvm4TierCsharpTemplate.PresentationLogic.API.PresentationLogic(businessLogic);
        }
    }
}