﻿using E_Commerce.Application.Interfaces.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace E_Commerce.Application.Infrastructure.AutoMapper
{
    public static class MapperProfileHelper
    {
        public static IList<Map> LoadStandardMappings(Assembly rootAssembly)
        {
            var types = rootAssembly.GetExportedTypes();

            var mapsFrom = (
                from type in types
                from instance in type.GetInterfaces()
                where
                    instance.IsGenericType && instance.GetGenericTypeDefinition() == typeof(IMapFrom<>)
                    && !type.IsAbstract
                    && !type.IsInterface
                select new Map
                {
                    Source = type.GetInterfaces().First().GetGenericArguments().First(),
                    Destination = type
                }
            ).ToList();

            return mapsFrom;
        }
    }

    public sealed class Map
    {
        public Type Source { get; set; }
        public Type Destination { get; set; }
    }
}
