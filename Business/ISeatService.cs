namespace TeatroBack.Business;

using TeatroBack.Models;

public interface ISeatService{
    List<SeatDto>GetAll();
    Seat? Get(int id);
    void Add(Seat Seat);
    void Update(Seat Seat);
    void Delete(int id);
    List<Seat> GetSeatsByUserId(int userId);
    

}