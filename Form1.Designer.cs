namespace Personel_Sistem_Yonetim
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGrafik = new Guna.UI2.WinForms.Guna2Button();
            this.btnİstatistik = new Guna.UI2.WinForms.Guna2Button();
            this.btnTemizle = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuncel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSil = new Guna.UI2.WinForms.Guna2Button();
            this.btnKaydet = new Guna.UI2.WinForms.Guna2Button();
            this.btnListeler = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAd = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoyad = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboSehir = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtMeslek = new Guna.UI2.WinForms.Guna2TextBox();
            this.rdBekar = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdEvli = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txtMaas = new Guna.UI2.WinForms.Guna2TextBox();
            this.datagridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.personelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.personelMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSet = new Personel_Sistem_Yonetim.PersonelDataSet();
            this.personelsTableAdapter = new Personel_Sistem_Yonetim.PersonelDataSetTableAdapters.PersonelsTableAdapter();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tolListeler = new System.Windows.Forms.ToolTip(this.components);
            this.tolKaydet = new System.Windows.Forms.ToolTip(this.components);
            this.tolSil = new System.Windows.Forms.ToolTip(this.components);
            this.tolGuncel = new System.Windows.Forms.ToolTip(this.components);
            this.tolTemizle = new System.Windows.Forms.ToolTip(this.components);
            this.tolistatistik = new System.Windows.Forms.ToolTip(this.components);
            this.tolGrafik = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.btnGrafik);
            this.groupBox2.Controls.Add(this.btnİstatistik);
            this.groupBox2.Controls.Add(this.btnTemizle);
            this.groupBox2.Controls.Add(this.btnGuncel);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Controls.Add(this.btnListeler);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(555, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 607);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // btnGrafik
            // 
            this.btnGrafik.Animated = true;
            this.btnGrafik.BorderColor = System.Drawing.Color.Magenta;
            this.btnGrafik.BorderRadius = 10;
            this.btnGrafik.BorderThickness = 2;
            this.btnGrafik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrafik.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGrafik.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGrafik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGrafik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGrafik.FillColor = System.Drawing.Color.White;
            this.btnGrafik.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGrafik.ForeColor = System.Drawing.Color.Magenta;
            this.btnGrafik.HoverState.FillColor = System.Drawing.Color.MediumVioletRed;
            this.btnGrafik.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnGrafik.Image = global::Personel_Sistem_Yonetim.Properties.Resources.icons8_graph_80;
            this.btnGrafik.Location = new System.Drawing.Point(31, 496);
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.btnGrafik.Size = new System.Drawing.Size(318, 63);
            this.btnGrafik.TabIndex = 6;
            this.btnGrafik.Text = "Grafik";
            this.tolGrafik.SetToolTip(this.btnGrafik, "Grafikleri Görüntelle!");
            this.btnGrafik.Click += new System.EventHandler(this.btnGrafik_Click);
            // 
            // btnİstatistik
            // 
            this.btnİstatistik.Animated = true;
            this.btnİstatistik.BorderColor = System.Drawing.Color.Purple;
            this.btnİstatistik.BorderRadius = 10;
            this.btnİstatistik.BorderThickness = 2;
            this.btnİstatistik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnİstatistik.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnİstatistik.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnİstatistik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnİstatistik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnİstatistik.FillColor = System.Drawing.Color.White;
            this.btnİstatistik.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnİstatistik.ForeColor = System.Drawing.Color.Purple;
            this.btnİstatistik.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnİstatistik.HoverState.FillColor = System.Drawing.Color.Purple;
            this.btnİstatistik.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnİstatistik.Image = global::Personel_Sistem_Yonetim.Properties.Resources.icons8_statistic_64;
            this.btnİstatistik.Location = new System.Drawing.Point(31, 427);
            this.btnİstatistik.Name = "btnİstatistik";
            this.btnİstatistik.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.btnİstatistik.Size = new System.Drawing.Size(318, 63);
            this.btnİstatistik.TabIndex = 5;
            this.btnİstatistik.Text = "İstatistik";
            this.tolistatistik.SetToolTip(this.btnİstatistik, "İstatistikleri görüntelle!");
            this.btnİstatistik.Click += new System.EventHandler(this.btnİstatistik_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Animated = true;
            this.btnTemizle.BorderColor = System.Drawing.Color.Tomato;
            this.btnTemizle.BorderRadius = 10;
            this.btnTemizle.BorderThickness = 2;
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTemizle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTemizle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTemizle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTemizle.FillColor = System.Drawing.Color.White;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTemizle.ForeColor = System.Drawing.Color.Tomato;
            this.btnTemizle.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnTemizle.HoverState.FillColor = System.Drawing.Color.Tomato;
            this.btnTemizle.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Image = global::Personel_Sistem_Yonetim.Properties.Resources.icons8_reset_64;
            this.btnTemizle.Location = new System.Drawing.Point(31, 358);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.PressedColor = System.Drawing.Color.OrangeRed;
            this.btnTemizle.ShadowDecoration.Color = System.Drawing.Color.Tomato;
            this.btnTemizle.Size = new System.Drawing.Size(318, 63);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "Temizle";
            this.tolTemizle.SetToolTip(this.btnTemizle, "Temizle");
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGuncel
            // 
            this.btnGuncel.Animated = true;
            this.btnGuncel.BorderColor = System.Drawing.Color.Green;
            this.btnGuncel.BorderRadius = 10;
            this.btnGuncel.BorderThickness = 2;
            this.btnGuncel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuncel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuncel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuncel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuncel.FillColor = System.Drawing.Color.White;
            this.btnGuncel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGuncel.ForeColor = System.Drawing.Color.Green;
            this.btnGuncel.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnGuncel.HoverState.FillColor = System.Drawing.Color.Green;
            this.btnGuncel.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnGuncel.Image = global::Personel_Sistem_Yonetim.Properties.Resources.icons8_update_50;
            this.btnGuncel.Location = new System.Drawing.Point(31, 289);
            this.btnGuncel.Name = "btnGuncel";
            this.btnGuncel.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(254)))));
            this.btnGuncel.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.btnGuncel.Size = new System.Drawing.Size(318, 63);
            this.btnGuncel.TabIndex = 3;
            this.btnGuncel.Text = "Güncelle";
            this.tolGuncel.SetToolTip(this.btnGuncel, "Güncelle");
            this.btnGuncel.Click += new System.EventHandler(this.btnGuncel_Click);
            // 
            // btnSil
            // 
            this.btnSil.Animated = true;
            this.btnSil.BorderColor = System.Drawing.Color.Red;
            this.btnSil.BorderRadius = 10;
            this.btnSil.BorderThickness = 2;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSil.FillColor = System.Drawing.Color.White;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSil.ForeColor = System.Drawing.Color.Red;
            this.btnSil.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnSil.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnSil.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSil.Image = global::Personel_Sistem_Yonetim.Properties.Resources.icons8_delete_48;
            this.btnSil.Location = new System.Drawing.Point(31, 220);
            this.btnSil.Name = "btnSil";
            this.btnSil.ShadowDecoration.BorderRadius = 10;
            this.btnSil.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSil.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.btnSil.Size = new System.Drawing.Size(318, 63);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.tolSil.SetToolTip(this.btnSil, "Sil");
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Animated = true;
            this.btnKaydet.BorderColor = System.Drawing.Color.Teal;
            this.btnKaydet.BorderRadius = 10;
            this.btnKaydet.BorderThickness = 2;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKaydet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKaydet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKaydet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKaydet.FillColor = System.Drawing.Color.White;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.ForeColor = System.Drawing.Color.Teal;
            this.btnKaydet.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnKaydet.HoverState.FillColor = System.Drawing.Color.Teal;
            this.btnKaydet.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Image = global::Personel_Sistem_Yonetim.Properties.Resources.icons8_create_50;
            this.btnKaydet.Location = new System.Drawing.Point(31, 151);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.PressedColor = System.Drawing.Color.DarkCyan;
            this.btnKaydet.ShadowDecoration.Color = System.Drawing.Color.Teal;
            this.btnKaydet.Size = new System.Drawing.Size(318, 63);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.tolKaydet.SetToolTip(this.btnKaydet, "Kaydet");
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnListeler
            // 
            this.btnListeler.Animated = true;
            this.btnListeler.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnListeler.BorderRadius = 10;
            this.btnListeler.BorderThickness = 2;
            this.btnListeler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListeler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnListeler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnListeler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnListeler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnListeler.FillColor = System.Drawing.Color.White;
            this.btnListeler.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnListeler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnListeler.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnListeler.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnListeler.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnListeler.Image = global::Personel_Sistem_Yonetim.Properties.Resources.list;
            this.btnListeler.Location = new System.Drawing.Point(31, 82);
            this.btnListeler.Name = "btnListeler";
            this.btnListeler.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(254)))));
            this.btnListeler.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.btnListeler.Size = new System.Drawing.Size(318, 63);
            this.btnListeler.TabIndex = 0;
            this.btnListeler.Text = "Listeler";
            this.tolListeler.SetToolTip(this.btnListeler, "Listeler");
            this.btnListeler.Click += new System.EventHandler(this.btnListeler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel Ad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = " Soyad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şehir :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(113, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Maaş :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Durum :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(104, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Meslek :";
            // 
            // txtId
            // 
            this.txtId.BorderRadius = 5;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.DefaultText = "";
            this.txtId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.Location = new System.Drawing.Point(221, 40);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PlaceholderText = "";
            this.txtId.SelectedText = "";
            this.txtId.Size = new System.Drawing.Size(286, 51);
            this.txtId.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.BorderRadius = 5;
            this.txtAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAd.DefaultText = "";
            this.txtAd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAd.ForeColor = System.Drawing.Color.Black;
            this.txtAd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAd.Location = new System.Drawing.Point(221, 112);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAd.Name = "txtAd";
            this.txtAd.PasswordChar = '\0';
            this.txtAd.PlaceholderText = "";
            this.txtAd.SelectedText = "";
            this.txtAd.Size = new System.Drawing.Size(286, 51);
            this.txtAd.TabIndex = 7;
            // 
            // txtSoyad
            // 
            this.txtSoyad.BorderRadius = 5;
            this.txtSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoyad.DefaultText = "";
            this.txtSoyad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoyad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoyad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoyad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoyad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoyad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoyad.ForeColor = System.Drawing.Color.Black;
            this.txtSoyad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoyad.Location = new System.Drawing.Point(221, 183);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.PasswordChar = '\0';
            this.txtSoyad.PlaceholderText = "";
            this.txtSoyad.SelectedText = "";
            this.txtSoyad.Size = new System.Drawing.Size(286, 51);
            this.txtSoyad.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.comboSehir);
            this.groupBox1.Controls.Add(this.guna2Panel1);
            this.groupBox1.Controls.Add(this.txtMeslek);
            this.groupBox1.Controls.Add(this.rdBekar);
            this.groupBox1.Controls.Add(this.rdEvli);
            this.groupBox1.Controls.Add(this.txtMaas);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 607);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // comboSehir
            // 
            this.comboSehir.BackColor = System.Drawing.Color.Transparent;
            this.comboSehir.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSehir.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSehir.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSehir.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSehir.ForeColor = System.Drawing.Color.Black;
            this.comboSehir.ItemHeight = 30;
            this.comboSehir.Items.AddRange(new object[] {
            "İstanbul",
            "Kocaeli",
            "Ankara",
            "Konya",
            "Kayseri",
            "Samsun",
            "İzmir",
            "Bursa",
            "Gaziyantep",
            "Sakarya",
            "Antalya",
            "Balıkesir",
            "Trabzon",
            "Eskişehir",
            "Çannakale"});
            this.comboSehir.ItemsAppearance.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSehir.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.comboSehir.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Black;
            this.comboSehir.Location = new System.Drawing.Point(221, 269);
            this.comboSehir.MaximumSize = new System.Drawing.Size(300, 0);
            this.comboSehir.MinimumSize = new System.Drawing.Size(30, 0);
            this.comboSehir.Name = "comboSehir";
            this.comboSehir.Size = new System.Drawing.Size(286, 36);
            this.comboSehir.StartIndex = 0;
            this.comboSehir.TabIndex = 14;
            this.comboSehir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMeslek
            // 
            this.txtMeslek.BorderRadius = 4;
            this.txtMeslek.BorderThickness = 0;
            this.txtMeslek.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMeslek.DefaultText = "";
            this.txtMeslek.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMeslek.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMeslek.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMeslek.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMeslek.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMeslek.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeslek.ForeColor = System.Drawing.Color.Black;
            this.txtMeslek.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMeslek.Location = new System.Drawing.Point(221, 496);
            this.txtMeslek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.PasswordChar = '\0';
            this.txtMeslek.PlaceholderText = "";
            this.txtMeslek.SelectedText = "";
            this.txtMeslek.Size = new System.Drawing.Size(286, 51);
            this.txtMeslek.TabIndex = 13;
            // 
            // rdBekar
            // 
            this.rdBekar.AutoSize = true;
            this.rdBekar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rdBekar.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdBekar.CheckedState.BorderThickness = 0;
            this.rdBekar.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.rdBekar.CheckedState.InnerColor = System.Drawing.Color.Blue;
            this.rdBekar.CheckedState.InnerOffset = -4;
            this.rdBekar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.rdBekar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rdBekar.Location = new System.Drawing.Point(399, 427);
            this.rdBekar.Name = "rdBekar";
            this.rdBekar.Size = new System.Drawing.Size(93, 29);
            this.rdBekar.TabIndex = 12;
            this.rdBekar.Text = "Bekar";
            this.rdBekar.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.rdBekar.UncheckedState.BorderThickness = 2;
            this.rdBekar.UncheckedState.FillColor = System.Drawing.SystemColors.ActiveBorder;
            this.rdBekar.UncheckedState.InnerColor = System.Drawing.SystemColors.ActiveBorder;
            // 
            // rdEvli
            // 
            this.rdEvli.AutoSize = true;
            this.rdEvli.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rdEvli.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdEvli.CheckedState.BorderThickness = 0;
            this.rdEvli.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.rdEvli.CheckedState.InnerColor = System.Drawing.Color.Blue;
            this.rdEvli.CheckedState.InnerOffset = -4;
            this.rdEvli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.rdEvli.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rdEvli.Location = new System.Drawing.Point(230, 427);
            this.rdEvli.Name = "rdEvli";
            this.rdEvli.Size = new System.Drawing.Size(72, 29);
            this.rdEvli.TabIndex = 11;
            this.rdEvli.Text = "Evli";
            this.rdEvli.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.rdEvli.UncheckedState.BorderThickness = 2;
            this.rdEvli.UncheckedState.FillColor = System.Drawing.SystemColors.ActiveBorder;
            this.rdEvli.UncheckedState.InnerColor = System.Drawing.SystemColors.ActiveBorder;
            // 
            // txtMaas
            // 
            this.txtMaas.BorderRadius = 5;
            this.txtMaas.BorderThickness = 0;
            this.txtMaas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaas.DefaultText = "";
            this.txtMaas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaas.ForeColor = System.Drawing.Color.Black;
            this.txtMaas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaas.Location = new System.Drawing.Point(221, 342);
            this.txtMaas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.PasswordChar = '\0';
            this.txtMaas.PlaceholderText = "";
            this.txtMaas.SelectedText = "";
            this.txtMaas.Size = new System.Drawing.Size(286, 51);
            this.txtMaas.TabIndex = 10;
            // 
            // datagridView
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.datagridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.datagridView.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.datagridView.ColumnHeadersHeight = 42;
            this.datagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelIdDataGridViewTextBoxColumn,
            this.personelFirstNameDataGridViewTextBoxColumn,
            this.personelLastNameDataGridViewTextBoxColumn,
            this.personelSehirDataGridViewTextBoxColumn,
            this.personelMaasDataGridViewTextBoxColumn,
            this.personelDurumDataGridViewCheckBoxColumn,
            this.personelMeslekDataGridViewTextBoxColumn});
            this.datagridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datagridView.DataSource = this.personelsBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.datagridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datagridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.datagridView.Location = new System.Drawing.Point(0, 616);
            this.datagridView.Name = "datagridView";
            this.datagridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.datagridView.RowHeadersVisible = false;
            this.datagridView.RowHeadersWidth = 70;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Transparent;
            this.datagridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.datagridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.datagridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.datagridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.datagridView.RowTemplate.Height = 30;
            this.datagridView.Size = new System.Drawing.Size(1398, 284);
            this.datagridView.StandardTab = true;
            this.datagridView.TabIndex = 2;
            this.datagridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.datagridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.datagridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.datagridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.datagridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridView.ThemeStyle.HeaderStyle.Height = 42;
            this.datagridView.ThemeStyle.ReadOnly = true;
            this.datagridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.datagridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridView.ThemeStyle.RowsStyle.Height = 30;
            this.datagridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.datagridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datagridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridView_CellMouseDoubleClick);
            // 
            // personelIdDataGridViewTextBoxColumn
            // 
            this.personelIdDataGridViewTextBoxColumn.DataPropertyName = "PersonelId";
            this.personelIdDataGridViewTextBoxColumn.HeaderText = "PersonelId";
            this.personelIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.personelIdDataGridViewTextBoxColumn.Name = "personelIdDataGridViewTextBoxColumn";
            this.personelIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelFirstNameDataGridViewTextBoxColumn
            // 
            this.personelFirstNameDataGridViewTextBoxColumn.DataPropertyName = "PersonelFirstName";
            this.personelFirstNameDataGridViewTextBoxColumn.HeaderText = "PersonelFirstName";
            this.personelFirstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.personelFirstNameDataGridViewTextBoxColumn.Name = "personelFirstNameDataGridViewTextBoxColumn";
            this.personelFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelLastNameDataGridViewTextBoxColumn
            // 
            this.personelLastNameDataGridViewTextBoxColumn.DataPropertyName = "PersonelLastName";
            this.personelLastNameDataGridViewTextBoxColumn.HeaderText = "PersonelLastName";
            this.personelLastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.personelLastNameDataGridViewTextBoxColumn.Name = "personelLastNameDataGridViewTextBoxColumn";
            this.personelLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelSehirDataGridViewTextBoxColumn
            // 
            this.personelSehirDataGridViewTextBoxColumn.DataPropertyName = "PersonelSehir";
            this.personelSehirDataGridViewTextBoxColumn.HeaderText = "PersonelSehir";
            this.personelSehirDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.personelSehirDataGridViewTextBoxColumn.Name = "personelSehirDataGridViewTextBoxColumn";
            this.personelSehirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelMaasDataGridViewTextBoxColumn
            // 
            this.personelMaasDataGridViewTextBoxColumn.DataPropertyName = "PersonelMaas";
            this.personelMaasDataGridViewTextBoxColumn.HeaderText = "PersonelMaas";
            this.personelMaasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.personelMaasDataGridViewTextBoxColumn.Name = "personelMaasDataGridViewTextBoxColumn";
            this.personelMaasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelDurumDataGridViewCheckBoxColumn
            // 
            this.personelDurumDataGridViewCheckBoxColumn.DataPropertyName = "PersonelDurum";
            this.personelDurumDataGridViewCheckBoxColumn.HeaderText = "PersonelDurum";
            this.personelDurumDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.personelDurumDataGridViewCheckBoxColumn.Name = "personelDurumDataGridViewCheckBoxColumn";
            this.personelDurumDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // personelMeslekDataGridViewTextBoxColumn
            // 
            this.personelMeslekDataGridViewTextBoxColumn.DataPropertyName = "PersonelMeslek";
            this.personelMeslekDataGridViewTextBoxColumn.HeaderText = "PersonelMeslek";
            this.personelMeslekDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.personelMeslekDataGridViewTextBoxColumn.Name = "personelMeslekDataGridViewTextBoxColumn";
            this.personelMeslekDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelsBindingSource
            // 
            this.personelsBindingSource.DataMember = "Personels";
            this.personelsBindingSource.DataSource = this.personelDataSet;
            // 
            // personelDataSet
            // 
            this.personelDataSet.DataSetName = "PersonelDataSet";
            this.personelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelsTableAdapter
            // 
            this.personelsTableAdapter.ClearBeforeFill = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Location = new System.Drawing.Point(6, 613);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.guna2Panel1.Size = new System.Drawing.Size(1392, 205);
            this.guna2Panel1.TabIndex = 3;
            // 
            // tolListeler
            // 
            this.tolListeler.BackColor = System.Drawing.SystemColors.Highlight;
            this.tolListeler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tolListeler.IsBalloon = true;
            this.tolListeler.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tolListeler.ToolTipTitle = "Listeler";
            // 
            // tolKaydet
            // 
            this.tolKaydet.BackColor = System.Drawing.Color.Blue;
            this.tolKaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tolKaydet.IsBalloon = true;
            this.tolKaydet.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tolKaydet.ToolTipTitle = "Kaydet";
            // 
            // tolSil
            // 
            this.tolSil.IsBalloon = true;
            this.tolSil.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.tolSil.ToolTipTitle = "Sil";
            // 
            // tolGuncel
            // 
            this.tolGuncel.IsBalloon = true;
            this.tolGuncel.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tolGuncel.ToolTipTitle = "Güncelle";
            // 
            // tolTemizle
            // 
            this.tolTemizle.IsBalloon = true;
            this.tolTemizle.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.tolTemizle.ToolTipTitle = "Temizle";
            // 
            // tolistatistik
            // 
            this.tolistatistik.IsBalloon = true;
            this.tolistatistik.ToolTipTitle = "İstatistik";
            // 
            // tolGrafik
            // 
            this.tolGrafik.IsBalloon = true;
            this.tolGrafik.ToolTipTitle = "GRAFİK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(948, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 607);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1398, 900);
            this.Controls.Add(this.datagridView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Button btnListeler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtId;
        private Guna.UI2.WinForms.Guna2TextBox txtAd;
        private Guna.UI2.WinForms.Guna2TextBox txtSoyad;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2RadioButton rdEvli;
        private Guna.UI2.WinForms.Guna2TextBox txtMaas;
        private Guna.UI2.WinForms.Guna2RadioButton rdBekar;
        private Guna.UI2.WinForms.Guna2TextBox txtMeslek;
        private Guna.UI2.WinForms.Guna2Button btnKaydet;
        private Guna.UI2.WinForms.Guna2Button btnSil;
        private Guna.UI2.WinForms.Guna2Button btnİstatistik;
        private Guna.UI2.WinForms.Guna2Button btnTemizle;
        private Guna.UI2.WinForms.Guna2Button btnGuncel;
        private Guna.UI2.WinForms.Guna2Button btnGrafik;
        private Guna.UI2.WinForms.Guna2DataGridView datagridView;
        private PersonelDataSet personelDataSet;
        private System.Windows.Forms.BindingSource personelsBindingSource;
        private PersonelDataSetTableAdapters.PersonelsTableAdapter personelsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn personelDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelMeslekDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox comboSehir;
        private System.Windows.Forms.ToolTip tolListeler;
        private System.Windows.Forms.ToolTip tolKaydet;
        private System.Windows.Forms.ToolTip tolSil;
        private System.Windows.Forms.ToolTip tolGuncel;
        private System.Windows.Forms.ToolTip tolistatistik;
        private System.Windows.Forms.ToolTip tolTemizle;
        private System.Windows.Forms.ToolTip tolGrafik;
    }
}

