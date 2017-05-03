using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class StatusVirtualMachine
    {
        [Key]
        public int StatusVirtualMachineId { get; set; }
        public int StatusId { get; set; }
        public int VirtualMachineId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }

        public Status Status { get; set; }
        public VirtualMachine VirtualMachine { get; set; }

    }
}
