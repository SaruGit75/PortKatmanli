using PortKatmanli.Entities;
using System.Collections.Generic;

namespace PortKatmanli.MvcWebUI
{
    public class RuleViewModel
    {
        public List<Rules> RuleSkip { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}