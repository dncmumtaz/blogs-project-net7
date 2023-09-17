﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Notification : BaseEntity
    {
        public string Type { get; set; }
        public string TypeSymbol { get; set; }
        public string Details { get; set; }
        public bool Status { get; set; }

    }
}
