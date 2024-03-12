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
            try{
            _context.Obras.Add(obra);
            SaveChanges();
            }catch(Exception e){
                _logger.LogError(e,"An error ocurred while adding an obra");
                throw;
            }
        }

        public Obra? Get(int obraId)
        {
            try
            {
                return _context.Obras.FirstOrDefault(p => p.Id == obraId);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error ocurred while showing");
                throw;
            }
        }

        public void Update(Obra obra)
        {
            try
            {
                _context.Entry(obra).State = EntityState.Modified;
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
            try{
            var obra = Get(obraId);
            if (obra == null)
            {
                throw new KeyNotFoundException("Obra not found.");
            }
            _context.Obras.Remove(obra);
            SaveChanges();
            }catch(Exception e){
                _logger.LogError(e,"An error ocurred while deleting an obra");
                throw;
            }
        }
        //Guardar Cambios
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public List<ObraDto> GetAll()
        {
            try{
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
            }catch(Exception e){
                _logger.LogError(e,"An error ocurred while showing obras");
                throw;
            }
        }
    }
}