/*PROGRAMA QUE LEA UN NUMERO DE TRES DÍGITOS (DEBE VALIDAR
 ESA ENTRADA) Y CALCULE LA SUMATORIA DE SUS DÍGITOS*/

public class TresDigitos7
{
    public static void TresD()
    {
        //-----------------------------------------------------------------------------
        //DECLARACION DE VARIABLES
        int num1, suma, Digito1, Digito2, Digito3;

        //==================================================================================================
        //SOLICITUD AL USUARIO
        System.Console.WriteLine("INTRODUZCA UN NUMERO DE TRES DIGITOS");
        num1 = Convert.ToInt32(Console.ReadLine());

        //====================================================================================================
        //PROCESO Y SALIDAD
        if (num1 >= 100 && num1 < 1000)
        {
            Digito1 = num1 / 100;
            Digito2 = (num1 % 100) / 10;
            Digito3 = num1 % 10;
            suma = Digito1 + Digito2 + Digito3;
            System.Console.WriteLine($"LA SUMA DE LOS DIGITOS {Digito1} , {Digito2} , {Digito3}  ES: [{suma}]");
        }
        else
        {
            System.Console.WriteLine("Su numero no tiene [tres digitos]");
            System.Console.WriteLine("FAVOR DE INGRESAR UN NUMERO DE TRES DIGITOS --ej:123-- ");
        }
    }
}