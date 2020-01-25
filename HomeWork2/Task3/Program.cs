namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("alex", "diachenko");
            emp.Position = "qa";
            emp.Experience = 2;
            emp.ShowEmploeeInfo();
        }
    }
}
