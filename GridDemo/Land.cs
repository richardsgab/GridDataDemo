﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridDemo
{
    public class Land
    {
        
        public string Name { get; set; }

        public Land(string name)
        {
            
            Name = name;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
