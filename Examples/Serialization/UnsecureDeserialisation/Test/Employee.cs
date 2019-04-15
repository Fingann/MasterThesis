using System.Collections.Generic;

namespace Test
{
    public class Owner
    {
        public string Name { get; set; }
        public List<Business> Businesses { get; set; }
    }
    public class Business
    {
        public string Address { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }

    }
    public class Employee
    {
        public string Name { get; set; }
    }
}