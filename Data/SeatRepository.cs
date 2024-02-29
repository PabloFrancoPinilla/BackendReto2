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

        public List<Seat> GetAll()
        {
            return _context.Seats.ToList();
        }
    }
}