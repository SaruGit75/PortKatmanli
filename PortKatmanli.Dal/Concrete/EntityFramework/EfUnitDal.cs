using PortKatmanli.Dal.Abstract;
using PortKatmanli.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortKatmanli.Dal.Concrete.EntityFramework
{
    public class EfUnitDal : IUnitDal
    {
        PortKatmanliContext _context = new PortKatmanliContext();
        public Unit Get(int unitId)
        {
            return _context.Units.FirstOrDefault(i => i.PKey == unitId);
        }
    }
}
