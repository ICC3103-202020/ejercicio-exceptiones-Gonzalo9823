using System;
namespace TareaExceptions
{
    public class InvalidAgeException : ApplicationException
    {
        private readonly int age;

        public InvalidAgeException(int age, string message) : base(message)
        {
            this.age = age;
        }

        public int Age { get => age; }
    }
}
