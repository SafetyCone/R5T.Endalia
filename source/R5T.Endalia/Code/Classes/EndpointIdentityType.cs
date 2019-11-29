using System;

using R5T.Guide;


namespace R5T.Endalia
{
    public class EndpointTypeIdentity : TypedGuid
    {
        #region Static

        public static EndpointTypeIdentity New()
        {
            var endpointTypeIdentity = new EndpointTypeIdentity();
            return endpointTypeIdentity;
        }

        public static EndpointTypeIdentity From(Guid value)
        {
            var endpointTypeIdentity = new EndpointTypeIdentity(value);
            return endpointTypeIdentity;
        }

        #endregion


        public EndpointTypeIdentity(Guid value)
            : base(value)
        {
        }

        public EndpointTypeIdentity()
            : this(TypedGuid.GetNewGuid())
        {
        }
    }
}
