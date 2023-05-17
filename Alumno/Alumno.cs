// See https://aka.ms/new-console-template for more information
using System;

public class Alumno
{
    public string? Nombre;
    public int Edad;
    public string? Direccion;
}

class Alumn
{
    static void Main(string[] args)
    {
        Alumno alumno = new Alumno();

        alumno.Nombre = "Adrian";
        alumno.Edad = 17;
        alumno.Direccion = "Calle Principal 123";

        Console.WriteLine("Nombre: " + alumno.Nombre);
        Console.WriteLine("Edad: " + alumno.Edad);
        Console.WriteLine("Dirección: " + alumno.Direccion);

        Console.ReadLine();
    }
}

