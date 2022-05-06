using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Practices.Unity;
using TestUsersCopy.Controllers;
using TestUsersCopy.Data.Repositories;
using TestUsersCopy.Models;
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
            container.RegisterType<IMotorcycleRepository, MotorcycleRepository>();
            container.RegisterType<IBrandRepository, BrandRepository>();
            container.RegisterType<IDealerRepository, DealerRepository>();
            container.RegisterType<ICategoryRepository, CategoryRepository>();
            container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>(new HierarchicalLifetimeManager());
            container.RegisterType<AccountController>(new InjectionConstructor());

            ////This was suppose to be used for refactoring the project in order to implement DI. But I undo it and it's dependencies for now.
            //container.RegisterType<IDbCommon<MotorcycleVM>, DbCommon<MotorcycleVM>>();

            RegisterTypes(container);

            return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
    
    }
  }
}