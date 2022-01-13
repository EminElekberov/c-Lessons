using System;
using System.Collections.Generic;
using System.Text;

namespace video11_task_
{
    class BookNorFoundException:Exception
    {
        private string _message;
        public BookNorFoundException(string message)
        {
            _message = message;
        }
        public override string Message => _message;

    }
}
