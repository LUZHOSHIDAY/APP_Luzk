namespace CapaPresentacion
{
    partial class FrmModuloEspecialista
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellidoEspecialista = new System.Windows.Forms.TextBox();
            this.txtNombreEspecialista = new System.Windows.Forms.TextBox();
            this.txtEspecialistaCMP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEspecialista = new System.Windows.Forms.ComboBox();
            this.dgvEspecialista = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "MODULO DE ADMINISTRACION DE ESPECIALISTAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtApellidoEspecialista
            // 
            this.txtApellidoEspecialista.BackColor = System.Drawing.SystemColors.Info;
            this.txtApellidoEspecialista.Location = new System.Drawing.Point(176, 146);
            this.txtApellidoEspecialista.Name = "txtApellidoEspecialista";
            this.txtApellidoEspecialista.Size = new System.Drawing.Size(200, 20);
            this.txtApellidoEspecialista.TabIndex = 39;
            // 
            // txtNombreEspecialista
            // 
            this.txtNombreEspecialista.BackColor = System.Drawing.SystemColors.Info;
            this.txtNombreEspecialista.Location = new System.Drawing.Point(176, 104);
            this.txtNombreEspecialista.Name = "txtNombreEspecialista";
            this.txtNombreEspecialista.Size = new System.Drawing.Size(200, 20);
            this.txtNombreEspecialista.TabIndex = 38;
            // 
            // txtEspecialistaCMP
            // 
            this.txtEspecialistaCMP.BackColor = System.Drawing.SystemColors.Info;
            this.txtEspecialistaCMP.Location = new System.Drawing.Point(176, 62);
            this.txtEspecialistaCMP.Name = "txtEspecialistaCMP";
            this.txtEspecialistaCMP.Size = new System.Drawing.Size(200, 20);
            this.txtEspecialistaCMP.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "APELLIDO ESPECIALISTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "NOMBRE ESPECIALISTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "ESPECIALISTACMP\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "CODIGO ESPECIALIDAD ";
            // 
            // comboBoxEspecialista
            // 
            this.comboBoxEspecialista.FormattingEnabled = true;
            this.comboBoxEspecialista.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxEspecialista.Location = new System.Drawing.Point(176, 190);
            this.comboBoxEspecialista.Name = "comboBoxEspecialista";
            this.comboBoxEspecialista.Size = new System.Drawing.Size(200, 21);
            this.comboBoxEspecialista.TabIndex = 41;
            // 
            // dgvEspecialista
            // 
            this.dgvEspecialista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEspecialista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialista.Location = new System.Drawing.Point(382, 37);
            this.dgvEspecialista.Name = "dgvEspecialista";
            this.dgvEspecialista.Size = new System.Drawing.Size(406, 262);
            this.dgvEspecialista.TabIndex = 42;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(604, 328);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 23);
            this.button4.TabIndex = 47;
            this.button4.Text = "BUSCAR";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(404, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 23);
            this.button3.TabIndex = 46;
            this.button3.Text = "ELIMINAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 23);
            this.button2.TabIndex = 45;
            this.button2.Text = "MODIFICAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "INSERTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmModuloEspecialista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvEspecialista);
            this.Controls.Add(this.comboBoxEspecialista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApellidoEspecialista);
            this.Controls.Add(this.txtNombreEspecialista);
            this.Controls.Add(this.txtEspecialistaCMP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmModuloEspecialista";
            this.Text = "FrmModuloEspecialista";
            this.Load += new System.EventHandler(this.FrmModuloEspecialista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellidoEspecialista;
        private System.Windows.Forms.TextBox txtNombreEspecialista;
        private System.Windows.Forms.TextBox txtEspecialistaCMP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxEspecialista;
        private System.Windows.Forms.DataGridView dgvEspecialista;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}