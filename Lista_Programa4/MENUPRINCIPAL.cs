internal class Program
{
    private static void Main(string[] args)
    {
        // MENU PRINCIPAL 
            //Presentacion de las opciones
        Console.WriteLine("======MENU DE PROGRMAS======\n");
        Console.WriteLine("    --ELIGA UN PROGRAMA--    \n" +
        "    1-Programa de meses  \n    2-Programa de Frases en otro Idioma  \n    3-Programa de dias  \n   0-Salir");

        byte opcion = Convert.ToByte(Console.ReadLine());
    // Declaracion de un ciclo do while
        do
            if (opcion == 1) 
            {
                NuMeses.Mes();// Llmamos el metodo o funcion
            }

            else if  (opcion == 2)
            {
                Submenu.Frase();// Llmamos el metodo o funcion
            }

            else if (opcion == 3)
            {
               NumDias.Dias(); // Llmamos el metodo o funcion
            }

            else 
            {
                System.Console.WriteLine("LA OPCION QUE ELEIGIO NO ES VALIDA.");// Si no se cumple la condicion
            }                                                                           

        while (opcion == 0); // Terminar el ciclo do while
    }
}



