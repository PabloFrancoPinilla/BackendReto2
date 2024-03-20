namespace TeatroBack.Data;
using TeatroBack.Models;
public interface ISessionRepository
{
    List<SessionDto> GetAll();
    SessionDto Get(int id);
    void Add(Session Session);
    void Update(SessionDto Session);
    void Delete(int id);
    List<SeatSalaDto> GetSeatsBySessionId(int sessionId);

}