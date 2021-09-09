using PortKatmanli.Dal.Abstract;
using PortKatmanli.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortKatmanli.Dal.Concrete.EntityFramework
{
    public class EfAllEventDal : IAllEventDal
    {
        private readonly PortKatmanliContext _context;

        public EfAllEventDal(PortKatmanliContext context)
        {
            _context = context;
        }

        public AllEvent Get(int allEventId)
        {
            return _context.AllEvents.FirstOrDefault(i => i.PKey == allEventId);
        }

        public List<AllEvent> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<AllEventComplexModel> GetAllEventComplexModel(string eventType, string unitId, string freightKind, string category, string transitState)
        {
            var sa = (from a in _context.AllEvents
                      join b in _context.Units on a.inv_unit_gkey equals b.inv_unit_gkey
                      where b.FreightKind == freightKind
                      && a.EventType == eventType
                      && b.UnitId == unitId
                      && b.TransitState == transitState
                      && b.Category == category
                      select new AllEventComplexModel
                      {
                          EventType = a.EventType,
                          FreightKind = b.FreightKind,
                          UnitId = b.UnitId,
                          TransitState = b.TransitState,
                          Category = b.Category
                      }).ToList();

            return sa;
        }
    }
}
