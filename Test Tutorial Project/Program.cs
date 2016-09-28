namespace Test_Tutorial_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new DataContractTutorial.IDataContractTutorialClient();
            var knowType = new DataContractTutorial.KnownTypeDataContract();
            //var serviceKnownType = new DataContractTutorial.ServiceKnownTypeDataContract();
            //service.KnownTypeExample(knowType);
            //service.ServiceKnownTypeExample(serviceKnownType);

        }
    }
}
