using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTest.Models
{
    public class BaseModel 
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Timestamp]
        public byte[] RowVersion { get; set; } = new byte[8];
        public DateTime CreationTime { get; private set; } = DateTime.Now;
    }
}
