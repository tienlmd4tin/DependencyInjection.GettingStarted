using Castle.Core.Resource;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;

namespace DependencyInjection.GettingStarted
{
    public static class IoC
    {
        public static IWindsorContainer Container
        {
            get
            {
                IWindsorContainer containerAccessor = new WindsorContainer(new XmlInterpreter(new ConfigResource("castle")));
                return containerAccessor;
            }
        }
    }
}