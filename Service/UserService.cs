using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Service
{
    public class UserService : IUserService
    {
        private DataContext _context;
        public UserService(DataContext context)
        {
            _context = context;
        }
        public async Task<bool> Create(User user)
        {
            await _context.users.AddAsync(user);
            var result = await _context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<bool> Update(User user)
        {
            _context.Update(user);
            var result = await _context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var user = await _context.users.FindAsync(id);

            _context.users.Remove(user);

            var result = await _context.SaveChangesAsync();

            return result > 0;
        }
    }
}
