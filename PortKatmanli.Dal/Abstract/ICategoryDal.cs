using PortKatmanli.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortKatmanli.Dal.Abstract
{
    public interface ICategoryDal
    {
        List<string> GetCat();
    }
}
