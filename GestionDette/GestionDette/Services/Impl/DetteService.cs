using Cours.Core;
using Cours.Data;
using Cours.Models;
using Microsoft.EntityFrameworkCore;

namespace Cours.Services;

public class DetteService : IDetteService
{

    private readonly ApplicationDbContext _context;

    public DetteService(ApplicationDbContext context)
    {
        this._context = context;
    }
    public async Task<IEnumerable<Dette>> GetDettesClientAsync(int clientId)
    {
        return await _context.Dettes
        .Where(dette => dette.ClientId == clientId)
        .ToListAsync();
    }

    public async Task<PaginationDetteModel> GetDettesClientByPaginate(int clientId, int page, int pageSize)
    {
        var dettes = _context.Dettes.Where(dette => dette.ClientId == clientId).AsQueryable<Dette>();
        var client = await _context.Clients.SingleAsync<Client>(client => client.Id == clientId)!;
        return await PaginationDetteModel.PaginateDette(dettes, pageSize, page, client);
    }
}
