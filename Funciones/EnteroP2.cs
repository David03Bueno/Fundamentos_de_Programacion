// PROGRAMA #2
 public class EnteroP2
 {
    public static void UltimoDig()
    {
        /*CONSTRUIR UNA FUNCIÓN QUE RECIBA COMO PARÁMETRO UN
          ENTERO DE DOS DÍGITOS Y RETORNE SU ÚLTIMO DÍGITO. */

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        System.Console.WriteLine("Digita un numero entero");
        string Num = Console.ReadLine()!;
    
        System.Console.WriteLine($"El Ultimo digito es: {Num[1]} \n");
        
        System.Console.WriteLine("PRESIONE ENTER PARA VOLVER AL MENU PRINCIPAL");
        Console.ResetColor();
        Console.ReadKey();
    }
 }
 