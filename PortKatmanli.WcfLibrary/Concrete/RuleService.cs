﻿using PortKatmanli.Bll.Concrete;
using PortKatmanli.Dal.Abstract;
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
        private readonly RuleManager _ruleManager = new RuleManager(new EfAllEventDal(new PortKatmanliContext()), new EfRuleDal(new PortKatmanliContext()), new EfCategoryDal(new PortKatmanliContext()));

        public void Add(Rules rule)
        {
            _ruleManager.Add(rule);
        }

        public void Delete(int ruleId)
        {
            _ruleManager.Delete(ruleId);
        }

        public Rules Get(int ruleId)
        {
            return _ruleManager.Get(ruleId);    
        }

        public List<Rules> GetAll()
        {
            return _ruleManager.GetAll();
        }

        public void Update(Rules rule)
        {
            _ruleManager.Update(rule);
        }

        public List<AllEventComplexModel> AllEventComplexModels(Rules rule)
        {
            return _ruleManager.AllEventComplexModels(rule);
        }

        public List<string> GetCat()
        {
            return _ruleManager.GetCat();
        }
    }
}
