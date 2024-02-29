namespace TeatroBack.Data;
using TeatroBack.Models;
public interface ISeatRepository
{
 List<Seat> GetAll();
 Seat Get(int id);
 void Add(Seat seat);
 void Update(Seat seat);
 void Delete(int id);
 List<Seat> GetSeatsByUserId(int userId);
}
