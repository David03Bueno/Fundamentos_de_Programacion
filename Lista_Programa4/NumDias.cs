/*Programa que le pida al usuario un numero del 1 al 7 y
que segun el numero, escriba en la pantalla el nombre
del dia de la semana correspondiente*/

public class NumDias
{
    public static void Dias()
    {
        System.Console.WriteLine("===PROGRAMA DE DIAS DE LA SEMANA===");
        System.Console.WriteLine("ELIJA UN NUMERO DEL 1 al 7");

        byte num = Convert.ToByte(Console.ReadLine());

        switch (num)
        {
            case 1:
                System.Console.WriteLine("Domingo");
                break;

            case 2:
                System.Console.WriteLine("Lunes");
                break;
                
            case 3:
                System.Console.WriteLine("Martes");
                break;

            case 4:
                System.Console.WriteLine("Miercoles");
                break;

            case 5:
                System.Console.WriteLine("Jueves");
                break;

            case 6:
                System.Console.WriteLine("Viernes");
                break;

            case 7:
                System.Console.WriteLine("Sabado");
                break;

            default:
                System.Console.WriteLine("EL NUMERO NO ES VALIDO");
                break;
        }
    }
}