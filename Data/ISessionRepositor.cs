namespace TeatroBack.Data;
using TeatroBack.Models;
public interface ISessionRepository
{
    List<SessionDto> GetAll();
    Session Get(int id);
    void Add(Session Session);
    void Update(Session Session);
    void Delete(int id);

}