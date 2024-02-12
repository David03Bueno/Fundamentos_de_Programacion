//PROGRAMA HECHO POR Luis David Bueno

/*Programa que le solicite al usuario su nombre y muestre un
saludo con el nombre que el usuario ha ingresado.*/
public class Saludo
{
    public static void saludo1()
    {
        Console.WriteLine("--Ingrese su Nombre--");// Aqui se le pide al usuario su nombre.

        string usuario = Console.ReadLine()!; // En esta linea se lee el nombre
        Console.WriteLine("> BIENVENIDO " + usuario + " <"); //Por ultimo le damos la bienvenida y le unimos su nombre
    }
}
