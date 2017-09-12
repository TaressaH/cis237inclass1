/*
 INDIVIDUAL EMPLOYEE CLASS 
 
 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Employee
    {
        /*VARIABLES*/


        /**BACKING FIELDS**/
        private string _firstName;
        private string _lastName;
        private decimal _weeklySalary;

        /**PROPERTIES**/
        public string FirstName
        {
            get { return _firstName; }
        }

        public string LastName
        {
            get { return _lastName;  }
        }

        public decimal WeeklySalary
        {
            get { return _weeklySalary; }
        }

        /**PUBLIC METHODS**/

         //PUBLIC TO STRING OVERRIDE 
        public override string ToString()
        {
            //CALL METHOD BELOW FOR FIRST & LAST NAME USES IT IN THIS METHOD 
            //DRY: don't repeat yourself 
            return this.FirstANDLASTNAME() + " " + _weeklySalary; 
        }

        //PUBLIC NAME STRING 
        public string FirstANDLASTNAME()
        {
            return _firstName + " " + _lastName; 
        }


        /**CONSTRUCTORS**/

        public Employee(string FirstName, string LastName, decimal WeeklySalary)
        {
            this._firstName = FirstName;
            this._lastName = LastName;
            this._weeklySalary = WeeklySalary; 

        }



    }
}
