using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TeatroBack.Models;

namespace TeatroBack.Data
{
    public class SessionRepository : ISessionRepository
    {
        private readonly ObraContext _context;
        private readonly ILogger<SessionRepository> _logger;

        public SessionRepository(ObraContext context, ILogger<SessionRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void Add(Session Session)
        {
            try{
            _context.Sessions.Add(Session);
            SaveChanges();
            }catch(Exception e){
                _logger.LogError(e,"An error ocurred while adding a session");
                throw;
            }
        }

        public Session? Get(int SessionId)
        {
            try{
            return _context.Sessions.FirstOrDefault(p => p.Id == SessionId);
            }catch(Exception e){
                _logger.LogError(e,"An error ocurred while getting a session");
                throw;
            }
        }

        public void Update(Session Session)
        {
            try{
            _context.Entry(Session).State = EntityState.Modified;
            SaveChanges();
            }catch(Exception e){
                _logger.LogError(e,"An error ocurred while updating");
            }
        }

        public void Delete(int SessionId)
        {
            try{
            var Session = Get(SessionId);
            if (Session == null)
            {
                throw new KeyNotFoundException("Session not found.");
            }
            _context.Sessions.Remove(Session);
            SaveChanges();
            }catch(Exception e){
                _logger.LogError(e,"An error ocurred deleting an obra");
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public List<SessionDto> GetAll()
        {
            try{
            var session = _context.Sessions
            .Include(s => s.Obra)
            .ToList();

            var sessionDto = session.Select(s => new SessionDto
            {
                Id = s.Id,
                Obra = new ObraDto
                {
                    Id = s.Obra.Id,
                    Name = s.Obra.Name,
                    Image = s.Obra.Image,
                    Duration = s.Obra.Duration,
                    Genre = s.Obra.Genre
                }
            }).ToList();

            return sessionDto;
            }catch(Exception e){
                _logger.LogError(e,"An error ocurred while showing obras");
                throw;
            }
        }
      
    }
}