namespace TeatroBack.Data;
using TeatroBack.Models;
public interface ISalaRepository
{
 List<SalaDto> GetAll();
 Sala Get(int id);
 void Add(Sala sala);
 void Update(Sala sala);
 void Delete(int id);
 List<SeatSalaDto>GetSeatsBySalaId(int salaId);
}
