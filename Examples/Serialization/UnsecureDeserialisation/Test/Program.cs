using System;
using System.Collections.Generic;
using Common;

namespace Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var owner = new Owner
            {
                Name = "Tim Apple", Businesses = new List<Business>
                {
                    new Business
                    {
                        Name = "ProgramingExtreme", Address = "ProgramingLane", Employees = new List<Employee>
                        {
                            new Employee {Name = "Harry"}, new Employee {Name = "Sally"}
                        }
                    }
                }
            };

            var ownerJson = UnsecureSerializer<Owner>.Serialize(owner);
            var EmployeeJson = UnsecureSerializer<DbEmployee>.Serialize(new DbEmployee("2"));

            var OwnerFromEmployer = UnsecureSerializer<Owner>.DeserializeToObject(EmployeeJson);

            Console.WriteLine("Hello World!");
        }
    }°
} 

}