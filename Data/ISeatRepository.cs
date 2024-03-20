namespace TeatroBack.Data;
using TeatroBack.Models;
public interface ISeatRepository
{
    List<SeatDto> GetAll();
    SeatDto Get(int id);
    void Add(Seat seat);
    void Update(SeatDto seat);
    void Delete(int id);
    List<Seat> GetSeatsByUserId(int userId);
    List<SeatSalaDto> GetSeatsBySalaId(int sessionId);
}
