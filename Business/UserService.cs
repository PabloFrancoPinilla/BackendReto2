namespace TeatroBack.Business;
using TeatroBack.Models;
using TeatroBack.Data;
public class UserService: IUserService
{


   private readonly IUserRepository _UserRepository;

    public UserService(IUserRepository UserRepository)
    {
        _UserRepository = UserRepository;
    }
    public List<User> GetAll() => _UserRepository.GetAll();

    public User? Get(int id) => _UserRepository.Get(id);

    public void Add(User User) => _UserRepository.Add(User);

    public void Update(User User) => _UserRepository.Update(User);

    public void Delete(int id) => _UserRepository.Delete(id);
   
}


