using System.Runtime.Serialization;

namespace WCF_Tutorial.DataContract
{
    [DataContract(Namespace ="MyNamespace")]
    public class CompositeDataContract
    {
        [DataMember]
        NamespaceDataContract CompositeContract { get; set; }
    }
}