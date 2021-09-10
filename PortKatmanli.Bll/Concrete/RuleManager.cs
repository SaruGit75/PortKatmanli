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
        private readonly IAllEventDal _allEventDal;
        private readonly ICategoryDal _categoryDal;

        public RuleManager(IAllEventDal allEventDal, IRuleDal ruleDal, ICategoryDal categoryDal)
        {
            _allEventDal = allEventDal;
            _ruleDal = ruleDal;
            _categoryDal = categoryDal;
        }

        public void Add(Rules rule)
        {
            _ruleDal.Add(rule);
        }

        public List<AllEventComplexModel> AllEventComplexModels(Rules rules)
        {
            return _allEventDal.GetAllEventComplexModel(rules.EventType, rules.UnitId, rules.FreightKind, rules.Category, rules.TransitState);
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

        public List<Category> GetCat()
        {
            return _categoryDal.GetCat();
        }

        public void Update(Rules rule)
        {
            _ruleDal.Update(rule);
        }

        //public List<AllEventComplexModel> AllEventComplexModel(Rules rules)
        //{
        //    return _allEventDal.GetAllEventComplexModel(rules.EventType, rules.unitId, rules.FreightKind, rules.Category, rules.TransitState);
        //}

    }
}
