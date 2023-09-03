using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTest.Models
{
    public class BasketballPlayer : BaseModel
    {
        public string Name { get; set; }
        public string DressNumber { get; set; }
        public string Position { get; set; }
        public Guid ClubId { get; set; }
        public virtual Club Club { get; set; }
    }
}
