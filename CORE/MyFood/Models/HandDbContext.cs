using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFood.Models
{
    public interface HandDbContext
    {
        List<Food> GetAll();
        List<Food> GetAllPage(string keyword, int pageIndex,int pageSize);
    }
}
