using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTest.Models
{
    public class League : BaseModel
    {
        public string State { get; set; }
        public string Name { get; set; }
        public int TableId { get; set; }
        public virtual Table Table { get; set; }
    }
}
