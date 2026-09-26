using backend;

var stack = new StackUsingList<string>();

var option = string.Empty;
do
{
    option = Menu();
    try
    {
        switch (option)
        {
            case "1":
                Console.Write("Digite el elemento: ");
                stack.Push(Console.ReadLine()!);
                break;
            case "2":
                Console.WriteLine($"Elemento desapilado: {stack.Pop()}");
                break;
            case "3":
                Console.WriteLine($"Elemento en el tope de la pila: {stack.Peek()}");
                break;
            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine($"Error: {ex.Message}");
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
    }

} while (option != "0");

string Menu()
{
    Console.WriteLine("1. Apilar");
    Console.WriteLine("2. Desapilar");
    Console.WriteLine("3. Ver tope de la pila ");
    Console.WriteLine("0. Salir");
    Console.Write("Seleccione una opción: ");
    return Console.ReadLine()!;
}
