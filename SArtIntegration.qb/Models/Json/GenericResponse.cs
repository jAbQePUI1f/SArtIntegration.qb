using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SArtIntegration.qb.Models.Json
{
    public  class GenericResponse<T>
    {
        public T data { get; set; }
        public int responseStatus { get; set; }
        public Message message { get; set; }
    }
    public class Message
    {
        public string code { get; set; }
        public string defaultMessage { get; set; }
    }
}
