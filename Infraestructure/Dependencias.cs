using ApplicationCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
    public class Dependencias
    {
        public static void ConfigureServices(IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(options => options.UseInMemoryDatabase("ArquitecturaLimpia"));

            using(var context = services.BuildServiceProvider().GetService<ApplicationContext>()) {
                context!.Productos.Add(new Producto { Id = 1, Nombre = "CAMISETA DE LOGICSTUDIO", Precio = 100, Descuento = (decimal)0.1 });
                context.Productos.Add(new Producto { Id = 2, Nombre = "GORRA DE NETBY", Precio = 200, Descuento = (decimal)0.2 });
                context.Productos.Add(new Producto { Id = 3, Nombre = "MOUSEPAD DE PRODUBANCO", Precio = 300, Descuento = (decimal)0.15 });
                context.SaveChanges();
            }

        }

    }
}
