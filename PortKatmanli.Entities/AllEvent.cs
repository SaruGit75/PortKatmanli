using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortKatmanli.Entities
{
    public class AllEvent
    {
        [Key]
        public long PKey { get; set; }
        public string EventType { get; set; }
        public long inv_unit_gkey { get; set; }
    }
}
