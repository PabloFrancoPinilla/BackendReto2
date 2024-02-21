namespace TeatroBack.Business;

using TeatroBack.Models;

public interface ISessionService{
    List<Session>GetAll();
    Session? Get(int id);
    void Add(Session Session);
    void Update(Session Session);
    void Delete(int id);
    

}