using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTest.Models
{
    public class Game : BaseModel
    {
        public string City { get; set; }
        public string Arena { get; set; }
        public Guid GuestId { get; set; }
        public Guid HomeId { get; set; }
        public virtual Club Guest { get; set; }
        public virtual Club Home { get; set; }
        public DateTime GameTime { get; set; }
        public int GuestPoints { get; set; }
        public int HomePoints { get; set; }
    }
}

