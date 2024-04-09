using ApplicationCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
    public class ApplicationContext :DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        }
}
