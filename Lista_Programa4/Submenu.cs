/*Programa que le muestre al usuario un menu como este: [E]Español
[I]Inglés  [F]Francés. Según la letra ingresada por el usuario,
muestre una frase en el lenguaje seleccionado.*/


public class Submenu
{
    public static void Frase()
    {
            //Presentacion de opciones 
        System.Console.WriteLine("===PROGRAMA DE FRASES EN OTRO IDIOMA===");
        System.Console.WriteLine("--ELIJA UNA OPCION--" +
        "\n  [E]-Español  \n  [I]-Ingles  \n  [F]Francés  \n");
       
       char opcion = char.ToUpper(Convert.ToChar(Console.ReadLine()!)); // Declaracion de Variable

        switch (opcion)
        {
            case 'E': 
            System.Console.WriteLine("QUE DIOS TE BENDIGA");
            break;

            case 'I': 
            System.Console.WriteLine("God bless you");
            break;

            case 'F': 
            System.Console.WriteLine("que Dieu te bénisse");
            break;

            default:
            System.Console.WriteLine("Este valor no es valido ");
            break;
        }

    }
}

