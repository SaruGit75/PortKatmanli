using PortKatmanli.Dal.Abstract;
using PortKatmanli.Entities;
using PortKatmanli.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortKatmanli.Bll.Concrete
{
    public class RuleManager : IRuleService
    {
        private readonly IRuleDal _ruleDal;

        public RuleManager(IRuleDal ruleDal)
        {
            _ruleDal = ruleDal;
        }

        public void Add(Rules rule)
        {
            _ruleDal.Add(rule);
        }

        public void Delete(int ruleId)
        {
            _ruleDal.Delete(ruleId);
        }

        public Rules Get(int ruleId)
        {
            return _ruleDal.Get(ruleId);
        }

        public List<Rules> GetAll()
        {
            return _ruleDal.GetAll();
        }

        public void Update(Rules rule)
        {
            _ruleDal.Update(rule);
        }
    }
}
