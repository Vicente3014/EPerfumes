using EPerfumesFinal.Models;

namespace EPerfumesFinal.Data.Services
{
    public interface IPerfumeService
    {
        Task<IEnumerable<Perfume>> GetAllAsync();
        Task<Perfume> GetByIDAsync(int id);
        Task AddAsync(Perfume perfume);
        Task<Perfume> UpdateAsync(int id, Perfume Newperfume);
        Task DeleteAsync(int id);
    }
}
