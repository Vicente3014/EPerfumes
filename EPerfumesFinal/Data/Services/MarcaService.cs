using EPerfumesFinal.Models;
using Microsoft.EntityFrameworkCore;

namespace EPerfumesFinal.Data.Services
{
    public class MarcaService : IMarcasService
    {
        private readonly AppDBContext _dbContext;
        public MarcaService(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Marca marca)
        {
           await _dbContext.Marcas.AddAsync(marca);
           await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _dbContext.Marcas.FirstOrDefaultAsync(n => n.Marca_ID == id);
            _dbContext.Marcas.Remove(result);
            await _dbContext.SaveChangesAsync();
        }
        
        public async Task<IEnumerable<Marca>> GetAllAsync()
        {
            var result = await _dbContext.Marcas.ToListAsync();
            return result;
        }

        public async Task<Marca> GetByIDAsync(int id)
        {
            var result = await _dbContext.Marcas.FirstOrDefaultAsync(n=>n.Marca_ID == id);
            return result;
        }

        public async Task<Marca> UpdateAsync(int id,Marca Newmarca)
        {
            _dbContext.Update(Newmarca);
            await _dbContext.SaveChangesAsync();
            return Newmarca;
        }
    }
}
