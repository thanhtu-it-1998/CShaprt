using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreProject.Models
{
    public class EFStoreRespository:IStoreRepository
    {
        private NetCoreProjectDbContext context;
        public EFStoreRespository(NetCoreProjectDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
    }
}
