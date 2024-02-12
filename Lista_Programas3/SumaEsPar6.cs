/*PROGRAMA QUE LEA DOS NÚMEROS Y DETERMINE SI
LA SUMATORIA DE AMBOS NÚMEROS ES PAR O IMPAR*/

public class SumaEsPar6
{
    public static void SumaPres()
    {
        //-----------------------------------------------------------------------------
        //DECLARACION DE VARIABLES
        int num1, num2, suma;
        //=========================================================================
        //SOLICITUD AL USUARIO
        System.Console.WriteLine("DIGITE EL PRIMER NUMERO");
        num1 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("DIGITE EL PRIMER NUMERO");
        num2 = Convert.ToInt32(Console.ReadLine());

        //================================================================================
        //PROCESO Y SALIDAD
        suma = num1 + num2;

        if (suma % 2 == 0)
        {
            System.Console.WriteLine($"LA SUMA DE {num1} Y {num2} ES PAR [{suma}]");
        }
        else
        {
            System.Console.WriteLine($"LA SUMA DE {num1} Y {num2} ES IMPAR [{suma}]");
        }
    }
}