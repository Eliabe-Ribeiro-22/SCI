
namespace Sistma_de_Ctrl.de_Igr._SC
{
    partial class FrmCadastroUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroUsuarios));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha1 = new System.Windows.Forms.TextBox();
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.cboNivelUsuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.ID_USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOGIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SENHA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SENHA2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIVEL_USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_CADASTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.buttonExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDataCadatro = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(105, 73);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(456, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtSenha1
            // 
            this.txtSenha1.Location = new System.Drawing.Point(105, 137);
            this.txtSenha1.Name = "txtSenha1";
            this.txtSenha1.PasswordChar = '*';
            this.txtSenha1.Size = new System.Drawing.Size(176, 20);
            this.txtSenha1.TabIndex = 3;
            this.txtSenha1.TextChanged += new System.EventHandler(this.txtSenha1_TextChanged);
            // 
            // txtSenha2
            // 
            this.txtSenha2.Location = new System.Drawing.Point(390, 143);
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.PasswordChar = '*';
            this.txtSenha2.Size = new System.Drawing.Size(176, 20);
            this.txtSenha2.TabIndex = 4;
            this.txtSenha2.TextChanged += new System.EventHandler(this.txtSenha2_TextChanged);
            // 
            // cboNivelUsuario
            // 
            this.cboNivelUsuario.BackColor = System.Drawing.Color.Yellow;
            this.cboNivelUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNivelUsuario.FormattingEnabled = true;
            this.cboNivelUsuario.Items.AddRange(new object[] {
            "------Selecione um Nível----------",
            "Administrador",
            "Pastor Presidente",
            "Vice-Presidente",
            "Pastor",
            "Tesoureiro",
            "Secretário",
            "Usuário"});
            this.cboNivelUsuario.Location = new System.Drawing.Point(392, 116);
            this.cboNivelUsuario.Name = "cboNivelUsuario";
            this.cboNivelUsuario.Size = new System.Drawing.Size(169, 21);
            this.cboNivelUsuario.TabIndex = 2;
            this.cboNivelUsuario.SelectedIndexChanged += new System.EventHandler(this.cboNivelUsuario_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nivel do Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digite a Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Redigite a Senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Login:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(105, 111);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(176, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Enabled = false;
            this.txtIdUsuario.Location = new System.Drawing.Point(105, 47);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(158, 20);
            this.txtIdUsuario.TabIndex = 0;
            this.txtIdUsuario.TextChanged += new System.EventHandler(this.txtIdUsuario_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Código do Usuário:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(144, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 42);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cadastro de Usuários";
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.AllowUserToAddRows = false;
            this.dtgUsuarios.AllowUserToDeleteRows = false;
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_USUARIO,
            this.LOGIN,
            this.NOME,
            this.SENHA1,
            this.SENHA2,
            this.NIVEL_USUARIO,
            this.STATUS,
            this.DATA_CADASTRO,
            this.btnEditar,
            this.buttonExcluir});
            this.dtgUsuarios.Location = new System.Drawing.Point(12, 202);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.ReadOnly = true;
            this.dtgUsuarios.RowHeadersVisible = false;
            this.dtgUsuarios.Size = new System.Drawing.Size(549, 191);
            this.dtgUsuarios.TabIndex = 7;
            this.dtgUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuarios_CellContentClick);
            // 
            // ID_USUARIO
            // 
            this.ID_USUARIO.HeaderText = "Código do Usuário";
            this.ID_USUARIO.Name = "ID_USUARIO";
            this.ID_USUARIO.ReadOnly = true;
            this.ID_USUARIO.Visible = false;
            // 
            // LOGIN
            // 
            this.LOGIN.HeaderText = "Login";
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.ReadOnly = true;
            this.LOGIN.Width = 200;
            // 
            // NOME
            // 
            this.NOME.HeaderText = "Nome";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            // 
            // SENHA1
            // 
            this.SENHA1.HeaderText = "Senha1";
            this.SENHA1.Name = "SENHA1";
            this.SENHA1.ReadOnly = true;
            this.SENHA1.Visible = false;
            // 
            // SENHA2
            // 
            this.SENHA2.HeaderText = "Senha2";
            this.SENHA2.Name = "SENHA2";
            this.SENHA2.ReadOnly = true;
            this.SENHA2.Visible = false;
            // 
            // NIVEL_USUARIO
            // 
            this.NIVEL_USUARIO.HeaderText = "Nível";
            this.NIVEL_USUARIO.Name = "NIVEL_USUARIO";
            this.NIVEL_USUARIO.ReadOnly = true;
            this.NIVEL_USUARIO.Width = 205;
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "Status";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            this.STATUS.Width = 140;
            // 
            // DATA_CADASTRO
            // 
            this.DATA_CADASTRO.HeaderText = "Data do Cadastro";
            this.DATA_CADASTRO.Name = "DATA_CADASTRO";
            this.DATA_CADASTRO.ReadOnly = true;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "";
            this.btnEditar.Image = global::Sistma_de_Ctrl.de_Igr._SC.Properties.Resources.editar;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            this.btnEditar.Width = 220;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.HeaderText = "";
            this.buttonExcluir.Image = global::Sistma_de_Ctrl.de_Igr._SC.Properties.Resources.excluir2;
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.ReadOnly = true;
            this.buttonExcluir.Width = 220;
            // 
            // cboStatus
            // 
            this.cboStatus.BackColor = System.Drawing.Color.Yellow;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "-----Selecione------",
            "Ativo",
            "Inativo"});
            this.cboStatus.Location = new System.Drawing.Point(105, 175);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(169, 21);
            this.cboStatus.TabIndex = 2;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            this.cboStatus.Leave += new System.EventHandler(this.cboStatus_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Status:";
            // 
            // dtpDataCadatro
            // 
            this.dtpDataCadatro.Enabled = false;
            this.dtpDataCadatro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadatro.Location = new System.Drawing.Point(392, 171);
            this.dtpDataCadatro.Name = "dtpDataCadatro";
            this.dtpDataCadatro.Size = new System.Drawing.Size(98, 20);
            this.dtpDataCadatro.TabIndex = 8;
            this.dtpDataCadatro.ValueChanged += new System.EventHandler(this.dtpDataCadatro_ValueChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Sistma_de_Ctrl.de_Igr._SC.Properties.Resources.editar;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Sistma_de_Ctrl.de_Igr._SC.Properties.Resources.excluir2;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::Sistma_de_Ctrl.de_Igr._SC.Properties.Resources.excluir;
            this.btnExcluir.Location = new System.Drawing.Point(338, 393);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(118, 45);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::Sistma_de_Ctrl.de_Igr._SC.Properties.Resources.salvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(227, 393);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(105, 45);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(452, 15);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(74, 44);
            this.btnNovo.TabIndex = 9;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Data do Cadastro:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(113, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "A senha deve conter 4 dígitos";
            // 
            // FrmCadastroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dtpDataCadatro);
            this.Controls.Add(this.dtgUsuarios);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.cboNivelUsuario);
            this.Controls.Add(this.txtSenha2);
            this.Controls.Add(this.txtSenha1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCadastroUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha1;
        private System.Windows.Forms.TextBox txtSenha2;
        private System.Windows.Forms.ComboBox cboNivelUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDataCadatro;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOGIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SENHA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SENHA2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIVEL_USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_CADASTRO;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn buttonExcluir;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}