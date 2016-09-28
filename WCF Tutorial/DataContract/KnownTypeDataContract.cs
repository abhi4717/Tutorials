using System.Runtime.Serialization;

namespace WCF_Tutorial.DataContract
{
    [DataContract]
    public class KnownTypeDataContract: BaseKnownTypeDataContract
    {
        [DataMember]
        public int VersionNumber { get; set; }
    }

    [DataContract]
    [KnownType(typeof(KnownTypeDataContract))]
    public class BaseKnownTypeDataContract
    {
        [DataMember]
        public string Name { get; set; }
    }
}