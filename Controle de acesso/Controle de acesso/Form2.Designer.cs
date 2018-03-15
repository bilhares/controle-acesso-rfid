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
            ((System.ComponentModel.ISupportInitialize)(this.ftUser)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ftUser
            // 
            this.ftUser.Location = new System.Drawing.Point(68, 12);
            this.ftUser.Name = "ftUser";
            this.ftUser.Size = new System.Drawing.Size(100, 94);
            this.ftUser.TabIndex = 0;
            this.ftUser.TabStop = false;
            // 
            // txNome
            // 
            this.txNome.AutoSize = true;
            this.txNome.Location = new System.Drawing.Point(6, 27);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(35, 13);
            this.txNome.TabIndex = 1;
            this.txNome.Text = "label1";
            // 
            // txEmail
            // 
            this.txEmail.AutoSize = true;
            this.txEmail.Location = new System.Drawing.Point(6, 52);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(35, 13);
            this.txEmail.TabIndex = 2;
            this.txEmail.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txNome);
            this.groupBox1.Controls.Add(this.txEmail);
            this.groupBox1.Location = new System.Drawing.Point(22, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do usuário";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ftUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.ftUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ftUser;
        private System.Windows.Forms.Label txNome;
        private System.Windows.Forms.Label txEmail;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}