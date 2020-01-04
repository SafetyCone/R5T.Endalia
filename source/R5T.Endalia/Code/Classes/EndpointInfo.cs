using System;


namespace R5T.Endalia
{
    public class EndpointInfo
    {
        public static EndpointInfo Null = null;


        public Guid Identity { get; set; }
        public string Name { get; set; }
        public EndpointTypeInfo TypeInfo { get; set; }
    }
}
