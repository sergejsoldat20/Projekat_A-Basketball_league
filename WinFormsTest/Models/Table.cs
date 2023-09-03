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
        public virtual List<Club> Clubs { get; set; } = new List<Club>();
        public virtual League League { get; set; }
        
    }
}
