using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace JobLibrary.BLL
{
    public class CompanyBLL
    {
        JobsDbEntities dbContext;
        public CompanyBLL(JobsDbEntities _dbContext)
        {
            dbContext = _dbContext;
        }

        public List<Company> getPaged()
        {

            var query = (from obj in dbContext.Companies select obj).ToList();
            return query;
        }
    }
}
