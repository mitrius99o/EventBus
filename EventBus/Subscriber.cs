using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus
{
    internal class Subscriber
    {
        public Subscriber(EventBus eventBus)
        {
            eventBus.NewPost += OnEvent;
        }
        private void OnEvent(object sender, NewPostEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
        public void Unregister(EventBus eventBus)
        {
            eventBus.NewPost -= OnEvent;
        }
    }
}
