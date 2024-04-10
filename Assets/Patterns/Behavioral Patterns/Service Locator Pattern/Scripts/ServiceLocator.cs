using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.ServiceLocatorPattern.Example
{
    public static class ServiceLocator
    {
        public static IDictionary<Type, object> Services { get => _services; }
        private static Dictionary<Type, object> _services = new();

        public static void Register<T>(T service)
        {
            if (!_services.ContainsKey(typeof(T)))
            {
                _services[typeof(T)] = service;
            }
        }

        public static T Get<T>()
        {
            return (T)_services[typeof(T)];
        }
    }
}
