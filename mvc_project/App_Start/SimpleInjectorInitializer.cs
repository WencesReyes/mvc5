[assembly: WebActivator.PostApplicationStartMethod(typeof(mvc_project.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace mvc_project.App_Start
{
    using System.Net.Http;
    using System.Reflection;
    using System.Web.Mvc;
    using Microsoft.Extensions.DependencyInjection;
    using mvc_project.Repositories;
    using mvc_project.Services;
    using SimpleInjector;
    using SimpleInjector.Integration.Web;
    using SimpleInjector.Integration.Web.Mvc;
    
    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            
            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            
            container.Verify();
            
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
     
        private static void InitializeContainer(Container container)
        {
            // For instance:
            // container.Register<IUserRepository, SqlUserRepository>(Lifestyle.Scoped);
            var serviceProvider = new ServiceCollection().AddHttpClient().BuildServiceProvider();
            container.RegisterSingleton(() => serviceProvider.GetRequiredService<IHttpClientFactory>());
            container.ContainerScope.RegisterForDisposal(serviceProvider);

            container.Register<IMovieRepository, MovieRepository>(Lifestyle.Scoped);
            container.Register<IMovieService, MovieService>(Lifestyle.Scoped);
        }
    }
}