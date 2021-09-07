using PortKatmanli.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortKatmanli.Dal.Abstract
{
    public interface IRuleDal
    {
        List<Rules> GetAll();
        Rules Get(int ruleId);
        void Add(Rules rule);
        void Delete(int ruleId);
        void Update(Rules rule);
    }
}
