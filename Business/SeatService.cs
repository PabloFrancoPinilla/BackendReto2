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
    public List<SeatDto> GetAll() => _SeatRepository.GetAll();

    public SeatDto? Get(int id) => _SeatRepository.Get(id);

    public void Add(Seat Seat) => _SeatRepository.Add(Seat);

    public void Update(SeatDto Seat) => _SeatRepository.Update(Seat);

    public void Delete(int id) => _SeatRepository.Delete(id);
    
    public  List<SeatDto> GetSeatsBySalaId(int salaId) => _SeatRepository.GetSeatsBySalaId(salaId);
   
}


