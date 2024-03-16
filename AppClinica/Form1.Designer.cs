namespace AppClinica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hHCCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeHHCCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actoMedicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeAMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeEspecialistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacienteToolStripMenuItem,
            this.hHCCToolStripMenuItem,
            this.actoMedicoToolStripMenuItem,
            this.especialistaToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 72);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDePacientesToolStripMenuItem});
            this.pacienteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pacienteToolStripMenuItem.Image")));
            this.pacienteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(128, 68);
            this.pacienteToolStripMenuItem.Text = "Paciente";
            // 
            // registroDePacientesToolStripMenuItem
            // 
            this.registroDePacientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDePacientesToolStripMenuItem.Image")));
            this.registroDePacientesToolStripMenuItem.Name = "registroDePacientesToolStripMenuItem";
            this.registroDePacientesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.registroDePacientesToolStripMenuItem.Text = "Registro de Pacientes";
            this.registroDePacientesToolStripMenuItem.Click += new System.EventHandler(this.registroDePacientesToolStripMenuItem_Click);
            // 
            // hHCCToolStripMenuItem
            // 
            this.hHCCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeHHCCToolStripMenuItem});
            this.hHCCToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hHCCToolStripMenuItem.Image")));
            this.hHCCToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.hHCCToolStripMenuItem.Name = "hHCCToolStripMenuItem";
            this.hHCCToolStripMenuItem.Size = new System.Drawing.Size(117, 68);
            this.hHCCToolStripMenuItem.Text = "HHCC";
            // 
            // registroDeHHCCToolStripMenuItem
            // 
            this.registroDeHHCCToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeHHCCToolStripMenuItem.Image")));
            this.registroDeHHCCToolStripMenuItem.Name = "registroDeHHCCToolStripMenuItem";
            this.registroDeHHCCToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.registroDeHHCCToolStripMenuItem.Text = "Registro de HHCC";
            // 
            // actoMedicoToolStripMenuItem
            // 
            this.actoMedicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeAMToolStripMenuItem});
            this.actoMedicoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("actoMedicoToolStripMenuItem.Image")));
            this.actoMedicoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.actoMedicoToolStripMenuItem.Name = "actoMedicoToolStripMenuItem";
            this.actoMedicoToolStripMenuItem.Size = new System.Drawing.Size(151, 68);
            this.actoMedicoToolStripMenuItem.Text = "Acto Medico";
            // 
            // registroDeAMToolStripMenuItem
            // 
            this.registroDeAMToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeAMToolStripMenuItem.Image")));
            this.registroDeAMToolStripMenuItem.Name = "registroDeAMToolStripMenuItem";
            this.registroDeAMToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.registroDeAMToolStripMenuItem.Text = "Registro de AM";
            // 
            // especialistaToolStripMenuItem
            // 
            this.especialistaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeEspecialistaToolStripMenuItem});
            this.especialistaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("especialistaToolStripMenuItem.Image")));
            this.especialistaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.especialistaToolStripMenuItem.Name = "especialistaToolStripMenuItem";
            this.especialistaToolStripMenuItem.Size = new System.Drawing.Size(143, 68);
            this.especialistaToolStripMenuItem.Text = "Especialista";
            // 
            // registroDeEspecialistaToolStripMenuItem
            // 
            this.registroDeEspecialistaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeEspecialistaToolStripMenuItem.Image")));
            this.registroDeEspecialistaToolStripMenuItem.Name = "registroDeEspecialistaToolStripMenuItem";
            this.registroDeEspecialistaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.registroDeEspecialistaToolStripMenuItem.Text = "Registro de Especialista";
            this.registroDeEspecialistaToolStripMenuItem.Click += new System.EventHandler(this.registroDeEspecialistaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportesToolStripMenuItem.Image")));
            this.reportesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(129, 68);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(105, 68);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 646);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1027, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 668);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hHCCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actoMedicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialistaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroDePacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeHHCCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeAMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeEspecialistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}

