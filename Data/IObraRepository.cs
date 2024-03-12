namespace TeatroBack.Data;
using TeatroBack.Models;
public interface IObraRepository
{
 List<ObraDto> GetAll();
 Obra Get(int id);
 void Add(Obra obra);
 void Update(Obra obra);
 void Delete(int id);
}
