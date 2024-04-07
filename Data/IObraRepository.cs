namespace TeatroBack.Data;
using TeatroBack.Models;
public interface IObraRepository
{
    List<ObraDto> GetAll();
    ObraDto Get(int id);
    void Add(Obra obra);
    void Update(ObraDto obra);
    void Delete(int id);

    List<SessionObraDto> GetSessionsByObraId(int obraId);

}
