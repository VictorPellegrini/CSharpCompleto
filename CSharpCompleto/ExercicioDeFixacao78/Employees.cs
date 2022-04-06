namespace Section0678_Listas
{
    public class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employees(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void SalaryIncrease(double percent)
        {
            Salary = Salary + (Salary * percent / 100);
        }
    }
}
