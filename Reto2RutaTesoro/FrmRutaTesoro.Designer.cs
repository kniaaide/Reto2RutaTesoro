namespace Reto2RutaTesoro
{
    partial class FrmRutaTesoro
    {
        private System.ComponentModel.IContainer? components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            grpDatos = new GroupBox();
            lblId = new Label();
            nudId = new NumericUpDown();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblPista = new Label();
            txtPista = new TextBox();
            lblPeligro = new Label();
            nudPeligro = new NumericUpDown();
            btnAgregar = new Button();
            btnBuscar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvRuta = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colUbicacion = new DataGridViewTextBoxColumn();
            colPista = new DataGridViewTextBoxColumn();
            colPeligro = new DataGridViewTextBoxColumn();
            lblEstado = new Label();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPeligro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRuta).BeginInit();
            SuspendLayout();
            //
            // grpDatos
            //
            grpDatos.Controls.Add(lblId);
            grpDatos.Controls.Add(nudId);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(lblPista);
            grpDatos.Controls.Add(txtPista);
            grpDatos.Controls.Add(lblPeligro);
            grpDatos.Controls.Add(nudPeligro);
            grpDatos.Controls.Add(btnAgregar);
            grpDatos.Controls.Add(btnBuscar);
            grpDatos.Controls.Add(btnModificar);
            grpDatos.Controls.Add(btnEliminar);
            grpDatos.Controls.Add(btnLimpiar);
            grpDatos.Location = new Point(12, 12);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(860, 190);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos de la ubicación";
            //
            // lblId
            //
            lblId.AutoSize = true;
            lblId.Location = new Point(20, 34);
            lblId.Name = "lblId";
            lblId.Text = "ID de ubicación:";
            //
            // nudId
            //
            nudId.Location = new Point(150, 30);
            nudId.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudId.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudId.Name = "nudId";
            nudId.Size = new Size(120, 27);
            nudId.TabIndex = 0;
            nudId.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // lblNombre
            //
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(300, 34);
            lblNombre.Name = "lblNombre";
            lblNombre.Text = "Nombre:";
            //
            // txtNombre
            //
            txtNombre.Location = new Point(370, 30);
            txtNombre.MaxLength = 60;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(260, 27);
            txtNombre.TabIndex = 1;
            //
            // lblPista
            //
            lblPista.AutoSize = true;
            lblPista.Location = new Point(20, 78);
            lblPista.Name = "lblPista";
            lblPista.Text = "Pista:";
            //
            // txtPista
            //
            txtPista.Location = new Point(150, 74);
            txtPista.MaxLength = 200;
            txtPista.Name = "txtPista";
            txtPista.Size = new Size(480, 27);
            txtPista.TabIndex = 2;
            //
            // lblPeligro
            //
            lblPeligro.AutoSize = true;
            lblPeligro.Location = new Point(660, 34);
            lblPeligro.Name = "lblPeligro";
            lblPeligro.Text = "Peligro (1-10):";
            //
            // nudPeligro
            //
            nudPeligro.Location = new Point(760, 30);
            nudPeligro.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudPeligro.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPeligro.Name = "nudPeligro";
            nudPeligro.Size = new Size(70, 27);
            nudPeligro.TabIndex = 3;
            nudPeligro.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // btnAgregar
            //
            btnAgregar.Location = new Point(20, 130);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 40);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            //
            // btnBuscar
            //
            btnBuscar.Location = new Point(180, 130);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(150, 40);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            //
            // btnModificar
            //
            btnModificar.Location = new Point(340, 130);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 40);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            //
            // btnEliminar
            //
            btnEliminar.Location = new Point(500, 130);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 40);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            //
            // btnLimpiar
            //
            btnLimpiar.Location = new Point(660, 130);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(170, 40);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar campos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            //
            // dgvRuta  (solo visualización)
            //
            dgvRuta.AllowUserToAddRows = false;
            dgvRuta.AllowUserToDeleteRows = false;
            dgvRuta.AllowUserToResizeRows = false;
            dgvRuta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRuta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRuta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRuta.Columns.AddRange(new DataGridViewColumn[] { colId, colUbicacion, colPista, colPeligro });
            dgvRuta.Location = new Point(12, 212);
            dgvRuta.MultiSelect = false;
            dgvRuta.Name = "dgvRuta";
            dgvRuta.ReadOnly = true;
            dgvRuta.RowHeadersVisible = false;
            dgvRuta.RowTemplate.Height = 29;
            dgvRuta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRuta.Size = new Size(860, 280);
            dgvRuta.TabIndex = 1;
            dgvRuta.CellClick += dgvRuta_CellClick;
            //
            // columnas
            //
            colId.FillWeight = 10F;
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colUbicacion.FillWeight = 30F;
            colUbicacion.HeaderText = "Ubicación";
            colUbicacion.Name = "colUbicacion";
            colUbicacion.ReadOnly = true;
            colPista.FillWeight = 50F;
            colPista.HeaderText = "Pista";
            colPista.Name = "colPista";
            colPista.ReadOnly = true;
            colPeligro.FillWeight = 10F;
            colPeligro.HeaderText = "Peligro";
            colPeligro.Name = "colPeligro";
            colPeligro.ReadOnly = true;
            //
            // lblEstado
            //
            lblEstado.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEstado.Location = new Point(12, 500);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(860, 28);
            lblEstado.Text = "Nodos en la ruta: 0";
            //
            // FrmRutaTesoro
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 541);
            Controls.Add(grpDatos);
            Controls.Add(dgvRuta);
            Controls.Add(lblEstado);
            MinimumSize = new Size(900, 580);
            Name = "FrmRutaTesoro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reto 2 - La Ruta del Tesoro Perdido";
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudId).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPeligro).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRuta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private Label lblId;
        private NumericUpDown nudId;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblPista;
        private TextBox txtPista;
        private Label lblPeligro;
        private NumericUpDown nudPeligro;
        private Button btnAgregar;
        private Button btnBuscar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvRuta;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colUbicacion;
        private DataGridViewTextBoxColumn colPista;
        private DataGridViewTextBoxColumn colPeligro;
        private Label lblEstado;
    }
}
