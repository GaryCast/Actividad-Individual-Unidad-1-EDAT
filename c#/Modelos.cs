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

// =========================
// MINI PROYECTO
// =========================
public record Password(string Valor, bool EsValida);

public struct Configuracion
{
    public int Longitud;
}

public class Usuario
{
    // 🔧 SOLUCIÓN AL WARNING CS8618
    public string Nombre { get; set; } = "";
    public Password[,] HistorialPasswords { get; set; } = new Password[0, 0];
}

public class Generador
{
    private static Random random = new Random();

    public static string Generar(int longitud)
    {
        string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";
        string password = "";

        for (int i = 0; i < longitud; i++)
        {
            password += caracteres[random.Next(caracteres.Length)];
        }

        return password;
    }

    public static bool Validar(string password)
    {
        bool mayus = false, minus = false, num = false, simb = false;

        foreach (char c in password)
        {
            if (char.IsUpper(c)) mayus = true;
            else if (char.IsLower(c)) minus = true;
            else if (char.IsDigit(c)) num = true;
            else simb = true;
        }

        return mayus && minus && num && simb;
    }
}

// =========================
// MÉTODOS DE EJECUCIÓN
// =========================
public class Ejecutador
{
    public static void EjecutarPunto3()
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

        // Modificación (inmutabilidad del record)
        records[0] = records[0] with { Promedio = 5.0 };

        Console.WriteLine("\nLista modificada:");
        foreach (var r in records)
        {
            Console.WriteLine(r);
        }
    }

    public static void EjecutarPunto4()
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

        // Modificación (mutabilidad de la clase)
        estudiantes[0].SetPromedio(5.0);

        Console.WriteLine("\nLista modificada:");
        foreach (var e in estudiantes)
        {
            e.MostrarInfo();
        }
    }

    public static void EjecutarMiniProyecto()
    {
        Console.WriteLine("\n=== MINI PROYECTO: USUARIOS Y PASSWORDS ===");

        Configuracion config = new Configuracion { Longitud = 10 };

        Usuario[] usuarios = new Usuario[2];

        for (int i = 0; i < usuarios.Length; i++)
        {
            usuarios[i] = new Usuario
            {
                Nombre = "Usuario " + (i + 1),
                HistorialPasswords = new Password[2, 2]
            };

            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    string pass;

                    do
                    {
                        pass = Generador.Generar(config.Longitud);
                    } while (!Generador.Validar(pass));

                    usuarios[i].HistorialPasswords[j, k] = new Password(pass, true);
                }
            }
        }

        // 🔍 Mostrar datos
        foreach (var u in usuarios)
        {
            Console.WriteLine($"\nUsuario: {u.Nombre}");

            foreach (var p in u.HistorialPasswords)
            {
                Console.WriteLine($"Password: {p.Valor} | Válida: {p.EsValida}");
            }
        }
    }
}