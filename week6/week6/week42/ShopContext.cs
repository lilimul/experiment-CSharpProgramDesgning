using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week3;

namespace week42
{
    public class ShopContext:DbContext
    {
        public ShopContext() : base("ShopdataBase")
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<ShopContext>());
        }
        public DbSet<good> Goods { set; get; }
    }
}
