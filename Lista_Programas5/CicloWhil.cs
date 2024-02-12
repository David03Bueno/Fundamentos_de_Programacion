                 //PROGRAMAS CON CILO WHILE

public class CicloWhil
{
    public static void Programs1()
    {
            
        Console.ForegroundColor = ConsoleColor.Blue;
        System.Console.WriteLine("CICLO WHILE \n" + "ELIJA UNA OPCION \n" +
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
                Num1_500();
                break;

            case 2:
                Num500_1();
                break;

            case 3:
                Impares();
                break;

            case 4:
                Hasta1000();
                break;

            case 5:
                Descendente();
                break;

            case 6:
                NumPar();
                break;

            case 7:
                DosNum();
                break;

            default:
                System.Console.WriteLine("La opcion elegida es incorrecta.");
                break;
        }
      
    }



    //===============================================================================
    //Funcion del 1 al 500
    public static void Num1_500()
    {
        //PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS DEL 1 AL 500
        int num = 1;
        while (num <= 500)
        {
            System.Console.WriteLine(num++);

        }

    }
    //---------------------------------------------------------------------------------
    //Funcion de 500 a 1
    public static void Num500_1()
    {
        //PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS DEL 500 AL 1
        int num = 500;
        while (num >= 1)
        {
            System.Console.WriteLine(num--);

        }

    }

    //---------------------------------------------------------------------------------
    //Funcion de numero impares 1_100
    public static void Impares()
    {
        //PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS IMPARES COMPRENDIDOS ENTRE EL 1 Y EL 100
        int num = 1;
        while (num < 99)
        {
            System.Console.WriteLine(num = num + 2);

        }

    }

    //---------------------------------------------------------------------------------
    //Funcion de numeros 5 en 5 hasta 1000
    public static void Hasta1000()
    {
        //PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS DEL 0 AL 1000, INCREMENTANDO DE 5 EN 5
        int num = 0;
        while (num < 1000)
        {
            System.Console.WriteLine(num = num + 5);
        }

    }

    //---------------------------------------------------------------------------------
    //Funcion de numeros descendente por pantalla
    public static void Descendente()
    {
        /*PROGRAMA QUE PIDA AL USUARIO UN NUMERO, Y MUESTRE EN PANTALLA 
        LA SECUENCIA DESCENDENTE DESDE EL NUMERO INGRESADO HASTA 0*/

        System.Console.WriteLine("Ingrese un Numero:");

        int num = int.Parse(Console.ReadLine()!);
        //  int num1;
        while (0 < num)
        {
            System.Console.WriteLine(num--);
        }

    }

    //---------------------------------------------------------------------------------
    //Funcion de numero multiplicado por 5 y sacar par
    public static void NumPar()
    {
        /* 6. PROGRAMA QUE PIDA AL USUARIO UN NUMERO. EL NUMERO RECIBIDO
        LO MULTIPLICARA POR 5. SI EL RESULTADO ES UN NUMERO PAR, MOSTRARA
        EN PANTALLA LA SECUENCIA ASCENDENTE DESDE EL NUMERO RECIBIDO HASTA
        EL RESULTADO DE LA MULTIPLICACION. EN CASO CONTRARIO, MOSTRARA LA SECUENCIA
        DESCENDENTE DESDE EL RESULTADO DE LA MULTIPLICACION HASTA EL NUMERO INGRESADO.
        */
        int num, multipli;
        System.Console.WriteLine("Ingrese un Numero:");

        num = int.Parse(Console.ReadLine()!);
        multipli = num * 5;

        if (multipli % 2 == 0)
        {
            while (num <= multipli)
            {
                System.Console.WriteLine(num++);
            }
        }
        else
        {
            while (multipli >= num)
            {
                System.Console.WriteLine(multipli--);
            }
        }

    }

    //---------------------------------------------------------------------------------
    //Funcion de dos numero 
    public static void DosNum()
    {
        /*7. PROGRAMA QUE PIDA AL USUARIO DOS NUMERO. SI EL 1ER NUMERO ES
         MAYOR QUE EL SEGUNDO, MOSTRARA LA SECUENCIA DESCENDENTE DESDE EL
        PRIMER NUMERO HASTA EL SEGUNDO, EN CASO CONTRARIO MOSTRAR LA SECUENCIA ASCENDENTE.*/

        int num1, num2;
        System.Console.WriteLine("Digite el Primer Numero");
        num1 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Digite el Segundo Numero");
        num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            while (num1 >= num2)
            {
                System.Console.WriteLine(num1--);
            }
        }
        else
        {
            while (num1 <= num2)
            {
                System.Console.WriteLine(num1++);
            }
        }
    }

}