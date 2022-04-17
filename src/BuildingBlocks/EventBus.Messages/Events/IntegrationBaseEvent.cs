using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Messages.Events
{
    public  class IntegrationBaseEvent
    {
        public IntegrationBaseEvent()
        {
            MessageId = Guid.NewGuid();
            CreationDate = DateTime.Now;
        }

        public IntegrationBaseEvent(Guid id, DateTime creationDate)
        {
            MessageId = id;
            CreationDate = creationDate;
        }

        public Guid MessageId { get; private set; }
        public DateTime CreationDate { get; private set; }
    }
}
