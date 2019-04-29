using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VilaItalia.Models
{
    public class VilaItaliaContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public VilaItaliaContext() : base("name=VilaItaliaContext")
        {
        }

        public System.Data.Entity.DbSet<VilaItalia.Models.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<VilaItalia.Models.Funcionario> Funcionarios { get; set; }

        public System.Data.Entity.DbSet<VilaItalia.Models.Motoboy> Motoboys { get; set; }
    }
}
