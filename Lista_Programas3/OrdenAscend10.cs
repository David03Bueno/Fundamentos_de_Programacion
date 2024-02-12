/*PROGRAMA QUE LEA TRES NÚMEROS Y LOS MUESTRE
 EN ORDEN ASCENDENTE (DE MENOR A MAYOR) */

public class OrdenAscend10
{
   public static void Orden()
   {
      //-----------------------------------------------------------------------------
      //DECLARACION DE VARIABLES
      int num1, num2, num3;

      //==================================================================================================
      //SOLICITUD AL USUARIO
      System.Console.WriteLine("DIGITE EL PRIMER NUMERO");
      num1 = Convert.ToInt32(Console.ReadLine());

      System.Console.WriteLine("DIGITE EL SEGUNDO NUMERO");
      num2 = Convert.ToInt32(Console.ReadLine());

      System.Console.WriteLine("DIGITE EL TERCER NUMERO");
      num3 = Convert.ToInt32(Console.ReadLine());

      //====================================================================================================
      //PROCESO Y SALIDAD
      if (num1 > num2 && num2 > num3)
      {
         System.Console.WriteLine($"{num1} \n {num2} \n {num3}");
      }
      //--------------------------------------------------------------------
      else if (num2 > num1 && num1 > num3)
      {
         System.Console.WriteLine($"{num2} \n {num1} \n {num3}");
      }
      //--------------------------------------------------------------------
      else if (num3 > num2 && num2 > num1)
      {
         System.Console.WriteLine($"{num3} \n {num2} \n {num1}");
      }

      else if (num1 > num3 && num3 > num2)
      {
         System.Console.WriteLine($"\n {num1} \n {num3} \n {num2}");
      }
   }
}