using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetProductsAsynce();
        Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsynce();
        Task<IReadOnlyList<ProductType>> GetProductTypesAsynce();

    }
}