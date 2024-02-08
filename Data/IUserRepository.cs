namespace TeatroBack.Data;
using TeatroBack.Models;
public interface IUserRepository
{
 List<User> GeatAll();
 User Get(int id);
 void Add(User user);
 void Update(User user);
 void Delete(int id);
}