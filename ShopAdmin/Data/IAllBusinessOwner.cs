using Entities;

namespace ShopAdmin.Data
{
    public interface IAllBusinessOwner
    {
        Task<List<EntBusinessOwner>> GetBusinessOwner();

        Task AddOwner(EntBusinessOwner eo);

        Task UpdateBO(EntBusinessOwner eo);
    }
}
