using PortKatmanli.Entities;
using System.Collections.Generic;

namespace PortKatmanli.MvcWebUI
{
    public class RuleViewModel
    {
        public List<Rules> Rules { get; set; }
        public object PagingInfo { get; set; }
        public List<Rules> Rule { get; internal set; }
    }
}