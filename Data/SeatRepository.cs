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


        public SeatRepository(ObraContext context, ILogger<SeatRepository> logger)
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

        public SeatDto? Get(int SeatId)
        {
            try
            {
                var seatDto = _context.Seats.FirstOrDefault(p => p.Id == SeatId);
                if (seatDto != null)
                {
                    var seat = new SeatDto
                    {
                        Id = seatDto.Id,
                        Number = seatDto.Number,
                       
                        Price = seatDto.Price,
                        State = seatDto.State,

                    };
                    return seat;
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

        public void Update(SeatDto Seat)
        {
            try
            {
                var _seat = _context.Seats.Find(Seat.Id);
                _seat.Number = Seat.Number;
                _seat.Price = Seat.Price;
                _seat.State = Seat.State;
                
                _context.Entry(_seat).State = EntityState.Modified;
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
                var Seat = _context.Seats.Find(SeatId);
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

       
        public List<SeatDto> GetSeatsBySalaId(int salaId)
        {

            try
            {
                var seats = _context.Seats.Where(s => s.SalaId == salaId)
                .Select(s => new SeatDto
                {
                    Id = s.Id,
                    Number = s.Number,
                    Price = s.Price,
                    State = s.State,
                  
                })
                .ToList();
                return seats;
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
                    .ToList();

                var seatDto = seat.Select(s => new SeatDto
                {
                    Id = s.Id,
                    Price = s.Price,
                    State = s.State,
                    Number = s.Number, 
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
