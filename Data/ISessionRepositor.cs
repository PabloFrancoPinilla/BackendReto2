namespace TeatroBack.Data;
using TeatroBack.Models;
public interface ISessionRepository
{
 List<Session> GetAll();
 Session Get(int id);
 void Add(Session Session);
 void Update(Session Session);
 void Delete(int id);
}
