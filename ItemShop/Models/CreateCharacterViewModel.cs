﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemShop.Models
{
    public class CreateCharacterViewModel
    {
        public int CharacterId { get; private set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public int RoleId { get; set; }
    }
}
