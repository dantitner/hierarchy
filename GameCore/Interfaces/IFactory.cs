﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameCore.Interfaces
{
    public interface IFactory
    {
        IEvent Generate<IEvent>();        
    }
}
