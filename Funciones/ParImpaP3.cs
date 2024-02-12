//PROGRAMA #3
public class ParImpaP3
{
    public static void Pares()
    {
        /*CONSTRUIR UNA FUNCIÓN QUE RECIBA COMO PARÁMETRO UN NUMERO Y RETORNE
           UN MENSAJE DICIENDO SI ES PAR O IMPAR, SEGÚN SEA EL CASO.*/

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        System.Console.WriteLine("Digite un numero:");
        int num1 = int.Parse(Console.ReadLine()!);

        if (num1 % 2 == 0)
        {
            System.Console.WriteLine($"El numero {num1} Es par \n");
        }
        else
        {
            System.Console.WriteLine($"El numero {num1} Es impar \n");
        }
        System.Console.WriteLine("PRESIONE ENTER PARA VOLVER AL MENU PRINCIPAL");
        Console.ResetColor();
        Console.ReadKey();
    }
}