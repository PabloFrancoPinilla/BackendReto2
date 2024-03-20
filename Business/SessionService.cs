namespace TeatroBack.Business;
using TeatroBack.Models;
using TeatroBack.Data;
public class SessionService : ISessionService
{


    private readonly ISessionRepository _SessionRepository;

    public SessionService(ISessionRepository SessionRepository)
    {
        _SessionRepository = SessionRepository;
    }
    public List<SessionDto> GetAll() => _SessionRepository.GetAll();

    public SessionDto? Get(int id) => _SessionRepository.Get(id);

    public void Add(Session Session) => _SessionRepository.Add(Session);

    public void Update(SessionDto Session) => _SessionRepository.Update(Session);

    public void Delete(int id) => _SessionRepository.Delete(id);
    public List<SeatSalaDto> GetSeatsBySessionId(int sessionId) => _SessionRepository.GetSeatsBySessionId(sessionId);

}


