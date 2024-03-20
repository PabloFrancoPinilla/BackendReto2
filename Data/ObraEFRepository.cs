using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TeatroBack.Models;
using Microsoft.Extensions.Logging;

namespace TeatroBack.Data
{
    public class ObraEFRepository : IObraRepository
    {
        private readonly ObraContext _context;
        private readonly ILogger<ObraEFRepository> _logger;

        public ObraEFRepository(ObraContext context, ILogger<ObraEFRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void Add(Obra obra)
        {
            try
            {
                _context.Obras.Add(obra);
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error ocurred while adding an obra");
                throw;
            }
        }

        public ObraDto? Get(int obraId)
        {
            try
            {
                var obraDto = _context.Obras.FirstOrDefault(p => p.Id == obraId);
                if (obraDto != null)
                {
                    var obra = new ObraDto
                    {
                        Id = obraDto.Id,
                        Name = obraDto.Name,
                        Image = obraDto.Image,
                        Duration = obraDto.Duration,
                        Genre = obraDto.Genre

                    };

                    return obra;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error ocurred while showing");
                throw;
            }
        }

        public void Update(ObraDto obra)
        {
            try
            {
                var _obra = _context.Obras.Find(obra.Id);
                _obra.Name = obra.Name;
                _obra.Image = obra.Image;
                _obra.Duration = obra.Duration;
                _obra.Genre = obra.Genre;
                _context.Entry(_obra).State = EntityState.Modified;
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error ocurred while updating");
                throw;
            }
        }

        public void Delete(int obraId)
        {
            try
            {
                var obra = _context.Obras.Find(obraId);
                if (obra == null)
                {
                    throw new KeyNotFoundException("Obra not found.");
                }
                _context.Obras.Remove(obra);
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error ocurred while deleting an obra");
                throw;
            }
        }
        //Guardar Cambios
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public List<SessionObraDto> GetSessionsByObraId(int obraId)
        {
            try
            {
                var sessions = _context.Sessions.Where(o => o.ObraId == obraId)
                .Select(o => new SessionObraDto
                {
                    Id = o.Id,
                    Date = o.Date,
                    SalaNumber = o.Sala.Number
                })
                .ToList();
                return sessions;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Ocurrió un error en SomeMethod");
                throw;
            }

        }

        public List<ObraDto> GetAll()
        {
            try
            {
                var obra = _context.Obras
                .ToList();

                var obraDto = obra.Select(o => new ObraDto
                {
                    Id = o.Id,
                    Name = o.Name,
                    Image = o.Image,
                    Duration = o.Duration,
                    Genre = o.Genre
                }).ToList();

                return obraDto;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error ocurred while showing obras");
                throw;
            }
        }
    }
}