using System;

namespace Console_APP_pratice
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = 1;
            int two = 2;
            Console.WriteLine("Do you know what is: ");
            Console.Write(" 1 + 2");
            Console.ReadLine();
            Console.WriteLine("the Solution is: ");
            Console.Write(one+two);
            Console.ReadLine();
            Console.WriteLine("Now this will become a Calculator");
            Console.WriteLine("Let's Start");
            Console.ReadKey();
            Console.WriteLine("let's Start with 2 digits for calculations");
            Console.ReadLine();
            Console.WriteLine("Type the first digit");
            Console.Write("First Digit: ");
            int fD = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Great!!");
            Console.ReadKey();
            Console.WriteLine("let's start with second digit");
            Console.Write("second Digit: ");
            int SD = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Great!!");
            Console.WriteLine("now decide what operation your would like to apply ");
            Console.WriteLine("                a= addititon(+)    ");
            Console.WriteLine("                s= subtraction(-)    ");
            Console.WriteLine("                d= Divition(/)    ");
            Console.WriteLine("                x= Multiplication(x)    ");
            Console.WriteLine("Which opperation to you want to just press the operation key(A,S,D,X)");
            
            switch (Console.ReadLine())
            {
                case "a":
                    
                        Console.WriteLine("the answer is:");
                        Console.WriteLine(fD+SD);
                    break;
                case "s":

                    Console.WriteLine("the answer is:");
                    Console.WriteLine(fD - SD);
                    break;
                case "d":

                    Console.WriteLine("the answer is:");
                    Console.WriteLine(fD / SD);
                    break;
                case "x":

                    Console.WriteLine("the answer is:");
                    Console.WriteLine(fD *SD);
                    break;

            }
            Console.WriteLine("This was the Answer, I am sure that this was a correct answer");
            Console.ReadKey();
            Console.Write("Do you want to do more operation if yess then type yess if not then no. yess or no?");
            String mon = (Console.ReadLine());
            
            
            if (mon == "yess")
            {
                Console.WriteLine("Now this will become a Calculator");
                Console.WriteLine("Let's Start");
                Console.ReadKey();
                Console.WriteLine("let's Start with 2 digits for calculations");
                Console.ReadLine();
                Console.WriteLine("Type the first digit");
                Console.Write("First Digit: ");
                int rD = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Great!!");
                Console.ReadKey();
                Console.WriteLine("let's start with second digit");
                Console.Write("second Digit: ");
                int gD = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Great!!");
                Console.WriteLine("now decide what operation your would like to apply ");
                Console.WriteLine("                a= addititon(+)    ");
                Console.WriteLine("                s= subtraction(-)    ");
                Console.WriteLine("                d= Divition(/)    ");
                Console.WriteLine("                x= Multiplication(x)    ");
                Console.WriteLine("Which opperation to you want to just press the operation key(A,S,D,X)");

                switch (Console.ReadLine())
                {
                    case "a":

                        Console.WriteLine("the answer is:");
                        Console.WriteLine(rD + gD);
                        break;
                    case "s":

                        Console.WriteLine("the answer is:");
                        Console.WriteLine( fD - SD);
                        break;
                    case "d":

                        Console.WriteLine("the answer is:");
                        Console.WriteLine(fD / SD);
                        break;
                    case "x":

                        Console.WriteLine("the answer is:");
                        Console.WriteLine(fD * SD);
                        break;

                }
                Console.WriteLine("This was the Answer, I am sure that this was a correct answer");
                Console.ReadKey();
                Console.Write("Do you want to do more operation if yess then type yess if not then no. yess or no?");
                
            }
            else
            {
                Console.WriteLine("This program will end!");
                Console.ReadKey();
                Console.WriteLine("Just press 'n' to close this Program");
                if (Console.ReadLine() == "n")
                {
                    Environment.Exit(1) ;
                }

            }
        }
    }
}
