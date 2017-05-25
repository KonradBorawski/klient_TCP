using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace klient_TCP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Polacz_Click(object sender, EventArgs e)
        {
            string host = myAdress.Text;
            int port = System.Convert.ToInt32(myPort.Value);

            try
            {
                TcpClient klient = new TcpClient(host, port);
                Info_o_polaczeniu.Items.Add("Nawiązano połączenie z" + host + "na porcie" + port);
                klient.Close();
            }
            catch(Exception ex)
            {
                Info_o_polaczeniu.Items.Add("Błąd: Nie udało się nawiązać połączenia!");
                MessageBox.Show(ex.ToString(), "Błąd");
            }
        }
    }
}
