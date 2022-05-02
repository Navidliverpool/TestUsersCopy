using System.Web.Mvc;
using Microsoft.Practices.Unity;
using TestUsersCopy.Data.Repositories;
using Unity.Mvc4;

namespace TestUsersCopy
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();

      // register all your components with the container here
      // it is NOT necessary to register your controllers

      // e.g. container.RegisterType<ITestService, TestService>();    
      RegisterTypes(container);
            container.RegisterType<IMotorcycleRepository, MotorcycleRepository>();
            container.RegisterType<IBrandRepository, BrandRepository>();
            container.RegisterType<IDealerRepository, DealerRepository>();
            container.RegisterType<ICategoryRepository, CategoryRepository>();

            return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
    
    }
  }
}