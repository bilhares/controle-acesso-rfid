namespace cadastro_tag
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.arduino = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEventos = new System.Windows.Forms.ComboBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtBaund = new System.Windows.Forms.TextBox();
            this.cbPortas = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // arduino
            // 
            this.arduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.arduino_DataReceived);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(12, 180);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(114, 20);
            this.txtTag.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Evento";
            // 
            // cbEventos
            // 
            this.cbEventos.FormattingEnabled = true;
            this.cbEventos.Location = new System.Drawing.Point(12, 144);
            this.cbEventos.Name = "cbEventos";
            this.cbEventos.Size = new System.Drawing.Size(212, 21);
            this.cbEventos.TabIndex = 6;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(137, 51);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(89, 23);
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtBaund
            // 
            this.txtBaund.Location = new System.Drawing.Point(7, 53);
            this.txtBaund.Name = "txtBaund";
            this.txtBaund.Size = new System.Drawing.Size(121, 20);
            this.txtBaund.TabIndex = 4;
            this.txtBaund.Text = "9600";
            // 
            // cbPortas
            // 
            this.cbPortas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPortas.FormattingEnabled = true;
            this.cbPortas.Location = new System.Drawing.Point(7, 25);
            this.cbPortas.Name = "cbPortas";
            this.cbPortas.Size = new System.Drawing.Size(121, 21);
            this.cbPortas.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConectar);
            this.groupBox1.Controls.Add(this.txtBaund);
            this.groupBox1.Controls.Add(this.cbPortas);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 86);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEventos);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort arduino;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEventos;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtBaund;
        private System.Windows.Forms.ComboBox cbPortas;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

