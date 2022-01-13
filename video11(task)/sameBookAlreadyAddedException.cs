using System;
using System.Collections.Generic;
using System.Text;

namespace video11_task_
{
    class sameBookAlreadyAddedException:Exception
    {
        private string _message;
        public sameBookAlreadyAddedException(string message)
        {
            _message = message;
        }
        public override string Message => _message;
    }
}
