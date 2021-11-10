using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus
{
    class NewPostEventArgs:EventArgs
    {
        private readonly string _msg;
        public NewPostEventArgs(string msg)
        {
            _msg = msg;
        }
        public string Message { get { return _msg; } }
    }
}
