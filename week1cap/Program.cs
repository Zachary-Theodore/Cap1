using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1cap
{
    class Program
    {
        //Method that recalls the program after it has run once
        static void Conti()
        {
            Console.WriteLine("Continue? (y/n)");
            string UserInput = Console.ReadLine();
            if (UserInput.ToLower() == "y")
            {
                Main();
            }
            else
            {
                return;
            }
        }
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        static void Main()
        {
            //Takes The inputs and stores them into a string variable
            Console.WriteLine("Please Enter a Word for Translation: ");
            string str =Console.ReadLine();
            //str = str.ToLower();
            //the line of code below looks for numbers and characters and if found reports an error meesage
            int numChar = str.IndexOfAny("0123456789@#$%^&*()-_=+".ToCharArray());
            if (numChar >= 0)
            {
                Console.WriteLine("Error: Your input contains a number or character.");
                Conti(); 
            }
            
            else if (str[0] == 'a' || str[0] == 'e' || str[0] == 'i' || str[0] == 'o' || str[0] == 'u')
            {
                Console.WriteLine(str + "way");
                Conti();
            }
            else 
            {       //IndexOfAny takes a list of chars and searchs the input for the first one it finds.
                //once it finds it i set it to vowelIndex and use that Index as a boundary to print from and to
                //in order to rearrange sections of the word. then ad "ay" on the end.
                    int vowelIndex = str.IndexOfAny("aeiouAEIOU".ToCharArray());
                    Console.Write(str.Substring(vowelIndex));
                    Console.WriteLine(str.Substring(0, vowelIndex) + "ay");
               
                Conti();
            }
            //here we call the continue method OUTSIDE of the for loop.
            
        }   
    }
}
