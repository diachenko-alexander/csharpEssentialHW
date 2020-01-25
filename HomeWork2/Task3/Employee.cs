namespace Task3
{
    class Employee
    {
        readonly string name;
        readonly string surname;
        string position;
        int experience;
        static double tax = 0.2;


        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
        }

        public string Position
        {
            get
            {
                if (position == null)
                {
                    return "Position unknown";
                }
                return position;
            }
            set { position = value; }
        }

        public int Experience
        {
            get
            {
                return experience;
            }
            set
            {
                if (value < 0)
                {
                    experience = 0;
                }
                experience = value;
            }
        }

        public Employee()
        {

        }

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        private double GetExperinceDelta ()
        {
           double experienceDelta = 0;
            if (experience > 1)
            {
                experienceDelta = 1.2;
            } else if (experience > 3) 
            {
                experienceDelta = 1.5;
            } else
            {
                experienceDelta = 2;
            }
            return experienceDelta;
        }

        public double CalculateSalary ()
        {
            double salary = 0;

            switch (position.ToLower())
            {
                case "qa":
                    salary = 1000;
                    break;
                case "dev":
                    salary = 2000;
                    break;
                default:
                    System.Console.WriteLine("Position unknown");
                    break;
            }
            return salary * GetExperinceDelta();
        }

        public void ShowEmploeeInfo()
        {
            System.Console.WriteLine($"Name: {name}\nSurname: {surname}\nPosition: {position}\nExperience: {experience}\nSalary: {CalculateSalary()}\nTax: {CalculateSalary() * tax}");
        }
    }
}
