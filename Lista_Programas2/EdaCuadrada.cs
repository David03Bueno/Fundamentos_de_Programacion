//PROGRAMA HECHO POR Luis David Bueno
//Programa que muestre en pantalla el cuadrado de su edad.
public class EdaCuadrada
{
    public static void Edad()
    {
        double edad = 0; // Aqui se declara la variable edad.

        System.Console.WriteLine("--Digite su edad--"); // Se le pide al usurio entrar su edad.

        edad = double.Parse(Console.ReadLine()!); //Se guarda el dato en la variable

        edad = Math.Pow(edad,2); //Atravez de esta operacion obtenemos el cuadrado de la edad
        System.Console.WriteLine("--Su edad al Cuadrado es: " + edad +"--"); // Imprimimos
    }
}
