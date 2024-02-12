// PROGRAMA HECHO POR Luis David Bueno
/* 
Programa que muestre en pantalla el mensaje: Hola Mundo! (El clásico, que nunca se queda).
*/
internal class Program1
{
    private static void Main()
    {

        Console.WriteLine("DIGITE EL NUMERO DEL PROGRAMA QUE DECEA ABRIR:");
        Console.WriteLine("1- Saludo con su nombre");
        Console.WriteLine("2- Sacando el cuadrado de una Edad");

        int opcion = int.Parse(Console.ReadLine()!);
        switch (opcion)
        {
            case 1:
                Saludo.saludo1();
                break;

            case 2:
                EdaCuadrada.Edad();
                break;
            default:
                System.Console.WriteLine("Su opcion es incorrecta");
                break;
        }
    }
}