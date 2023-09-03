using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsTest.Data;
using WinFormsTest.Models;
using WinFormsTest.Models.DTO;

namespace WinFormsTest.Service;

public class ApplicationService
{

	private readonly ApplicationDbContext _context;

    public ApplicationService()
    {
        _context = new ApplicationDbContext();
    }

    public async Task<List<BasketballPlayer>> GetAllPlayersByClubAsync(Guid clubId) 
    {
        return await _context
            .BasketballPlayer
            .Where(x => x.ClubId == clubId)
            .ToListAsync();
    }

    public async Task<List<Club>> GetClubsAsync() 
    {
        return await _context.Club.ToListAsync();
    }

    public async Task InsertGame(Game game) 
    {
        _context.Game.Add(game);
        await _context.SaveChangesAsync();
    }

    public BasketballPlayer GetPlayerAsync(Guid id)
    {
        return _context
            .BasketballPlayer
            .Where(x => x.Id == id)
            .First();
    }
        
}
