using $safeprojectname$.BusinessLogic.API;

namespace $safeprojectname$.PresentationLogic.API
{
    internal static class PresentationLogicFactory
    {
        internal static IPresentationLogic CreatePresentationLogic()
        {
            var businessLogic = BusinessLogicFactory.CreateBusinessLogic();
            return new $safeprojectname$.PresentationLogic.API.PresentationLogic(businessLogic);
        }
    }
}