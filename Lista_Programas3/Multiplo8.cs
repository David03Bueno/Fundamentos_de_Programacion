//PROGRAMA QUE LEA UN NUMERO Y DETERMINE SI ES MÚLTIPLO DE 6.

public class Multiplo8
{
    public static void multiploDi()
    {
        //-----------------------------------------------------------------------------
        //DECLARACION DE VARIABLES
        int num1;

        //==================================================================================================
        //SOLICITUD AL USUARIO
        System.Console.WriteLine("DIGITE UN NUMERO");
        num1 = Convert.ToInt32(Console.ReadLine());

        //====================================================================================================
        //PROCESO Y SALIDAD
        if (num1 % 6 == 0)
        {
            System.Console.WriteLine($"{num1} ES MULTIPLO DE 6");
        }
        else
        {
            System.Console.WriteLine($"{num1} NO ES MULTIPLO DE 6");
        }
    }
}