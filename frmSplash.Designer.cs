
namespace Sistma_de_Ctrl.de_Igr._SC
{
    partial class frmSplash
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
            this.label1 = new System.Windows.Forms.Label();
            this.pbBarra = new System.Windows.Forms.ProgressBar();
            this.relogio = new System.Windows.Forms.Timer(this.components);
            this.relogioData = new System.Windows.Forms.Timer(this.components);
            this.lblData = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 209);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Controle para Igrejas";
            // 
            // pbBarra
            // 
            this.pbBarra.BackColor = System.Drawing.Color.Lime;
            this.pbBarra.Location = new System.Drawing.Point(12, 301);
            this.pbBarra.MarqueeAnimationSpeed = 1000;
            this.pbBarra.Name = "pbBarra";
            this.pbBarra.Size = new System.Drawing.Size(625, 50);
            this.pbBarra.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbBarra.TabIndex = 1;
            // 
            // relogio
            // 
            this.relogio.Enabled = true;
            this.relogio.Interval = 32;
            // 
            // relogioData
            // 
            this.relogioData.Enabled = true;
            this.relogioData.Interval = 1000;
            this.relogioData.Tick += new System.EventHandler(this.relogioData_Tick);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(260, 354);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(95, 39);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Carregando...";
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(649, 397);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.pbBarra);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbBarra;
        private System.Windows.Forms.Timer relogio;
        private System.Windows.Forms.Timer relogioData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label2;
    }
}