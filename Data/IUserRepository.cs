namespace TeatroBack.Data;
using TeatroBack.Models;
public interface IUserRepository
{
    List<UserGetDto> GetAll();
    UserGetDto Get(int id);
    void Add(User user);
    void Update(User user);
    void Delete(int id);

    string Login(string Mail, string Password);
    public User GetForUpdate(int userId);

}
