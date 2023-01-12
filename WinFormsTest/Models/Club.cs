using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTest.Models
{
    public class Club : BaseModel
    {
        public string Name { get; set; }
        public string City { get; set; }
        public List<BasketballPlayer> BasketballPlayers { get; set; } = new List<BasketballPlayer>();
        public List<TableClub> TableClubs { get; set; } = new List<TableClub>();
        public List<Game> HomeGames { get; set; } = new List<Game>();
        public List<Game> GuestGames { get; set; } = new List<Game>();
    }
}
