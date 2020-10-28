
namespace $safeprojectname$.PresentationLogic.API
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
