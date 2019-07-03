using Autofac;
using Autofac.Integration.Mvc;
using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web
{
    public class ContainerConfig
    {
        internal static void RegisterContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<InMemoryRestaurantData>()
                   .As<IRestaurantData>()
                   .SingleInstance();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}