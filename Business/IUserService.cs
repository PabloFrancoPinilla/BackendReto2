namespace TeatroBack.Business;

using TeatroBack.Models;

public interface IUserService
{
    List<UserGetDto> GetAll();
    UserGetDto? Get(int id);
    void Add(User User);
    void Update(User User);
    void Delete(int id);
    string Login(string Mail, string Password);
    public User GetForUpdate(int userId);

    public UserIdDto GetUserByMail(string Mail);
}