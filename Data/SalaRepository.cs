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
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred in the Add method");
                throw;
            }
        }

        public SalaDto? Get(int salaId)
        {
            try
            {
                var sala = _context.Salas
                    .Include(s => s.Sessions)
                    .Include(s => s.Seats)
                    .FirstOrDefault(p => p.Id == salaId);

                if (sala != null)
                {
                    var salaDto = new SalaDto
                    {
                        Id = sala.Id,
                        Number = sala.Number,
                        Sessions = sala.Sessions.Select(session => new SessionRDto
                        {
                            Id = session.Id,
                            // Map other properties as needed
                        }).ToList(),
                        Seats = sala.Seats.Select(seat => new SeatDto
                        {
                            Id = seat.Id,
                            Number = seat.Number,
                            State = seat.State,
                        }).ToList()
                    };
                    return salaDto;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred in the Get method");
                throw;
            }
        }

        // Update method already provided in the previous response

        public void Delete(int salaId)
        {
            try
            {
                var sala = _context.Salas.Find(salaId);
                if (sala == null)
                {
                    throw new KeyNotFoundException("Sala not found.");
                }
                _context.Salas.Remove(sala);
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred in the Delete method");
                throw;
            }
        }

        public List<SeatSalaDto> GetSeatsBySalaId(int salaId)
        {
            try
            {
                var seats = _context.Seats
                    .Where(s => s.SalaId == salaId)
                    .Select(s => new SeatSalaDto
                    {
                        Id = s.Id,
                        Number = s.Number,
                        State = s.State,
                    })
                    .ToList();
                return seats;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred in the GetSeatsBySalaId method");
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

                    // Update sessions
                    existingSala.Sessions = salaDto.Sessions.Select(sessionDto => new Session
                    {
                        Id = sessionDto.Id,
                    }).ToList();

                    // Update seats
                    existingSala.Seats = salaDto.Seats.Select(seatDto => new Seat
                    {
                        Id = seatDto.Id,
                        Number = seatDto.Number,
                        State = seatDto.State,
                    }).ToList();

                    _context.Entry(existingSala).State = EntityState.Modified;
                    SaveChanges();
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred in the Update method");
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
                    .Include(s => s.Sessions)
                    .Include(s => s.Seats)
                    .ToList();

                var salaDtos = salas.Select(s => new SalaDto
                {
                    Id = s.Id,
                    Number = s.Number,
                    Sessions = s.Sessions.Select(session => new SessionRDto
                    {
                        Id = session.Id,
                        // Map other properties as needed
                    }).ToList(),
                    Seats = s.Seats.Select(seat => new SeatDto
                    {
                        Id = seat.Id,
                        Number = seat.Number,
                        State = seat.State,
                    }).ToList()
                }).ToList();

                return salaDtos;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred in the GetAll method");
                throw;
            }
        }
    }
}
