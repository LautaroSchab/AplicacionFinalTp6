using AplicacionTp6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionTp6.Services
{
    public interface IProductoService
    {
        Task<IEnumerable<Producto>> GetProductsAsync();

        Task<Producto> CreateProductAsync(Producto producto);

        Task<bool> UpdateProductAsync(int id, Producto producto); 
        Task<bool> DeleteProductAsync(int id); 
    }
}
