using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1cap
{
    class Program
    {

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


        static void Main()
        {
            Console.WriteLine("Please Enter a Word for Translation: ");
            string str = Console.ReadLine();
            

            if (str[0] == 'a' || str[0] == 'e' || str[0] == 'i' || str[0] == 'o' || str[0] == 'u')
            {
                Console.WriteLine(str + "way");
            }

           
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    
                    
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
                    
                    
                }
                

            }
            Conti();

        }
        
    }
}
