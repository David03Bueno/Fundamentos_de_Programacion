//PROGRAMA #4

using System.ComponentModel;

public class TablaP4
{
    public static void TabMul()
    {
        /*CONSTRUIR UNA FUNCIÓN QUE RECIBA COMO PARÁMETRO UN ENTERO
         DE DOS DÍGITOS Y QUE ESTA FUNCIÓN GENERE Y MUESTRE EN PANTALLA
        LA TABLA DE MULTIPLICAR DEL PRIMER DÍGITO, SIENDO EL LÍMITE DE
        LA TABLA EL SEGUNDO DÍGITO. */

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        System.Console.WriteLine("Digite un numero de dos digitos:");
        int num = int.Parse(Console.ReadLine()!);

        int numero1 = num / 10;
        int numero2 = num % 10;

        System.Console.WriteLine($"EL PRIMER DIGITO ES {numero1} Y EL SEGUNDO ES: {numero2}");

        for (int i = 1; i < numero2; i++)
        {
            int multip = numero1 * i;
            System.Console.WriteLine(multip + "\n");
        }
        System.Console.WriteLine("PRESIONE ENTER PARA VOLVER AL MENU PRINCIPAL");
        Console.ResetColor();
        Console.ReadKey();
    }
}