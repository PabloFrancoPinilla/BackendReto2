namespace TeatroBack.Business;

using TeatroBack.Models;

public interface IObraService
{
    List<ObraDto> GetAll();
    Obra? Get(int id);
    void Add(Obra obra);
    void Update(Obra obra);
    void Delete(int id);

    List<SessionObraDto> GetSessionsByObraId(int obraId);
    
}