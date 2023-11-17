using EPerfumesFinal.Models;

namespace EPerfumesFinal.Data.Services
{
    public interface IMarcasService
    {
        Task<IEnumerable<Marca>> GetAllAsync();
        Task<Marca> GetByIDAsync(int id);
        Task AddAsync(Marca marca);
        Task<Marca> UpdateAsync(int id, Marca Newmarca);
        Task DeleteAsync(int id);

    }
}
