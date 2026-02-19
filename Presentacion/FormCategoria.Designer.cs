namespace Presentacion
{
    partial class FormCategoria
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
            lblId = new Label();
            lblNombre = new Label();
            lblDescripcion = new Label();
            txtNombre = new TextBox();
            textBox2 = new TextBox();
            txtDescripcion = new TextBox();
            lblTitulo = new Label();
            btnAgregarCategoria = new Button();
            dgvCategorias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(75, 128);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            lblId.Click += label1_Click_1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(41, 169);
            lblNombre.Name = "lblNombre";
            lblNombre.RightToLeft = RightToLeft.Yes;
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            lblNombre.Click += lblNombre_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(23, 218);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripcion";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(98, 120);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(147, 23);
            txtNombre.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(98, 161);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(147, 23);
            textBox2.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(98, 210);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(147, 23);
            txtDescripcion.TabIndex = 5;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.Location = new Point(12, 43);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(300, 50);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Registrat Categoria de Vehiculo";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Click += lblTitulo_Click;
            // 
            // btnAgregarCategoria
            // 
            btnAgregarCategoria.Location = new Point(133, 259);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(75, 23);
            btnAgregarCategoria.TabIndex = 7;
            btnAgregarCategoria.Text = "Registrar";
            btnAgregarCategoria.UseVisualStyleBackColor = true;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(311, 120);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.Size = new Size(441, 113);
            dgvCategorias.TabIndex = 8;
            // 
            // FormCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCategorias);
            Controls.Add(btnAgregarCategoria);
            Controls.Add(lblTitulo);
            Controls.Add(txtDescripcion);
            Controls.Add(textBox2);
            Controls.Add(txtNombre);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Name = "FormCategoria";
            Text = "FormCategoria";
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblNombre;
        private Label lblDescripcion;
        private TextBox txtNombre;
        private TextBox textBox2;
        private TextBox txtDescripcion;
        private Label lblTitulo;
        private Button btnAgregarCategoria;
        private DataGridView dgvCategorias;
    }
}