/*PROGRAMA QUE LEA UN NUMERO DE DOS DÍGITOS Y
 DETERMINE SI UN DÍGITO ES MÚLTIPLO DE OTRO*/

public class MultiploDigitos9
{
    public static void Mul()
    {
        //-----------------------------------------------------------------------------
        //DECLARACION DE VARIABLES
        int num1, Digito1, Digito2;

        //==================================================================================================
        //SOLICITUD AL USUARIO
        System.Console.WriteLine("DIGITE UN NUMERO");
        num1 = Convert.ToInt32(Console.ReadLine());

        //====================================================================================================
        //PROCESO Y SALIDAD
        if (num1 >= 10 && num1 < 100)
        {
            Digito1 = num1 / 10;
            Digito2 = num1 % 10;

            if (Digito1 % Digito2 == 0)
            {
                System.Console.WriteLine($"EL DIGITO {Digito1} ES MULTIPLO DEL DIGITO {Digito2} ");
            }
            else
            {
                System.Console.WriteLine($"EL DIGITO {Digito1} NO ES MULTIPLO DEL DIGITO {Digito2} ");
            }

        }
        else
        {
            System.Console.WriteLine("Este numero no es de dos digitos.");
            System.Console.WriteLine("FAVOR DE INGRESAR UN NUMERO DE DOS DIGITOS");
        }
    }
}