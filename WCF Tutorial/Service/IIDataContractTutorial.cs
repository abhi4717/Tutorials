using System.ServiceModel;
using WCF_Tutorial.DataContract;

namespace WCF_Tutorial.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IIDataContractTutorial" in both code and config file together.
    [ServiceContract]
    public interface IIDataContractTutorial
    {
        [OperationContract]
        void DoWork(CompositeDataContract  contract);

        /// <summary>
        /// Example of implementation of KnownType
        /// </summary>
        /// <param name="contract"></param>
        [OperationContract]
        void KnownTypeExample(BaseKnownTypeDataContract contract);

        /// <summary>
        /// Example of implementation of Service Known Type
        /// </summary>
        /// <param name="contract"></param>
        [OperationContract]
        [ServiceKnownType(typeof(ServiceKnownTypeDataContract))]
        void ServiceKnownTypeExample(BaseServiceKnownTypeDataContract contract);
    }
}
