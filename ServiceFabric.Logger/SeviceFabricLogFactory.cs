﻿using System;
using Logger.Base;

namespace Logger.ServiceFabric
{
    public class ConcreteFactoryServiceFabricEventSource : ILogFactory
    {
        private readonly object _serviceContext;

        public ConcreteFactoryServiceFabricEventSource(object serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public ILogInternal GetLogger() //Factory Method Implementation 
        {
            var serviceFabricLogInstance = ServiceFabricEventSource.Current;
            serviceFabricLogInstance.SetServiceContext(_serviceContext);
            return serviceFabricLogInstance;
        }
    }
}