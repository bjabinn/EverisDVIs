using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class VirtualMachine
    {
        [Key]
        public int VirtualMachineId { get; set; }
        public string Name { get; set; }
        public string Ip { get; set; }
        public string Tpx { get; set; }
        public string Password { get; set; }

        public ICollection<EnvironmentVirtualMachine> EnvironmentVirtualMachines { get; set; }
        public ICollection<StatusVirtualMachine> StatusVirtualMachines { get; set; }
    }
}
