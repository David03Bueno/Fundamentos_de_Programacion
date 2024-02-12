/*Programa que le pida al usuario que inserte un numero del 1 al 12.
Aplicar un switch para que muestre el mes correspondiente al número
ingresado, siendo 1 = Enero y 12 =  Diciembre. Contemplar incluir un
mensaje si el usuario ingresa un numero fuera de este rango. */

public class NuMeses
{
  
    public static void Mes()
    {
        System.Console.WriteLine("  ===PROGRAMA DE MES===");
        System.Console.WriteLine("DIGITE UN NUMERO DEL 1 AL 12");

        byte Nmes = Convert.ToByte(Console.ReadLine());
        switch (Nmes)
        {
            case 1:
                System.Console.WriteLine("El numero digitado es del mes de Enero");
                break;
            case 2:
                System.Console.WriteLine("El numero digitado es del mes de Febrero");
                break;

            case 3:
                System.Console.WriteLine("El numero digitado es del mes de Marzo");
                break;

            case 4:
                System.Console.WriteLine("El numero digitado es del mes de Abril");
                break;

            case 5:
                System.Console.WriteLine("El numero digitado es del mes de mayo");
                break;

            case 6:
                System.Console.WriteLine("El numero digitado es del mes de Junio");
                break;

            case 7:
                System.Console.WriteLine("El numero digitado es del mes de Julio");
                break;

            case 8:
                System.Console.WriteLine("El numero digitado es del mes de Agosto");
                break;

            case 9:
                System.Console.WriteLine("El numero digitado es del mes de Septiembre");
                break;

            case 10:
                System.Console.WriteLine("El numero digitado es del mes de Octubre");
                break;

            case 11:
                System.Console.WriteLine("El numero digitado es del mes de Noviembre");
                break;

            case 12:
                System.Console.WriteLine("El numero digitado es del mes de Diciembre");
                break;

            default:
                System.Console.WriteLine("Este valor no es valido ");
                break;
        }

    }

}
