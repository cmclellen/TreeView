using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace CompanyABC.TreeView.Web.DependencyResolution
{
    public class ServiceActivator : IHttpControllerActivator
    {
        public ServiceActivator(IContainer container)
        {
            Container = container;
        }

        IContainer Container
        {
            get;
            set;
        }

        public IHttpController Create(HttpRequestMessage request
            , HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            var controller = Container.GetInstance(controllerType) as IHttpController;
            return controller;
        }
    }
}