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
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Controle_de_acesso
{
    public partial class frmLogin : Form
    {
        private ArrayList senhas = new ArrayList();
        private static String sev = "localhost";
        private static String url = "http://"+sev+":8081/api/";


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
            //MessageBox.Show("id "+senha);
            //if (senha.Trim() == "")
            //    MessageBox.Show("Você deve informar uma senha!");
            //else if (senhas.Contains(senha))
            //    MessageBox.Show("Login efetuado!");
            //else
            //    MessageBox.Show("Senha inválida!");

            //95cef3aa

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync(url+ "rfid/user-ev/" + senha).Result;

            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
               // Usuario u = JsonConvert.DeserializeObject<Usuario>(result);
                UserEvRetorno u = JsonConvert.DeserializeObject<UserEvRetorno>(result);

                if (u.nomeUser != null)
                {

                    MessageBox.Show("Login efetuado!\n" + u.nomeUser);
                    Form2 fr2 = new Form2();
                    fr2.SetDados(u);
                    fr2.Show();
                }
                else
                {
                    MessageBox.Show("Senha inválida!");
                }
                
            }
            else
            {
                MessageBox.Show("tag invalida!");
            }
            txtSenha.Text = "";

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            senhas.Add("admin");
            senhas.Add("12345");
            senhas.Add("7497572e");
            senhas.Add("95cef3aa");

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 fr3 = new Form3(this);
            fr3.Show();
            this.Visible = false;
         }
    }
}
