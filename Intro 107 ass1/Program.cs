using System;

namespace Intro_107_ass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            p.Exc1();

            float res= p.Sum(123.334f,345.123f);
            Console.WriteLine(res);

            string a =p.GetTheAnswer();
            Console.WriteLine("The answer to life , universe and everything is " + a);
            decimal exp = p.GetMostExpensive(098771.23m,123098.007m,);


        }

        string GetTheAnswer()
        {
            return "42";
        }
        float Sum (float n1 , float n2)
        {
            return n1 + n2;
        }

        void Exc1()
        {
            //print numbers from 1 to 14
            for(int i=1;i<=14;i++)
            {  
                if(i !=7 && i !=13)
                {
                    Console.WriteLine(i);
                }
                
            }
        }


        void TestVariables()
        {
            //data_type name
            string name = "Joan Gradillas";
            int age = 22;
            decimal total = 99.34m;
            float average = 342.344f;
            bool found = false;

         

        }

        // return_type name (params)
        string SayHello()
        {
            Console.WriteLine("Hello there");
            int age =17;

            if(age > 18)
            {
                return "Hi";
            }
            return "";
            
        }
    }
}
