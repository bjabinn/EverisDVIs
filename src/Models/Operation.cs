using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Operation
    {
        [Key]
        public int OperationId { get; set; }
        public int UserId { get; set; }
        public int VirtualMachineId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int ModeId { get; set; }

        public User User { get; set; }
        public VirtualMachine VirtualMachine { get; set; }
        public VisitMode VisitMode { get; set; }
    }
}
