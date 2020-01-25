using System;

namespace AdditionalTask
{
    class User
    {
        private string login;
        private string name;
        private string surname;
        private int age;
        private readonly DateTime createdDate;

        public string Login
        {
            get
            {
                if (login == null)
                {
                    return "Field is empty";
                }
                return login;
            }
            set { login = value; }
        }

        public string Name
        {
            get
            {
                if (name == null)
                {
                    return "Field is empty";
                }
                return name;

            }
            set { name = value; }
        }


        public string Surname
        {
            get
            {
                if (surname == null)
                {
                    return "Field is empty";
                }
                return surname;
            }
            set { surname = value; }
        }

        public int Age
        {
            get 
            {
                if (age < 0)
                {
                    age = 0;
                } 
                return age;
            }
            set { age = value; }
        }



        public User()
        {
            this.createdDate = DateTime.Now;
        }

        public User(string login, string name, string surname, int age)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.createdDate = DateTime.Now;
        }

        public void ShowUserData()
        {
            Console.WriteLine($"Login: {login}\nName: {name}\nSurname:{surname}\nAge: {age}\nCreated Date: {createdDate}");
        }
    }
}
