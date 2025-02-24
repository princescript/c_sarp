using System;


namespace Conversion08
{
    internal class Program
    {
        static void Main()
        {
            //int i = 100;
            //float f = i;
            //Console.WriteLine(f);

            float f = 123.45f;
            //int i = (int)f;
            double j = Convert.ToInt64(f);
            Console.WriteLine(j);
            double i = (double)f;
            int a = Convert.ToInt32(f);
            Console.WriteLine(a);

            string strNum = "784G";
            //int j  = Convert.ToInt32(strNum);
            //int j = int.Parse(strNum);

            string strNum1 = "987H";

            int Result = 0;
            bool IsSucess =  int.TryParse(strNum1, out Result);
            if (IsSucess) { 
                Console.WriteLine(Result);
            }
            else
            {
                Console.WriteLine("Inter Vailed Number");
            }

        }
    }
}
