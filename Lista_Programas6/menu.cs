// MENU PRINCIPAL

int num1 = 0;
while (num1 == 0)
{

    Console.ForegroundColor = ConsoleColor.Yellow;

    int opcion;
    System.Console.WriteLine("\n--BIENVENIDO AL PROGRAMA DE CICLO FOR Y ARRAY-- \n");

    System.Console.WriteLine("ELIJA UNA OPCION:\n" +
    "1-PROGRAMAS CON CICLO FOR \n2-PROGRAMAS CON ARRAY \n");
    opcion = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    Console.ResetColor();

    


    switch (opcion)
    {
        case 1:
            CicloFor.Submenu1();
            System.Console.WriteLine("\n");
            break;

        case 2:
            Array2.Submenu2();
            System.Console.WriteLine("\n");
            break;

        default:
            System.Console.WriteLine("La opciones incorrecta");
            break;
    }
    Console.ForegroundColor = ConsoleColor.DarkRed;
    System.Console.WriteLine("PRESIONE 0 PARA MOSTRAR MENU PRINCIPAL \n" +
    "PRESIONE 1 PARA CERRAR EL PROGRAMA");
    num1 = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
}

