using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TeatroBack.Models;

namespace TeatroBack.Data
{
    public class UserEFRepository : IUserRepository
    {
        private readonly ObraContext _context;

        public UserEFRepository(ObraContext context)
        {
            _context = context;
        }

        public void Add(User User)
        {
            _context.Users.Add(User);
            SaveChanges();
        }

        public User? Get(int userId)
        {
            return _context.Users.FirstOrDefault(p => p.Id == userId);
        }

        public void Update(User User)
        {
            _context.Entry(User).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(int UserId)
        {
            var User = Get(UserId);
            if (User == null)
            {
                throw new KeyNotFoundException("User not found.");
            }
            _context.Users.Remove(User);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }
    }
}