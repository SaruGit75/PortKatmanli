using PortKatmanli.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortKatmanli.Dal.Abstract
{
    public interface IAllEventDal
    {
        List<AllEvent> GetAll();
        AllEvent Get(int allEventId);
        List<AllEventComplexModel> GetAllEventComplexModel(string eventType, string unitId, string freightKind, string category, string transitState);
    }

    public class AllEventComplexModel
    {
        public string EventType { get; set; }
        public string FreightKind { get; internal set; }
        public string UnitId { get; internal set; }
        public string TransitState { get; internal set; }
        public string Category { get; internal set; }
    }
}
