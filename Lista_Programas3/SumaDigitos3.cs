/*PROGRAMA QUE LEA UN NUMERO DE DOS DÍGITOS
QUE DETERMINE LA SUMA DE LOS DOS DÍGITOS.*/
class SumaDigitos3
{
    public static void SumaDig3()
    {
        //---------------------------------------------------
        //DECLARACION DE VARIABLES
        int num1, Digito1, Digito2, suma;
        //===============================================================================
        //SOLICITUD AL USUARIO
        System.Console.WriteLine("DIGITE UN NUMERO DE DOS DIGITOS");
        num1 = Convert.ToInt32(Console.ReadLine());
        //================================================================================
        //PROCESO Y SALIDAD
        Digito1 = num1 / 10;
        Digito2 = num1 % 10;
        suma = Digito1 + Digito2;
        System.Console.WriteLine($"LA SUMA DE LOS DIGITOS {Digito1} Y {Digito2} ES: [{suma}]");
    }
}