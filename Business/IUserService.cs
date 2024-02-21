namespace TeatroBack.Business;

using TeatroBack.Models;

public interface IUserService{
    List<User>GetAll();
    User? Get(int id);
    void Add(User User);
    void Update(User User);
    void Delete(int id);
    

}