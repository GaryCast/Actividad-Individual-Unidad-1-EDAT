from dataclasses import dataclass

@dataclass
class Estudiante:
    nombre: str
    edad: int
    promedio: float

# =========================
# 1. CREACIÓN DE INSTANCIAS
# =========================
e1 = Estudiante("Ana", 20, 4.5)
e2 = Estudiante("Luis", 22, 3.8)
e3 = Estudiante("Marta", 19, 4.2)

# =========================
# 2. ARREGLO (LISTA)
# =========================
estudiantes = [e1, e2, e3]

# =========================
# 3. RECORRIDO INICIAL
# =========================
print("=== LISTA ORIGINAL ===")
for e in estudiantes:
    print(f"Nombre: {e.nombre}, Edad: {e.edad}, Promedio: {e.promedio}")

# =========================
# 4. MODIFICACIÓN
# =========================
estudiantes[0].promedio = 5.0

# =========================
# 5. RECORRIDO DESPUÉS DE MODIFICAR
# =========================
print("\n=== LISTA MODIFICADA ===")
for e in estudiantes:
    print(f"Nombre: {e.nombre}, Edad: {e.edad}, Promedio: {e.promedio}")