import random
import string
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

    estudiantes = [
        EstudianteRecord("Ana", 20, 4.5),
        EstudianteRecord("Luis", 22, 3.8),
        EstudianteRecord("Marta", 19, 4.2)
    ]

    print("Lista original:")
    for e in estudiantes:
        print(e)

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

    estudiantes = [
        Estudiante("Ana", 20, 4.5),
        Estudiante("Luis", 22, 3.8),
        Estudiante("Marta", 19, 4.2)
    ]

    print("Lista original:")
    for e in estudiantes:
        e.mostrarInfo()

    estudiantes[0].setPromedio(5.0)

    print("\nLista modificada:")
    for e in estudiantes:
        e.mostrarInfo()


# =========================
# MINI PROYECTO
# =========================
@dataclass(frozen=True)
class Password:
    valor: str
    es_valida: bool


@dataclass
class Configuracion:
    longitud: int


class Usuario:
    def __init__(self, nombre):
        self.nombre = nombre
        self.historial_passwords = [[None for _ in range(2)] for _ in range(2)]


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


def ejecutar_mini_proyecto():
    print("\n=== MINI PROYECTO ===")

    config = Configuracion(longitud=10)
    usuarios = [Usuario(f"Usuario {i+1}") for i in range(2)]

    for usuario in usuarios:
        for i in range(2):
            for j in range(2):
                while True:
                    password = Generador.generar(config.longitud)
                    if Generador.validar(password):
                        usuario.historial_passwords[i][j] = Password(password, True)
                        break

    for usuario in usuarios:
        print(f"\nUsuario: {usuario.nombre}")
        for fila in usuario.historial_passwords:
            for p in fila:
                print(f"Password: {p.valor} | Valida: {p.es_valida}")