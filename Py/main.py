from dataclasses import dataclass

# =========================
# PUNTO 3: RECORD (dataclass)
# =========================
@dataclass
class EstudianteRecord:
    nombre: str
    edad: int
    promedio: float


def ejecutar_punto3():
    print("=== PUNTO 3: RECORD (dataclass) ===")

    e1 = EstudianteRecord("Ana", 20, 4.5)
    e2 = EstudianteRecord("Luis", 22, 3.8)
    e3 = EstudianteRecord("Marta", 19, 4.2)

    estudiantes = [e1, e2, e3]

    print("Lista original:")
    for e in estudiantes:
        print(e)

    # Modificación directa (mutable)
    estudiantes[0].promedio = 5.0

    print("\nLista modificada:")
    for e in estudiantes:
        print(e)


# =========================
# PUNTO 4: CLASE
# =========================
class Estudiante:
    def __init__(self, nombre, edad, promedio):
        self.nombre = nombre
        self.edad = edad
        self.promedio = promedio

    def mostrarInfo(self):
        print(f"Nombre: {self.nombre}, Edad: {self.edad}, Promedio: {self.promedio}")

    def setPromedio(self, nuevoPromedio):
        self.promedio = nuevoPromedio


def ejecutar_punto4():
    print("\n=== PUNTO 4: OBJETOS (CLASES) ===")

    e1 = Estudiante("Ana", 20, 4.5)
    e2 = Estudiante("Luis", 22, 3.8)
    e3 = Estudiante("Marta", 19, 4.2)

    estudiantes = [e1, e2, e3]

    print("Lista original:")
    for e in estudiantes:
        e.mostrarInfo()

    estudiantes[0].setPromedio(5.0)

    print("\nLista modificada:")
    for e in estudiantes:
        e.mostrarInfo()


# =========================
# EJECUCIÓN
# =========================
ejecutar_punto3()
ejecutar_punto4()