/*PROGRAMA QUE LEA LA EDAD DEL USUARIO. SI ES MAYOR QUE
50 MOSTRAR MENSAJE QUE DIGA "ABUELO." SI ES MAYOR QUE
30 MOSTRAR MENSAJE QUE DIGA "PADRE". EN CASO CONTRARIO
MOSTRAR MENSAJE QUE DIGA "HIJO"*/

public class Edad12
{
    public static void Edad_APH()
    {
        //-----------------------------------------------------------------------------
        //DECLARACION DE VARIABLES
        int edad;

        //==================================================================================================
        //SOLICITUD AL USUARIO
        System.Console.WriteLine("    --PROMEDIO DE EDAD--    \n");

        System.Console.WriteLine("DIGITE SU EDAD: ");
        edad = Convert.ToInt32(Console.ReadLine());

        //====================================================================================================
        //PROCESO Y SALIDAD
        if (edad > 50) { System.Console.WriteLine("  ABUELO  "); }

        else if (edad <= 50 && edad >= 30) { System.Console.WriteLine("  PADRE  "); }

        else if (edad < 30) { System.Console.WriteLine("  HIJO  "); }
    }
}