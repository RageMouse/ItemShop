using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Models
{
    public class Role
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public Role()
        {

        }

        public Role(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
