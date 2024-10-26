using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Sistem_Yonetim
{
    public partial class Grafique : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["Personel_Sistem_Yonetim.Properties.Settings.connection"].ConnectionString;
        SqlConnection connection= new SqlConnection(connectionString);
        SqlCommand command;
        SqlDataReader reader;
        public Grafique()
        {
            InitializeComponent();
        }

        private void ControlExit_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.Show();
            this.Close();
            form.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnGoRegistration_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.Show();
            this.Close();
            form.StartPosition = FormStartPosition.CenterScreen;
        }
        private void  Sehirler()
        {
            connection.Open();
            string query = $"select PersonelSehir, count(PersonelSehir)  from Personels Group by PersonelSehir";
            command = new SqlCommand(query, connection);
            reader =  command.ExecuteReader();
            while (reader.Read())
            {
                chartSehir.Series["Şehirler"].Points.AddXY(reader[0],reader[1]);
            }
            connection.Close();
        }
        private void MeslekMaas()
        {
            connection.Open();
            string query = $"select PersonelMeslek, AVG(PersonelMaas) from Personels Group by PersonelMeslek";
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                chartMeslekMaas.Series["Meslek Maaş"].Points.AddXY(reader[0], reader[1]);
            }
            connection.Close();
        }

        private void Grafique_Load(object sender, EventArgs e)
        {
            Sehirler();
            MeslekMaas();
        }
    }
}
