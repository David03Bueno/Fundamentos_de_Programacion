//PROGRAMA QUE LEA DOS NÚMEROS Y DETERMINE CUAL ES EL MAYOR
public class NumMayor5
{
    public static void NumeroM()
    {
        //-----------------------------------------------------------------------------
        //DECLARACION DE VARIABLES
        int num1, num2;
        //=========================================================================
        //SOLICITUD AL USUARIO
        System.Console.WriteLine("DIGITE EL PRIMER NUMERO");
        num1 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("DIGITE EL PRIMER NUMERO");
        num2 = Convert.ToInt32(Console.ReadLine());
        //================================================================================
        //PROCESO Y SALIDAD
        if (num1 > num2)
        {
            System.Console.WriteLine($"EL NUMERO MAYOR ES:  {num1}");
        }
        else if (num1 == num2)
        {
            System.Console.WriteLine("LOS DOS NUMEROS SON IGUALES");
        }
        else
        {
            System.Console.WriteLine($"EL NUMERO MAYOR ES:  {num2}");
        }
    }
}

