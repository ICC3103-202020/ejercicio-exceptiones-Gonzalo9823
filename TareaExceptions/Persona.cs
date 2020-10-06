using System;
namespace TareaExceptions
{
    public class Persona
    {
        private string name;
        private int age;
        private int money;
        private string[] toys;

        public Persona(string name, int age, int money, string[] toys)
        {
            this.name = name;
            this.age = age;
            this.money = money;
            this.toys = toys;
        }

        public void UpdateAge(int newAge)
        {
            if (newAge < 0)
            {
                throw new InvalidAgeException(newAge, "Age can't be negative.");
            }

            age = newAge;
        }

        public string GetToyAtIndex(int index)
        {
            return toys[index];
        }

        public void DivideMoney(int parts)
        {
            if(parts == 0)
            {
                throw new DivideByZeroException();
            }

            money = money / parts;
        }
    }
}
