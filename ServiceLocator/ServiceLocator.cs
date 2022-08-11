using System;
using System.Collections.Generic;

namespace ServiceLocator
{
    public class ServiceLocator
    {
        private static ServiceLocator _instance;
        public static ServiceLocator Instance => _instance ??= new ServiceLocator();
        private readonly Dictionary<Type, object> _services;

        public ServiceLocator()
        {
            _services = new Dictionary<Type, object>();
        }

        public T GetService<T>()
        {
            Type key = typeof(T);
            if(!_services.TryGetValue(key, out var service))
            {
                string message = $"Service {key} not found";
                throw new Exception(message);
            }
            else
            {
                return (T)service;
            }
        }

        public void RegisterService<T>(T service)
        {
            Type key = typeof(T);
            if (!_services.ContainsKey(key))
            {
                _services.Add(key, service);
            }
        }
    }
}
