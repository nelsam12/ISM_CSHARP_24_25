using Cours.Core;
using Cours.Models;

namespace Cours.Services;

public interface IClientService{
    Task<IEnumerable<Client>> GetClientsAsync();
    Task<Client> Create(Client client);

    Task<PaginationModel<Client>> GetClientsByPaginate(int page, int pageSize);
}
