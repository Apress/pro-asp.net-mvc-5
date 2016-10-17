using System.Web.Mvc;

namespace MvcModels.Infrastructure {
    public class CustomValueProviderFactory : ValueProviderFactory {

        public override IValueProvider GetValueProvider(ControllerContext
                controllerContext) {
            return new CountryValueProvider();
        }
    }
}
