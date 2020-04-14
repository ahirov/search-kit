// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) Anton Hirov

using System.Reflection;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using SearchKit.Service.IoC;

namespace SearchKit.IoC
{
    internal static class SearchKitModule
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();
            var assembly = Assembly.GetExecutingAssembly();

            builder.RegisterControllers(assembly);
            builder.RegisterModule<AutofacWebTypesModule>();
            builder.RegisterModule<SearchKitServiceModule>();

            builder.RegisterAssemblyTypes(assembly)
                   .Where(_ => _.Name.EndsWith("Converter"))
                   .AsImplementedInterfaces();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}