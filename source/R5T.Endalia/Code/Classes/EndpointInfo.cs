using System;


namespace R5T.Endalia
{
    public class EndpointInfo
    {
        public Guid Identity { get; set; }
        public string Name { get; set; }
        public EndpointTypeInfo TypeInfo { get; set; }
    }
}
