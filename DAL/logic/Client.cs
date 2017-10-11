﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.logic
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
