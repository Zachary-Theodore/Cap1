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
//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        static void Main()
        {
            //Takes The inputs and stores them into a string variable
            Console.WriteLine("Please Enter a Word for Translation: ");
            string str = Console.ReadLine();
            
            //Searches for a first case being if the word starts with a vowel
            //if so prints the word
            if (str[0] == 'a' || str[0] == 'e' || str[0] == 'i' || str[0] == 'o' || str[0] == 'u')
            {
                Console.WriteLine(str + "way");
            }

           
            else
            {
                //THis whole section is where the magic happens.
                for (int i = 0; i < str.Length; i++)
                {
                    
                    //for each of these if and else ifs the loop checks each index looking for 
                    //a vowel, when it finds a vowel it remebers where that vowel is then
                    // and prints from that vowel to the end of the string, then prints from
                    //the 0 index up to right before the vowel, and then ay then breaks. 
                  
                        if (str[i] == 'a')
                        {
                            int vowelIndex = str.IndexOf('a');
                            Console.Write(str.Substring(vowelIndex));
                            Console.WriteLine(str.Substring(0, vowelIndex) + "ay");
                            break;
                        }
                        else if (str[i] == 'e')
                        {
                            int vowelIndex = str.IndexOf('e');
                            Console.Write(str.Substring(vowelIndex));
                            Console.WriteLine(str.Substring(0, vowelIndex) + "ay");
                            break;
                        }
                        else if (str[i] == 'i')
                        {
                            int vowelIndex = str.IndexOf('i');
                            Console.Write(str.Substring(vowelIndex));
                            Console.WriteLine(str.Substring(0, vowelIndex) + "ay");
                            break;
                        }
                        else if (str[i] == 'o')
                        {
                            int vowelIndex = str.IndexOf('o');
                            Console.Write(str.Substring(vowelIndex));
                            Console.WriteLine(str.Substring(0, vowelIndex) + "ay");
                            break;
                        }
                        else if (str[i] == 'u')
                        {
                            int vowelIndex = str.IndexOf('u');
                            Console.Write(str.Substring(vowelIndex));
                            Console.WriteLine(str.Substring(0, vowelIndex) + "ay");
                            break;
                        }
                        else if (str[i] == 'y')
                        {
                        int vowelIndex = str.IndexOf('y');
                        Console.Write(str.Substring(vowelIndex));
                        Console.WriteLine(str.Substring(0, vowelIndex) + "ay");
                        break;
                        }

                }
                

            }
            //here we call the continue method OUTSIDE of the for loop.
            Conti();

        }
        
    }
}
