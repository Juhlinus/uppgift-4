using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Uppgift4.Models
{
    [Serializable]
    public class Messages : IEnumerable<BaseMessage>
    {
        private List<BaseMessage> _messages = new List<BaseMessage>();

        public void Add(BaseMessage message)
        {
            if (_messages == null)
                throw new NullReferenceException("_messages");

            _messages.Add(message);
        }

        public BaseMessage Get(int i)
        {
            if (i > _messages.Count())
                throw new IndexOutOfRangeException("i");

            return _messages[i];
        }

        public int Count()
        {
            return _messages.Count;
        }

        IEnumerator<BaseMessage> IEnumerable<BaseMessage>.GetEnumerator()
        {
            return _messages.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _messages.GetEnumerator();
        }
    }
}
