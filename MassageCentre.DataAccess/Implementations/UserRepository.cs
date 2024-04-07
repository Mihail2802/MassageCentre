using MassageCentre.DataAccess.Interfaces;
using MassageCentre.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MassageCentre.DataAccess.Implementations
{
    public class UserRepository : IRepository<User>
    {
        private readonly MassageCentreDbContext _context;
        public UserRepository(MassageCentreDbContext _context)
        {
            this._context = _context;
        }
        public async Task CreateAsync(User entity)
        {
            await _context.Users.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            User userDb = await GetByIdAsync(id);
            _context.Remove(userDb);
            await _context.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Users.Include(x => x.Id)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(User entity)
        {
            _context.Users.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
