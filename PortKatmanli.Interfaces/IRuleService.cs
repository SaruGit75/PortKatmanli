using PortKatmanli.Dal.Abstract;
using PortKatmanli.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PortKatmanli.Interfaces
{
    [ServiceContract]
    public interface IRuleService
    {
        [OperationContract]
        List<Rules> GetAll();
        [OperationContract]
        Rules Get(int ruleId);
        [OperationContract]
        void Add(Rules rule);
        [OperationContract]
        void Delete(int ruleId);
        [OperationContract]
        void Update(Rules rule);
        [OperationContract]
        List<AllEventComplexModel> AllEventComplexModels(Rules rules);
        [OperationContract]
        List<Category> GetCat();
    }
}