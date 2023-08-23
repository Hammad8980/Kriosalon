using Entities;

namespace ShopAdmin.Data
{
    public class AllBusinessOwner:IAllBusinessOwner
    {
        private readonly HttpClient _http;
        public AllBusinessOwner(HttpClient http) { 
            _http = http;
        }
        public async Task<List<EntBusinessOwner>> GetBusinessOwner()
        {

            return await _http.GetFromJsonAsync<List<EntBusinessOwner>>("api/BusinessOwner/getowners");
        }
        public async Task AddOwner(EntBusinessOwner eo)
        {
            await _http.PostAsJsonAsync("api/BusinessOwner/savebo", eo);
        }
        
    }
}
