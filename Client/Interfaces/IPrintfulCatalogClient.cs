using Client.Models;
using Client.Models.Response;

namespace Client.Interfaces
{
    public interface IPrintfulCatalogClient
    {
        Task<PrintfulResponse<List<Product>>> GetProducts(long? categoryId);
        Task<PrintfulResponse<VariantInfo>> GetVariant(int variantId);
        Task<PrintfulResponse<ProductInfo>> GetProduct(int productId);
        Task<PrintfulResponse<ProductSizeGuide>> GetProductSizeGuide(int productId);
        Task<PrintfulResponse<CategoriesResponse>> GetCategories();
        Task<PrintfulResponse<CategoryResponse>> GetCategory(int categoryId);
    }
}