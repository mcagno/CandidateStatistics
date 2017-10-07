using System.Web.Http;
using System.Web.Http.Cors;
using CandidatesManager;
using CandidateStatisticManager.WebAPI.Controllers;
using Microsoft.Practices.Unity;

namespace CandidateStatisticManager.WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Web API enable cors to allow full access
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            // Web API configuration and services
            var container = new UnityContainer();
            container.RegisterType<IEntryValidator, EntryValidator>(new InjectionConstructor());
            container.RegisterType<ICandidateRepository, DummyCandidateRepository>();
            container.RegisterType<ICandidateStatisticManager, CandidatesManager.CandidateStatisticManager>();
            container.RegisterType<CandidateStatisticController>();
            config.DependencyResolver = new UnityResolver(container);
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
