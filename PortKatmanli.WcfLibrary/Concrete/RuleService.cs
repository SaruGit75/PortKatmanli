using PortKatmanli.Bll.Concrete;
using PortKatmanli.Dal.Concrete.EntityFramework;
using PortKatmanli.Entities;
using PortKatmanli.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortKatmanli.WcfLibrary.Concrete
{
    public class RuleService : IRuleService
    {
        private readonly RuleManager _ruleManager = new RuleManager(new EfRuleDal());
        public void Add(Rule rule)
        {
            _ruleManager.Add(rule);
        }

        public void Delete(int ruleId)
        {
            _ruleManager.Delete(ruleId);
        }

        public Rule Get(int ruleId)
        {
            return _ruleManager.Get(ruleId);    
        }

        public List<Rule> GetAll()
        {
            return _ruleManager.GetAll();
        }

        public void Update(Rule rule)
        {
            _ruleManager.Update(rule);
        }
    }
}
