namespace TeatroBack.Data;
using TeatroBack.Models;
public interface ISeatRepository
{
 List<Seat> GeatAll();
 Seat Get(int id);
 void Add(Seat seat);
 void Update(Seat seat);
 void Delete(int id);
}
