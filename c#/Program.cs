using System;

public record Estudiante(string Nombre, int Edad, double Promedio);

class Program
{
    static void Main(string[] args)
    {
        // =========================
        // 1. CREACIÓN DE INSTANCIAS
        // =========================
        var e1 = new Estudiante("Ana", 20, 4.5);
        var e2 = new Estudiante("Luis", 22, 3.8);
        var e3 = new Estudiante("Marta", 19, 4.2);

        // =========================
        // 2. ARREGLO
        // =========================
        Estudiante[] estudiantes = { e1, e2, e3 };

        // =========================
        // 3. RECORRIDO INICIAL
        // =========================
        Console.WriteLine("=== LISTA ORIGINAL ===");
        foreach (var e in estudiantes)
        {
            Console.WriteLine($"Nombre: {e.Nombre}, Edad: {e.Edad}, Promedio: {e.Promedio}");
        }

        // =========================
        // 4. MODIFICACIÓN
        // =========================
        estudiantes[0] = estudiantes[0] with { Promedio = 5.0 };

        // =========================
        // 5. RECORRIDO DESPUÉS DE MODIFICAR
        // =========================
        Console.WriteLine("\n=== LISTA MODIFICADA ===");
        foreach (var e in estudiantes)
        {
            Console.WriteLine($"Nombre: {e.Nombre}, Edad: {e.Edad}, Promedio: {e.Promedio}");
        }
    }
}