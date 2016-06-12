using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.Text;

namespace NorthwindClient
{
    public static class ServiceFactory
    {
        private static readonly ClientSection _clientSection = ConfigurationManager.GetSection("system.serviceModel/client") as ClientSection;
        private static readonly BindingsSection _bindingSection = ConfigurationManager.GetSection("system.serviceModel/bindings") as BindingsSection;
        public static T Create<T>()
        {
            T context = default(T);
            foreach (ChannelEndpointElement endpoint in _clientSection.Endpoints)
            {
                if (endpoint.Contract == typeof(T).FullName)
                {
                    Binding b = BindingFactory.GetFromConfig(endpoint.BindingConfiguration);
                    context = ChannelFactory<T>.CreateChannel(b, new EndpointAddress(endpoint.Address));
                }
            }
            return context;
        }
        public static class BindingFactory
        {
            public static Binding GetFromConfig(string configurationName)
            {
                var bingingsSection = BindingsSection.GetSection(ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None));
                var bindingType = (from b in bingingsSection.BindingCollections
                                   where b.ConfiguredBindings.Count > 0 && b.ContainsKey(configurationName)
                                   select b.BindingType).FirstOrDefault();
                var binding = bindingType != null ? Activator.CreateInstance(bindingType, configurationName) : null;
                return (Binding)binding;
            }
        }
    }
}
