//PROGRAMA #5

public class NumMayorP5
{
    public static void Mayor()
    {
        /*CONSTRUIR UNA FUNCIÓN QUE RECIBA COMO PARÁMETRO UN ENTERO
         DE DOS DÍGITOS. LA FUNCIÓN DEBE RETORNAR EL MAYOR DE LOS DOS DÍGITOS.*/

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        System.Console.WriteLine("Digite un numero de dos digitos:");
        int num = int.Parse(Console.ReadLine()!);

        int numero1 = num / 10;
        int numero2 = num % 10;

        System.Console.WriteLine($"EL PRIMER DIGITO ES: {numero1} Y EL SEGUNDO ES: {numero2}");

        if (numero1 > numero2)
        {
            System.Console.WriteLine($"El numero mayor es: {numero1} \n");
        }
        else
        {
             System.Console.WriteLine($"El numero mayor es: {numero2} \n");
        }

        System.Console.WriteLine("PRESIONE ENTER PARA VOLVER AL MENU PRINCIPAL");
        Console.ResetColor();
        Console.ReadKey();
    }
}