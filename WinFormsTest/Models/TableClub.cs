using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTest.Models
{
    public class TableClub
    {
        public Guid ClubId { get; set; }
        public Guid TableId { get; set; }
        public int ClubPoints { get; set; }
    }
}
