using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class EnvironmentVirtualMachine
    {
        [Key]
        public int EnvironmentVirtualMachineId { get; set; }
        public int EnvironmentId { get; set; }
        public int VirtualMachineId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }

        public Environment Environment { get; set; }
        public VirtualMachine VirtualMachine { get; set; }

    }
}
