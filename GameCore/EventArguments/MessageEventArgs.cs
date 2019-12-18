using System;
using System.Collections.Generic;
using System.Text;

namespace GameCore.EventArguments
{
    public class MessageEventArgs : EventArgs
    {
        public string Message { get; set; }

        public MessageEventArgs(string message)
        {
            Message = message;
        }
    }
}
