﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class NPC : Entity
    {
        public Character Owner { get; set; }
    }
}
