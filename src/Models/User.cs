using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public int VirtualMachineId { get; set; }

        public ICollection<Operation> Operations { get; set; }
    }
}
