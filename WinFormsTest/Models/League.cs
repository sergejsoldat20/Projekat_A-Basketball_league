﻿using System;
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
        public Guid TableId { get; set; }
        public Table Table { get; set; }
    }
}
