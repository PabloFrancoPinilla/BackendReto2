using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TeatroBack.Models;

namespace TeatroBack.Data
{
    public class SeatRepository : ISeatRepository
    {
        private readonly ObraContext _context;

        public SeatRepository(ObraContext context)
        {
            _context = context;
        }

        public void Add(Seat Seat)
        {
            _context.Seats.Add(Seat);
            SaveChanges();
        }

        public Seat? Get(int SeatId)
        {
            return _context.Seats.FirstOrDefault(p => p.Id == SeatId);
        }

        public void Update(Seat Seat)
        {
            _context.Entry(Seat).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(int SeatId)
        {
            var Seat = Get(SeatId);
            if (Seat == null)
            {
                throw new KeyNotFoundException("Seat not found.");
            }
            _context.Seats.Remove(Seat);
            SaveChanges();
        }

        public List<Seat> GetSeatsByUserId(int userId)
        {
            return _context.Seats.Where(s => s.UserId == userId).ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public List<SeatDto> GetAll()
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
    }
}