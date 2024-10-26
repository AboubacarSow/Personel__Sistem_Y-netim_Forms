using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading;
using System.Collections.Generic;
using System.Linq;


namespace Personel_Sistem_Yonetim
{
    public partial class Form1 : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["Personel_Sistem_Yonetim.Properties.Settings.connection"].ConnectionString;
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.personelsTableAdapter.Fill(this.personelDataSet.Personels);
        }
        private void btnListeler_Click(object sender, EventArgs e)
        {
            this.personelsTableAdapter.Fill(this.personelDataSet.Personels);
       
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            connection.Open();
            bool durum = (rdEvli.Checked) ? true : false;
            string colonne = "PersonelFirstName,PersonelLastName,PersonelSehir,PersonelMaas,PersonelDurum,PersonelMeslek";
            string query = $"insert into Personels ({colonne}) values(@p1,@p2,@p3,@p4,@p5,@p6)";
            CommandeExecuter(durum, query);
            connection.Close();
            MessageBox.Show("Kayıt başarılı!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CommandeExecuter(bool durum, string query)
        {
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@p1", txtAd.Text);
            command.Parameters.AddWithValue("@p2", txtSoyad.Text);
            command.Parameters.AddWithValue("@p3", comboSehir.SelectedItem.ToString());
            command.Parameters.AddWithValue("@p4", Convert.ToInt16(txtMaas.Text));
            command.Parameters.AddWithValue("@p5", durum);
            command.Parameters.AddWithValue("@p6", txtMeslek.Text);
            command.ExecuteNonQuery();
        }
       
        private void btnSil_Click(object sender, EventArgs e)
        {
            int value = (int)datagridView.CurrentRow.Cells[0].Value;

            string query = $"delete from Personels where PersonelId ={value}";
            DialogResult result= MessageBox.Show("Bu işlem yapmayi emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result.Equals(DialogResult.Yes))
            {
               connection.Open();
               command = new SqlCommand(query, connection);
               command.ExecuteNonQuery();
               connection.Close();
               Thread.Sleep(1000);
               MessageBox.Show("İşlem Basırılı!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public bool Verification( bool durum)
        {
            var values = new List<string>();
            values.Add(txtAd.Text);
            values.Add(txtSoyad.Text);
            values.Add(comboSehir.SelectedItem.ToString());
            values.Add(txtMaas.Text);
            values.Add(txtMeslek.Text);
            values.Add(durum.ToString());
            if(values.Any(value=> value=="" || value==null))
                return false;
            return true;
        }
        private void btnGuncel_Click(object sender, EventArgs e)
        {
                bool durum = (rdEvli.Checked) ? true : false;
            if (Verification(durum))
            {

                DialogResult result = MessageBox.Show("Bu işlem yapmayi emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result.Equals(DialogResult.Yes))
                {
                    int value = (int)datagridView.CurrentRow.Cells[0].Value;
                    connection.Open();  
                    string query = $"update Personels set PersonelFirstName =@p1,PersonelLastName =@p2,PersonelSehir =@p3,PersonelMaas=@p4,PersonelDurum=@p5, PersonelMeslek=@p6 where PersonelId={value}";
                    CommandeExecuter(durum, query);
                    connection.Close();
                    MessageBox.Show("Kayıt Güncellendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Bütün alanları doldurmadınız!", "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void datagridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtId.Text = datagridView.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = (string)datagridView.CurrentRow.Cells[1].Value;
            txtSoyad.Text = (string)datagridView.CurrentRow.Cells[2].Value;
            comboSehir.StartIndex = comboSehir.Items.IndexOf(datagridView.CurrentRow.Cells[3].Value);
            txtMaas.Text = datagridView.CurrentRow.Cells[4].Value.ToString();
            if((bool)datagridView.CurrentRow.Cells[5].Value)
            {
                
              rdEvli.Checked = (bool)datagridView.CurrentRow.Cells[5].Value;
              
            }
            else
            {
              rdBekar.Checked =!(bool)datagridView.CurrentRow.Cells[5].Value;

            }
            txtMeslek.Text = (string)datagridView.CurrentRow.Cells[6].Value;
            
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtId.Text= String.Empty;
            txtAd.Text = String.Empty;
            txtSoyad.Text = String.Empty;
            comboSehir.StartIndex= -1;
            txtMaas.Text = String.Empty;    
            txtMeslek.Text = String.Empty;
            rdEvli.Checked = false;
            rdBekar.Checked = false;
        }
        private void btnİstatistik_Click(object sender, EventArgs e)
        {
            Form form = new Statistique();
            form.Show();
            form.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            Grafique graph= new Grafique();
            this.Hide();
            graph.Show();   
        }
    }
}
