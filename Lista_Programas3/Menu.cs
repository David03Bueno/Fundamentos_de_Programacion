// MENU PRINCIPAL PARA LLAMAR LOS 12 PROGRAMAS

public class Menu
{
    public static void Main(string[] sgrs)
    {
        System.Console.WriteLine("---MENU DE OPCIONES DE LOS 12 SIGUIENTES PROGRAMAS---\n");
        System.Console.WriteLine("ELIJA UNA OPCION");
        System.Console.WriteLine("1- Numeros Negativos y Positivos");
        System.Console.WriteLine("2- Numeros Impares");
        System.Console.WriteLine("3- Numero de Dos Dijitos y Saber su Suma");
        System.Console.WriteLine("4- Numero de Dos Dijitos y Saber si son Iguales");
        System.Console.WriteLine("5- Leer Dos Numeros Encontrar el Mayor");
        System.Console.WriteLine("6- Leer Dos Numeros, Sumarlos y Saber es Par");
        System.Console.WriteLine("7- Leer un Numero de Tres Digitos y Calcular la suma de los tres");
        System.Console.WriteLine("8- Leer Un Numero Y Determine Si Es Múltiplo De 6");
        System.Console.WriteLine("9- Leer Un Numero De Dos Dígitos Y Saber Si Uno Es Múltiplo De Otro");
        System.Console.WriteLine("10- Leer Tres Números Y Los Muestre De Menor A Mayor");
        System.Console.WriteLine("11- Leer Un Numero De Tres Digitos Y saber si el Primero Es Igual Al Ultimo");
        System.Console.WriteLine("12- Leer La Edad Del Usuario y Ejecutar Procesos");

        int opciones = int.Parse(Console.ReadLine()!);
        switch (opciones)
        {
            case 1:
                PositivoNegat1.PosNea();
                break;
            case 2:
                Pares_Impar2.NumPares();
                break;

            case 3:
                SumaDigitos3.SumaDig3();
                break;
            case 4:
                IgualdaDigitos4.Igual();
                break;

            case 5:
                NumMayor5.NumeroM();
                break;

            case 6:
                SumaEsPar6.SumaPres();
                break;
            case 7:
                TresDigitos7.TresD();
                break;

            case 8:
                Multiplo8.multiploDi();
                break;

            case 9:
                MultiploDigitos9.Mul();
                break;

            case 10:
                OrdenAscend10.Orden();
                break;
            case 11:
                DigitosTres11.tresDi();
                break;

            case 12:
                Edad12.Edad_APH();
                break;

            default:
            System.Console.WriteLine("Opcion incorrecta");
            break;
        }

    }
}