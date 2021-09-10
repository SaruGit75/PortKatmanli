using PortKatmanli.Dal.Abstract;
using PortKatmanli.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PortKatmanli.Dal.Concrete.EntityFramework
{
    public class EfCategoryDal : ICategoryDal
    {
        private readonly PortKatmanliContext _context;

        public EfCategoryDal(PortKatmanliContext context)
        {
            _context = context;
        }

        public List<Category> GetCat()
        {
            var catGet = (from a in _context.Units.Select(i => i.Category).Distinct()
                         select new Category
                         {                             
                             CategoryName = a
                         }).ToList();

            return catGet;
        }
    }
}
