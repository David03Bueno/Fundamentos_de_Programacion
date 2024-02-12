/*PROGRAMA QUE LEA UN NUMERO ENTERO DE TRES DIGITOS
  Y DETERMINE SI EL PRIMERO ES IGUAL AL ULTIMO.*/

public class DigitosTres11
{
    public static void tresDi()
    {
        //-----------------------------------------------------------------------------
        //DECLARACION DE VARIABLES
        int num1, Digito1, Digito2, Digito3;

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

            if (Digito1 == Digito3)
            {
                System.Console.WriteLine($"EL PRIMER DIGITO [{Digito1}] ES IGUAL AL TERCER DIGITO [{Digito3}] ");
            }
            else
            {
                System.Console.WriteLine($"EL PRIMER DIGITO [{Digito1}] NO ES IGUAL AL TERCER DIGITO [{Digito3}] ");
            }
        }
        else
        {
            System.Console.WriteLine("Su numero no tiene [tres digitos]");
            System.Console.WriteLine("FAVOR DE INGRESAR UN NUMERO DE TRES DIGITOS --ej:123-- ");
        }
    }
}