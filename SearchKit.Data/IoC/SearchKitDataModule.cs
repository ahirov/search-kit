// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) Anton Hirov

using System.Reflection;
using Autofac;
using Module = Autofac.Module;

namespace SearchKit.Data.IoC
{
    public class SearchKitDataModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly)
                   .Except<SearchKitDbContext>()
                   .AsImplementedInterfaces()
                   .SingleInstance();

            builder.RegisterType<SearchKitDbContext>()
                   .AsImplementedInterfaces()
                   .InstancePerLifetimeScope();
        }
    }
}