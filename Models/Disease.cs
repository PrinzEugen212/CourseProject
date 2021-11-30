using System;
using System.Collections.Generic;
using System.Text;

namespace CorseProject.Models
{
    public class Disease
    {
        public int? ID { get; set; }
        public string Name { get; set; }

        public Disease(string name)
        {
            Name = name;
        }
    }
}
