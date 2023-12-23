namespace carvedrock.bl.principles.FCOI
{
    public class FCOI
    {
        public FCOI()
        {
            Employee employee = new();
            Person person = new();
            person.title = "Architect";
            person.name = "John Doe";
            person.age = 35;
            employee.salary = 1500;
            employee.person = person;
        }
    }
}
