using EPerfumesFinal.Models;
using Microsoft.EntityFrameworkCore;

namespace EPerfumesFinal.Data.Services
{
    public class PerfumeService : IPerfumeService
    {
        private readonly AppDBContext _dbContext;
        public PerfumeService(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Perfume perfume)
        {
            await _dbContext.Perfumes.AddAsync(perfume);
            await _dbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Perfume>> GetAllAsync()
        {
            var result = await _dbContext.Perfumes.ToListAsync();
            return result;
        }

        public async Task<Perfume> GetByIDAsync(int id)
        {
            var result = await _dbContext.Perfumes.FirstOrDefaultAsync(n => n.Perfume_ID == id);
            return result;
        }

        public async Task<Perfume> UpdateAsync(int id,Perfume Newperfume)
        {
            _dbContext.Update(Newperfume);
            await _dbContext.SaveChangesAsync();
            return Newperfume;
        }
        public async Task DeleteAsync(int id)
        {
            var result = await _dbContext.Perfumes.FirstOrDefaultAsync(n => n.Perfume_ID == id);
            _dbContext.Perfumes.Remove(result);
            await _dbContext.SaveChangesAsync();
        }



    }
}

