using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Model
{
    public class Context : DbContext
    {
        public DbSet<Pessoa> dBpessoa { get; set; }
        public DbSet<Casal> dBcasal { get; set; }
        public DbSet<Mes> dBmes { get; set; }
    }
}
