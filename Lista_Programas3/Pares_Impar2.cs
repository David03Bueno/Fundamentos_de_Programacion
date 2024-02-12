/*PROGRAMA QUE LEA UN NUMERO DE DOS DÍGITOS Y DETERMINE SI AMBOS DÍGITOS
SON PARES O IMPARES. DEBE MOSTRAR UN MENSAJE DANDO LA INFORMACIÓN DE
CADA DÍGITO (DECIR: "EL 1ER DÍGITO ES __(PAR  O IMPAR), EL SEGUNDO...").*/

class Pares_Impar2
{

    public static void NumPares()
    {
        //-----------------------------------------------------------------------------
        //DECLARACION DE VARIABLES
        int num, num1, num2;
        //================================================================================
        //SOLICITUD AL USUARIO
        System.Console.WriteLine("INTRODUZCA UN NUMERO DE DOS DIGITOS");
        num = Convert.ToInt32(Console.ReadLine());

        //================================================================================
        //PROCESO Y SALIDAD
        num1 = num / 10;
        num2 = num % 10;

        if (num1 % 2 == 0)
        {
            System.Console.WriteLine($"EL 1ER DÍGITO  {num1} ES PAR");
        }
        else
        {
            System.Console.WriteLine($"EL 1ER DÍGITO  {num1} ES IMPAR");
        }
        //--------------------------------------------------------------------
        if (num2 % 2 == 0)
        {
            System.Console.WriteLine($"EL 2DO DÍGITO  {num2} ES PAR");
        }
        else
        {
            System.Console.WriteLine($"EL 2DO DÍGITO  {num2} ES IMPAR");
        }
    }
}
