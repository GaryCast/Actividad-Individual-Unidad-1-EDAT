using System;

// =========================
// RECORD (PUNTO 3)
// =========================
public record EstudianteRecord(string Nombre, int Edad, double Promedio);

// =========================
// CLASE (PUNTO 4)
// =========================
public class Estudiante
{
    public string Nombre;
    public int Edad;
    public double Promedio;

    public Estudiante(string nombre, int edad, double promedio)
    {
        Nombre = nombre;
        Edad = edad;
        Promedio = promedio;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Promedio: {Promedio}");
    }

    public void SetPromedio(double nuevoPromedio)
    {
        Promedio = nuevoPromedio;
    }
}

class Program
{
    static void Main(string[] args)
    {
        EjecutarPunto3();
        EjecutarPunto4();
    }

    // =========================
    // PUNTO 3: RECORD
    // =========================
    static void EjecutarPunto3()
    {
        Console.WriteLine("=== PUNTO 3: RECORD ===");

        var r1 = new EstudianteRecord("Ana", 20, 4.5);
        var r2 = new EstudianteRecord("Luis", 22, 3.8);
        var r3 = new EstudianteRecord("Marta", 19, 4.2);

        EstudianteRecord[] records = { r1, r2, r3 };

        Console.WriteLine("Lista original:");
        foreach (var r in records)
        {
            Console.WriteLine(r);
        }

        // Modificación
        records[0] = records[0] with { Promedio = 5.0 };

        Console.WriteLine("\nLista modificada:");
        foreach (var r in records)
        {
            Console.WriteLine(r);
        }
    }

    // =========================
    // PUNTO 4: CLASE
    // =========================
    static void EjecutarPunto4()
    {
        Console.WriteLine("\n=== PUNTO 4: OBJETOS (CLASES) ===");

        var e1 = new Estudiante("Ana", 20, 4.5);
        var e2 = new Estudiante("Luis", 22, 3.8);
        var e3 = new Estudiante("Marta", 19, 4.2);

        Estudiante[] estudiantes = { e1, e2, e3 };

        Console.WriteLine("Lista original:");
        foreach (var e in estudiantes)
        {
            e.MostrarInfo();
        }

        // Modificación
        estudiantes[0].SetPromedio(5.0);

        Console.WriteLine("\nLista modificada:");
        foreach (var e in estudiantes)
        {
            e.MostrarInfo();
        }
    }
}