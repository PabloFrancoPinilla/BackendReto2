namespace TeatroBack.Data;
using TeatroBack.Models;
public interface IReserveRepository
{
    List<Reserve> GetAll();
    Reserve Get(int id);
    void Add(Reserve reserve);
    void Update(Reserve reserve);
    void Delete(int id);

    List<SeatUserDto> GetSeatsByUserId(int userId);
     List<ReserveDto> GetReserveBySessionId(int SessionId);

}
