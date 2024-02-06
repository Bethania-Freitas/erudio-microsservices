using System.Text.Json;

namespace GeekShopping.ProductAPI.Utils
{
    public static class HttpClientExtensions
    {
        public static async Task<T> HeadContentAs<T>(this HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
                throw new ApplicationException($"Something went wrong calling the api" +
                    $"{response.ReasonPhrase}");
            var dataAsString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonSerializer.Deserialize<T>(
                dataAsString,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}
