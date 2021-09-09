﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PortKatmanli.Entities
{
    public class Rules
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int RuleHeaderId { get; set; }
        public string EventType { get; set; }
        public string FreightKind { get; set; }
        public string Category { get; set; }
        public string TransitState { get; set; }
        public string UnitId { get; set; }
    }
}
