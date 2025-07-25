using Autofac;

namespace LineNex.Infrastructure.CrossCutting.IOCs
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigurationIOC.Load(builder);
        }
    }
}