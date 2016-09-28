namespace ProfessionalTutorial.Chapter_3_Inheritance
{
    public class MyBaseClass
    {
        public string Name;

        //public MyBaseClass()
        //{
        //    Name = "<No Name>";
        //}

        public string MyGrooveMethod()
        {
            return string.Empty;
        }
    }

    public class MyDerivedClass: MyBaseClass
    {
        public int Age;

        public MyDerivedClass()
        {
            Age = 0;
        }

        public new int MyGrooveMethod()
        {
            base.MyGrooveMethod();
            return 0;
        }
    }

    public class Implementation_Inheritance
    {

    }
}
