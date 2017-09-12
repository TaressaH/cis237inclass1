
/**USER INTERFACE CLASS***/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{


    class UserInterface
    {
        //NO VARIABLES    NEEDED IN CLASS 
        //NO PROPERTIES   NEEDED IN CLASS
        //NO CONSTRUCTORS NEEDED IN CLASS

        /*****PUBLIC METHODS*****/

        public int GetUserInput()
        {
            //PRINT OUT A MENU 

            this.PrintMenu();



            //GET INPUT FROM USER 
            String input = Console.ReadLine();

            //WHILE INPUT IS INVALID RE GET INPUT 
            while (input != "1" && input != "2")
            {
                //PRINT ERROR MESSAGE 

                this.PrintErrorMessage();

                //RE-PRINT MENU 
                this.PrintMenu();  


                //GET INPUT FROM CONSOLE    
                input = Console.ReadLine(); 
            }

            //POINT: KNOW INPUT IS A VALID NUMBER 
            //INPUT IS EITHER A 1 OR A 2 
            return Int32.Parse(input); 

        }


        //ANY INTERACTION USES THE CONSOLE WILL HAVE THS FILE
        public void Output(string outputString)
        {
            Console.WriteLine(outputString); 
        }

        /*******PRIVATE METHODS********/

        private void PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Exit");
        }

        private void PrintErrorMessage()
        {
            Console.WriteLine("Not a valid entry");
            Console.WriteLine("Please make a valid choice");
            Console.WriteLine(); 
        }




    }
}
