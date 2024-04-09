using ApplicationCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
    public class ProductoRepository :IProductoRepository
    {
        private readonly ApplicationContext _context;

        public ProductoRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Producto> ObtenerTodosLosProductos()
        {
            return _context.Productos.ToList();
        }
    }
}
