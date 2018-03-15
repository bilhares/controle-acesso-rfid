using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_acesso
{
    public partial class Form2 : Form
    {
       // public static Usuario u { get; set; }

        public Form2()
        {
          
           InitializeComponent();
            ftUser.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void SetDados(UserEvRetorno u)
        {
            txNome.Text = u.nomeUser;
            txEmail.Text = u.emailUser;
            ftUser.Image = ByteToImage(u.ftUser);
            txNomEvento.Text = u.nomeEvento;
            txPrecoEv.Text = u.preco.ToString();
            txLocalEv.Text = u.local;
            txDataEv.Text = u.data.ToString();
            ftEvento.Image = ByteToImage(u.ftEvento);

        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
    }
}
