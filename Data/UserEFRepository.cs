using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TeatroBack.Models;
using Serilog;
using Microsoft.Extensions.Logging;

namespace TeatroBack.Data
{
    public class UserEFRepository : IUserRepository
    {
        private readonly ObraContext _context;
        private readonly ILogger<UserEFRepository> _logger;

        public UserEFRepository(ObraContext context)
        {
            _context = context;
        }

        public void Add(User User)
        {
            _context.Users.Add(User);
            SaveChanges();
        }

        public UserGetDto? Get(int userId)
        {
            try
            {
                var userDto = _context.Users.FirstOrDefault(p => p.Id == userId);
                if (userDto != null)
                {
                    var user = new UserGetDto
                    {
                        Id = userDto.Id,
                        Name = userDto.Name,
                        LastName = userDto.LastName,
                        Mail = userDto.Mail,
                    };
                    return user;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Ocurrió un error en SomeMethod");
                throw;
            }
        }
        public User? GetForUpdate(int userId)
        {
            return _context.Users.FirstOrDefault(p => p.Id == userId);
        }

        public string Login(string Mail, string Password)
        {
            var user = _context.Users.FirstOrDefault(p => p.Mail == Mail);
            if (user == null)
            {
                return "User not found";
            }
            else if (user.Password == Password)
            {
                return "User found";
            }
            else
            {
                return "Incorrect password";
            }
        }

        public void Update(User User)
        {
            _context.Entry(User).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(int UserId)
        {
            try
            {
                var User = _context.Users.Find(UserId);
                if (User == null)
                {
                    throw new KeyNotFoundException("User not found.");
                }
                _context.Users.Remove(User);
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error ocurred deleting an user");
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public List<UserGetDto> GetAll()
        {
            var users = _context.Users.Select(s => new UserGetDto
            {
                Id = s.Id,
                Name = s.Name,
                LastName = s.LastName,
                Mail = s.Mail,
            }).ToList();

            return users;
        }
    }
}