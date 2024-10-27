using FamiliaConsole.Class;
using System.Text.RegularExpressions;

namespace FamiliaConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Son son = new Son(
                firstName: "Carlos",
                lastName: "Gonzalez",
                job: "Engineer",
                hobby: "Fishing",
                nickname: "Carlitos",
                favoriteSport: "Soccer",
                grandfatherAge: 81,
                fatherAge: 51,
                age: 21
            );

            while (true)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Mostrar valores");
                Console.WriteLine("2. Modificar valores");
                Console.WriteLine("3. Salir");
                Console.WriteLine("--------------------------");
                Console.Write("Seleccione una opción: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        son.DisplayValues();
                        break;

                    case "2":
                        Console.Write("Nuevo apellido: ");
                        string newLastName = Console.ReadLine();
                        while (!Regex.IsMatch(newLastName, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑüÜ\s']{2,}$"))
                        {
                            Console.WriteLine("Error: El apellido solo puede contener letras, tildes, espacios y apóstrofes, y debe tener al menos dos letras.");
                            Console.Write("Intente de nuevo: ");
                            newLastName = Console.ReadLine();
                        }

                        Console.Write("Nuevo trabajo del abuelo: ");
                        string newJob = Console.ReadLine();

                        Console.Write("Nueva edad del abuelo: ");
                        int newGrandfatherAge;
                        while (!int.TryParse(Console.ReadLine(), out newGrandfatherAge) || newGrandfatherAge <= 0)
                        {
                            Console.WriteLine("Error: La edad debe ser un número positivo.");
                            Console.Write("Intente de nuevo: ");
                        }

                        Console.Write("Nuevo nombre del padre: ");
                        string newFirstName = Console.ReadLine();
                        while (!Regex.IsMatch(newFirstName, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑüÜ\s']{2,}$"))
                        {
                            Console.WriteLine("Error: El nombre solo puede contener letras, tildes, espacios y apóstrofes, y debe tener al menos dos letras.");
                            Console.Write("Intente de nuevo: ");
                            newFirstName = Console.ReadLine();
                        }

                        Console.Write("Nuevo hobby del padre: ");
                        string newHobby = Console.ReadLine();

                        Console.Write("Nueva edad del padre: ");
                        int newFatherAge;
                        while (!int.TryParse(Console.ReadLine(), out newFatherAge) || newFatherAge <= 0 || newFatherAge >= newGrandfatherAge)
                        {
                            Console.WriteLine("Error: La edad debe ser un número positivo y menor que la edad del abuelo.");
                            Console.Write("Intente de nuevo: ");
                        }

                        Console.Write("Nuevo apodo del hijo: ");
                        string newNickname = Console.ReadLine();
                        while (!Regex.IsMatch(newNickname, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑüÜ\s']{2,}$"))
                        {
                            Console.WriteLine("Error: El apodo solo puede contener letras, tildes, espacios y apóstrofes, y debe tener al menos dos letras.");
                            Console.Write("Intente de nuevo: ");
                            newNickname = Console.ReadLine();
                        }

                        Console.Write("Nuevo deporte favorito del hijo: ");
                        string newFavoriteSport = Console.ReadLine();

                        Console.Write("Nueva edad del hijo: ");
                        int newSonAge;
                        while (!int.TryParse(Console.ReadLine(), out newSonAge) || newSonAge <= 0 || newSonAge >= newFatherAge)
                        {
                            Console.WriteLine("Error: La edad debe ser un número positivo y menor que la edad del padre.");
                            Console.Write("Intente de nuevo: ");
                        }

                        son.ModifyValues(newLastName, newJob, newFirstName, newHobby, newNickname, newFavoriteSport, newGrandfatherAge, newFatherAge, newSonAge);
                        break;

                    case "3":
                        return;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }
    }

}

