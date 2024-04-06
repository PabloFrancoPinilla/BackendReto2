namespace TeatroBack.Business;

using TeatroBack.Models;

public interface IReserveService
{
    List<Reserve> GetAll();
    Reserve? Get(int id);
    void Add(Reserve Reserve);
    void Update(Reserve Reserve);
    void Delete(int id);

    List<SeatUserDto> GetSeatsByUserId(int userId);
     List<ReserveDto> GetReserveBySessionId(int SessionId);
    
}