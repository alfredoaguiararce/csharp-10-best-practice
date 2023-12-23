namespace carvedrock.bl.principles.FCOI
{
    public class Employee 
    {
        public int salary;
        public Person person {  get; set; }
        public Employee(int salary, Person person)
        {
            this.salary = salary;
            this.person = person;
        }

        public Employee()
        {
        }
    }
}
