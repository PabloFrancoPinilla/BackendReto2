namespace TeatroBack.Data;
using TeatroBack.Models;
public interface ISalaService
{
 List<SalaDto> GetAll();
 SalaDto Get(int id);
 void Add(Sala sala);
 void Update(SalaDto sala);
 void Delete(int id);
 List<SeatSalaDto>GetSeatsBySalaId(int salaId);
}
