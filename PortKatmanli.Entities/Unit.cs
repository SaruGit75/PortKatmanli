using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortKatmanli.Entities
{
    public class Unit
    {
        [Key]
        public long PKey { get; set; }
        public string FreightKind{ get; set; }
        public string Category { get; set; }
        public string TransitState { get; set; }
        public long inv_unit_gkey { get; set; }
        public string UnitId { get; set; }
    }
}
