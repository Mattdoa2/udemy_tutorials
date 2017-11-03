using System;
using System.Collections.Generic;

namespace vega.Models
{
    public class Make
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Model> Models { get; set; }
        
        Make(){}
        
    }
}