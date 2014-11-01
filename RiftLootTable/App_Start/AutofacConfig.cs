using Autofac;
using Autofac.Integration.Mvc;
using RiftLootTable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace RiftLootTable.App_Start
{
    public class AutofacConfig
    {
        public static void Configure()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<RiftLootTableContext>().InstancePerRequest();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
        }
    }
}