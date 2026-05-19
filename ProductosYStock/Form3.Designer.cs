namespace ProductosYStock
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            btnVolver = new Button();
            dgvStock = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtCantidad = new TextBox();
            txtFecha = new TextBox();
            btnActualizar = new Button();
            label3 = new Label();
            label4 = new Label();
            txtStock = new TextBox();
            txtProducto = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnSumar = new Button();
            btnQuitar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.GrayText;
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.ControlLightLight;
            btnVolver.Location = new Point(1011, 506);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(101, 42);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // dgvStock
            // 
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new Point(407, 12);
            dgvStock.Name = "dgvStock";
            dgvStock.ReadOnly = true;
            dgvStock.RowHeadersWidth = 51;
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStock.Size = new Size(705, 476);
            dgvStock.TabIndex = 1;
            dgvStock.CellClick += dgvStock_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 198);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 2;
            label1.Text = "cantidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 260);
            label2.Name = "label2";
            label2.Size = new Size(160, 20);
            label2.TabIndex = 3;
            label2.Text = "fecha de actualizacion:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(113, 198);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 4;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(203, 260);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(147, 27);
            txtFecha.TabIndex = 5;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.GradientActiveCaption;
            btnActualizar.Location = new Point(203, 370);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(113, 44);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 128);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 7;
            label3.Text = "id_producto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 63);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 8;
            label4.Text = "id_stock:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(108, 60);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 9;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(135, 128);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(125, 27);
            txtProducto.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnSumar
            // 
            btnSumar.BackColor = SystemColors.GradientActiveCaption;
            btnSumar.Location = new Point(37, 370);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(113, 44);
            btnSumar.TabIndex = 12;
            btnSumar.Text = "Añadir";
            btnSumar.UseVisualStyleBackColor = false;
            btnSumar.Click += btnSumar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.BackColor = SystemColors.ControlText;
            btnQuitar.ForeColor = SystemColors.ButtonHighlight;
            btnQuitar.Location = new Point(37, 460);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(113, 44);
            btnQuitar.TabIndex = 13;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = false;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 560);
            Controls.Add(btnQuitar);
            Controls.Add(btnSumar);
            Controls.Add(txtProducto);
            Controls.Add(txtStock);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnActualizar);
            Controls.Add(txtFecha);
            Controls.Add(txtCantidad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvStock);
            Controls.Add(btnVolver);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private DataGridView dgvStock;
        private Label label1;
        private Label label2;
        private TextBox txtCantidad;
        private TextBox txtFecha;
        private Button btnActualizar;
        private Label label3;
        private Label label4;
        private TextBox txtStock;
        private TextBox txtProducto;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnSumar;
        private Button btnQuitar;
    }
}