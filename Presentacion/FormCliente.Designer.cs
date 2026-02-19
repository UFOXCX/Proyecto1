namespace Presentacion
{
    partial class FormCliente
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
            dgvCategorias = new DataGridView();
            btnAgregarCategoria = new Button();
            lblTitulo = new Label();
            txtNombre = new TextBox();
            txtIdentificacion = new TextBox();
            txtId = new TextBox();
            txtFechaNacimiento = new TextBox();
            txtFechaRegistro = new TextBox();
            lblId = new Label();
            lblIdentificacion = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            chkActivo = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(328, 118);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.Size = new Size(441, 113);
            dgvCategorias.TabIndex = 14;
            // 
            // btnAgregarCategoria
            // 
            btnAgregarCategoria.Location = new Point(182, 270);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(75, 23);
            btnAgregarCategoria.TabIndex = 13;
            btnAgregarCategoria.Text = "Registrar";
            btnAgregarCategoria.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.Location = new Point(74, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(300, 50);
            lblTitulo.TabIndex = 12;
            lblTitulo.Text = "Registrar Cliente";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(153, 139);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(147, 23);
            txtNombre.TabIndex = 11;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(153, 110);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(147, 23);
            txtIdentificacion.TabIndex = 10;
            // 
            // txtId
            // 
            txtId.Location = new Point(153, 81);
            txtId.Name = "txtId";
            txtId.Size = new Size(147, 23);
            txtId.TabIndex = 9;
            txtId.TextChanged += txtNombre_TextChanged;
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Location = new Point(153, 168);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(147, 23);
            txtFechaNacimiento.TabIndex = 15;
            // 
            // txtFechaRegistro
            // 
            txtFechaRegistro.Location = new Point(153, 197);
            txtFechaRegistro.Name = "txtFechaRegistro";
            txtFechaRegistro.Size = new Size(147, 23);
            txtFechaRegistro.TabIndex = 16;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(130, 89);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 17;
            lblId.Text = "Id";
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Location = new Point(68, 118);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(79, 15);
            lblIdentificacion.TabIndex = 18;
            lblIdentificacion.Text = "Identificacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 147);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 19;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 176);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 20;
            label3.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 205);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 21;
            label4.Text = "Fecha de Registro";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(173, 226);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(100, 19);
            chkActivo.TabIndex = 22;
            chkActivo.Text = "Cliente Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkActivo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblIdentificacion);
            Controls.Add(lblId);
            Controls.Add(txtFechaRegistro);
            Controls.Add(txtFechaNacimiento);
            Controls.Add(dgvCategorias);
            Controls.Add(btnAgregarCategoria);
            Controls.Add(lblTitulo);
            Controls.Add(txtNombre);
            Controls.Add(txtIdentificacion);
            Controls.Add(txtId);
            Name = "FormCliente";
            Text = "FormCliente";
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategorias;
        private Button btnAgregarCategoria;
        private Label lblTitulo;
        private TextBox txtNombre;
        private TextBox txtIdentificacion;
        private TextBox txtId;
        private TextBox txtFechaNacimiento;
        private TextBox txtFechaRegistro;
        private Label lblId;
        private Label lblIdentificacion;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox chkActivo;
    }
}