
namespace Sistma_de_Ctrl.de_Igr._SC
{
    partial class frmConfiguracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracoes));
            this.TcConfiguracoes = new System.Windows.Forms.TabControl();
            this.tcCongregacao = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgCongregacoes = new System.Windows.Forms.DataGridView();
            this.ID_CONGREGACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONGREGACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_SETOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRIGENTE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRIGENTE2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIdCongregacao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExcluirCongregacao = new System.Windows.Forms.Button();
            this.btnSalvarCongregacao = new System.Windows.Forms.Button();
            this.cboSetor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDirigente2 = new System.Windows.Forms.TextBox();
            this.txtDirigente1 = new System.Windows.Forms.TextBox();
            this.txtNomeCongregacao = new System.Windows.Forms.TextBox();
            this.TcSetor = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.dtgSetor = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SETOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUPERVISOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluirSetor = new System.Windows.Forms.Button();
            this.btnSalvarSetor = new System.Windows.Forms.Button();
            this.txtSupervisor = new System.Windows.Forms.TextBox();
            this.txtIdSetor = new System.Windows.Forms.TextBox();
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.TcConfiguracoes.SuspendLayout();
            this.tcCongregacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCongregacoes)).BeginInit();
            this.TcSetor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSetor)).BeginInit();
            this.SuspendLayout();
            // 
            // TcConfiguracoes
            // 
            this.TcConfiguracoes.Controls.Add(this.tcCongregacao);
            this.TcConfiguracoes.Controls.Add(this.TcSetor);
            this.TcConfiguracoes.Location = new System.Drawing.Point(12, 65);
            this.TcConfiguracoes.Name = "TcConfiguracoes";
            this.TcConfiguracoes.SelectedIndex = 0;
            this.TcConfiguracoes.Size = new System.Drawing.Size(742, 415);
            this.TcConfiguracoes.TabIndex = 0;
            // 
            // tcCongregacao
            // 
            this.tcCongregacao.Controls.Add(this.label10);
            this.tcCongregacao.Controls.Add(this.label8);
            this.tcCongregacao.Controls.Add(this.dtgCongregacoes);
            this.tcCongregacao.Controls.Add(this.txtIdCongregacao);
            this.tcCongregacao.Controls.Add(this.label7);
            this.tcCongregacao.Controls.Add(this.btnExcluirCongregacao);
            this.tcCongregacao.Controls.Add(this.btnSalvarCongregacao);
            this.tcCongregacao.Controls.Add(this.cboSetor);
            this.tcCongregacao.Controls.Add(this.label2);
            this.tcCongregacao.Controls.Add(this.label1);
            this.tcCongregacao.Controls.Add(this.txtDirigente2);
            this.tcCongregacao.Controls.Add(this.txtDirigente1);
            this.tcCongregacao.Controls.Add(this.txtNomeCongregacao);
            this.tcCongregacao.Location = new System.Drawing.Point(4, 22);
            this.tcCongregacao.Name = "tcCongregacao";
            this.tcCongregacao.Padding = new System.Windows.Forms.Padding(3);
            this.tcCongregacao.Size = new System.Drawing.Size(734, 389);
            this.tcCongregacao.TabIndex = 0;
            this.tcCongregacao.Text = "Congregação";
            this.tcCongregacao.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "2º Dirigente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "1º Dirigente:";
            // 
            // dtgCongregacoes
            // 
            this.dtgCongregacoes.AllowUserToAddRows = false;
            this.dtgCongregacoes.AllowUserToDeleteRows = false;
            this.dtgCongregacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCongregacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CONGREGACAO,
            this.CONGREGACAO,
            this.NOME_SETOR,
            this.DIRIGENTE1,
            this.DIRIGENTE2});
            this.dtgCongregacoes.Location = new System.Drawing.Point(17, 165);
            this.dtgCongregacoes.Name = "dtgCongregacoes";
            this.dtgCongregacoes.ReadOnly = true;
            this.dtgCongregacoes.RowHeadersVisible = false;
            this.dtgCongregacoes.Size = new System.Drawing.Size(683, 173);
            this.dtgCongregacoes.TabIndex = 8;
            // 
            // ID_CONGREGACAO
            // 
            this.ID_CONGREGACAO.HeaderText = "Código";
            this.ID_CONGREGACAO.Name = "ID_CONGREGACAO";
            this.ID_CONGREGACAO.ReadOnly = true;
            this.ID_CONGREGACAO.Visible = false;
            // 
            // CONGREGACAO
            // 
            this.CONGREGACAO.HeaderText = "Congregação";
            this.CONGREGACAO.Name = "CONGREGACAO";
            this.CONGREGACAO.ReadOnly = true;
            this.CONGREGACAO.Width = 180;
            // 
            // NOME_SETOR
            // 
            this.NOME_SETOR.HeaderText = "Setor";
            this.NOME_SETOR.Name = "NOME_SETOR";
            this.NOME_SETOR.ReadOnly = true;
            // 
            // DIRIGENTE1
            // 
            this.DIRIGENTE1.HeaderText = "1º Dirigente";
            this.DIRIGENTE1.Name = "DIRIGENTE1";
            this.DIRIGENTE1.ReadOnly = true;
            this.DIRIGENTE1.Width = 200;
            // 
            // DIRIGENTE2
            // 
            this.DIRIGENTE2.HeaderText = "2º Dirigente";
            this.DIRIGENTE2.Name = "DIRIGENTE2";
            this.DIRIGENTE2.ReadOnly = true;
            this.DIRIGENTE2.Width = 200;
            // 
            // txtIdCongregacao
            // 
            this.txtIdCongregacao.Enabled = false;
            this.txtIdCongregacao.Location = new System.Drawing.Point(103, 6);
            this.txtIdCongregacao.Name = "txtIdCongregacao";
            this.txtIdCongregacao.ReadOnly = true;
            this.txtIdCongregacao.Size = new System.Drawing.Size(73, 20);
            this.txtIdCongregacao.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Código";
            // 
            // btnExcluirCongregacao
            // 
            this.btnExcluirCongregacao.BackColor = System.Drawing.Color.Peru;
            this.btnExcluirCongregacao.Image = global::Sistma_de_Ctrl.de_Igr._SC.Properties.Resources.excluir1;
            this.btnExcluirCongregacao.Location = new System.Drawing.Point(253, 344);
            this.btnExcluirCongregacao.Name = "btnExcluirCongregacao";
            this.btnExcluirCongregacao.Size = new System.Drawing.Size(130, 39);
            this.btnExcluirCongregacao.TabIndex = 6;
            this.btnExcluirCongregacao.Text = "Excluir";
            this.btnExcluirCongregacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluirCongregacao.UseVisualStyleBackColor = false;
            this.btnExcluirCongregacao.Click += new System.EventHandler(this.btnExcluirCongregacao_Click);
            // 
            // btnSalvarCongregacao
            // 
            this.btnSalvarCongregacao.BackColor = System.Drawing.Color.Peru;
            this.btnSalvarCongregacao.Image = global::Sistma_de_Ctrl.de_Igr._SC.Properties.Resources.salvar;
            this.btnSalvarCongregacao.Location = new System.Drawing.Point(117, 344);
            this.btnSalvarCongregacao.Name = "btnSalvarCongregacao";
            this.btnSalvarCongregacao.Size = new System.Drawing.Size(130, 39);
            this.btnSalvarCongregacao.TabIndex = 5;
            this.btnSalvarCongregacao.Text = "Salvar";
            this.btnSalvarCongregacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvarCongregacao.UseVisualStyleBackColor = false;
            this.btnSalvarCongregacao.Click += new System.EventHandler(this.btnSalvarCongregacao_Click);
            // 
            // cboSetor
            // 
            this.cboSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSetor.FormattingEnabled = true;
            this.cboSetor.Items.AddRange(new object[] {
            "----Selecione um Setor--------",
            "1",
            "2",
            "3"});
            this.cboSetor.Location = new System.Drawing.Point(103, 63);
            this.cboSetor.Name = "cboSetor";
            this.cboSetor.Size = new System.Drawing.Size(121, 21);
            this.cboSetor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Setor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Congregação:";
            // 
            // txtDirigente2
            // 
            this.txtDirigente2.Location = new System.Drawing.Point(103, 116);
            this.txtDirigente2.Name = "txtDirigente2";
            this.txtDirigente2.Size = new System.Drawing.Size(354, 20);
            this.txtDirigente2.TabIndex = 4;
            this.txtDirigente2.TextChanged += new System.EventHandler(this.txtDirigente2_TextChanged);
            // 
            // txtDirigente1
            // 
            this.txtDirigente1.Location = new System.Drawing.Point(103, 90);
            this.txtDirigente1.Name = "txtDirigente1";
            this.txtDirigente1.Size = new System.Drawing.Size(354, 20);
            this.txtDirigente1.TabIndex = 3;
            this.txtDirigente1.TextChanged += new System.EventHandler(this.txtDirigente1_TextChanged);
            // 
            // txtNomeCongregacao
            // 
            this.txtNomeCongregacao.Location = new System.Drawing.Point(103, 32);
            this.txtNomeCongregacao.Name = "txtNomeCongregacao";
            this.txtNomeCongregacao.Size = new System.Drawing.Size(354, 20);
            this.txtNomeCongregacao.TabIndex = 1;
            this.txtNomeCongregacao.Leave += new System.EventHandler(this.txtNomeCongregacao_Leave);
            // 
            // TcSetor
            // 
            this.TcSetor.Controls.Add(this.label9);
            this.TcSetor.Controls.Add(this.dtgSetor);
            this.TcSetor.Controls.Add(this.btnExcluirSetor);
            this.TcSetor.Controls.Add(this.btnSalvarSetor);
            this.TcSetor.Controls.Add(this.txtSupervisor);
            this.TcSetor.Controls.Add(this.txtIdSetor);
            this.TcSetor.Controls.Add(this.txtSetor);
            this.TcSetor.Controls.Add(this.label6);
            this.TcSetor.Controls.Add(this.label3);
            this.TcSetor.Location = new System.Drawing.Point(4, 22);
            this.TcSetor.Name = "TcSetor";
            this.TcSetor.Padding = new System.Windows.Forms.Padding(3);
            this.TcSetor.Size = new System.Drawing.Size(734, 389);
            this.TcSetor.TabIndex = 1;
            this.TcSetor.Text = "Setor";
            this.TcSetor.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Supervisor:";
            // 
            // dtgSetor
            // 
            this.dtgSetor.AllowUserToAddRows = false;
            this.dtgSetor.AllowUserToDeleteRows = false;
            this.dtgSetor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSetor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.SETOR,
            this.SUPERVISOR});
            this.dtgSetor.Location = new System.Drawing.Point(20, 135);
            this.dtgSetor.Name = "dtgSetor";
            this.dtgSetor.ReadOnly = true;
            this.dtgSetor.RowHeadersVisible = false;
            this.dtgSetor.Size = new System.Drawing.Size(683, 173);
            this.dtgSetor.TabIndex = 4;
            this.dtgSetor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSetor_CellDoubleClick);
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "Código";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Visible = false;
            this.CODIGO.Width = 300;
            // 
            // SETOR
            // 
            this.SETOR.HeaderText = "Setor";
            this.SETOR.Name = "SETOR";
            this.SETOR.ReadOnly = true;
            this.SETOR.Width = 300;
            // 
            // SUPERVISOR
            // 
            this.SUPERVISOR.HeaderText = "Supervisor";
            this.SUPERVISOR.Name = "SUPERVISOR";
            this.SUPERVISOR.ReadOnly = true;
            this.SUPERVISOR.Width = 450;
            // 
            // btnExcluirSetor
            // 
            this.btnExcluirSetor.BackColor = System.Drawing.Color.Peru;
            this.btnExcluirSetor.Image = global::Sistma_de_Ctrl.de_Igr._SC.Properties.Resources.excluir1;
            this.btnExcluirSetor.Location = new System.Drawing.Point(188, 308);
            this.btnExcluirSetor.Name = "btnExcluirSetor";
            this.btnExcluirSetor.Size = new System.Drawing.Size(130, 39);
            this.btnExcluirSetor.TabIndex = 4;
            this.btnExcluirSetor.Text = "Excluir";
            this.btnExcluirSetor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluirSetor.UseVisualStyleBackColor = false;
            this.btnExcluirSetor.Click += new System.EventHandler(this.btnExcluirSetor_Click);
            // 
            // btnSalvarSetor
            // 
            this.btnSalvarSetor.BackColor = System.Drawing.Color.Peru;
            this.btnSalvarSetor.Image = global::Sistma_de_Ctrl.de_Igr._SC.Properties.Resources.salvar;
            this.btnSalvarSetor.Location = new System.Drawing.Point(52, 308);
            this.btnSalvarSetor.Name = "btnSalvarSetor";
            this.btnSalvarSetor.Size = new System.Drawing.Size(130, 39);
            this.btnSalvarSetor.TabIndex = 3;
            this.btnSalvarSetor.Text = "Salvar";
            this.btnSalvarSetor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvarSetor.UseVisualStyleBackColor = false;
            this.btnSalvarSetor.Click += new System.EventHandler(this.btnSalvarSetor_Click);
            // 
            // txtSupervisor
            // 
            this.txtSupervisor.Location = new System.Drawing.Point(73, 84);
            this.txtSupervisor.Name = "txtSupervisor";
            this.txtSupervisor.Size = new System.Drawing.Size(354, 20);
            this.txtSupervisor.TabIndex = 2;
            // 
            // txtIdSetor
            // 
            this.txtIdSetor.Enabled = false;
            this.txtIdSetor.Location = new System.Drawing.Point(73, 6);
            this.txtIdSetor.Name = "txtIdSetor";
            this.txtIdSetor.ReadOnly = true;
            this.txtIdSetor.Size = new System.Drawing.Size(73, 20);
            this.txtIdSetor.TabIndex = 100;
            // 
            // txtSetor
            // 
            this.txtSetor.Location = new System.Drawing.Point(73, 32);
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.Size = new System.Drawing.Size(354, 20);
            this.txtSetor.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Setor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Configurações da Entidade";
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Peru;
            this.btnNovo.Location = new System.Drawing.Point(647, 40);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(107, 37);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo Cadastro";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(805, 492);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TcConfiguracoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfiguracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.frmConfiguracoes_Load);
            this.TcConfiguracoes.ResumeLayout(false);
            this.tcCongregacao.ResumeLayout(false);
            this.tcCongregacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCongregacoes)).EndInit();
            this.TcSetor.ResumeLayout(false);
            this.TcSetor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSetor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TcConfiguracoes;
        private System.Windows.Forms.TabPage tcCongregacao;
        private System.Windows.Forms.Button btnExcluirCongregacao;
        private System.Windows.Forms.Button btnSalvarCongregacao;
        private System.Windows.Forms.ComboBox cboSetor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDirigente1;
        private System.Windows.Forms.TextBox txtNomeCongregacao;
        private System.Windows.Forms.TabPage TcSetor;
        private System.Windows.Forms.Button btnExcluirSetor;
        private System.Windows.Forms.Button btnSalvarSetor;
        private System.Windows.Forms.TextBox txtSetor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgCongregacoes;
        private System.Windows.Forms.TextBox txtIdCongregacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgSetor;
        private System.Windows.Forms.TextBox txtIdSetor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDirigente2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSupervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SETOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUPERVISOR;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CONGREGACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONGREGACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_SETOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRIGENTE1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRIGENTE2;
    }
}