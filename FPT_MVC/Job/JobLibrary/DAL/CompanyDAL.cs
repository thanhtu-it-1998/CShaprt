using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobLibrary.DAL
{
    public class CompanyDAL
    {
        JobsDbEntities1 dbContext;
        public CompanyDAL(JobsDbEntities1 _dbContext)
        {
            dbContext = _dbContext;
        }

        public List<Company> GetCompanies()
        {
            var query = (from obj in dbContext.Companies select obj).ToList();
            return query;
        }
    }
}
