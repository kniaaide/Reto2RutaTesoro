namespace Reto2RutaTesoro
{
    /// <summary>
    /// Representa una ubicación de la ruta del tesoro.
    /// Cada nodo guarda sus datos y una referencia al siguiente nodo.
    /// </summary>
    public class Nodo
    {
        /// <summary>ID único de la ubicación.</summary>
        public int Id { get; set; }

        /// <summary>Nombre del lugar.</summary>
        public string Nombre { get; set; }

        /// <summary>Pista que lleva al tesoro.</summary>
        public string Pista { get; set; }

        /// <summary>Nivel de peligro (1 a 10).</summary>
        public int NivelPeligro { get; set; }

        /// <summary>Referencia al siguiente nodo (null si es el último).</summary>
        public Nodo? Siguiente { get; set; }

        public Nodo(int id, string nombre, string pista, int nivelPeligro)
        {
            Id = id;
            Nombre = nombre;
            Pista = pista;
            NivelPeligro = nivelPeligro;
            Siguiente = null; // Un nodo nuevo todavía no apunta a nada.
        }
    }
}
