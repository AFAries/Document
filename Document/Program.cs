using System;
using System.IO;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            //Have to make these variables before try to use them in the try
            //and the finally. Also had to give them a null value to work
            string userInputName = null;
            string fileType = ".txt";
            string realFile = null;
            string userInputData = null;
            //string path = null; was used to check filepath below
            StreamWriter sw = null;

            try
            {
                Console.WriteLine("Document");
                Console.WriteLine("");

                //prompts the user to enter the file name to make and creates a string
                Console.WriteLine("Please input Document Name");
                userInputName = Console.ReadLine();

                //This is to append/add to the inputted file name string
                realFile = userInputName + fileType;

                //Sets string for whatever user inputs into the document being made
                Console.WriteLine("What is inside this document?");
                userInputData = Console.ReadLine();

                //used this to figure out where the document is being made
                //path = Directory.GetCurrentDirectory();
                //Console.WriteLine("The current directory is {0}", path);

                //Makes the file based on user inputted name and file type
                sw = new StreamWriter(userInputName + fileType);

                //Writes a line of text
                sw.WriteLine("{0}", userInputData);
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                Environment.Exit(0);
                return;
            }

            finally
            {
                //Had to make null values above to use the try variables here
                Console.WriteLine("{0} was successfully created.", realFile);
                Console.WriteLine("{0} has {1} character/characters", realFile, userInputData.Length);
                sw.Close();
                Environment.Exit(0);

            }
        }
    }
}
