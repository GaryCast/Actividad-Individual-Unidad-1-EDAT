# Actividad Individual Unidad 1  
## Record o Struct
### Fundamentos:
* **Concepto y utilidad (almacenar datos relacionados).**
Un struct o record es una forma de agrupar datos relacionados dentro de una sola estructura. Su utilidad principal es organizar información que pertenece a una misma entidad, como por ejemplo los datos de un estudiante: nombre, edad y promedio. En lugar de manejar variables sueltas, se encapsulan en una sola unidad, lo que mejora la claridad y el orden del código.

* **Diferencias entre un registro/struct y un objeto.** 
La diferencia principal entre un struct (o registro) y un objeto (clase) radica en su propósito y complejidad. Mientras que un objeto combina datos y comportamiento (atributos y métodos), un struct o record se enfoca principalmente en almacenar datos. Además, en C#, los struct son tipos de valor, mientras que las clases son tipos de referencia, lo que influye en cómo se almacenan y se copian en memoria.

* **Tipado y acceso a campos.**
En cuanto al tipado y acceso a campos, tanto en C# como en Python se trabaja con tipado definido (explícito en C# y opcional en Python). Los campos se acceden directamente mediante el nombre del atributo, lo que permite leer o modificar los valores de forma sencilla, dependiendo de si la estructura es mutable o no.

### Actividades:
* **Declaración.** Definir un struct o record que contenga: nombre, edad, promedio.

 <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" width="40"/>

```c#
public record Estudiante(string Nombre, int Edad, double Promedio);
```

  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/python/python-original.svg" width="40"/>


```python
from dataclasses import dataclass

@dataclass
class Estudiante:
    nombre: str
    edad: int
    promedio: float
```

* **Inicialización.**
Crear 3 instancias con datos ficticios en los lenguajes dados (C# y Python).

 <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" width="40"/>

```c#
public record Estudiante(string Nombre, int Edad, double Promedio);

class Program
{
    static void Main(string[] args)
    {
        var e1 = new Estudiante("Ana", 20, 4.5);
        var e2 = new Estudiante("Luis", 22, 3.8);
        var e3 = new Estudiante("Marta", 19, 4.2);

        Console.WriteLine(e1);
        Console.WriteLine(e2);
        Console.WriteLine(e3);
    }
}
```

  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/python/python-original.svg" width="40"/>


```python
from dataclasses import dataclass

@dataclass
class Estudiante:
    nombre: str
    edad: int
    promedio: float

# Crear las 3 instancias
e1 = Estudiante("Ana", 20, 4.5)
e2 = Estudiante("Luis", 22, 3.8)
e3 = Estudiante("Marta", 19, 4.2)

# Mostrar los datos
print(e1)
print(e2)
print(e3)
```

* **Recorrido.**
Guardar las instancias en un arreglo y recorrerlo mostrando los datos.

 <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" width="40"/>

```c#
using System;

public record Estudiante(string Nombre, int Edad, double Promedio);

class Program
{
    static void Main(string[] args)
    {
        // Crear instancias
        var e1 = new Estudiante("Ana", 20, 4.5);
        var e2 = new Estudiante("Luis", 22, 3.8);
        var e3 = new Estudiante("Marta", 19, 4.2);

        // Guardar en un arreglo
        Estudiante[] estudiantes = { e1, e2, e3 };

        // Recorrer el arreglo
        foreach (var e in estudiantes)
        {
            Console.WriteLine($"Nombre: {e.Nombre}, Edad: {e.Edad}, Promedio: {e.Promedio}");
        }
    }
}
```

  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/python/python-original.svg" width="40"/>

```python
from dataclasses import dataclass

@dataclass
class Estudiante:
    nombre: str
    edad: int
    promedio: float

# Crear instancias
e1 = Estudiante("Ana", 20, 4.5)
e2 = Estudiante("Luis", 22, 3.8)
e3 = Estudiante("Marta", 19, 4.2)

# Guardar en una lista (arreglo en Python)
estudiantes = [e1, e2, e3]

# Recorrer la lista
for e in estudiantes:
    print(f"Nombre: {e.nombre}, Edad: {e.edad}, Promedio: {e.promedio}")

```

* **Modificación.**
Cambiar el promedio de un estudiante específico.

 <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" width="40"/>

```c#
using System;

public record Estudiante(string Nombre, int Edad, double Promedio);

class Program
{
    static void Main(string[] args)
    {
        var e1 = new Estudiante("Ana", 20, 4.5);
        var e2 = new Estudiante("Luis", 22, 3.8);
        var e3 = new Estudiante("Marta", 19, 4.2);

        Estudiante[] estudiantes = { e1, e2, e3 };

        // Modificar el promedio de Ana
        estudiantes[0] = estudiantes[0] with { Promedio = 5.0 };

        foreach (var e in estudiantes)
        {
            Console.WriteLine(e);
        }
    }
}
```
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/python/python-original.svg" width="40"/>


```python
from dataclasses import dataclass

@dataclass
class Estudiante:
    nombre: str
    edad: int
    promedio: float

e1 = Estudiante("Ana", 20, 4.5)
e2 = Estudiante("Luis", 22, 3.8)
e3 = Estudiante("Marta", 19, 4.2)

estudiantes = [e1, e2, e3]

# Modificar el promedio de Ana
estudiantes[0].promedio = 5.0

for e in estudiantes:
    print(e)
```

* **Comparativa.**
Documentar las diferencias de implementación en los lenguajes.

| Aspecto             | C# (record)                     | Python (dataclass)                            |
| ------------------- | ------------------------------- | --------------------------------------------- |
| Definición          | `public record Estudiante(...)` | `@dataclass class Estudiante:`                |
| Tipado              | Fuerte (tipos obligatorios)     | Dinámico (tipos opcionales pero recomendados) |
| Creación de objetos | `new Estudiante(...)`           | `Estudiante(...)`                             |
| Estructura de datos | Arreglo (`Estudiante[]`)        | Lista (`[]`)                                  |
| Tamaño de colección | Fijo                            | Dinámico                                      |
| Recorrido           | `foreach`                       | `for`                                         |
| Acceso a datos      | `e.Nombre`                      | `e.nombre`                                    |
| Mutabilidad         | Inmutable (por defecto)       | Mutable                                     |
| Modificación        | `with { Propiedad = valor }`    | Asignación directa                            |
| Sintaxis general    | Más estricta                    | Más simple y flexible                         |


En C#, los record están diseñados para ser estructuras de datos inmutables, lo que significa que una vez creados, sus valores no deben cambiar. Por ello, cualquier modificación se realiza mediante la creación de una nueva instancia basada en la original, utilizando la expresión with.

Por otro lado, en Python, las clases (incluyendo dataclass) son mutables por defecto, permitiendo modificar directamente los atributos de un objeto sin necesidad de crear una copia.

## Objetos (Clases e instancias)
### Actividades:
* **Declaración.**
Definir una clase Estudiante con: nombre, edad, promedio y un método mostrarInfo.

 <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" width="40"/>

```c#
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
```
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/python/python-original.svg" width="40"/>


```python
class Estudiante:
    def __init__(self, nombre, edad, promedio):
        self.nombre = nombre
        self.edad = edad
        self.promedio = promedio

    def mostrarInfo(self):
        print(f"Nombre: {self.nombre}, Edad: {self.edad}, Promedio: {self.promedio}")

    def setPromedio(self, nuevoPromedio):
        self.promedio = nuevoPromedio
```

* **Inicialización.**
Crear 3 instancias y almacenarlas en un arreglo/lista.

 <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" width="40"/>

```c#
var e1 = new Estudiante("Ana", 20, 4.5);
var e2 = new Estudiante("Luis", 22, 3.8);
var e3 = new Estudiante("Marta", 19, 4.2);

Estudiante[] estudiantes = { e1, e2, e3 };
```
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/python/python-original.svg" width="40"/>


```python
e1 = Estudiante("Ana", 20, 4.5)
e2 = Estudiante("Luis", 22, 3.8)
e3 = Estudiante("Marta", 19, 4.2)
```
* **Recorrido.**
Llamar al método mostrarInfo para cada objeto.

 <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" width="40"/>

```c#
foreach (var e in estudiantes)
{
    e.MostrarInfo();
}
```
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/python/python-original.svg" width="40"/>


```python
for e in estudiantes:
    e.mostrarInfo()
```

* **Modificación.**
Cambiar el promedio de un estudiante mediante un método setPromedio.

 <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" width="40"/>

```c#
estudiantes[0].SetPromedio(5.0);
```
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/python/python-original.svg" width="40"/>


```python
estudiantes[0].setPromedio(5.0)
```
* **Comparativa.**
Explicar la diferencia entre esta clase y un struct o record.

La diferencia entre una clase y un struct o record se basa principalmente en el propósito y la forma en que manejan los datos. En C#, una clase es un tipo de referencia que no solo almacena información, sino que también permite definir comportamientos a través de métodos. Esto la hace ideal para representar objetos más complejos dentro de un sistema, donde además de datos se necesita lógica, como ocurre con entidades como clientes, ventas o vehículos.

En cambio, un struct en C# es un tipo de valor que se utiliza para almacenar datos simples y ligeros. Su enfoque es más básico, ya que generalmente no se usa para modelar comportamientos complejos. Por otro lado, un record está pensado para representar datos de forma más segura e inmutable, facilitando la comparación entre objetos por su contenido. Es una opción moderna para manejar información estructurada sin necesidad de mucha lógica interna.

En Python, la diferencia es un poco más flexible. Una clase puede cumplir tanto el rol de un objeto complejo como el de una estructura de datos simple, dependiendo de cómo se utilice. Sin embargo, cuando se quiere algo similar a un record de C#, se emplean las dataclass, que permiten definir estructuras de datos de manera más clara y automática. Aun así, estas siguen siendo clases, pero con menos necesidad de escribir código repetitivo.

En resumen, las clases se utilizan cuando se necesita combinar datos y comportamiento, mientras que los struct y record (o dataclass en Python) se enfocan más en organizar y representar datos. La elección entre uno u otro depende del nivel de complejidad y del tipo de problema que se esté resolviendo.

## Diferencias entre Struct/Record y Objetos
* Actividad teórico-práctica:
Los estudiantes crearán una tabla comparativa con:
    - Definición
    - Mutabilidad
    - Tipado
    - Uso en memoria (stack/heap)
    - Ejemplo en un lenguaje estático y uno dinámico



| Aspecto                     | Struct / Record                                                            | Objetos (Clases)                                                        |
| --------------------------- | -------------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| Definición                  | Estructuras diseñadas principalmente para **almacenar datos** relacionados | Entidades que combinan **datos (atributos) y comportamiento (métodos)** |
| Mutabilidad                 | `struct`: mutable / `record`: inmutable por defecto                        | Generalmente **mutables**                                               |
| Tipado                      | Tipado **fuerte y explícito** (especialmente en C#)                        | C#: tipado fuerte / Python: tipado dinámico                             |
| Uso en memoria (stack/heap) | `struct`: stack (valor) / `record`: heap (referencia)                      | Generalmente en el **heap** (referencia)                                |
| Ejemplo (lenguaje estático) | **C# (record):**<br>`public record Est(string Nombre, int Edad);`          | **C# (class):**<br>`public class Est { public string Nombre; }`         |
| Ejemplo (lenguaje dinámico) | **Python (dataclass):**<br>`@dataclass class Est: nombre:str`              | **Python (class):**<br>`class Est: def __init__(self,n): self.n=n`      |


* Implementar el mismo problema con un struct/record y con un objeto para analizar ventajas y desventajas.

 <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" width="40"/>

Usando record (estructura de datos)

```c#
public record Estudiante(string Nombre, int Edad, double Promedio);

var e1 = new Estudiante("Ana", 20, 4.5);
var e2 = new Estudiante("Luis", 22, 3.8);

// Mostrar datos
Console.WriteLine(e1);

// Modificar (crear nueva instancia)
e2 = e2 with { Promedio = 4.0 };

```

 <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" width="40"/>

Usando class (objeto)


```c#
public class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public double Promedio { get; set; }

    public void Mostrar()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Promedio: {Promedio}");
    }
}

var e1 = new Estudiante { Nombre = "Ana", Edad = 20, Promedio = 4.5 };
var e2 = new Estudiante { Nombre = "Luis", Edad = 22, Promedio = 3.8 };

// Mostrar
e1.Mostrar();

// Modificar directamente
e2.Promedio = 4.0;
```

  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/python/python-original.svg" width="40"/>

Usando dataclass (equivalente a record)

```python
from dataclasses import dataclass

@dataclass
class Estudiante:
    nombre: str
    edad: int
    promedio: float

e1 = Estudiante("Ana", 20, 4.5)
e2 = Estudiante("Luis", 22, 3.8)

print(e1)

# Modificación directa (mutable)
e2.promedio = 4.0
```
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/python/python-original.svg" width="40"/>

Usando class (objeto)

```python
class Estudiante:
    def __init__(self, nombre, edad, promedio):
        self.nombre = nombre
        self.edad = edad
        self.promedio = promedio

    def mostrar(self):
        print(f"Nombre: {self.nombre}, Edad: {self.edad}, Promedio: {self.promedio}")

e1 = Estudiante("Ana", 20, 4.5)
e2 = Estudiante("Luis", 22, 3.8)

e1.mostrar()

# Modificación
e2.promedio = 4.0
```
Ventajas y Desventajas:

Cuando se utiliza un record en C# o una dataclass en Python, el enfoque está completamente orientado a manejar datos de forma simple y organizada. Este tipo de estructuras reduce la cantidad de código necesario, ya que automáticamente gestionan aspectos como la inicialización y la representación de los datos. Además, en el caso de C#, los record ofrecen inmutabilidad por defecto, lo que ayuda a evitar errores al modificar información accidentalmente. Sin embargo, su principal limitación es que no están pensados para incluir lógica compleja o comportamientos avanzados.

Por otro lado, las clases (objetos) ofrecen mucha más flexibilidad, ya que permiten combinar datos con métodos. Esto las hace ideales para modelar entidades más completas dentro de un sistema, donde no solo importa la información, sino también las acciones que se pueden realizar con ella. La desventaja es que requieren más código y una estructura más detallada, lo que puede hacer el desarrollo un poco más lento en comparación con record o dataclass.

En términos generales, los record en C# y las dataclass en Python son más adecuados cuando se necesita representar datos de forma clara y sencilla, mientras que las clases son la mejor opción cuando el problema requiere lógica, validaciones o comportamientos adicionales. La elección entre uno y otro depende del nivel de complejidad del sistema y del rol que cumpla la entidad dentro del programa.


## ACTIVIDAD PRÁCTICA: Mini-proyecto integrador:
Modificar el ejercicio asignado en la actividad Protocolo Individual Unidad 1 (ver lista de asignación de ejercicios) y aplicar los conceptos de Objetos, Struct y Récord como elementos (items) guardados en los arreglos o matrices. (Java) opcional y mejor calificación si lo hace en otro de los lenguajes indicados en esta actividad.

Implementar la solución en dos lenguajes distintos para comparar diferencias sintácticas y de paradigma.

 <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" width="40"/>

 ```c#
 using System;

// =========================
// RECORD (Contraseña)
// =========================
public record Password(string Valor, bool EsValida);

// =========================
// STRUCT (Configuración)
// =========================
public struct Configuracion
{
    public int Longitud;
}

// =========================
// CLASE (Usuario)
// =========================
public class Usuario
{
    public string Nombre { get; set; } = "";
    public Password[,] HistorialPasswords { get; set; } = new Password[0, 0];
}

// =========================
// GENERADOR DE CONTRASEÑAS
// =========================
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
// PROGRAMA PRINCIPAL
// =========================
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== MINI PROYECTO: USUARIOS Y CONTRASEÑAS ===");

        Configuracion config = new Configuracion { Longitud = 10 };

        Usuario[] usuarios = new Usuario[2];

        // Creación de usuarios y generación de contraseñas
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

        // Mostrar información
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
```
Este código implementa un mini-proyecto en C# donde se generan y validan contraseñas para varios usuarios. Se utilizan diferentes estructuras de datos: un record para representar contraseñas de forma inmutable, un struct para definir la configuración (longitud de la contraseña) y una class para modelar a los usuarios.

El programa crea un arreglo de usuarios, donde cada uno contiene una matriz bidimensional de contraseñas. Estas contraseñas se generan automáticamente y se validan para asegurar que cumplan con ciertos criterios (mayúsculas, minúsculas, números y símbolos). Finalmente, se recorre la estructura completa para mostrar la información en consola, evidenciando el uso de arreglos y matrices anidadas.

  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/python/python-original.svg" width="40"/>

```python
import random
import string

# =========================
# RECORD (equivalente en Python)
# =========================
from dataclasses import dataclass

@dataclass(frozen=True)
class Password:
    valor: str
    es_valida: bool


# =========================
# STRUCT (equivalente)
# =========================
@dataclass
class Configuracion:
    longitud: int


# =========================
# CLASE (Usuario)
# =========================
class Usuario:
    def __init__(self, nombre):
        self.nombre = nombre
        self.historial_passwords = [[None for _ in range(2)] for _ in range(2)]


# =========================
# GENERADOR DE CONTRASEÑAS
# =========================
class Generador:
    @staticmethod
    def generar(longitud):
        caracteres = string.ascii_letters + string.digits + "!@#$%^&*()"
        return ''.join(random.choice(caracteres) for _ in range(longitud))

    @staticmethod
    def validar(password):
        mayus = any(c.isupper() for c in password)
        minus = any(c.islower() for c in password)
        num = any(c.isdigit() for c in password)
        simb = any(not c.isalnum() for c in password)

        return mayus and minus and num and simb


# =========================
# PROGRAMA PRINCIPAL
# =========================
def main():
    print("=== MINI PROYECTO: USUARIOS Y CONTRASEÑAS ===")

    config = Configuracion(longitud=10)

    usuarios = [Usuario(f"Usuario {i+1}") for i in range(2)]

    # Generación de contraseñas
    for usuario in usuarios:
        for i in range(2):
            for j in range(2):
                while True:
                    password = Generador.generar(config.longitud)
                    if Generador.validar(password):
                        usuario.historial_passwords[i][j] = Password(password, True)
                        break

    # Mostrar información
    for usuario in usuarios:
        print(f"\nUsuario: {usuario.nombre}")
        for fila in usuario.historial_passwords:
            for p in fila:
                print(f"Password: {p.valor} | Válida: {p.es_valida}")


# Ejecutar programa
if __name__ == "__main__":
    main()

```
La versión en Python mantiene la misma lógica del programa en C#, pero adaptada a un lenguaje dinámico. Se utilizan dataclasses para simular el comportamiento de record y struct, mientras que las listas permiten representar arreglos y matrices de forma flexible.