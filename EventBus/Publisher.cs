using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus
{
    class Publisher
    {
        EventBus EventBus { get; set; }
        public Publisher(EventBus eventBus)
        {
            EventBus = eventBus;
        }
    }
}
