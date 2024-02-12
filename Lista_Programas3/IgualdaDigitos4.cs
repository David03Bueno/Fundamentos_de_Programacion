/*PROGRAMA QUE LEA UN NUMERO ENTERO DE DOS DÍGITOS
 Y DETERMINE SI SUS DOS DÍGITOS SON IGUALES.*/
public class IgualdaDigitos4
{
    public static void Igual()
    {
        //-----------------------------------------------------------------------------
        //DECLARACION DE VARIABLES
        int num1, Digito1, Digito2;
        //=========================================================================
        //SOLICITUD AL USUARIO
        System.Console.WriteLine("DIGITE UN NUMERO DE DOS DIGITOS");
        num1 = Convert.ToInt32(Console.ReadLine());
        //================================================================================
        //PROCESO Y SALIDAD
        Digito1 = num1 / 10;
        Digito2 = num1 % 10;

        if (Digito1 == Digito2)
        {
            System.Console.WriteLine($"LOS DIGITOS {Digito1} Y {Digito2} SON IGUALES.");
        }
        else
        {
            System.Console.WriteLine($"LOS DIGITOS {Digito1} Y {Digito2} NO SON IGUALES.");
        }
    }
}
