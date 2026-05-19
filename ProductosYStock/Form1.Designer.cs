namespace ProductosYStock
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btnProductos = new Button();
            btnStock = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(271, 55);
            label1.Name = "label1";
            label1.Size = new Size(269, 49);
            label1.TabIndex = 0;
            label1.Text = "¡Bienvenido/a!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(203, 150);
            label2.Name = "label2";
            label2.Size = new Size(406, 41);
            label2.TabIndex = 1;
            label2.Text = "¿Sobre que quiere trabajar?";
            // 
            // btnProductos
            // 
            btnProductos.BackColor = SystemColors.ActiveCaption;
            btnProductos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = SystemColors.ActiveCaptionText;
            btnProductos.Location = new Point(203, 259);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(132, 48);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnStock
            // 
            btnStock.BackColor = SystemColors.ActiveCaption;
            btnStock.Location = new Point(477, 259);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(132, 48);
            btnStock.TabIndex = 3;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ActiveBorder;
            btnSalir.Location = new Point(337, 380);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(132, 48);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnStock);
            Controls.Add(btnProductos);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnProductos;
        private Button btnStock;
        private Button btnSalir;
    }
}
