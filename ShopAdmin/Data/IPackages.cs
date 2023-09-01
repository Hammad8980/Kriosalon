using Entities;

namespace ShopAdmin.Data
{
    public interface IPackages
    {
        Task<List<EntPackages>> GetPackages(int id);

        Task DeletePackage(int id);

        Task SavePackage(EntPackages ep);
        Task Updatepackage(EntPackages ep);
    }
}
