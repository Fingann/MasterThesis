using Common;

namespace Test
{
    public class DbEmployee
    {
        public DbEmployee(string id)
        {
            ReflectionLogger.LogMethod();
            Employee = GetDbEmployee(id);
        }

        public Employee Employee { get; set; }

        private Employee GetDbEmployee(string id)
        {
            ReflectionLogger.LogMethod();
            //Retrive employee from db
            return new Employee {Name = "Steven DB"};
        }
    }
}