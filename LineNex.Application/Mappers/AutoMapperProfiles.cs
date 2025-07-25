using LineNex.Domain.Entity;
using AutoMapper;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Application.Mappers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            #region Dtos
            CreateMap<CompanyDto, Company>().ReverseMap();
            CreateMap<UserCompanyDto, UserCompany>().ReverseMap();
            CreateMap<ProductionLineDto, ProductionLine>().ReverseMap();
            CreateMap<MachineDto, Machine>().ReverseMap();
            CreateMap<ProductionLineMachineDto, ProductionLineMachine>().ReverseMap();
            CreateMap<SensorDto, Sensor>().ReverseMap();
            CreateMap<MachineSensorDto, MachineSensor>().ReverseMap();
            CreateMap<DistributionPointDto, DistributionPoint>().ReverseMap();
            CreateMap<DistributionPointMachineDto, DistributionPointMachine>().ReverseMap();
            CreateMap<MachineConnectionDto, MachineConnection>().ReverseMap();
            CreateMap<TagDto, Tag>().ReverseMap();
            CreateMap<MachineSensorDataDto, MachineSensorData>().ReverseMap();
            CreateMap<InventoryDto, Inventory>().ReverseMap();
            CreateMap<LayoutDto, Layout>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<MachineTagDto, MachineTag>().ReverseMap();
            CreateMap<InventoryDistributionPointDto, InventoryDistributionPoint>().ReverseMap();
            CreateMap<DistributionPointStockDto, DistributionPointStock>().ReverseMap();
            CreateMap<RoleDto, Role>().ReverseMap();
            CreateMap<PermissionDto, Permission>().ReverseMap();
            CreateMap<RolePermissionDto, RolePermission>().ReverseMap();
            #endregion

            #region Post Models
            CreateMap<CompanyPostModel, Company>().ReverseMap();
            CreateMap<UserCompanyPostModel, UserCompany>().ReverseMap();
            CreateMap<ProductionLinePostModel, ProductionLine>().ReverseMap();
            CreateMap<MachinePostModel, Machine>().ReverseMap();
            CreateMap<ProductionLineMachinePostModel, ProductionLineMachine>().ReverseMap();
            CreateMap<SensorPostModel, Sensor>().ReverseMap();
            CreateMap<MachineSensorPostModel, MachineSensor>().ReverseMap();
            CreateMap<DistributionPointPostModel, DistributionPoint>().ReverseMap();
            CreateMap<DistributionPointMachinePostModel, DistributionPointMachine>().ReverseMap();
            CreateMap<MachineConnectionPostModel, MachineConnection>().ReverseMap();
            CreateMap<TagPostModel, Tag>().ReverseMap();
            CreateMap<MachineSensorDataPostModel, MachineSensorData>().ReverseMap();
            CreateMap<InventoryPostModel, Inventory>().ReverseMap();
            CreateMap<LayoutPostModel, Layout>().ReverseMap();
            CreateMap<UserPostModel, User>().ReverseMap();
            CreateMap<MachineTagPostModel, MachineTag>().ReverseMap();
            CreateMap<InventoryDistributionPointPostModel, InventoryDistributionPoint>().ReverseMap();
            CreateMap<DistributionPointStockPostModel, DistributionPointStock>().ReverseMap();
            CreateMap<RolePostModel, Role>().ReverseMap();
            CreateMap<PermissionPostModel, Permission>().ReverseMap();
            CreateMap<RolePermissionPostModel, RolePermission>().ReverseMap();
            #endregion

            #region Put Models
            CreateMap<CompanyPutModel, Company>().ReverseMap();
            CreateMap<UserCompanyPutModel, UserCompany>().ReverseMap();
            CreateMap<ProductionLinePutModel, ProductionLine>().ReverseMap();
            CreateMap<MachinePutModel, Machine>().ReverseMap();
            CreateMap<ProductionLineMachinePutModel, ProductionLineMachine>().ReverseMap();
            CreateMap<SensorPutModel, Sensor>().ReverseMap();
            CreateMap<MachineSensorPutModel, MachineSensor>().ReverseMap();
            CreateMap<DistributionPointPutModel, DistributionPoint>().ReverseMap();
            CreateMap<DistributionPointMachinePutModel, DistributionPointMachine>().ReverseMap();
            CreateMap<MachineConnectionPutModel, MachineConnection>().ReverseMap();
            CreateMap<TagPutModel, Tag>().ReverseMap();
            CreateMap<MachineSensorDataPutModel, MachineSensorData>().ReverseMap();
            CreateMap<InventoryPutModel, Inventory>().ReverseMap();
            CreateMap<LayoutPutModel, Layout>().ReverseMap();
            CreateMap<UserPutModel, User>().ReverseMap();
            CreateMap<MachineTagPutModel, MachineTag>().ReverseMap();
            CreateMap<InventoryDistributionPointPutModel, InventoryDistributionPoint>().ReverseMap();
            CreateMap<DistributionPointStockPutModel, DistributionPointStock>().ReverseMap();
            CreateMap<RolePutModel, Role>().ReverseMap();
            CreateMap<PermissionPutModel, Permission>().ReverseMap();
            CreateMap<RolePermissionPutModel, RolePermission>().ReverseMap();
            #endregion

            #region Get Models
            CreateMap<CompanyGetModel, Company>().ReverseMap();
            CreateMap<UserCompanyGetModel, UserCompany>().ReverseMap();
            CreateMap<ProductionLineGetModel, ProductionLine>().ReverseMap();
            CreateMap<MachineGetModel, Machine>().ReverseMap();
            CreateMap<ProductionLineMachineGetModel, ProductionLineMachine>().ReverseMap();
            CreateMap<SensorGetModel, Sensor>().ReverseMap();
            CreateMap<MachineSensorGetModel, MachineSensor>().ReverseMap();
            CreateMap<DistributionPointGetModel, DistributionPoint>().ReverseMap();
            CreateMap<DistributionPointMachineGetModel, DistributionPointMachine>().ReverseMap();
            CreateMap<MachineConnectionGetModel, MachineConnection>().ReverseMap();
            CreateMap<TagGetModel, Tag>().ReverseMap();
            CreateMap<MachineSensorDataGetModel, MachineSensorData>().ReverseMap();
            CreateMap<InventoryGetModel, Inventory>().ReverseMap();
            CreateMap<LayoutGetModel, Layout>().ReverseMap();
            CreateMap<UserGetModel, User>().ReverseMap();
            CreateMap<MachineTagGetModel, MachineTag>().ReverseMap();
            CreateMap<InventoryDistributionPointGetModel, InventoryDistributionPoint>().ReverseMap();
            CreateMap<DistributionPointStockGetModel, DistributionPointStock>().ReverseMap();
            CreateMap<RoleGetModel, Role>().ReverseMap();
            CreateMap<PermissionGetModel, Permission>().ReverseMap();
            CreateMap<RolePermissionGetModel, RolePermission>().ReverseMap();
            #endregion
        }
    }
}
