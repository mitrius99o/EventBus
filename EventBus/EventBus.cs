using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus
{
    internal class EventBus
    {
        //здесь определяем делегат, который будет держать цепочку событий
        public event EventHandler<NewPostEventArgs> NewPost;
        protected virtual void OnNewPost(NewPostEventArgs e)
        {
            NewPost?.Invoke(this, e);
        }
        public void SimulateNewPost(string msg)
        {
            NewPostEventArgs e = new NewPostEventArgs(msg);
            OnNewPost(e);
        }
    }
}
