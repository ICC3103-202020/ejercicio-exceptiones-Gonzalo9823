using System;

namespace TareaExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] toys = { "Auto", "Plasticina", "Lapices" };
            Persona persona = new Persona("Gonzalo", 21, 10000, toys);

            // Ejemplo 1

            try
            {
                persona.UpdateAge(-1);
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine(e.Message);
            }

            // Ejemplo 2

            try
            {
                string toy = persona.GetToyAtIndex(5);
                Console.WriteLine(toy);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            // Ejemplo 3

            try
            {
                persona.DivideMoney(0);
            } catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            // El programa sigue aunque hubieron varios errores.
        }
    }
}
