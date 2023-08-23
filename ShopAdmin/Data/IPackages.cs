using Entities;

namespace ShopAdmin.Data
{
    public interface IPackages
    {
        Task<List<EntPackages>> GetPackages(int id);
    }
}
