using AutoMapper;
using Autofac;
using LineNex.Application.Applications;
using LineNex.Application.Interfaces;
using LineNex.Application.Mappers;
using LineNex.Service.Interfaces;
using LineNex.Service.Services;
using LineNex.Infrastructure.Repositories;
using LineNex.Service.Interfaces.Helpers;
using LineNex.Service.Services.Helpers;
using LineNex.Core.Interfaces;
using LineNex.Domain.Entity;
using Microsoft.AspNetCore.Identity;

namespace LineNex.Infrastructure.CrossCutting.IOCs
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfiles>();
            }).CreateMapper())
            .As<IMapper>()
            .InstancePerLifetimeScope();

            #region Application Services
            builder.RegisterType<CompanyApplicationService>().As<ICompanyApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<DistributionPointApplicationService>().As<IDistributionPointApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<DistributionPointMachineApplicationService>().As<IDistributionPointMachineApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<InventoryApplicationService>().As<IInventoryApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<LayoutApplicationService>().As<ILayoutApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<MachineApplicationService>().As<IMachineApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<MachineConnectionApplicationService>().As<IMachineConnectionApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<MachineSensorApplicationService>().As<IMachineSensorApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<MachineSensorDataApplicationService>().As<IMachineSensorDataApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<ProductionLineApplicationService>().As<IProductionLineApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<ProductionLineMachineApplicationService>().As<IProductionLineMachineApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<SensorApplicationService>().As<ISensorApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<TagApplicationService>().As<ITagApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<UserCompanyApplicationService>().As<IUserCompanyApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<UserApplicationService>().As<IUserApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<MachineTagApplicationService>().As<IMachineTagApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<InventoryDistributionPointApplicationService>().As<IInventoryDistributionPointApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<DistributionPointStockApplicationService>().As<IDistributionPointStockApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<RoleApplicationService>().As<IRoleApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<PermissionApplicationService>().As<IPermissionApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<RolePermissionApplicationService>().As<IRolePermissionApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<AuthApplicationService>().As<IAuthApplicationService>().InstancePerLifetimeScope();
            #endregion

            #region Services
            builder.RegisterType<CompanyService>().As<ICompanyService>().InstancePerLifetimeScope();
            builder.RegisterType<DistributionPointService>().As<IDistributionPointService>().InstancePerLifetimeScope();
            builder.RegisterType<DistributionPointMachineService>().As<IDistributionPointMachineService>().InstancePerLifetimeScope();
            builder.RegisterType<InventoryService>().As<IInventoryService>().InstancePerLifetimeScope();
            builder.RegisterType<LayoutService>().As<ILayoutService>().InstancePerLifetimeScope();
            builder.RegisterType<MachineService>().As<IMachineService>().InstancePerLifetimeScope();
            builder.RegisterType<MachineConnectionService>().As<IMachineConnectionService>().InstancePerLifetimeScope();
            builder.RegisterType<MachineSensorService>().As<IMachineSensorService>().InstancePerLifetimeScope();
            builder.RegisterType<MachineSensorDataService>().As<IMachineSensorDataService>().InstancePerLifetimeScope();
            builder.RegisterType<ProductionLineService>().As<IProductionLineService>().InstancePerLifetimeScope();
            builder.RegisterType<ProductionLineMachineService>().As<IProductionLineMachineService>().InstancePerLifetimeScope();
            builder.RegisterType<SensorService>().As<ISensorService>().InstancePerLifetimeScope();
            builder.RegisterType<TagService>().As<ITagService>().InstancePerLifetimeScope();
            builder.RegisterType<UserCompanyService>().As<IUserCompanyService>().InstancePerLifetimeScope();
            builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
            builder.RegisterType<MachineTagService>().As<IMachineTagService>().InstancePerLifetimeScope();
            builder.RegisterType<InventoryDistributionPointService>().As<IInventoryDistributionPointService>().InstancePerLifetimeScope();
            builder.RegisterType<DistributionPointStockService>().As<IDistributionPointStockService>().InstancePerLifetimeScope();
            builder.RegisterType<RoleService>().As<IRoleService>().InstancePerLifetimeScope();
            builder.RegisterType<PermissionService>().As<IPermissionService>().InstancePerLifetimeScope();
            builder.RegisterType<RolePermissionService>().As<IRolePermissionService>().InstancePerLifetimeScope();
            builder.RegisterType<AuthService>().As<IAuthService>().InstancePerLifetimeScope();
            builder.RegisterType<EmailService>().As<IEmailService>().InstancePerLifetimeScope();
            builder.RegisterType<TokenGeneratorService>().As<ITokenGeneratorService>().InstancePerLifetimeScope();
            #endregion

            #region Repositorys
            builder.RegisterType<CompanyRepository>().As<ICompanyRepository>().InstancePerLifetimeScope();
            builder.RegisterType<DistributionPointRepository>().As<IDistributionPointRepository>().InstancePerLifetimeScope();
            builder.RegisterType<DistributionPointMachineRepository>().As<IDistributionPointMachineRepository>().InstancePerLifetimeScope();
            builder.RegisterType<InventoryRepository>().As<IInventoryRepository>().InstancePerLifetimeScope();
            builder.RegisterType<LayoutRepository>().As<ILayoutRepository>().InstancePerLifetimeScope();
            builder.RegisterType<MachineRepository>().As<IMachineRepository>().InstancePerLifetimeScope();
            builder.RegisterType<MachineConnectionRepository>().As<IMachineConnectionRepository>().InstancePerLifetimeScope();
            builder.RegisterType<MachineSensorRepository>().As<IMachineSensorRepository>().InstancePerLifetimeScope();
            builder.RegisterType<MachineSensorDataRepository>().As<IMachineSensorDataRepository>().InstancePerLifetimeScope();
            builder.RegisterType<ProductionLineRepository>().As<IProductionLineRepository>().InstancePerLifetimeScope();
            builder.RegisterType<ProductionLineMachineRepository>().As<IProductionLineMachineRepository>().InstancePerLifetimeScope();
            builder.RegisterType<SensorRepository>().As<ISensorRepository>().InstancePerLifetimeScope();
            builder.RegisterType<TagRepository>().As<ITagRepository>().InstancePerLifetimeScope();
            builder.RegisterType<UserCompanyRepository>().As<IUserCompanyRepository>().InstancePerLifetimeScope();
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerLifetimeScope();
            builder.RegisterType<MachineTagRepository>().As<IMachineTagRepository>().InstancePerLifetimeScope();
            builder.RegisterType<InventoryDistributionPointRepository>().As<IInventoryDistributionPointRepository>().InstancePerLifetimeScope();
            builder.RegisterType<DistributionPointStockRepository>().As<IDistributionPointStockRepository>().InstancePerLifetimeScope();
            builder.RegisterType<RoleRepository>().As<IRoleRepository>().InstancePerLifetimeScope();
            builder.RegisterType<PermissionRepository>().As<IPermissionRepository>().InstancePerLifetimeScope();
            builder.RegisterType<RolePermissionRepository>().As<IRolePermissionRepository>().InstancePerLifetimeScope();
            builder.RegisterType<AuthRepository>().As<IAuthRepository>().InstancePerLifetimeScope();
            #endregion

            builder.RegisterType<PasswordHasher<User>>().As<IPasswordHasher<User>>().InstancePerLifetimeScope();
        }
    }
}
