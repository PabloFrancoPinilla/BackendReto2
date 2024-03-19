namespace TeatroBack.Business;

using TeatroBack.Models;

public interface ISeatService{
    List<SeatDto>GetAll();
    SeatDto? Get(int id);
    void Add(Seat Seat);
    void Update(SeatDto Seat);
    void Delete(int id);
    List<Seat> GetSeatsByUserId(int userId);
    List<Seat>  GetSeatsBySession(int number);
    List<SeatSalaDto> GetSeatsBySalaId(int salaId);
    

}