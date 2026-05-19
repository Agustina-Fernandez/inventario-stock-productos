namespace ProductosYStock
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAtras = new Button();
            dgvProductos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // btnAtras
            // 
            btnAtras.BackColor = SystemColors.GrayText;
            btnAtras.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtras.ForeColor = SystemColors.ButtonHighlight;
            btnAtras.Location = new Point(1011, 506);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(101, 42);
            btnAtras.TabIndex = 0;
            btnAtras.Text = "Volver";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(407, 12);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(705, 476);
            dgvProductos.TabIndex = 1;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 72);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 2;
            label1.Text = "id_producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 143);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 3;
            label2.Text = "nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 210);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 4;
            label3.Text = "descripción:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 280);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 5;
            label4.Text = "precio:";
            // 
            // txtId
            // 
            txtId.Location = new Point(141, 69);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(141, 140);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(223, 27);
            txtNombre.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(141, 207);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(223, 27);
            txtDescripcion.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(141, 277);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 9;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.GradientActiveCaption;
            btnAgregar.Location = new Point(43, 375);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(119, 48);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.GradientActiveCaption;
            btnEditar.Location = new Point(231, 375);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(119, 48);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ControlText;
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(43, 464);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 48);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 560);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvProductos);
            Controls.Add(btnAtras);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtras;
        private DataGridView dgvProductos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
    }
}