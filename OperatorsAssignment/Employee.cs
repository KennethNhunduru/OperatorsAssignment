using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    //Creating an Employee class with Id, FirstName and LastName properties. 
    class Employee
    {
        //Adding the properties.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //To make operations on user-defined data types is not as simple as the operations on built-in data types.
        //To use operators with user-defined data types, they need to be overloaded according to the developer's needs.
        //An operator can be overloaded by defining a FUNCTION to it.
        //The function of the operator is declared by using the 'operator' keyword.

        //The operator function is defined inside the class or structure whose objects/variables
        //we require the overloaded operator to work with.
        //The benefit of overloading an operator is to have the provision to make your own
        //implementation of the operator. 

        //Comparison operators (like <, >, ==) can be overloaded but MUST be overloaded in pairs. 

        //Overloading the “==” operator In the Employee class, so it checks if two Employee objects
        //are equal by comparing their Id property.

        //First comparison
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            bool result = (employee1.Id == employee2.Id);
            
            return result;                            
        }
        //Second comparison 
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            bool result = (employee1.Id != employee2.Id);            
            
            return result;
                      
        }
    }
}
