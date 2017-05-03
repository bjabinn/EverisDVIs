using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class VisitMode
    {
        [Key]
        public int VisitModeId { get; set; }
        public string Name { get; set; }
        
        public ICollection<Operation> Operations { get; set; }
    }
}
