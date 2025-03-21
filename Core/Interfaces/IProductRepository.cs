using System;
using Core.Entities;

namespace Core.Interfaces;

public interface IProductRepository
{
    Task<IReadOnlyList<Product>> GetProductsAsync(string? brand, string? type, string? sort);
    Task<Product?> GetProductByIdAsycn(int id);

    void AddProduct(Product product);
    void DeleteProduct(Product product);
    void UpdateProduct(Product product);

    Task<IReadOnlyList<string>> GetBrandsAsync();
    Task<IReadOnlyList<string>> GetTypesAsync();


    bool IsProductExist(int id);
    Task<bool> SaveChangesAsyn();
}
