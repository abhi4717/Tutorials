using System;
using WCF_Tutorial.DataContract;

namespace WCF_Tutorial.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "IDataContractTutorial" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select IDataContractTutorial.svc or IDataContractTutorial.svc.cs at the Solution Explorer and start debugging.
    public class IDataContractTutorial : IIDataContractTutorial
    {
        public void DoWork(CompositeDataContract  contract)
        {
        }

        public void KnownTypeExample(BaseKnownTypeDataContract contract)
        {

        }

        public void ServiceKnownTypeExample(BaseServiceKnownTypeDataContract contract)
        {
        }
    }
}
