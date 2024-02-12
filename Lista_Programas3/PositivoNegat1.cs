/*PROGRAMA QUE LEA UN NUMERO Y DETERMINE SI ES POSITIVO
 O NEGATIVO, MOSTRANDO UN MENSAJE PARA CADA CASO*/
class PositivoNegat1
{
    //--------------------------------------------------------
    //Declaracion De variables
    public static void PosNea()
    {
        int num1;
        //============================================================
        //Solicitud Al Usuario
        System.Console.WriteLine("--NUMERO NEGATIVO O POSITIVO-- \n");

        System.Console.WriteLine("Digte un numero");
        num1 = Convert.ToInt32(Console.ReadLine());
        //================================================================
        // Proceso
        if (num1 > 0)
        {
            System.Console.WriteLine($"El Numero: {num1} Es Positivo");
        }
        else
        {
            System.Console.WriteLine($"El Numero: {num1} Es Negativo");
        }
    }
}