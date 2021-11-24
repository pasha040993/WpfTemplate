using System;
using System.Collections.Generic;
using System.Text;

namespace WpfTemplate.ViewModel
{
    class MessageTextViewModel : ITag
    {
        public string Message { get; }

        public MessageTextViewModel(string message)
        {
            Message = message;
        }
    }
}
