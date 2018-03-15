namespace Controle_de_acesso
{
    partial class Form2
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
            this.ftUser = new System.Windows.Forms.PictureBox();
            this.txNome = new System.Windows.Forms.Label();
            this.txEmail = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txLocalEv = new System.Windows.Forms.Label();
            this.txPrecoEv = new System.Windows.Forms.Label();
            this.txNomEvento = new System.Windows.Forms.Label();
            this.ftEvento = new System.Windows.Forms.PictureBox();
            this.txDataEv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ftUser)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ftEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // ftUser
            // 
            this.ftUser.Location = new System.Drawing.Point(47, 22);
            this.ftUser.Name = "ftUser";
            this.ftUser.Size = new System.Drawing.Size(100, 94);
            this.ftUser.TabIndex = 0;
            this.ftUser.TabStop = false;
            // 
            // txNome
            // 
            this.txNome.AutoSize = true;
            this.txNome.Location = new System.Drawing.Point(6, 125);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(35, 13);
            this.txNome.TabIndex = 1;
            this.txNome.Text = "label1";
            // 
            // txEmail
            // 
            this.txEmail.AutoSize = true;
            this.txEmail.Location = new System.Drawing.Point(6, 150);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(35, 13);
            this.txEmail.TabIndex = 2;
            this.txEmail.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txNome);
            this.groupBox1.Controls.Add(this.ftUser);
            this.groupBox1.Controls.Add(this.txEmail);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 178);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do usuário";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txLocalEv);
            this.groupBox2.Controls.Add(this.txPrecoEv);
            this.groupBox2.Controls.Add(this.txNomEvento);
            this.groupBox2.Controls.Add(this.ftEvento);
            this.groupBox2.Controls.Add(this.txDataEv);
            this.groupBox2.Location = new System.Drawing.Point(247, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 178);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados evento";
            // 
            // txLocalEv
            // 
            this.txLocalEv.AutoSize = true;
            this.txLocalEv.Location = new System.Drawing.Point(115, 147);
            this.txLocalEv.Name = "txLocalEv";
            this.txLocalEv.Size = new System.Drawing.Size(35, 13);
            this.txLocalEv.TabIndex = 7;
            this.txLocalEv.Text = "label2";
            // 
            // txPrecoEv
            // 
            this.txPrecoEv.AutoSize = true;
            this.txPrecoEv.Location = new System.Drawing.Point(115, 122);
            this.txPrecoEv.Name = "txPrecoEv";
            this.txPrecoEv.Size = new System.Drawing.Size(35, 13);
            this.txPrecoEv.TabIndex = 6;
            this.txPrecoEv.Text = "label1";
            // 
            // txNomEvento
            // 
            this.txNomEvento.AutoSize = true;
            this.txNomEvento.Location = new System.Drawing.Point(22, 122);
            this.txNomEvento.Name = "txNomEvento";
            this.txNomEvento.Size = new System.Drawing.Size(35, 13);
            this.txNomEvento.TabIndex = 4;
            this.txNomEvento.Text = "label1";
            // 
            // ftEvento
            // 
            this.ftEvento.Location = new System.Drawing.Point(50, 19);
            this.ftEvento.Name = "ftEvento";
            this.ftEvento.Size = new System.Drawing.Size(100, 94);
            this.ftEvento.TabIndex = 3;
            this.ftEvento.TabStop = false;
            // 
            // txDataEv
            // 
            this.txDataEv.AutoSize = true;
            this.txDataEv.Location = new System.Drawing.Point(22, 147);
            this.txDataEv.Name = "txDataEv";
            this.txDataEv.Size = new System.Drawing.Size(35, 13);
            this.txDataEv.TabIndex = 5;
            this.txDataEv.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 202);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.ftUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ftEvento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ftUser;
        private System.Windows.Forms.Label txNome;
        private System.Windows.Forms.Label txEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txNomEvento;
        private System.Windows.Forms.PictureBox ftEvento;
        private System.Windows.Forms.Label txDataEv;
        private System.Windows.Forms.Label txLocalEv;
        private System.Windows.Forms.Label txPrecoEv;
    }
}