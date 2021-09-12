using System;

namespace invintorySy
{
    class Program
    {
        static void Main(string[] args)
        {int i = 1;
        string result;
            while( i >0){
                Console.WriteLine("What would you like to do?");
               result = Console.ReadLine();
                if(result == "/help"){

                }else{
                    Console.WriteLine("that is not a comand type /help for a list of comands");
                }


            }
        }
    }
}
