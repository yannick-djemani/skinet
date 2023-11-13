using Core.Entities;

namespace Core.Interface
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAnsyc(int id);
        Task<IReadOnlyList<Product>>GetProductsAsync();
        Task<IReadOnlyList<ProductBrand>>GetProductBrandsAsync();
        Task<IReadOnlyList<ProductType>>GetProductTypeAsync();
    }
}