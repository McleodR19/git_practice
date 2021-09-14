using System;

namespace invintorySy
{
    class Program
    {
        
       
        //function to add items into array 
        static void invintory(){
            //the multi demensoinal array for the invintory system
            string[,] inv = new string[3,2] {
            {"food","1"},
            {"pop","7"},
            {"Lites","3"}
            };
            Console.WriteLine("Welcome to invintory function! What would you like to do?");
            //initilizing varriables for while function and setting result for customer response
            int i=1;
            string result;
            while(i > 0){
               result= Console.ReadLine();
               if(result =="status"){
        //nested for loop to print array
        for (int h = 0; i < inv.GetLength(0); h++)
        {
            for (int j = 0; j < inv.GetLength(1); j++) {
                Console.Write("{0} ", inv[h, j]);
            }
            Console.WriteLine();
        } }else if(result=="end"){
            i++;
        }

            }
        }



        static void Main(string[] args)
        {
            int i = 1;
            string[] comand = new string[2]{"end","invintory"};
        string result;
         Console.WriteLine("What would you like to do?");
            while( i >0){
               result = Console.ReadLine();
                if(result == "/help"){
                    //placeholder will add commands as I make them
                    Console.WriteLine("Here is a list of commands:");
                     foreach (var h in comand){
                         Console.WriteLine(h);

                    }

                }else if(result == "end"){
                    //exits while loop
                    i--;
                }else if(result == "invintory"){
                    invintory();

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
