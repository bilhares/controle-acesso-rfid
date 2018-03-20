using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastro_tag
{
    public partial class Form1 : Form
    {
        private static String sev = "localhost";
        private static String url = "http://" + sev + ":8081/api/";

        public Form1()
        {
            InitializeComponent();
            populateCombo();
        }

        public void populateCombo()
        {
            cbEventos.DisplayMember = "nome";
            cbEventos.ValueMember = "id";
            //////
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync(url + "eventos/sem-tag").Result;

            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;

                Evento[] evs = JsonConvert.DeserializeObject<Evento[]>(result);
                if (evs.Length > 0)
                {
                    cbEventos.DataSource = evs;
                }

            }
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

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] p = SerialPort.GetPortNames();
            cbPortas.DataSource = p;
        }

        private void arduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(cadastrarTag));
        }

        public void cadastrarTag(object o, EventArgs e)
        {
            string teste = arduino.ReadLine().Replace("\r", "");
            MessageBox.Show("aaaaa");
            cadastrarTag(teste);
        }

        public void cadastrarTag(String id)
        {
            long idEvento = (long)cbEventos.SelectedValue;
            long idTag = Convert.ToInt64(id, 16);

            MessageBox.Show("id " + idTag + " evento " + idEvento);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            dynamic jsonObject = new Newtonsoft.Json.Linq.JObject();
            jsonObject.id = idTag;
            jsonObject.idEvento = idEvento;
            jsonObject.ativo = true;

            var json = jsonObject.ToString();
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PostAsync(url + "rfid", content).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Cadastrado com sucesso");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastrarTag(txtTag.Text);
        }
    }
}
