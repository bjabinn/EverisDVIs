using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Environment
    {
        [Key]
        public int EnvironmentId { get; set; }
        public string Name { get; set; }

        public ICollection<EnvironmentVirtualMachine> EnvironmentVirtualMachines { get; set; }
    }
}
