namespace pryPonssaVERDULEROS
{
    partial class FrmRegistro
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
            this.lblNombreVend = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxtKilos = new System.Windows.Forms.MaskedTextBox();
            this.lstNombreProd = new System.Windows.Forms.ComboBox();
            this.lstNombreVend = new System.Windows.Forms.ComboBox();
            this.lblKilos = new System.Windows.Forms.Label();
            this.lblNombreProd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreVend
            // 
            this.lblNombreVend.AutoSize = true;
            this.lblNombreVend.Location = new System.Drawing.Point(19, 32);
            this.lblNombreVend.Name = "lblNombreVend";
            this.lblNombreVend.Size = new System.Drawing.Size(93, 13);
            this.lblNombreVend.TabIndex = 0;
            this.lblNombreVend.Text = "Nombre Vendedor";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(296, 143);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(94, 41);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.mtxtKilos);
            this.groupBox1.Controls.Add(this.lstNombreProd);
            this.groupBox1.Controls.Add(this.lstNombreVend);
            this.groupBox1.Controls.Add(this.lblKilos);
            this.groupBox1.Controls.Add(this.lblNombreProd);
            this.groupBox1.Controls.Add(this.lblNombreVend);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 176);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // mtxtKilos
            // 
            this.mtxtKilos.Location = new System.Drawing.Point(118, 143);
            this.mtxtKilos.Mask = "99999";
            this.mtxtKilos.Name = "mtxtKilos";
            this.mtxtKilos.Size = new System.Drawing.Size(45, 20);
            this.mtxtKilos.TabIndex = 8;
            this.mtxtKilos.ValidatingType = typeof(int);
            this.mtxtKilos.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            this.mtxtKilos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox1_KeyPress);
            // 
            // lstNombreProd
            // 
            this.lstNombreProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstNombreProd.FormattingEnabled = true;
            this.lstNombreProd.Location = new System.Drawing.Point(118, 66);
            this.lstNombreProd.Name = "lstNombreProd";
            this.lstNombreProd.Size = new System.Drawing.Size(121, 21);
            this.lstNombreProd.TabIndex = 7;
            // 
            // lstNombreVend
            // 
            this.lstNombreVend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstNombreVend.FormattingEnabled = true;
            this.lstNombreVend.Location = new System.Drawing.Point(118, 29);
            this.lstNombreVend.Name = "lstNombreVend";
            this.lstNombreVend.Size = new System.Drawing.Size(121, 21);
            this.lstNombreVend.TabIndex = 6;
            // 
            // lblKilos
            // 
            this.lblKilos.AutoSize = true;
            this.lblKilos.Location = new System.Drawing.Point(19, 146);
            this.lblKilos.Name = "lblKilos";
            this.lblKilos.Size = new System.Drawing.Size(29, 13);
            this.lblKilos.TabIndex = 5;
            this.lblKilos.Text = "Kilos";
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.AutoSize = true;
            this.lblNombreProd.Location = new System.Drawing.Point(19, 69);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(90, 13);
            this.lblNombreProd.TabIndex = 4;
            this.lblNombreProd.Text = "Nombre Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "VERDULERIA";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(19, 109);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(118, 103);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(99, 20);
            this.dtpFecha.TabIndex = 10;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de ventas";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreVend;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox lstNombreProd;
        private System.Windows.Forms.ComboBox lstNombreVend;
        private System.Windows.Forms.Label lblKilos;
        private System.Windows.Forms.Label lblNombreProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxtKilos;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}