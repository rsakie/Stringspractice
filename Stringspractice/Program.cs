using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringspractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Robert";
            //int lengthOfName =  firstName.Length;
            //Console.WriteLine(firstName);
            //Console.WriteLine(lengthOfName);

            //string myfavQuote = "\"Its a yam sham\" - Buffy Summers";
            //Console.WriteLine(myfavQuote);

            //string escapeString = "I want a tab after this line \t I want a new line without writeline \nHi";
            //string escapestring2 = "I want to show a backslash here \\ Hey whats that noise \a";
            //Console.WriteLine(escapeString);
            //Console.WriteLine(escapestring2);

            //Console.WriteLine("User one, please type something");
            //string userOneInput = Console.ReadLine();
            //Console.WriteLine("user two, please type something");
            //string userTwoinput = Console.ReadLine();

            //if (userOneInput == userTwoinput)
            //{
            //    Console.WriteLine("user 2 is a copy cat!");
            //}
            //else
            //{
            //    Console.WriteLine("Way to be Original");
            //}
            //
            // (another way to ==)

            //Console.WriteLine("User one, please type something");
            //string userOneInput = Console.ReadLine();
            //Console.WriteLine("user two, please type something");
            //string userTwoinput = Console.ReadLine();

            //if (userOneInput.Equals(userTwoinput))
            //{
            //    Console.WriteLine("user 2 is a copy cat!");
            //}
            //else
            //{
            //    Console.WriteLine("Way to be Original");
            //}


            //Console.WriteLine("This is a Tab. \t \nThis is a Backspace \\. \nand This is a bell sound \a");

            //Console.WriteLine("Please enter your First Name:");
            //string firstName = Console.ReadLine();

            //Console.WriteLine(" Please enter you Last Name");
            //string lastName = Console.ReadLine();


            //Console.WriteLine(firstName + " " + firstName.Length);
            //Console.WriteLine(lastName + " " + lastName.Length);

            //if (firstName.Length > lastName.Length)
            //{
            //    Console.WriteLine("First is Longer");
            //}
            //else if (firstName.Length == lastName.Length)
            //{
            //    Console.WriteLine("Samsis");
            //}
            //else
            //{
            //    Console.WriteLine("Last must be Longer");

            Console.WriteLine("Please enter your First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine(" Please enter someone else's first Name");
            string secondName = Console.ReadLine();

            if (firstName == secondName)
            {
                Console.WriteLine("Names are the same");
            }
            else
            {
                Console.WriteLine("Names are Different");
            }
            }
        }
    }
    

