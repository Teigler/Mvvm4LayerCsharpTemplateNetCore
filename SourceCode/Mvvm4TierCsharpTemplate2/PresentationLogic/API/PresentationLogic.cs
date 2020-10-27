
namespace Mvvm4TierCsharpTemplate2.PresentationLogic.API
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
