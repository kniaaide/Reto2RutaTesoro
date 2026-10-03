# Reto 2 – La Ruta del Tesoro Perdido

Aplicación de escritorio en **C# / .NET 10 / Windows Forms** que simula la búsqueda de un tesoro usando una **lista simplemente enlazada construida desde cero**. Cada ubicación del mapa es un nodo que apunta a la siguiente ubicación de la ruta.

```
Cabeza
  ↓
[Nodo 1] → [Nodo 2] → [Nodo 3] → [Nodo 4] → null
```

## Cómo ejecutarlo

1. Abre **`Reto2RutaTesoro.sln`** con Visual Studio 2026.
2. Pulsa el botón verde **▶ Iniciar** (o **F5**).

Requiere la carga de trabajo *Desarrollo de escritorio con .NET*.

## Estructura del proyecto

```
Reto2RutaTesoro/
├── Reto2RutaTesoro.sln
├── README.md
└── Reto2RutaTesoro/
    ├── Reto2RutaTesoro.csproj
    ├── Nodo.cs
    ├── ListaSimple.cs
    ├── FrmRutaTesoro.cs
    ├── FrmRutaTesoro.Designer.cs
    └── Program.cs
```

| Archivo | Responsabilidad |
|---|---|
| `Nodo.cs` | Representa una ubicación: `Id`, `Nombre`, `Pista`, `NivelPeligro` y la referencia `Siguiente`. |
| `ListaSimple.cs` | Contiene **toda** la lógica de la lista enlazada (insertar, buscar, modificar, eliminar, recorrer). |
| `FrmRutaTesoro.cs` | Interacción con el usuario: lee los controles, llama a `ListaSimple` y refresca la tabla. |
| `FrmRutaTesoro.Designer.cs` | Diseño de la interfaz (controles de WinForms). |
| `Program.cs` | Punto de entrada de la aplicación. |

## Restricción principal

No se usa `List<T>`, `LinkedList<T>`, `Queue<T>`, `Stack<T>`, `Dictionary<TKey,TValue>` ni arreglos para guardar datos. Los datos viven únicamente en los objetos `Nodo` enlazados por `Siguiente`. El `DataGridView` es **solo visual**.

## La interfaz

- **ID de ubicación** (`NumericUpDown`)
- **Nombre** y **Pista** (`TextBox`)
- **Nivel de peligro 1–10** (`NumericUpDown`)
- Botones: **Agregar**, **Buscar**, **Modificar**, **Eliminar** y **Limpiar campos**
- **Tabla** con las columnas ID, Ubicación, Pista y Peligro
- Una etiqueta inferior con la cantidad de nodos en la ruta

## Operaciones de la lista (`ListaSimple`)

| Método | Qué hace |
|---|---|
| `Insertar(Nodo)` | Agrega un nodo **al final**. Devuelve `false` si el ID ya existe o el peligro no está entre 1 y 10. |
| `Buscar(int id)` | Recorre la lista y devuelve el nodo con ese ID, o `null` si no existe. |
| `Modificar(id, nombre, pista, peligro)` | Cambia los datos del nodo (el ID no cambia). Devuelve `false` si no existe. |
| `Eliminar(int id)` | Quita el nodo reenlazando sus vecinos. Maneja lista vacía, eliminación de la cabeza y de un nodo intermedio o final. |
| `Recorrer(Action<Nodo>)` | Recorre de `Cabeza` a `null` ejecutando una acción por nodo. |
| `EstaVacia()` | Indica si la lista no tiene nodos. |

Propiedades: `Cabeza` (primer nodo, solo lectura desde fuera) y `Cantidad`.

### Cómo funciona eliminar

```
Antes:   Cabeza → [1] → [2] → [3] → null
Eliminar(2):
Después: Cabeza → [1] ───────→ [3] → null
```

El nodo anterior pasa a apuntar al siguiente del nodo eliminado, y este último se desconecta.

## Flujo de una acción

```
Clic en botón
      ↓
El formulario lee los controles y valida
      ↓
Llama a ListaSimple (Insertar / Buscar / Modificar / Eliminar)
      ↓
ListaSimple manipula los nodos
      ↓
ActualizarTabla(): limpia el DataGridView y lo llena
recorriendo desde Cabeza hasta null
```

La lógica de la lista **nunca** se programa dentro de los eventos de los botones.

## Validaciones

- El nombre y la pista son obligatorios.
- No se permiten IDs repetidos.
- El peligro debe estar entre 1 y 10 (se valida en el control y en la lista).
- Eliminar pide confirmación.

## Uso rápido

1. Escribe ID, nombre, pista y peligro, y pulsa **Agregar**.
2. Haz clic en una fila de la tabla para cargar sus datos en los campos.
3. Cambia los datos y pulsa **Modificar**.
4. Pon un ID y pulsa **Buscar** para localizar y resaltar una ubicación.
5. Pulsa **Eliminar** para quitar la ubicación del ID indicado.
