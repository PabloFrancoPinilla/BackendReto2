using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TeatroBack.Models;
using Serilog;
using Microsoft.Extensions.Logging;

namespace TeatroBack.Data
{
    public class SeatRepository : ISeatRepository
    {
        private readonly ObraContext _context;
        private readonly ILogger<SeatRepository> _logger;


        public SeatRepository(ObraContext context,ILogger<SeatRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void Add(Seat Seat)
        {
            try
            {
                _context.Seats.Add(Seat);
                Log.Information("Seat added");
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Ocurrió un error en SomeMethod");
                throw;
            }
        }

        public Seat? Get(int SeatId)
        {
            try
            {
                return _context.Seats.FirstOrDefault(p => p.Id == SeatId);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Ocurrió un error en SomeMethod");
                throw;
            }
        }

        public void Update(Seat Seat)
        {
            try
            {
                _context.Entry(Seat).State = EntityState.Modified;
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Ocurrió un error en SomeMethod");
                throw;
            }
        }

        public void Delete(int SeatId)
        {
            try
            {
                var Seat = Get(SeatId);
                if (Seat == null)
                {
                    throw new KeyNotFoundException("Seat not found.");
                }
                _context.Seats.Remove(Seat);
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Ocurrió un error en SomeMethod");
                throw;
            }
        }

        public List<Seat> GetSeatsByUserId(int userId)
        {
            try
            {
                return _context.Seats.Where(s => s.UserId == userId).ToList();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Ocurrió un error en SomeMethod");
                throw;
            }
        }
          public List<Seat>GetSeatsBySession(int number){

            try
            {
                return _context.Seats.Where(s => s.Number == number).ToList();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Ocurrió un error en SomeMethod");
                throw;
            }
        }
          public List<Seat>GetSeatsBySessionId(int sessionId){

            try
            {
                return _context.Seats.Where(s => s.SessionId == sessionId).ToList();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Ocurrió un error en SomeMethod");
                throw;
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public List<SeatDto> GetAll()
        {
            try
            {
                var seat = _context.Seats
                    .Include(s => s.Session)
                    .ThenInclude(se => se.Obra)
                    .Include(s => s.User)
                    .ToList();

                var seatDto = seat.Select(s => new SeatDto
                {
                    Id = s.Id,
                    State = s.State,
                    Number = s.Number,
                    UserId = s.UserId,
                    Session = new SessionDto
                    {
                        Id = s.Session.Id,
                        Obra = new ObraDto
                        {
                            Id = s.Session.Obra.Id,
                            Name = s.Session.Obra.Name,
                            Image = s.Session.Obra.Image,
                            Duration = s.Session.Obra.Duration,
                            Genre = s.Session.Obra.Genre
                        }
                    }
                }).ToList();

                return seatDto;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Ocurrió un error en SomeMethod");
                throw;
            }
        }
    }
}
