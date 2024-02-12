// PROGRAMAS UTILIZANDO CICLOS FOR

using System.Reflection;

public class CicloFor
{
    public static void Submenu1()
    {
        int num = 0;
        while (num == 0)
        {


            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine("--PROGRAMAS UTILIZANDO FOR--");
            System.Console.WriteLine("ELIJA UNA OPCION \n" +
            "1-Un programa que pregunte cuántos números se van a introducir, \n" +
             "pida esos números y muestre cuántos números negativos ha introducido. \n");

            System.Console.WriteLine("2-Un programa que solicite dos numeros. Debe mostrar \n" +
            "la secuenciadescendente desde el numero mas grande hasta el numero menor. \n");

            System.Console.WriteLine("3-Un programa que solicite un numero al usuario. Si \n" +
            "el numero es mayor que 10 y es impar, mostrar la secuencia de ascendente \n" +
             "del 100 al 500, de 10 en 10. Si es mayor que 10 y es par mostrar un saludo \n" +
             "5 veces. Si es menor o igual que 10 mostrar su nombre y matricula 15 veces. ");
            Console.ResetColor();
            int opcion = int.Parse(Console.ReadLine()!);

            Console.Clear();

            switch (opcion)
            {
                case 1:
                    NumNegat();
                    System.Console.WriteLine("\n");
                    break;
                case 2:
                    NumDeced();
                    System.Console.WriteLine("\n");
                    break;
                case 3:
                    MayorA10();
                    System.Console.WriteLine("\n");
                    break;

                default:
                    System.Console.WriteLine("La Opcion elejida es incorrecta.");
                    break;
            }

            
            System.Console.WriteLine("PRESIONE 0 PARA REPETIR OPCIONES \n" +
            "PRECIONE 1 PARA CERRAR");
            num = int.Parse(Console.ReadLine()!);
            Console.ResetColor();
        }
    }



    //----------------------------------------------------------------------------------------------
    //Funcion de numeros negativos
    public static void NumNegat()

    /*1-Escriba un programa que pregunte cuántos números se van a introducir,
     pida esos números y muestre cuántos números negativos ha introducido.*/
    {
        Console.ForegroundColor = ConsoleColor.Green;
        int cantidad, num, contador = 0;
        System.Console.WriteLine("Cuantos Numeros Desea Ingresar?");
        cantidad = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < cantidad; i++)
        {
            System.Console.WriteLine("Introduzca un numeros:");
            num = int.Parse(Console.ReadLine()!);

            if (num < 0)
            {
                contador = contador + 1;
            }
        }
        System.Console.WriteLine($"La cantidad de numeros negativos es: {contador}");
    }

    //----------------------------------------------------------------------------------------------
    //Funcion de numeros descendentes
    public static void NumDeced()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        /*2-Escriba un programa que solicite dos numeros. Debe mostrar la 
        secuencia descendente desde el numero mas grande hasta el numero menor*/
        int num1, num2;
        System.Console.WriteLine("Digite el primer Numero \n");
        num1 = int.Parse(Console.ReadLine()!);
        System.Console.WriteLine("Digite el segundo Numero \n");
        num2 = int.Parse(Console.ReadLine()!);

        if (num1 < num2)
        {
            for (int i = num2; i >= num1; i--)
            {
                System.Console.WriteLine(i);
            }
        }
        else
        {
            for (int i = num1; i >= num2; i--)
            {
                System.Console.WriteLine(i);
            }
        }
    }

    //----------------------------------------------------------------------------------------------
    //Funcion de numeros mayor a 10
    public static void MayorA10()
    {
        /*Escriba un programa que solicite un numero al usuario. Si el numero
        es mayor que 10 y es impar, mostrar la secuencia de ascendente del 100
        al 500, de 10 en 10. Si es mayor que 10 y es par mostrar un saludo 5 
        veces. Si es menor o igual que 10 mostrar su nombre y matricula 15 veces.*/

        System.Console.WriteLine("Digite un numero:");
        int num = int.Parse(Console.ReadLine()!);
        if (num > 10 && num % 2 != 0)
        {
            for (int i = 100; i <= 500; i += 10)
            {
                System.Console.WriteLine(i);
            }
        }
        else if (num > 10 && num % 2 == 0)
        {
            for (int i = 0; i <= 5; i++)
            {
                System.Console.WriteLine("Hola");
            }
        }
        else if (num <= 10)
        {
            System.Console.WriteLine("Digite su nombre:");
            string nombre = Console.ReadLine()!;

            System.Console.WriteLine("Digite su matricula:");
            string matricula = Console.ReadLine()!;

            for (int i = 15; i <= 15; i++)
            {
                System.Console.WriteLine(nombre + " " + matricula);
            }
        }

    }

}