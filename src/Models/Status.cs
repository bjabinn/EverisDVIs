using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Status
    {
        [Key]
        public int StatusId { get; set; }
        public string Name { get; set; }

        public ICollection<StatusVirtualMachine> StatusVirtualMachines { get; set; }
    }
}
