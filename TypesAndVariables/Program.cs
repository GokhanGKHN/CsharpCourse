namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Value Types (Değer Tipleri)
            //Console.WriteLine("Hello, World!");

            decimal number7     = 20;
            double  number6     = 10.4;
            char    character   = 'a';         
            bool    condition   = false;
            sbyte   number5     =   56;
            byte    number4     =   255;
            short   number3     =   32767;
            int     number1     =   2147483647;
            long    number2     =   -922337203685477580;
            var     number8     = 10;
                    number8     = 'A';

        

            Console.WriteLine("Nuber1 is{0}",number1);
            Console.WriteLine("Nuber2 is{0}",number2);
            Console.WriteLine("Nuber3 is{0}",number3);
            Console.WriteLine("Nuber4 is{0}",number4);
            Console.WriteLine("Nuber5 is{0}",number5);
            Console.WriteLine("Nuber6 is{0}", number6);
            Console.WriteLine("Nuber7 is{0}", number7);
            Console.WriteLine("Nuber8 is{0}", number8);
            Console.WriteLine("Condition is{0}",condition);
            Console.WriteLine("Character is{0}", (int)character);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();
        }
       
    }
    enum Days
    {
        Monday , Tuesday, Wednesday, Thursday, Friday,Saturday, Sunday
    }
}