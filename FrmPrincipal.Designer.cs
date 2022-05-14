namespace Sistma_de_Ctrl.de_Igr.Evang.Ass.de_Deus_SICAD
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnPatrimonial = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnTesourarias = new System.Windows.Forms.Button();
            this.btnSecretarias = new System.Windows.Forms.Button();
            this.btnConfiguracao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TSMenuPrincipal = new System.Windows.Forms.ToolStrip();
            this.btnConfiguracoes = new System.Windows.Forms.ToolStripButton();
            this.btnSecretaria = new System.Windows.Forms.ToolStripButton();
            this.btnTesouraria = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.relogio = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNivelUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHorario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSair = new System.Windows.Forms.Button();
            this.TSMenuPrincipal.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPatrimonial
            // 
            this.btnPatrimonial.BackColor = System.Drawing.Color.Peru;
            this.btnPatrimonial.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatrimonial.Location = new System.Drawing.Point(20, 190);
            this.btnPatrimonial.Name = "btnPatrimonial";
            this.btnPatrimonial.Size = new System.Drawing.Size(172, 52);
            this.btnPatrimonial.TabIndex = 0;
            this.btnPatrimonial.Text = "Patrimonial";
            this.btnPatrimonial.UseVisualStyleBackColor = false;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Peru;
            this.btnUsuarios.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(20, 271);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(172, 110);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Cadastro de Usuários";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnTesourarias
            // 
            this.btnTesourarias.BackColor = System.Drawing.Color.Peru;
            this.btnTesourarias.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTesourarias.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTesourarias.Location = new System.Drawing.Point(20, 98);
            this.btnTesourarias.Name = "btnTesourarias";
            this.btnTesourarias.Size = new System.Drawing.Size(172, 52);
            this.btnTesourarias.TabIndex = 0;
            this.btnTesourarias.Text = "Tesouraria";
            this.btnTesourarias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTesourarias.UseVisualStyleBackColor = false;
            this.btnTesourarias.Click += new System.EventHandler(this.btnTesouraria_Click);
            // 
            // btnSecretarias
            // 
            this.btnSecretarias.BackColor = System.Drawing.Color.Peru;
            this.btnSecretarias.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecretarias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecretarias.Location = new System.Drawing.Point(20, 4);
            this.btnSecretarias.Name = "btnSecretarias";
            this.btnSecretarias.Size = new System.Drawing.Size(172, 52);
            this.btnSecretarias.TabIndex = 0;
            this.btnSecretarias.Text = "Secretaria";
            this.btnSecretarias.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSecretarias.UseVisualStyleBackColor = false;
            this.btnSecretarias.Click += new System.EventHandler(this.btnSecretaria_Click);
            // 
            // btnConfiguracao
            // 
            this.btnConfiguracao.BackColor = System.Drawing.Color.Peru;
            this.btnConfiguracao.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracao.Location = new System.Drawing.Point(20, 408);
            this.btnConfiguracao.Name = "btnConfiguracao";
            this.btnConfiguracao.Size = new System.Drawing.Size(172, 52);
            this.btnConfiguracao.TabIndex = 0;
            this.btnConfiguracao.Text = "Configurações";
            this.btnConfiguracao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConfiguracao.UseVisualStyleBackColor = false;
            this.btnConfiguracao.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(785, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "SCI - Sistema de Controle de Igrejas";
            // 
            // TSMenuPrincipal
            // 
            this.TSMenuPrincipal.Dock = System.Windows.Forms.DockStyle.None;
            this.TSMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConfiguracoes,
            this.btnSecretaria,
            this.btnTesouraria,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6});
            this.TSMenuPrincipal.Location = new System.Drawing.Point(450, 25);
            this.TSMenuPrincipal.Name = "TSMenuPrincipal";
            this.TSMenuPrincipal.Size = new System.Drawing.Size(150, 25);
            this.TSMenuPrincipal.TabIndex = 3;
            this.TSMenuPrincipal.Text = "toolStrip1";
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConfiguracoes.Image = global::Sistma_de_Ctrl.de_Igr._SC.Properties.Resources.Engrenagem;
            this.btnConfiguracoes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(23, 22);
            this.btnConfiguracoes.Text = "Configurações";
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // btnSecretaria
            // 
            this.btnSecretaria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSecretaria.Image = ((System.Drawing.Image)(resources.GetObject("btnSecretaria.Image")));
            this.btnSecretaria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSecretaria.Name = "btnSecretaria";
            this.btnSecretaria.Size = new System.Drawing.Size(23, 22);
            this.btnSecretaria.Text = "toolStripButton2";
            this.btnSecretaria.Click += new System.EventHandler(this.btnSecretaria_Click);
            // 
            // btnTesouraria
            // 
            this.btnTesouraria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTesouraria.Image = ((System.Drawing.Image)(resources.GetObject("btnTesouraria.Image")));
            this.btnTesouraria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTesouraria.Name = "btnTesouraria";
            this.btnTesouraria.Size = new System.Drawing.Size(23, 22);
            this.btnTesouraria.Text = "Tesouraria";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.Calendario);
            this.pnlPrincipal.Location = new System.Drawing.Point(255, 83);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(942, 553);
            this.pnlPrincipal.TabIndex = 5;
            // 
            // Calendario
            // 
            this.Calendario.BackColor = System.Drawing.Color.PeachPuff;
            this.Calendario.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.Calendario.FirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.Calendario.Location = new System.Drawing.Point(92, 47);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnTesourarias);
            this.panel1.Controls.Add(this.btnPatrimonial);
            this.panel1.Controls.Add(this.btnConfiguracao);
            this.panel1.Controls.Add(this.btnSecretarias);
            this.panel1.Location = new System.Drawing.Point(12, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 553);
            this.panel1.TabIndex = 6;
            // 
            // relogio
            // 
            this.relogio.Enabled = true;
            this.relogio.Interval = 1000;
            this.relogio.Tick += new System.EventHandler(this.relogio_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblNivelUsuario,
            this.lblHorario,
            this.lblData});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1197, 24);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.lblUsuario.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(122, 19);
            this.lblUsuario.Text = "toolStripStatusLabel1";
            // 
            // lblNivelUsuario
            // 
            this.lblNivelUsuario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblNivelUsuario.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblNivelUsuario.Name = "lblNivelUsuario";
            this.lblNivelUsuario.Size = new System.Drawing.Size(122, 19);
            this.lblNivelUsuario.Text = "toolStripStatusLabel2";
            // 
            // lblHorario
            // 
            this.lblHorario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblHorario.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(122, 19);
            this.lblHorario.Text = "toolStripStatusLabel3";
            // 
            // lblData
            // 
            this.lblData.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblData.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(122, 19);
            this.lblData.Text = "toolStripStatusLabel4";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Peru;
            this.btnSair.Image = global::Sistma_de_Ctrl.de_Igr._SC.Properties.Resources.sair;
            this.btnSair.Location = new System.Drawing.Point(847, 22);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(77, 55);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 663);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TSMenuPrincipal);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.TSMenuPrincipal.ResumeLayout(false);
            this.TSMenuPrincipal.PerformLayout();
            this.pnlPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPatrimonial;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnTesourarias;
        private System.Windows.Forms.Button btnConfiguracao;
        private System.Windows.Forms.Button btnSecretarias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip TSMenuPrincipal;
        private System.Windows.Forms.ToolStripButton btnConfiguracoes;
        private System.Windows.Forms.ToolStripButton btnSecretaria;
        private System.Windows.Forms.ToolStripButton btnTesouraria;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer relogio;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblNivelUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblHorario;
        private System.Windows.Forms.ToolStripStatusLabel lblData;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MonthCalendar Calendario;
    }
}

