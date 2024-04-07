namespace TeatroBack.Business;
using TeatroBack.Models;
using TeatroBack.Data;
public class UserService : IUserService
{


    private readonly IUserRepository _UserRepository;

    public UserService(IUserRepository UserRepository)
    {
        _UserRepository = UserRepository;
    }
    public List<UserGetDto> GetAll() => _UserRepository.GetAll();

    public UserGetDto? Get(int id) => _UserRepository.Get(id);

    public void Add(User User) => _UserRepository.Add(User);

    public void Update(User User) => _UserRepository.Update(User);

    public void Delete(int id) => _UserRepository.Delete(id);

    public string Login(string Mail, string Password) => _UserRepository.Login(Mail, Password);

    public User GetForUpdate(int userId) => _UserRepository.GetForUpdate(userId);

    public UserIdDto GetUserByMail(string Mail) => _UserRepository.GetUserByMail(Mail);

}


