// PROGRAMAS CON ARRAYS

using System.Security.Cryptography.X509Certificates;

public class Array2
{
    public static void Submenu2()
    {
        int salida = 0;
        while (salida == 0)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            
            System.Console.WriteLine("PROGRMAS USANOD ARREGLOS \n" +
            "ELIJA UNA OPCION \n");

            System.Console.WriteLine(
            "1-PROGRAMA QUE LE PIDA AL USUARIO 5 NÚMEROS Y LOS ALMACENE EN UN ARREGLO.\n" +
            "CUANDO EL USUARIO TERMINE DE INGRESARLOS  DEBE MOSTRAR LA SUMATORIA DE \n" +
            "ESOS NÚMEROS.\n");

            System.Console.WriteLine("2-PROGRAMA QUE RECIBA 7 NÚMEROS DE PARTE DEL USUARIO. DEBE VERIFICAR \n" +
           "SI DENTRO DE ELLOS ESTA EL 23. EN CASO DE QUE ASÍ SEA, MOSTRAR UN SALUDO \n" +
           "Y SALIR. EN CASO CONTRARIO MOSTRAR UNA DESPEDIDA Y SALIR. \n");

            System.Console.WriteLine("3-PROGRAMA QUE LEA 10 NÚMEROS ENTEROS INGRESADOS POR EL USUARIO Y \n" +
            "LOS INSERTE EN UN ARREGLO. A CONTINUACIÓN, EL PROGRAMA DEBE CONTAR \n" +
            "Y CLASIFICAR CUÁNTOS NÚMEROS PARES Y CUÁNTOS NÚMEROS IMPARES HAY DENTRO \n" +
            "DEL ARREGLO, Y MOSTRAR ESOS RESULTADOS.\n");

            System.Console.WriteLine("4-PROGRAMA QUE LEA 5 NÚMEROS POR TECLADO. DEBE COPIAR LOS \n" +
             "VALORES EN UN SEGUNDO ARREGLO, SIGUIENDO ESTE REQUERIMIENTO: \n" +

             "-SI EL NUMERO DE TURNO DEL PRIMER ARREGLO ES PAR, \n" +
             "COPIARLO AL SEGUNDO ARREGLO MULTIPLICADO POR 10. \n" +
            "-EN CASO CONTRARIO COPIARLO AL SEGUNDO ARREGLO TAL COMO ESTA.\n");
            Console.ResetColor();
            Console.ResetColor();

            int opcion = int.Parse(Console.ReadLine()!);
            switch (opcion)
            {
                case 1:
                    Arreglo1();
                    break;

                case 2:
                    Arreglo2();
                    break;

                case 3:
                    Arreglo3();
                    break;

                case 4:
                    Arreglo4();
                    break;

                default:
                    System.Console.WriteLine("La Opcion es elejida es incorrecta");
                    break;
            }
            System.Console.WriteLine("PRESIONE 0 PARA REPETIR OPCIONES \n" +
            "PRECIONE 1 PARA CERRAR");
            salida = int.Parse(Console.ReadLine()!);
        }
    }

    //==================================================================================================
    //-------------------------------------------------------------------------------------
    //Funcion de suma arreglos
    public static void Arreglo1()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        /*1-PROGRAMA QUE LE PIDA AL USUARIO 5 NÚMEROS Y LOS ALMACENE EN UN ARREGLO.
            "CUANDO EL USUARIO TERMINE DE INGRESARLOS  DEBE MOSTRAR LA SUMATORIA DE
            "ESOS NÚMEROS.*/

        int[] num5 = new int[5];
        int suma = 0;

        System.Console.WriteLine("Digite 5 numeros:");
        for (int i = 0; i < num5.Length; i++)
        {
            System.Console.WriteLine("Entre un numero");
            num5[i] = int.Parse(Console.ReadLine()!);

            suma += num5[i];
        }
        System.Console.WriteLine($"La suma de sus numeros es: {suma}");
    }

    //-------------------------------------------------------------------------------------
    //Funcion de NUMERO 23
    public static void Arreglo2()
    {
        Console.ForegroundColor = ConsoleColor.Green;

        /*2-PROGRAMA QUE RECIBA 7 NÚMEROS DE PARTE DEL USUARIO. DEBE VERIFICAR
          SI DENTRO DE ELLOS ESTA EL 23. EN CASO DE QUE ASÍ SEA, MOSTRAR UN SALUDO
          Y SALIR. EN CASO CONTRARIO MOSTRAR UNA DESPEDIDA Y SALIR.
*/
        int[] num7 = new int[7];

        System.Console.WriteLine("Digite 7 Numeros:\n");

        string saludo = "";

        for (int i = 0; i < num7.Length; i++)
        {
       
            System.Console.WriteLine("Entre un numero:");
            num7[i] = int.Parse(Console.ReadLine()!);

            if (num7[i] == 23)
            {
                saludo = "Hola";
                System.Console.WriteLine(saludo);
            }
            if (num7[i] != 23)
            {
                saludo = "Hasta luego";
                System.Console.WriteLine(saludo);
            }
             
        }
        
        

    }

    //-------------------------------------------------------------------------------------
    //Funcion de 10 NUMERO
    public static void Arreglo3()
    {
        Console.ForegroundColor = ConsoleColor.Green;

        /*3-PROGRAMA QUE LEA 10 NÚMEROS ENTEROS INGRESADOS POR EL USUARIO Y
         LOS INSERTE EN UN ARREGLO. A CONTINUACIÓN, EL PROGRAMA DEBE CONTAR
         Y CLASIFICAR CUÁNTOS NÚMEROS PARES Y CUÁNTOS NÚMEROS IMPARES HAY DENTRO
         DEL ARREGLO, Y MOSTRAR ESOS RESULTADOS.
        */
        int[] num10 = new int[10];
        int contador1 = 0, contador2 = 0;

        System.Console.WriteLine("Digite 10 numero:");

        for (int i = 0; i < num10.Length; i++)
        {
            System.Console.WriteLine("Entre un numero");
            num10[i] = int.Parse(Console.ReadLine()!);

            if (num10[i] % 2 == 0)
            {
                contador1 += 1;
            }
            if (num10[i] % 2 != 0)
            {
                contador2 += 1;
            }
        }
        System.Console.WriteLine($"Los numeros pares son: {contador1}");
        System.Console.WriteLine($"Los numeros impares son: {contador2}");

    }

    //-------------------------------------------------------------------------------------
    //Funcion de dos arrays
    public static void Arreglo4()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        /*4-PROGRAMA QUE LEA 5 NÚMEROS POR TECLADO. DEBE COPIAR LOS 
         VALORES EN UN SEGUNDO ARREGLO, SIGUIENDO ESTE REQUERIMIENTO:

        -SI EL NUMERO DE TURNO DEL PRIMER ARREGLO ES PAR, 
          COPIARLO AL SEGUNDO ARREGLO MULTIPLICADO POR 10.
        -EN CASO CONTRARIO COPIARLO AL SEGUNDO ARREGLO TAL COMO ESTA. */

        int[] num = new int[5];
        int[] num1 = new int[5];

        System.Console.WriteLine("Digite 5 Numeros:");
        for(int i =0; i< num.Length;i++)
        {
            System.Console.WriteLine("Entre un Numero");
            num[i] = int.Parse(Console.ReadLine()!);
            if (num[i] % 2 == 0)
            {
                num1[i] = num[i] * 10;
                System.Console.WriteLine($"Su numero par multiplicado por 10 es; {num1[i]}");
            }
            else
            {
                num1[i] = num[i];
                System.Console.WriteLine($"El numero impar es: {num1[i]}");
            }
        }
    }

}