using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTest.Models
{
    public class Club : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public virtual List<BasketballPlayer> BasketballPlayers { get; set; } = new List<BasketballPlayer>();
        public virtual List<Table> Tables { get; set; } = new List<Table>();
        public virtual List<Game> HomeGames { get; set; } = new List<Game>();
        public virtual List<Game> GuestGames { get; set; } = new List<Game>();
    }
}
