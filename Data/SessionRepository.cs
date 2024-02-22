using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TeatroBack.Models;

namespace TeatroBack.Data
{
    public class SessionRepository : ISessionRepository
    {
        private readonly ObraContext _context;

        public SessionRepository(ObraContext context)
        {
            _context = context;
        }

        public void Add(Session Session)
        {
            _context.Sessions.Add(Session);
            SaveChanges();
        }

        public Session? Get(int SessionId)
        {
            return _context.Sessions.FirstOrDefault(p => p.Id == SessionId);
        }

        public void Update(Session Session)
        {
            _context.Entry(Session).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(int SessionId)
        {
            var Session = Get(SessionId);
            if (Session == null)
            {
                throw new KeyNotFoundException("Session not found.");
            }
            _context.Sessions.Remove(Session);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public List<Session> GetAll()
        {
            return _context.Sessions.ToList();
        }
    }
}