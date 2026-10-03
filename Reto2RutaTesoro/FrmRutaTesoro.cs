namespace Reto2RutaTesoro
{
    /// <summary>
    /// Formulario principal. Solo captura datos, delega en ListaSimple
    /// y refresca el DataGridView (que es únicamente visual).
    /// </summary>
    public partial class FrmRutaTesoro : Form
    {
        // La única fuente de verdad de los datos es la lista enlazada.
        private readonly ListaSimple _ruta = new ListaSimple();

        public FrmRutaTesoro()
        {
            InitializeComponent();
            ActualizarTabla();
        }

        // ───────────────────────── Eventos de botones ─────────────────────────

        private void btnAgregar_Click(object? sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            var nuevo = new Nodo(
                (int)nudId.Value,
                txtNombre.Text.Trim(),
                txtPista.Text.Trim(),
                (int)nudPeligro.Value);

            if (_ruta.Insertar(nuevo))
            {
                ActualizarTabla();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show($"Ya existe una ubicación con ID {nuevo.Id}.",
                    "ID duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscar_Click(object? sender, EventArgs e)
        {
            Nodo? encontrado = _ruta.Buscar((int)nudId.Value);

            if (encontrado == null)
            {
                MessageBox.Show("No se encontró ninguna ubicación con ese ID.",
                    "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MostrarNodoEnCampos(encontrado);
            SeleccionarFilaPorId(encontrado.Id);
        }

        private void btnModificar_Click(object? sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            bool ok = _ruta.Modificar(
                (int)nudId.Value,
                txtNombre.Text.Trim(),
                txtPista.Text.Trim(),
                (int)nudPeligro.Value);

            if (ok)
            {
                ActualizarTabla();
                MessageBox.Show("Ubicación modificada correctamente.",
                    "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No existe una ubicación con ese ID.",
                    "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object? sender, EventArgs e)
        {
            int id = (int)nudId.Value;

            if (_ruta.Buscar(id) == null)
            {
                MessageBox.Show("No existe una ubicación con ese ID.",
                    "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var respuesta = MessageBox.Show($"¿Eliminar la ubicación con ID {id}?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta != DialogResult.Yes) return;

            _ruta.Eliminar(id);
            ActualizarTabla();
            LimpiarCampos();
        }

        private void btnLimpiar_Click(object? sender, EventArgs e)
        {
            LimpiarCampos();
        }

        /// <summary>
        /// Al hacer clic en una fila, se pide el nodo a la lista (no se leen
        /// los datos de la celda como almacenamiento) y se muestra en los campos.
        /// </summary>
        private void dgvRuta_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvRuta.Rows[e.RowIndex].Cells[colId.Index].Value is int id)
            {
                Nodo? nodo = _ruta.Buscar(id);
                if (nodo != null) MostrarNodoEnCampos(nodo);
            }
        }

        // ───────────────────────── Métodos auxiliares ─────────────────────────

        /// <summary>
        /// Refresca el DataGridView recorriendo la lista desde Cabeza hasta null.
        /// </summary>
        private void ActualizarTabla()
        {
            dgvRuta.Rows.Clear();

            Nodo? actual = _ruta.Cabeza;
            while (actual != null)
            {
                dgvRuta.Rows.Add(actual.Id, actual.Nombre, actual.Pista, actual.NivelPeligro);
                actual = actual.Siguiente;
            }

            dgvRuta.ClearSelection();
            lblEstado.Text = $"Nodos en la ruta: {_ruta.Cantidad}";
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre de la ubicación es obligatorio.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPista.Text))
            {
                MessageBox.Show("La pista es obligatoria.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPista.Focus();
                return false;
            }

            return true;
        }

        private void MostrarNodoEnCampos(Nodo nodo)
        {
            nudId.Value = nodo.Id;
            txtNombre.Text = nodo.Nombre;
            txtPista.Text = nodo.Pista;
            nudPeligro.Value = nodo.NivelPeligro;
        }

        private void SeleccionarFilaPorId(int id)
        {
            foreach (DataGridViewRow fila in dgvRuta.Rows)
            {
                if (fila.Cells[colId.Index].Value is int valor && valor == id)
                {
                    fila.Selected = true;
                    dgvRuta.FirstDisplayedScrollingRowIndex = fila.Index;
                    break;
                }
            }
        }

        private void LimpiarCampos()
        {
            nudId.Value = nudId.Minimum;
            nudPeligro.Value = nudPeligro.Minimum;
            txtNombre.Clear();
            txtPista.Clear();
            dgvRuta.ClearSelection();
            nudId.Focus();
        }
    }
}
