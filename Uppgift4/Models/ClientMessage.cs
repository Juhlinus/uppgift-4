using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift4.Models
{
    public class ClientMessage
    {
        public string Name { get; set; }
        public BaseMessage[] messages { get; set; }
    }
}
