using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTest.Models
{
    public class Table : BaseModel
    {
        public string Season { get; set; }
        public List<TableClub> TableClubs { get; set; } = new List<TableClub>();
        public League League { get; set; }
        
    }
}
