using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Models
{
    public class Role
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string RoleType { get; private set; }

        public Role()
        {

        }

        public Role(string name, string description, string roleType)
        {
            Name = name;
            Description = description;
            RoleType = roleType;
        }
    }
}
