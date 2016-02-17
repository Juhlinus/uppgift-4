using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift4.Models
{
    [Serializable]
    public class BaseMessage
    {
        public int Id { get; set; }
        public string Time { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public bool Read { get; set; }
    }
}
