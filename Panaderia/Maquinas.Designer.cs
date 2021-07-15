namespace Panaderia
{
    partial class Maquinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maquinas));
            this.dtgmaquinas = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbnumero = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.lbencargado = new System.Windows.Forms.Label();
            this.lbultimo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtencargado = new System.Windows.Forms.TextBox();
            this.txtultimo = new System.Windows.Forms.TextBox();
            this.txtproximo = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgmaquinas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgmaquinas
            // 
            this.dtgmaquinas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgmaquinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgmaquinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Nombre,
            this.encargado,
            this.ultimo,
            this.proxima});
            this.dtgmaquinas.Location = new System.Drawing.Point(299, 13);
            this.dtgmaquinas.Name = "dtgmaquinas";
            this.dtgmaquinas.RowHeadersWidth = 51;
            this.dtgmaquinas.Size = new System.Drawing.Size(554, 350);
            this.dtgmaquinas.TabIndex = 0;
            this.dtgmaquinas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgmaquinas_CellClick);
            this.dtgmaquinas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgmaquinas_CellContentClick);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero de maquina";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            this.Numero.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre maquina";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // encargado
            // 
            this.encargado.HeaderText = "Nombre del encargado ";
            this.encargado.MinimumWidth = 6;
            this.encargado.Name = "encargado";
            this.encargado.Width = 125;
            // 
            // ultimo
            // 
            this.ultimo.HeaderText = "Fecha de ultimo mantenimiento";
            this.ultimo.MinimumWidth = 6;
            this.ultimo.Name = "ultimo";
            this.ultimo.Width = 125;
            // 
            // proxima
            // 
            this.proxima.HeaderText = "Fecha de proximo mantenimiento";
            this.proxima.MinimumWidth = 6;
            this.proxima.Name = "proxima";
            this.proxima.Width = 125;
            // 
            // lbnumero
            // 
            this.lbnumero.AutoSize = true;
            this.lbnumero.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.lbnumero.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbnumero.Location = new System.Drawing.Point(17, 26);
            this.lbnumero.Name = "lbnumero";
            this.lbnumero.Size = new System.Drawing.Size(164, 20);
            this.lbnumero.TabIndex = 1;
            this.lbnumero.Text = "Numero de maquina:";
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.lbnombre.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbnombre.Location = new System.Drawing.Point(17, 81);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(163, 20);
            this.lbnombre.TabIndex = 2;
            this.lbnombre.Text = "Nombre de maquina:";
            // 
            // lbencargado
            // 
            this.lbencargado.AutoSize = true;
            this.lbencargado.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.lbencargado.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbencargado.Location = new System.Drawing.Point(17, 134);
            this.lbencargado.Name = "lbencargado";
            this.lbencargado.Size = new System.Drawing.Size(170, 20);
            this.lbencargado.TabIndex = 3;
            this.lbencargado.Text = "Codigo del encargado:";
            // 
            // lbultimo
            // 
            this.lbultimo.AutoSize = true;
            this.lbultimo.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.lbultimo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbultimo.Location = new System.Drawing.Point(17, 185);
            this.lbultimo.Name = "lbultimo";
            this.lbultimo.Size = new System.Drawing.Size(181, 20);
            this.lbultimo.TabIndex = 4;
            this.lbultimo.Text = "Ultimo mantenimiento:";
            this.lbultimo.Click += new System.EventHandler(this.Lbultimo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 5;
            // 
            // txtnumero
            // 
            this.txtnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero.Location = new System.Drawing.Point(19, 49);
            this.txtnumero.MaxLength = 10;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(266, 26);
            this.txtnumero.TabIndex = 6;
            this.txtnumero.TextChanged += new System.EventHandler(this.Txtnumero_TextChanged);
            this.txtnumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtultimo_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(19, 104);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(260, 26);
            this.txtnombre.TabIndex = 7;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnombre_KeyPress);
            // 
            // txtencargado
            // 
            this.txtencargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtencargado.Location = new System.Drawing.Point(19, 156);
            this.txtencargado.MaxLength = 6;
            this.txtencargado.Name = "txtencargado";
            this.txtencargado.Size = new System.Drawing.Size(261, 26);
            this.txtencargado.TabIndex = 8;
            this.txtencargado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtencargado_KeyPress);
            // 
            // txtultimo
            // 
            this.txtultimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtultimo.Location = new System.Drawing.Point(19, 211);
            this.txtultimo.MaxLength = 10;
            this.txtultimo.Name = "txtultimo";
            this.txtultimo.Size = new System.Drawing.Size(260, 26);
            this.txtultimo.TabIndex = 9;
            this.txtultimo.TextChanged += new System.EventHandler(this.txtultimo_TextChanged);
            this.txtultimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtultimo_KeyPress_1);
            // 
            // txtproximo
            // 
            this.txtproximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproximo.Location = new System.Drawing.Point(21, 263);
            this.txtproximo.MaxLength = 10;
            this.txtproximo.Name = "txtproximo";
            this.txtproximo.Size = new System.Drawing.Size(260, 26);
            this.txtproximo.TabIndex = 10;
            this.txtproximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtproximo_KeyPress);
            // 
            // btnagregar
            // 
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F);
            this.btnagregar.Location = new System.Drawing.Point(21, 323);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(143, 31);
            this.btnagregar.TabIndex = 12;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnborrar.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F);
            this.btnborrar.Location = new System.Drawing.Point(170, 323);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(111, 31);
            this.btnborrar.TabIndex = 16;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.Btnborrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(162)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(83, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 53);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(326, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mantenimiento:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(58)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtgmaquinas);
            this.panel2.Controls.Add(this.btnagregar);
            this.panel2.Controls.Add(this.btnborrar);
            this.panel2.Controls.Add(this.txtproximo);
            this.panel2.Controls.Add(this.txtultimo);
            this.panel2.Controls.Add(this.txtnumero);
            this.panel2.Controls.Add(this.lbnombre);
            this.panel2.Controls.Add(this.lbencargado);
            this.panel2.Controls.Add(this.lbnumero);
            this.panel2.Controls.Add(this.lbultimo);
            this.panel2.Controls.Add(this.txtnombre);
            this.panel2.Controls.Add(this.txtencargado);
            this.panel2.Location = new System.Drawing.Point(82, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 377);
            this.panel2.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(15, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 31);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(193, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "(dd/mm/aaaa)\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(17, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Proximo mantenimiento:";
            // 
            // Maquinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1036, 514);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Maquinas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitácora de Mantenimiento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Maquinas_FormClosed);
            this.Load += new System.EventHandler(this.Maquinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgmaquinas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgmaquinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn encargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn proxima;
        private System.Windows.Forms.Label lbnumero;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label lbencargado;
        private System.Windows.Forms.Label lbultimo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtencargado;
        private System.Windows.Forms.TextBox txtultimo;
        private System.Windows.Forms.TextBox txtproximo;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}