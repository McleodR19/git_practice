using System;

namespace invintorySy
{
    class Program
    {
        static void Main(string[] args)
        {int i = 1;
        string result;
         Console.WriteLine("What would you like to do?");
            while( i >0){
               result = Console.ReadLine();
                if(result == "/help"){
                    //placeholder will add commands as I make them
                    Console.WriteLine("Here is a list of commands");

                }else if(result == "end"){
                    //exits while loop
                    i--;
                }
                else{
                    //error cetch
                    Console.WriteLine("that is not a comand type /help for a list of comands");
                }
            }
         
                Console.WriteLine("Thank you for using invintorySy");
            
        }
    }
}
