using System;
using System.Collections.Generic;
using System.Text;

namespace HW
{
    class value
    {
        public value()
        {
            
        }
        
        public value(int id,string name,string category)
        {
            Id = id;
            Name = name;
            Category = category;
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }
    }

    class Locate : value
    {
        public Locate()
        {

        }
        public Locate(string location)
        {
            Location = location;

        }
        
        public string Location { get; set; }
    }
}
