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
            this.txtKilos = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNombreProd = new System.Windows.Forms.Label();
            this.lblKilos = new System.Windows.Forms.Label();
            this.lstNombreVend = new System.Windows.Forms.ComboBox();
            this.lstNombreProd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
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
            // txtKilos
            // 
            this.txtKilos.Location = new System.Drawing.Point(118, 104);
            this.txtKilos.Name = "txtKilos";
            this.txtKilos.Size = new System.Drawing.Size(54, 20);
            this.txtKilos.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(295, 120);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(94, 41);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstNombreProd);
            this.groupBox1.Controls.Add(this.lstNombreVend);
            this.groupBox1.Controls.Add(this.lblKilos);
            this.groupBox1.Controls.Add(this.lblNombreProd);
            this.groupBox1.Controls.Add(this.lblNombreVend);
            this.groupBox1.Controls.Add(this.txtKilos);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 142);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
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
            // lblKilos
            // 
            this.lblKilos.AutoSize = true;
            this.lblKilos.Location = new System.Drawing.Point(19, 107);
            this.lblKilos.Name = "lblKilos";
            this.lblKilos.Size = new System.Drawing.Size(29, 13);
            this.lblKilos.TabIndex = 5;
            this.lblKilos.Text = "Kilos";
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
            // lstNombreProd
            // 
            this.lstNombreProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstNombreProd.FormattingEnabled = true;
            this.lstNombreProd.Location = new System.Drawing.Point(118, 66);
            this.lstNombreProd.Name = "lstNombreProd";
            this.lstNombreProd.Size = new System.Drawing.Size(121, 21);
            this.lstNombreProd.TabIndex = 7;
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
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 228);
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
        private System.Windows.Forms.TextBox txtKilos;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox lstNombreProd;
        private System.Windows.Forms.ComboBox lstNombreVend;
        private System.Windows.Forms.Label lblKilos;
        private System.Windows.Forms.Label lblNombreProd;
        private System.Windows.Forms.Label label4;
    }
}