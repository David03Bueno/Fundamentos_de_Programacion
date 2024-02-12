//MENU PRINCIPAL DE CICLOS
public class MenuPrincipal
{
    public static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;

        int opcion;
        System.Console.WriteLine("\n--BIENVENIDO AL PROGRAMA DE LOS CICLOS WHILE & DO WHILE-- \n");
         
       
        System.Console.WriteLine("ELIJA UNA OPCION:\n" +
        "1-PROGRAMAS CON CICLO WHILE \n2-PROGRAMAS CON CILO DO WHILE \n");
        opcion = Convert.ToInt32(Console.ReadLine());

        Console.ResetColor();
        switch (opcion)
        {
            case 1:
                CicloWhil.Programs1();
                break;
            
            case 2:
            CicloDowhi.programs2();
                break;

            default:
                System.Console.WriteLine("La opcion elejida no es valida vuelva a intentar \n");
                
                break;
        }
    }
}
