using Interview.Repository;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace Interview
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            container.RegisterType<IPaymentRepository, PaymentRepository>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}