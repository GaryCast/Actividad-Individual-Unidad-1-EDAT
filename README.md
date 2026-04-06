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
```c#
public record Estudiante(string Nombre, int Edad, double Promedio);
```

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
* Declaración
Definir una clase Estudiante con: nombre, edad, promedio y un método mostrarInfo.


* Inicialización
Crear 3 instancias y almacenarlas en un arreglo/lista.


* Recorrido
Llamar al método mostrarInfo para cada objeto.


* Modificación
Cambiar el promedio de un estudiante mediante un método setPromedio.


* Comparativa
Explicar la diferencia entre esta clase y un struct o record.



## Diferencias entre Struct/Record y Objetos
* Actividad teórico-práctica:
Los estudiantes crearán una tabla comparativa con:
    - Definición
    - Mutabilidad
    - Tipado
    - Uso en memoria (stack/heap)
    - Ejemplo en un lenguaje estático y uno dinámico

* Implementar el mismo problema con un struct/record y con un objeto para analizar ventajas y desventajas.


## Mini-proyecto integrador:
Usar un arreglo de objetos que contengan un campo que sea a su vez una matriz.

Implementar la solución en dos lenguajes distintos para comparar diferencias sintácticas y de paradigma.


## ACTIVIDAD PRÁCTICA:
Modificar el ejercicio asignado en la actividad Protocolo Individual Unidad 1 (ver lista de asignación de ejercicios) y aplicar los conceptos de Objetos, Struct y Récord como elementos (items) guardados en los arreglos o matrices. (Java) opcional y mejor calificación si lo hace en otro de los lenguajes indicados en esta actividad.
