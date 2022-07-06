using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesLab
{
    internal class Movie
    {
        //properties
        public string Title { get; set; }
        public string Category { get; set; }
        public Movie(string _title, string _category)
        {
            Title = _title;
            Category = _category;
        }
        public static bool GetContinue()
        {
            //default value, will eventually be replaced
            bool result = true;
            //check if user wants to continue
            while (true)
            {
                Console.WriteLine("Would you like to browse more? y/n");
                string choice = Console.ReadLine().ToLower().Trim();

                //check user input
                if (choice == "y")
                {
                    result = true;
                    break;
                }
                else if (choice == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("That result was invalid. Try again.");
                }
            }
            return result;
        }
    }
}
