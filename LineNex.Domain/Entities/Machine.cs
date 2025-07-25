using System.ComponentModel.DataAnnotations;

namespace LineNex.Domain.Entity
{
    public class Machine : BaseEntity
    {
        public required string Name { get; set; }
        public ICollection<ProductionLineMachine>? ProductionLineMachines { get; set; }
        public ICollection<MachineSensor>? MachineSensors { get; set; }
        public ICollection<DistributionPointMachine>? DistributionPointMachines { get; set; }
        public ICollection<MachineConnection>? MachineConnections { get; set; }
        public ICollection<MachineTag>? MachineTags { get; set; }
    }
}