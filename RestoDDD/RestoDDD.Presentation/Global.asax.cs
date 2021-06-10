using Ioc;
using Microsoft.Practices.Unity;
using RestoDDD.Application.AutoMapper;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace RestoDDD.Presentation
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            IUnityContainer container = new UnityContainer();
            Ioc.IoC i = new IoC(container);
            i.ResgitreType();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            //AutoMapper
            AutoMapperWebConfiguration.Configure();
        }
    }
}
