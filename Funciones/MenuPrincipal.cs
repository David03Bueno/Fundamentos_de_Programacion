
int opcion;
do
{

  //PROGRAMA PRINCIPAL
  Console.BackgroundColor = ConsoleColor.White;
  Console.Clear();
  Console.ForegroundColor = ConsoleColor.Black;
  System.Console.WriteLine("---------------MENU DE PROGRAMAS---------------");
  System.Console.WriteLine("---------------Elija una opcion:---------------");
  System.Console.WriteLine("1-SALUDO QUE INCLUYA EL NOMBRE DEL USUARIO QUE RECIBIÓ.");
  System.Console.WriteLine("2-UN ENTERO DE DOS DÍGITOS Y RETORNE SU ÚLTIMO DÍGITO. ");
  System.Console.WriteLine("3-UN NUMERO Y RETORNE UN MENSAJE DICIENDO SI ES PAR O IMPAR, SEGÚN SEA EL CASO.");
  System.Console.WriteLine("4-LA TABLA DE MULTIPLICAR DEL PRIMER DÍGITO, SIENDO EL LÍMITE DE LA TABLA EL SEGUNDO DÍGITO.");
  System.Console.WriteLine("5-LA FUNCIÓN DEBE RETORNAR EL MAYOR DE LOS DOS DÍGITOS.");
  System.Console.WriteLine("0-Para salir");


  opcion = int.Parse(Console.ReadLine()!);

  Console.ResetColor();

  Console.ResetColor();
  switch (opcion)
  {
    case 1:
      SaludoP1.Saludo();
      break;

    case 2:
      EnteroP2.UltimoDig();
      break;

    case 3:
      ParImpaP3.Pares();
      break;
    
    case 4:
      TablaP4.TabMul();
      break;
    
    case 5:
      NumMayorP5.Mayor();
      break;

    case 0:
      System.Console.WriteLine("Saliendo...");
      break;

    default:
      System.Console.WriteLine("La opcion selecionada es incorecta");

      break;
  }

} while (opcion != 0);
