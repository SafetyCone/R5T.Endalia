using System;

using R5T.Guide;


namespace R5T.Endalia
{
    public class EndpointIdentity : TypedGuid
    {
        #region Static

        public static EndpointIdentity New()
        {
            var endpointIdentity = new EndpointIdentity();
            return endpointIdentity;
        }

        public static EndpointIdentity From(Guid value)
        {
            var endpointIdentity = new EndpointIdentity(value);
            return endpointIdentity;
        }

        #endregion


        public EndpointIdentity(Guid value)
            : base(value)
        {
        }

        public EndpointIdentity()
            : this(TypedGuid.GetNewGuid())
        {
        }
    }
}
