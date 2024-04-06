using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TeatroBack.Models;
using Microsoft.Extensions.Logging;

namespace TeatroBack.Data
{
    public class ReserveRepository : IReserveRepository
    {
        private readonly ObraContext _context;
        private readonly ILogger<ReserveRepository> _logger;

        public ReserveRepository(ObraContext context, ILogger<ReserveRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void Add(Reserve Reserve)
        {
            try
            {
                _context.Reserves.Add(Reserve);
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error ocurred while adding an Reserve");
                throw;
            }
        }

        public Reserve Get(int ReserveId)
        {
            try
            {
                return _context.Reserves.FirstOrDefault(p => p.Id == ReserveId);

            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error ocurred while showing");
                throw;
            }
        }

        public void Update(Reserve Reserve)
        {
            try
            {
                var _Reserve = _context.Reserves.Find(Reserve.Id);

                _context.Entry(_Reserve).State = EntityState.Modified;
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error ocurred while updating");
                throw;
            }
        }

        public void Delete(int ReserveId)
        {
            try
            {
                var Reserve = _context.Reserves.Find(ReserveId);
                if (Reserve == null)
                {
                    throw new KeyNotFoundException("Reserve not found.");
                }
                _context.Reserves.Remove(Reserve);
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error ocurred while deleting an Reserve");
                throw;
            }
        }
        //Guardar Cambios
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public List<SeatUserDto> GetSeatsByUserId(int UserId)
        {
            try
            {
                var reserves = _context.Reserves
                .Include(r => r.Seat)
                .Include(s => s.Session)
                .ThenInclude(s => s.Sala)
                .Include(o=>o.Session.Obra)
                .Where(r => r.UserId == UserId)
                .ToList();
                var seatUserDtos = reserves.Select(r => new SeatUserDto
                {
                    Id = r.Seat.Id, 
                    Number = r.Seat.Number, 
                    State = r.Seat.State,
                    Session = new SessionDto
                    {
                        Id = r.Session.Id,
                        Obra = new ObraDto
                        {
                            Id = r.Session.Obra.Id,
                            Name = r.Session.Obra.Name,
                            Image = r.Session.Obra.Image,
                            Duration = r.Session.Obra.Duration,
                            Genre = r.Session.Obra.Genre,
                            Description = r.Session.Obra.Description
                        }, 
                        Date = r.Session.Date, 
                        SalaNumber = r.Session.Sala.Number
                    },
                    Price = r.Seat.Price
                }).ToList();
                return seatUserDtos;

            }
            catch (Exception e)
            {
                _logger.LogError(e, "Ocurrió un error en SomeMethod");
                throw;
            }

        }

        public List<Reserve> GetAll()
        {
            try
            {
                return _context.Reserves.Include(r => r.Seat)
                .Include(r => r.Session)
                .ToList();


            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error ocurred while showing Reserves");
                throw;
            }
        }
    }
}