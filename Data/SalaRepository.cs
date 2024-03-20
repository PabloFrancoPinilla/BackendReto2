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

        public SalaDto? Get(int salaId)
        {
            try
            {
                var salaDto = _context.Salas.Include(s => s.Seats)
                .FirstOrDefault(p => p.Id == salaId);


                if (salaDto != null)
                {
                    var sala = new SalaDto
                    {
                        Id = salaDto.Id,
                        Number = salaDto.Number,
                        SessionId = salaDto.SessionId,
                        Seats = salaDto.Seats.Select(seat => new SeatDto
                        {
                            Id = seat.Id,
                            Number = seat.Number,
                            UserId = seat.UserId,
                            State = seat.State,
                            SalaId = seat.SalaId
                        }).ToList()
                    };
                    return sala;
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

        public void Update(SalaDto salaDto)
        {
            try
            {
                var existingSala = _context.Salas.Include(s => s.Seats).FirstOrDefault(s => s.Id == salaDto.Id);
                if (existingSala != null)
                {
                    existingSala.Number = salaDto.Number;
                    existingSala.SessionId = salaDto.SessionId;

                    // Actualiza las plazas solo si es necesario
                    existingSala.Seats = salaDto.Seats.Select(seatDto => new Seat
                    {
                        Id = seatDto.Id,
                        Number = seatDto.Number,
                        UserId = seatDto.UserId,
                        State = seatDto.State,
                    }).ToList();

                    _context.Entry(existingSala).State = EntityState.Modified;
                    SaveChanges();
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Ocurrió un error en el método Update");
                throw;
            }
        }

        public void Delete(int salaId)
        {
            try
            {
                var sala = _context.Salas.Find(salaId);
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
                    Number = s.Number,
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
