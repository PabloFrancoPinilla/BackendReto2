namespace TeatroBack.Business;

using TeatroBack.Models;

public interface ISessionService
{
    List<SessionDto> GetAll();
    SessionDto? Get(int id);
    void Add(Session Session);
    void Update(SessionDto Session);
    void Delete(int id);



}