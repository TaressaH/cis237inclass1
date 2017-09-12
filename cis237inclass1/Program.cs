/*
 IN CLASS ASSIGNMENT 1 
 
 FUNCTION: 
 MULTIPLE CLASSES TO UNDERSTAND INSTANCES 
 BEST PRACTICES FOR CREATING CLASSES 
 CLASS AGGREGATION 
 APPLYING GIT TO VISUAL STUDIO 
 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            //NEW UI CLASS TO USE 
            UserInterface ui = new UserInterface();


            //a new employee created to make sure that our Employee class works 

            Employee myEmployee = new Employee("David", "Barnes", 835.00m);

            Console.WriteLine(myEmployee);
            Console.WriteLine(myEmployee.FirstANDLASTNAME());

            //makes an array to hold more than one employee instances 
            //KEYWORD: MEMORY ALLOCATION 
            //ARRAY: GOING TO BE IN HEAP 
            Employee[] employees = new Employee[10];

            employees[0] = new Employee("James", "Kirk", 1701.00m);
            employees[1] = new Employee("Jean-Luc", "Picard", 17 - 1.00m);
            employees[2] = new Employee("Benjamin", "Sisko", 587.00m);
            employees[3] = new Employee("Kathryn", "Janeway", 287.00m);
            employees[4] = new Employee("Johnathan", "Archer", 127.00m);

            //GET INPUT FROM USER FOR USER INTERFACE 
            //public get user input 
            int choice = ui.GetUserInput();

            //WHILE LOOP: USER CHOSEN OTHER THAN 2
            //DO WHILE LOOP --> SWITCH STATEMENT RUN A DIFFERENT CASE FOR DIFFERENT INTEGER PICK FROM USER      
            while (choice != 2)
            {

                //CREATE A STRING: CONCATENATED 
                string outputString = "";

                //Print out the employees in the array 

                foreach (Employee employee in employees)
                {
                    if (employee != null)
                    {
                        //CONCATENATE EMPLOYEE TO OUTPUT STRING
                        //CHECK FOR NULL, UNFILLED VALUES ARRAY SIZING   
                        outputString += employee.ToString() + Environment.NewLine;
                    }

                }
                //CONSOLE OUTPUT FOR OUTPUT STRING 
                //DESIGNATING UI CLASS TO GET THE WORK DONE 
                ui.Output(outputString);

                //after switch case 

                //RE PROMPT USER FOR NEW INPUT 
                choice = ui.GetUserInput(); 

            }
        }
    }
}

