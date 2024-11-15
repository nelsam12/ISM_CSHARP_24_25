using Cours.Core;
using Cours.Models;

namespace Cours.Services;

public interface IDetteService
{
    Task<IEnumerable<Dette>> GetDettesClientAsync(int clientId);
    Task<PaginationDetteModel> GetDettesClientByPaginate(int clientId, int page, int pageSize);
}
