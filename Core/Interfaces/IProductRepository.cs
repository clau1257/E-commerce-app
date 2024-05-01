using Core.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;
using Core.Interfaces;


namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);
        Task GetProductByIdAsync();
        Task<IReadOnlyList<Product>>GetProductsAsync();
        Task<IReadOnlyList<ProductBrand>>GetProductBrandsAsync();
        Task<IReadOnlyList<ProductType>>GetProductTypesAsync();

    }
}