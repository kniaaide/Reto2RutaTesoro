namespace Reto2RutaTesoro
{
    /// <summary>
    /// Lista simplemente enlazada construida desde cero.
    /// Solo usa referencias entre objetos Nodo (sin List, arreglos, etc.).
    /// Toda la lógica de la estructura vive aquí.
    ///
    ///   Cabeza → [Nodo 1] → [Nodo 2] → [Nodo 3] → null
    /// </summary>
    public class ListaSimple
    {
        /// <summary>Primer nodo de la lista (null si está vacía).</summary>
        public Nodo? Cabeza { get; private set; }

        /// <summary>Cantidad de nodos actuales.</summary>
        public int Cantidad { get; private set; }

        public ListaSimple()
        {
            Cabeza = null;
            Cantidad = 0;
        }

        public bool EstaVacia() => Cabeza == null;

        /// <summary>
        /// Inserta un nodo al final de la lista.
        /// Devuelve false si el ID ya existe o si el nodo es inválido.
        /// </summary>
        public bool Insertar(Nodo nuevoNodo)
        {
            if (nuevoNodo == null) return false;
            if (nuevoNodo.NivelPeligro < 1 || nuevoNodo.NivelPeligro > 10) return false;
            if (Buscar(nuevoNodo.Id) != null) return false; // ID duplicado

            nuevoNodo.Siguiente = null;

            if (Cabeza == null)
            {
                // Lista vacía: el nuevo nodo es la cabeza.
                Cabeza = nuevoNodo;
            }
            else
            {
                // Recorrer hasta el último nodo.
                Nodo actual = Cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoNodo;
            }

            Cantidad++;
            return true;
        }

        /// <summary>Busca un nodo por ID. Devuelve null si no existe.</summary>
        public Nodo? Buscar(int id)
        {
            Nodo? actual = Cabeza;
            while (actual != null)
            {
                if (actual.Id == id) return actual;
                actual = actual.Siguiente;
            }
            return null;
        }

        /// <summary>
        /// Modifica los datos de un nodo existente (el ID no cambia).
        /// Devuelve false si no existe o si el peligro es inválido.
        /// </summary>
        public bool Modificar(int id, string nuevoNombre, string nuevaPista, int nuevoPeligro)
        {
            if (nuevoPeligro < 1 || nuevoPeligro > 10) return false;

            Nodo? nodo = Buscar(id);
            if (nodo == null) return false;

            nodo.Nombre = nuevoNombre;
            nodo.Pista = nuevaPista;
            nodo.NivelPeligro = nuevoPeligro;
            return true;
        }

        /// <summary>
        /// Elimina el nodo con el ID indicado, reenlazando los vecinos.
        /// Devuelve false si no existe.
        /// </summary>
        public bool Eliminar(int id)
        {
            if (Cabeza == null) return false; // Lista vacía

            // Caso 1: eliminar la cabeza.
            if (Cabeza.Id == id)
            {
                Cabeza = Cabeza.Siguiente;
                Cantidad--;
                return true;
            }

            // Caso 2: eliminar un nodo intermedio o el último.
            Nodo anterior = Cabeza;
            Nodo? actual = Cabeza.Siguiente;

            while (actual != null)
            {
                if (actual.Id == id)
                {
                    anterior.Siguiente = actual.Siguiente; // Saltar el nodo
                    actual.Siguiente = null;               // Desconectarlo
                    Cantidad--;
                    return true;
                }
                anterior = actual;
                actual = actual.Siguiente;
            }

            return false; // No se encontró
        }

        /// <summary>
        /// Recorre la lista de Cabeza a null ejecutando una acción por cada nodo.
        /// </summary>
        public void Recorrer(Action<Nodo> accion)
        {
            Nodo? actual = Cabeza;
            while (actual != null)
            {
                accion(actual);
                actual = actual.Siguiente;
            }
        }
    }
}
