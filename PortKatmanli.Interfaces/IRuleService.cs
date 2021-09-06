using PortKatmanli.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortKatmanli.Interfaces
{
    public interface IRuleService
    {
        List<Rule> GetAll();
        Rule Get(int ruleId);
        void Add(Rule rule);
        void Delete(int ruleId);
        void Update(Rule rule);
    }
}
