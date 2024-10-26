using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Sistem_Yonetim
{
    public partial class Statistique : Form
    {

        static string connectionString = ConfigurationManager.ConnectionStrings["Personel_Sistem_Yonetim.Properties.Settings.connection"].ConnectionString;
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command;
        public Statistique()
        {
            InitializeComponent();
        }

           
       

        private void ControlExit_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            this.Close();
            form.Show();
        }

        private void btnGoRegistration_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            this.Close();
            form.Show();
            form.StartPosition = FormStartPosition.CenterScreen;
        }
        
        private int ToplamPersonelSayisi()
        {
            connection.Open();
            string query = $"Select count(*) from Personels";
            command = new SqlCommand(query, connection);
            int Count = (int)  command.ExecuteScalar();
            connection.Close();
            return Count;
        }
        private int EvliPersonelSayisi()
        {
            connection.Open();
            string query = $"Select count(*) from Personels where PersonelDurum=1";
            command = new SqlCommand(query, connection);    
            int Count = (int) command.ExecuteScalar();
            connection.Close();
            return Count;
        }
        private int SehirSayisi()
        {
            connection.Open();
            string query = $"Select count(distinct PersonelSehir) from Personels";
            command = new SqlCommand(query, connection);
            int Count = (int)command.ExecuteScalar();
            connection.Close();
            return Count;
        }
        private int ToplamMaas()
        {
            connection.Open();
            string query = $"Select Sum(PersonelMaas) from Personels";
            command = new SqlCommand(query, connection);
            int Count = (int)command.ExecuteScalar();
            connection.Close();
            return Count;
        }
        private int OrtalamaMaas()
        {
            connection.Open();
            string query = $"Select Avg(PersonelMaas) from Personels";
            command = new SqlCommand(query, connection);
            int Count = (int)command.ExecuteScalar();
            connection.Close();
            return Count;
        }
        private void Statistique_Load(object sender, EventArgs e)
        {
            lblToplamPersonel.Text = ToplamPersonelSayisi().ToString();
            lblEvliPersonel.Text = EvliPersonelSayisi().ToString();
            lblBekarPersonel.Text = (ToplamPersonelSayisi() - EvliPersonelSayisi()).ToString();
            lblSehirSayisi.Text = SehirSayisi().ToString();
            lblToplamMaas.Text = ToplamMaas().ToString();
            lblOrtalamaMaas.Text = OrtalamaMaas().ToString();
        }
    }
}
