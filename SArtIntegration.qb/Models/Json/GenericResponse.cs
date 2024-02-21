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
