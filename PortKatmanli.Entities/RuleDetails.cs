using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortKatmanli.Entities
{
    public class RuleDetails
    {
        public int RuleDetailHeaderKey { get; set; }
        public int RuleItemKey { get; set; }
        public string EventType { get; set; }

        public long inv_unit_gkey { get; set; }
    }
}
