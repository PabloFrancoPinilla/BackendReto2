namespace TeatroBack.Business;
using TeatroBack.Models;
using TeatroBack.Data;
public class ObraService : IObraService
{


    private readonly IObraRepository _obraRepository;

    public ObraService(IObraRepository obraRepository)
    {
        _obraRepository = obraRepository;
    }
    public List<ObraDto> GetAll() => _obraRepository.GetAll();

    public ObraDto? Get(int id) => _obraRepository.Get(id);

    public void Add(Obra Obra) => _obraRepository.Add(Obra);

    public void Update(ObraDto Obra) => _obraRepository.Update(Obra);

    public void Delete(int id) => _obraRepository.Delete(id);

    public List<SessionObraDto> GetSessionsByObraId(int obraId) => _obraRepository.GetSessionsByObraId(obraId);


}


