
namespace Sistma_de_Ctrl.de_Igr._SC
{
    partial class frmPesquisaAvancada
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
            this.cboSituacao = new System.Windows.Forms.ComboBox();
            this.btnPesquisarPesquisaAvancada = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSetor = new System.Windows.Forms.ComboBox();
            this.cboCongregacao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cboNome = new System.Windows.Forms.ComboBox();
            this.txtPesquisaAvancada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboSituacao
            // 
            this.cboSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSituacao.FormattingEnabled = true;
            this.cboSituacao.Items.AddRange(new object[] {
            "---Selecione uma Situação-----------------------",
            "Membro Ativo",
            "Congregado Ativo",
            "Disciplinado",
            "Desligado",
            "Mudou-se de Igreja",
            "Óbito"});
            this.cboSituacao.Location = new System.Drawing.Point(285, 161);
            this.cboSituacao.Name = "cboSituacao";
            this.cboSituacao.Size = new System.Drawing.Size(201, 21);
            this.cboSituacao.TabIndex = 2;
            // 
            // btnPesquisarPesquisaAvancada
            // 
            this.btnPesquisarPesquisaAvancada.Location = new System.Drawing.Point(380, 360);
            this.btnPesquisarPesquisaAvancada.Name = "btnPesquisarPesquisaAvancada";
            this.btnPesquisarPesquisaAvancada.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarPesquisaAvancada.TabIndex = 3;
            this.btnPesquisarPesquisaAvancada.Text = "Pesquisar";
            this.btnPesquisarPesquisaAvancada.UseVisualStyleBackColor = true;
            this.btnPesquisarPesquisaAvancada.Click += new System.EventHandler(this.btnPesquisarPesquisaAvancada_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pesquisa por Situação do Cadastro:";
            // 
            // cboSetor
            // 
            this.cboSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSetor.FormattingEnabled = true;
            this.cboSetor.Items.AddRange(new object[] {
            "---Selecione um Setor-----------------------",
            "1",
            "2",
            "3"});
            this.cboSetor.Location = new System.Drawing.Point(285, 234);
            this.cboSetor.Name = "cboSetor";
            this.cboSetor.Size = new System.Drawing.Size(201, 21);
            this.cboSetor.TabIndex = 2;
            // 
            // cboCongregacao
            // 
            this.cboCongregacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCongregacao.FormattingEnabled = true;
            this.cboCongregacao.Items.AddRange(new object[] {
            "---Selecione uma Congregação-----------------------",
            "Canaã",
            "Belém",
            "Betânia",
            "Getsêmani",
            "Mananciais",
            "Monte Hermon",
            "Monte Sião",
            "Nova Jerusalém",
            "Sede",
            "Shalom"});
            this.cboCongregacao.Location = new System.Drawing.Point(276, 207);
            this.cboCongregacao.Name = "cboCongregacao";
            this.cboCongregacao.Size = new System.Drawing.Size(201, 21);
            this.cboCongregacao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pesuisa por Congregação:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pesquisa por Setor:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(461, 360);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(123, 23);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar a Secretaria";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // cboNome
            // 
            this.cboNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNome.FormattingEnabled = true;
            this.cboNome.Items.AddRange(new object[] {
            "---Selecione uma Opção-----------------------",
            "Nome do Cadastro"});
            this.cboNome.Location = new System.Drawing.Point(285, 94);
            this.cboNome.Name = "cboNome";
            this.cboNome.Size = new System.Drawing.Size(201, 21);
            this.cboNome.TabIndex = 2;
            // 
            // txtPesquisaAvancada
            // 
            this.txtPesquisaAvancada.Location = new System.Drawing.Point(300, 297);
            this.txtPesquisaAvancada.Name = "txtPesquisaAvancada";
            this.txtPesquisaAvancada.Size = new System.Drawing.Size(346, 20);
            this.txtPesquisaAvancada.TabIndex = 6;
            this.txtPesquisaAvancada.Text = "Digite aqui";
            this.txtPesquisaAvancada.TextChanged += new System.EventHandler(this.txtPesquisaAvancada_TextChanged);
            this.txtPesquisaAvancada.Leave += new System.EventHandler(this.txtPesquisaAvancada_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Digite o que deseja pesquisar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pesquisa Avançada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(397, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Selecione um tipo de pesquisa e escreva no campo abaixo o que deseja pesquisar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Pesquisa por Nome:";
            // 
            // frmPesquisaAvancada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPesquisaAvancada);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisarPesquisaAvancada);
            this.Controls.Add(this.cboCongregacao);
            this.Controls.Add(this.cboSetor);
            this.Controls.Add(this.cboNome);
            this.Controls.Add(this.cboSituacao);
            this.Name = "frmPesquisaAvancada";
            this.Text = "frmPesquisaAvançada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSituacao;
        private System.Windows.Forms.Button btnPesquisarPesquisaAvancada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSetor;
        private System.Windows.Forms.ComboBox cboCongregacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cboNome;
        private System.Windows.Forms.TextBox txtPesquisaAvancada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}