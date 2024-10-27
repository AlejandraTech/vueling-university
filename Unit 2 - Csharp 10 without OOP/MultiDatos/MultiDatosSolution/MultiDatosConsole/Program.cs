// See https://aka.ms/new-console-template for more information

Console.WriteLine("- Introduce un valor booleano (true / false): ");
string booleanInput = Console.ReadLine();
bool booleanValue;
if (bool.TryParse(booleanInput, out booleanValue))
{
    bool negatedBoolean = !booleanValue;

    Console.WriteLine("- Introduce un número entero: ");
    string intInput = Console.ReadLine();
    int intValue;
    if (int.TryParse(intInput, out intValue))
    {
        Console.WriteLine("- Introduce un número decimal (usa punto para decimales): ");
        string decimalInput = Console.ReadLine();
        decimal decimalValue;
        if (decimal.TryParse(decimalInput, out decimalValue) && decimalValue != 0)
        {
            decimal divisionResult = intValue / decimalValue;

            Console.WriteLine("- Introduce un carácter: ");
            string charInput = Console.ReadLine();
            char charValue;
            if (char.TryParse(charInput, out charValue))
            {
                Console.WriteLine("- Introduce un texto: ");
                string textValue = Console.ReadLine();

                string formatText = charValue + " (" + textValue + ") " + charValue;

                Console.WriteLine("- Introduce una fecha y una hora (yyyy-MM-dd HH:mm): ");
                string dateTimeInput = Console.ReadLine();
                DateTime dateTimeValue;
                if (DateTime.TryParse(dateTimeInput, out dateTimeValue))
                {
                    DateTime lastSecondfMonth = new DateTime(dateTimeValue.Year, dateTimeValue.Month, DateTime.DaysInMonth(dateTimeValue.Year, dateTimeValue.Month), 23, 59, 59);

                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Resultados:");
                    Console.WriteLine(" - Negación del booleano: " + negatedBoolean);
                    Console.WriteLine(" - Resultado de la división: " + divisionResult);
                    Console.WriteLine(" - Texto formateado: " + formatText);
                    Console.WriteLine(" - Último segundo del último día del mes: " + lastSecondfMonth);
                    Console.WriteLine("--------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("Fecha y hora no válidas. (yyyy-MM-dd HH:mm)");
                }
            }
            else
            {
                Console.WriteLine("Carácter no válido.");
            }
        }
        else
        {
            Console.WriteLine("Número decimal no válido o no puede ser cero.");
        }
    }
    else
    {
        Console.WriteLine("Número entero no válido.");
    }
}
else
{
    Console.WriteLine("Valor booleano no válido.");
}
