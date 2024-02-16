namespace TeatroBack.Business;
using TeatroBack.Models;
using TeatroBack.Data;
public class ObraService: IObraService
{


   private readonly IObraRepository _obraRepository;

    public ObraService(IObraRepository obraRepository)
    {
        _obraRepository = obraRepository;
    }
    public List<Obra> GetAll() => _obraRepository.GetAll();

    public Obra? Get(int id) => _obraRepository.Get(id);

    public void Add(Obra Obra) => _obraRepository.Add(Obra);

    public void Update(Obra Obra) => _obraRepository.Update(Obra);

    public void Delete(int id) => _obraRepository.Delete(id);
   
}


