//PROGRAMA #1


public class SaludoP1
{
    public static void Saludo()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        /*1.CONSTRUIR UNA FUNCIÓN QUE RECIBA COMO PARÁMETRO UNA CADENA 
        (EL NOMBRE DEL USUARIO) LA FUNCIÓN DEBE RETORNAR UN SALUDO QUE
         INCLUYA EL NOMBRE DEL USUARIO QUE RECIBIÓ. */
        System.Console.WriteLine("Digita tu nombre");
        string nombre = Console.ReadLine()!;
        System.Console.WriteLine($"Hola, Como estas, {nombre} \n");

        System.Console.WriteLine("PRESIONE ENTER PARA VOLVER AL MENU PRINCIPAL");
        Console.ResetColor();
        Console.ReadKey();
    }
}