namespace TeatroBack.Business;
using TeatroBack.Models;
using TeatroBack.Data;
public class SeatService: ISeatService
{


   private readonly ISeatRepository _SeatRepository;

    public SeatService(ISeatRepository SeatRepository)
    {
        _SeatRepository = SeatRepository;
    }
    public List<Seat> GetAll() => _SeatRepository.GetAll();

    public Seat? Get(int id) => _SeatRepository.Get(id);

    public void Add(Seat Seat) => _SeatRepository.Add(Seat);

    public void Update(Seat Seat) => _SeatRepository.Update(Seat);

    public void Delete(int id) => _SeatRepository.Delete(id);
    public  List<Seat> GetSeatsByUserId(int userId) => _SeatRepository.GetSeatsByUserId(userId);
   
}


