// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) Anton Hirov

using System.Reflection;
using Autofac;
using SearchKit.Data.IoC;
using Module = Autofac.Module;

namespace SearchKit.Service.IoC
{
    public class SearchKitServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<SearchKitDataModule>();

            var assembly = Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly)
                   .AsImplementedInterfaces()
                   .SingleInstance();
        }
    }
}