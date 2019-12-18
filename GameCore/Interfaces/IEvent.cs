using System;
using System.Collections.Generic;
using System.Text;

namespace GameCore.Interfaces
{
    public interface IEvent
    {
        void Execute();
        void Drop();
    }
}
