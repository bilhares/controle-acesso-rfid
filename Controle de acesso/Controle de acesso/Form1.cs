using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO.Ports;

namespace Controle_de_acesso
{
    public partial class frmLogin : Form
    {
        private ArrayList senhas = new ArrayList();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            login(txtSenha.Text);
        }

        private void login(string senha)
        {
            if (senha.Trim() == "")
                MessageBox.Show("Você deve informar uma senha!");
            else if (senhas.Contains(senha))
                MessageBox.Show("Login efetuado!");
            else
                MessageBox.Show("Senha inválida!");

            txtSenha.Text = "";
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            senhas.Add("admin");
            senhas.Add("12345");
            senhas.Add("7497572e");

            string[] p = SerialPort.GetPortNames();
            cbPortas.DataSource = p;

       }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if(Keys.Enter == e.KeyCode)
                login(txtSenha.Text);
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                arduino.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void arduino_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(loginArduino));
        }

        private void loginArduino(object o, EventArgs e)
        {
            string teste = arduino.ReadLine().Replace("\r", "");
            login(teste);
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            txtBaund.Enabled = !txtBaund.Enabled;
            try
            {                
                if (btnConectar.Text == "Conectar")
                {
                    arduino.PortName = cbPortas.SelectedValue.ToString();
                    arduino.BaudRate = Int32.Parse(txtBaund.Text);
                    arduino.Open();
                    btnConectar.Text = "Desconectar";
                    MessageBox.Show("Conexão efetuada!");
                }
                else
                {
                    arduino.Close();
                    btnConectar.Text = "Conectar";
                    MessageBox.Show("Desconectado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

    }
}
