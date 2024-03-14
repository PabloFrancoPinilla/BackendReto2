using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TeatroBack.Models;
using Serilog;
using Microsoft.Extensions.Logging;

namespace TeatroBack.Data
{
    public class SalaRepository : ISalaRepository
    {
        private readonly ObraContext _context;
        private readonly ILogger<SalaRepository> _logger;


        public SalaRepository(ObraContext context, ILogger<SalaRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void Add(Sala sala)
        {
            try
            {
                _context.Salas.Add(sala);
                Log.Information("sala added");
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Ocurrió un error en SomeMethod");
                throw;
            }
        }

        public Sala? Get(int salaId)
        {
            try
            {
                return _context.Salas.FirstOrDefault(p => p.Id == salaId);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Ocurrió un error en SomeMethod");
                throw;
            }
        }

        public void Update(Sala sala)
        {
            try
            {
                _context.Entry(sala).State = EntityState.Modified;
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Ocurrió un error en SomeMethod");
                throw;
            }
        }

        public void Delete(int salaId)
        {
            try
            {
                var sala = Get(salaId);
                if (sala == null)
                {
                    throw new KeyNotFoundException("sala not found.");
                }
                _context.Salas.Remove(sala);
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Ocurrió un error en SomeMethod");
                throw;
            }
        }

        public List<SeatSalaDto> GetSeatsBySalaId(int salaId)
        {

            try
            {
                var seats = _context.Seats.Where(s => s.SalaId == salaId)
                .Select(s => new SeatSalaDto
                {
                    Id = s.Id,
                    Number = s.Number,
                    State = s.State,
                    UserId = s.UserId
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

        public List<SalaDto> GetAll()
        {
            try
            {
                var salas = _context.Salas
                    .Include(s => s.Seats) 
                    .ToList();

                var salaDtos = salas.Select(s => new SalaDto
                {
                    Id = s.Id,
                    Numero = s.Numero,
                    SessionId = s.SessionId, 
                    Seats = s.Seats.Select(seat => new SeatDto
                    {
                        Id = seat.Id,
                        Number = seat.Number,
                        UserId = seat.UserId,
                        State = seat.State,
                        SalaId = seat.SalaId
                    }).ToList()
                }).ToList();

                return salaDtos;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Ocurrió un error en GetAll");
                throw;
            }
        }

    }
}
