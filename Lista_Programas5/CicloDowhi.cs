//PROGRMAS CON CICLO DO WHILE 

using System.Runtime.ConstrainedExecution;

public class CicloDowhi
{
    public static void programs2()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine("CICLO DO WHILE \n" + "ELIJA UNA OPCION \n" +
        "1. PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS DEL 1 AL 500 \n" +
        "2. PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS DEL 500 AL 1 \n" +
        "3. PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS IMPARES COMPRENDIDOS ENTRE EL 1 Y EL 100 \n" +
        "4. PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS DEL 0 AL 1000, INCREMENTANDO DE 5 EN 5 \n" +
        "5. PROGRAMA QUE PIDA AL USUARIO UN NUMERO, Y MUESTR EN PANTALLA LA SECUENCIA DESCENDENTE DESDE EL NUMERO INGRESADO HASTA 0\n" +
        "6. PROGRAMA QUE PIDA AL USUARIO UN NUMERO. EL NUMERO RECIBIDO LO MULTIPLICARA POR 5." +
            "SI EL RESULTADO ES UN NUMERO PAR, MOSTRARA EN PANTALLA LA SECUENCIA ASCENDENTE DESDE" +
            "EL NUMERO RECIBIDO HASTA EL RESULTADO DE LA MULTIPLICACION. EN CASO CONTRARIO, MOSTRARA" +
            "LA SECUENCIA DESCENDENTE DESDE EL RESULTADO DE LA MULTIPLICACION HASTA EL NUMERO INGRESADO.\n" +
        "7. PROGRAMA QUE PIDA AL USUARIO DOS NUMERO. SI EL 1ER NUMERO ES MAYOR QUE EL SEGUNDO, " +
            "MOSTRARA LA SECUENCIA DESCENDENTE DESDE EL PRIMER NUMERO HASTA EL SEGUNDO, " +
            "EN CASO CONTRARIO MOSTRAR LA SECUENCIA ASCENDENTE.");
        Console.ResetColor();

        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                DoNum1_500();
                break;

            case 2:
                DoNum500_1();
                break;

            case 3:
                DoImpares();
                break;

            case 4:
                DoHasta1000();
                break;

            case 5:
                DoDescendente();
                break;

            case 6:
                DoNumPar();
                break;

            case 7:
                DoDosNum();
                break;

            default:
                System.Console.WriteLine("La opcion elegida es incorrecta.");
                break;
        }
    }

    //================================================================================================
    //Funcion del 1 al 500
    public static void DoNum1_500()
    {
        //1. PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS DEL 1 AL 500
        int num = 0;
        do
        {
            System.Console.WriteLine(num++);
        } while (num <= 500);
    }

    //================================================================================================
    //Funcion de 500 al 1
    public static void DoNum500_1()
    {
        //2. PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS DEL 500 AL 1
        int num = 500;
        do
        {
            System.Console.WriteLine(num--);
        } while (num > 0);
    }

    //================================================================================================
    //Funcion de Numero Impares
    public static void DoImpares()
    {
        //3. PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS IMPARES COMPRENDIDOS ENTRE EL 1 Y EL 100
        int num = 1;
        do
        {
            num = num + 2;
            System.Console.WriteLine(num);
        } while (num < 99);
    }

    //================================================================================================
    //Funcion de 5 hasta 1000
    public static void DoHasta1000()
    {
        //4. PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS DEL 0 AL 1000, INCREMENTANDO DE 5 EN 5
        int num = 0;
        do
        {
            num = num + 5;
            System.Console.WriteLine(num);
        } while (num < 1000);
    }

    //================================================================================================
    //Funcion de Descendente 
    public static void DoDescendente()
    {
        /*5. PROGRAMA QUE PIDA AL USUARIO UN NUMERO, Y MUESTRE EN PANTALLA 
          LA SECUENCIA DESCENDENTE DESDE EL NUMERO INGRESADO HASTA 0*/

        System.Console.WriteLine("Ingrese un Numero:");
        int num = int.Parse(Console.ReadLine()!);

        do
        {
            System.Console.WriteLine(num--);
        } while (0 <= num);
    }

    //================================================================================================
    //Funcion de Numero Par eh Impar
    public static void DoNumPar()
    {
        /* 6. PROGRAMA QUE PIDA AL USUARIO UN NUMERO. EL NUMERO RECIBIDO
        LO MULTIPLICARA POR 5. SI EL RESULTADO ES UN NUMERO PAR, MOSTRARA
        EN PANTALLA LA SECUENCIA ASCENDENTE DESDE EL NUMERO RECIBIDO HASTA
        EL RESULTADO DE LA MULTIPLICACION. EN CASO CONTRARIO, MOSTRARA LA SECUENCIA
        DESCENDENTE DESDE EL RESULTADO DE LA MULTIPLICACION HASTA EL NUMERO INGRESADO.
        */
        System.Console.WriteLine("Ingrese un Numero:");
        int num = int.Parse(Console.ReadLine()!);
        int multipli = num * 5;

        if (multipli % 2 == 0)
        {
            do
            {
                System.Console.WriteLine(num++);
            } while (num <= multipli);
        }
        else
        {
            do
            {
                System.Console.WriteLine(multipli--);
            } while (multipli >= num);
        }

    }

    //================================================================================================
    //Funcion de dos Numeros 
    public static void DoDosNum()
    {
        /*7. PROGRAMA QUE PIDA AL USUARIO DOS NUMERO. SI EL 1ER NUMERO ES
         MAYOR QUE EL SEGUNDO, MOSTRARA LA SECUENCIA DESCENDENTE DESDE EL
        PRIMER NUMERO HASTA EL SEGUNDO, EN CASO CONTRARIO MOSTRAR LA SECUENCIA ASCENDENTE.*/

        int num1, num2;
        System.Console.WriteLine("Digite el Primer Numero");
        num1 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Digite el Segundo Numero");
        num2 = Convert.ToInt32(Console.ReadLine());

        if(num1 > num2)
        {
            do
            {
                System.Console.WriteLine(num1--);
            } while (num2 <= num1);
        }
        else
        {
            do
            {
                System.Console.WriteLine(num1++);
            } while (num1 <= num2);
        }


    }
}