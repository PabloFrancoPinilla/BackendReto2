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
            try
            {
                _context.Sessions.Add(Session);
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error ocurred while adding a session");
                throw;
            }
        }

        public SessionDto? Get(int SessionId)
        {
            try
            {
                var sessionDto = _context.Sessions.Include(o => o.Obra)
                .FirstOrDefault(p => p.Id == SessionId);
                if (sessionDto != null)
                {
                    var session = new SessionDto
                    {
                        Id = sessionDto.Id,
                        Obra = new ObraDto
                        {
                            Id = sessionDto.Obra.Id,
                            Name = sessionDto.Obra.Name,
                            Image = sessionDto.Obra.Image,
                            Duration = sessionDto.Obra.Duration,
                            Genre = sessionDto.Obra.Genre
                        },
                        Date = sessionDto.Date

                    };
                    return session;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error ocurred while getting a session");
                throw;
            }
        }

        public void Update(SessionDto Session)
        {
            try
            {
                var _session = _context.Sessions.Find(Session.Id);
                _session.Date = Session.Date;
                _context.Entry(_session).State = EntityState.Modified;
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error ocurred while updating");
            }
        }

        public void Delete(int SessionId)
        {
            try
            {
                var Session = _context.Sessions.Find(SessionId);
                if (Session == null)
                {
                    throw new KeyNotFoundException("Session not found.");
                }
                _context.Sessions.Remove(Session);
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error ocurred deleting an obra");
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public List<SessionDto> GetAll()
        {
            try
            {
                var session = _context.Sessions
                .Include(s => s.Obra)
                .ToList();

                var sessionDto = session.Select(s => new SessionDto
                {
                    Id = s.Id,
                    Date = s.Date,
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
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error ocurred while showing obras");
                throw;
            }
        }

        public List<SeatSalaDto> GetSeatsBySessionId(int sessionId)
        {
            try
            {
                var seats = _context.Seats.Where(s => s.Sala.SessionId == sessionId)
                .Select(s => new SeatSalaDto
                {
                    Id = s.Id,
                    Number = s.Number,
                    State = s.State,
                    UserId = s.UserId
                }).ToList();
                return seats;


            }
            catch (Exception e)
            {
                _logger.LogError(e, "Ocurrió un error en SomeMethod");
                throw;
            }
        }

    }
}