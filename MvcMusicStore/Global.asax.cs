using System;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MyLogger;
using Autofac;
using Autofac.Integration.Mvc;
using MvcMusicStore.App_Start;

namespace MvcMusicStore
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            DependencyResolver.SetResolver(DependencyResolverConfig.GetConfiguredDependencyResolver());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //PerformanceCountersConfig.ConfigureCounters();
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exception = Server.GetLastError();
            var logger = DependencyResolver.Current.GetService(typeof(ILogger)) as ILogger;
            logger?.Error(exception);
        }
    }
}
