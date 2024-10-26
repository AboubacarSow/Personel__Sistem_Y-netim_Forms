using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Sistem_Yonetim
{
    public partial class AdminPaneli : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["Personel_Sistem_Yonetim.Properties.Settings.connection"].ConnectionString;
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command;
        public AdminPaneli()
        {
            InitializeComponent();
        }
        public bool Verifchamp()
        {
            var values = new List<string>();
            values.Add(txtKullanıcıAdı.Text);
            values.Add(txtSifre.Text);
            if (values.Any(value => value == "" || value == null))
                return false;
            return true;
        }
        private bool verification()
        {
            if(Verifchamp())
            {
                connection.Open();
                string query = $"select * from YetkiliPersonels where UserName=@p and Password=@p1";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@p",txtKullanıcıAdı.Text);
                command.Parameters.AddWithValue("@p1", txtSifre.Text);
                SqlDataReader reader = command.ExecuteReader();
                bool result =reader.Read();
                return result;
            }
            else
            {
                MessageBox.Show("Bütün alanları doldurmadınız!", "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(verification())
            {
              Form1 form= new Form1();    
              this.Hide();
              form.Show();

            }
        }
        private void txtKullanıcıAdı_Enter(object sender, EventArgs e)
        {
            txtKullanıcıAdı.FillColor=Color.White;
            txtKullanıcıAdı.BorderColor=Color.DarkGray;
            txtKullanıcıAdı.ForeColor = Color.Black;
            txtKullanıcıAdı.TextAlign = HorizontalAlignment.Left;
            txtKullanıcıAdı.BorderThickness=2;

        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            txtSifre.FillColor=Color.White;
            txtSifre.BorderColor = Color.DarkGray;
            txtSifre.ForeColor = Color.Black;
            txtSifre.TextAlign = HorizontalAlignment.Left;
            txtSifre.BorderThickness = 2;

        }
    }
}
