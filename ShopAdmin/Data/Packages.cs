using Entities;

namespace ShopAdmin.Data
{
    public class Packages : IPackages
    {
        private readonly HttpClient _http;

        public Packages(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<EntPackages>> GetPackages(int id)
        {
            return await _http.GetFromJsonAsync<List<EntPackages>>("api/Packages/getpackagesbyshopid/"+id);
        }
    }
}
