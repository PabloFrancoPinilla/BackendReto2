using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TeatroBack.Models;

namespace TeatroBack.Data
{
    public class ObraEFRepository : IObraRepository
    {
        private readonly ObraContext _context;

        public ObraEFRepository(ObraContext context)
        {
            _context = context;
        }

        public void Add(Obra obra)
        {
            _context.Obras.Add(obra);
            SaveChanges();
        }

        public Obra? Get(int obraId)
        {
            return _context.Obras.FirstOrDefault(p => p.Id == obraId);
        }

        public void Update(Obra obra)
        {
            _context.Entry(obra).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(int obraId)
        {
            var obra = Get(obraId);
            if (obra == null)
            {
                throw new KeyNotFoundException("Obra not found.");
            }
            _context.Obras.Remove(obra);
            SaveChanges();
        }
        //Guardar Cambios
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public List<ObraDto> GetAll()
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
    }
}