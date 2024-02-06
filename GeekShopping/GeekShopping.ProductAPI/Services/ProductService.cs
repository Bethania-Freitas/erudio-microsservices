using GeekShopping.ProductAPI.Model;
using GeekShopping.ProductAPI.Services.IServices;
using GeekShopping.ProductAPI.Utils;

namespace GeekShopping.ProductAPI.Services
{

    public class ProductService : IProductService
    {
        private readonly HttpClient _client;
        public const string BasePath = "api/v1/product";

        public async Task<IEnumerable<ProductModel>> FindAllProducts()
        {
            var response = await _client.GetAsync(BasePath);
            return await response.HeadContentAs<List<ProductModel>>();
        }

        public async Task<ProductModel> FindProductById(long id)
        {
            var response = await _client.GetAsync($"{BasePath}/{id}");
            return await response.HeadContentAs<ProductModel>();
        }

        public async Task<ProductModel> CreateProduct(ProductModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductModel> UpdateProduct(ProductModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProductById(long id)
        {
            throw new NotImplementedException();
        }



    }
}
