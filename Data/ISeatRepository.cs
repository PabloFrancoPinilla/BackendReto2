namespace TeatroBack.Data;
using TeatroBack.Models;
public interface ISeatRepository
{
    List<SeatDto> GetAll();
    Seat Get(int id);
    void Add(Seat seat);
    void Update(Seat seat);
    void Delete(int id);
    List<Seat> GetSeatsByUserId(int userId);
    List<Seat> GetSeatsBySession(int number);
    List<SeatSalaDto> GetSeatsBySalaId(int sessionId);
}
