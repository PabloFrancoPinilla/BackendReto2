namespace TeatroBack.Business;
using TeatroBack.Models;
using TeatroBack.Data;
public class ReserveService : IReserveService
{


    private readonly IReserveRepository _ReserveRepository;

    public ReserveService(IReserveRepository ReserveRepository)
    {
        _ReserveRepository = ReserveRepository;
    }
    public List<Reserve> GetAll() => _ReserveRepository.GetAll();

    public Reserve? Get(int id) => _ReserveRepository.Get(id);

    public void Add(Reserve Reserve) => _ReserveRepository.Add(Reserve);

    public void Update(Reserve Reserve) => _ReserveRepository.Update(Reserve);

    public void Delete(int id) => _ReserveRepository.Delete(id);
    public List<SeatUserDto> GetSeatsByUserId(int userId) => _ReserveRepository.GetSeatsByUserId(userId);

    public List<ReserveDto> GetReserveBySessionId(int SessionId) => _ReserveRepository.GetReserveBySessionId(SessionId);

    


}


