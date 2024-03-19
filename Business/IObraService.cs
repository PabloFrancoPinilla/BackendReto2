namespace TeatroBack.Business;

using TeatroBack.Models;

public interface IObraService
{
    List<ObraDto> GetAll();
    ObraDto? Get(int id);
    void Add(Obra obra);
    void Update(ObraDto obra);
    void Delete(int id);

    List<SessionObraDto> GetSessionsByObraId(int obraId);
    
}