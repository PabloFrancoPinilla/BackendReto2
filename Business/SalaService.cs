namespace TeatroBack.Business;
using TeatroBack.Models;
using TeatroBack.Data;
public class SalaService: ISalaService
{


   private readonly ISalaRepository _SalaRepository;

    public SalaService(ISalaRepository SalaRepository)
    {
        _SalaRepository = SalaRepository;
    }
    public List<SalaDto> GetAll() => _SalaRepository.GetAll();

    public Sala? Get(int id) => _SalaRepository.Get(id);

    public void Add(Sala Sala) => _SalaRepository.Add(Sala);

    public void Update(Sala Sala) => _SalaRepository.Update(Sala);

    public void Delete(int id) => _SalaRepository.Delete(id);
    public  List<SeatSalaDto> GetSeatsBySalaId(int salaId) => _SalaRepository.GetSeatsBySalaId(salaId);
   
}


