using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy.Interfaces
{
    interface IUndead
    {
        int CallTime { get; set; } //время призыва

        void Destroy();  //дефолтня реализация => убрать с поля боя

        void DecreaseCalltime(); //дефолтная реализация => CallTime--;
    }
}
