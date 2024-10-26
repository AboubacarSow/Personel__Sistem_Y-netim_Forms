namespace Personel_Sistem_Yonetim
{
    partial class Grafique
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartSehir = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMeslekMaas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ControlExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnGoRegistration = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartSehir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMeslekMaas)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSehir
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSehir.ChartAreas.Add(chartArea1);
            this.chartSehir.Cursor = System.Windows.Forms.Cursors.Hand;
            legend1.BackColor = System.Drawing.Color.White;
            legend1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartSehir.Legends.Add(legend1);
            this.chartSehir.Location = new System.Drawing.Point(12, 77);
            this.chartSehir.Name = "chartSehir";
            this.chartSehir.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Legend = "Legend1";
            series1.Name = "Şehirler";
            this.chartSehir.Series.Add(series1);
            this.chartSehir.Size = new System.Drawing.Size(489, 327);
            this.chartSehir.TabIndex = 0;
            this.chartSehir.Text = "Şehirler";
            // 
            // chartMeslekMaas
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMeslekMaas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMeslekMaas.Legends.Add(legend2);
            this.chartMeslekMaas.Location = new System.Drawing.Point(606, 77);
            this.chartMeslekMaas.Name = "chartMeslekMaas";
            this.chartMeslekMaas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.Legend = "Legend1";
            series2.Name = "Meslek Maaş";
            this.chartMeslekMaas.Series.Add(series2);
            this.chartMeslekMaas.Size = new System.Drawing.Size(489, 327);
            this.chartMeslekMaas.TabIndex = 1;
            this.chartMeslekMaas.Text = "chart2";
            // 
            // ControlExit
            // 
            this.ControlExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlExit.BackColor = System.Drawing.SystemColors.Control;
            this.ControlExit.BorderRadius = 8;
            this.ControlExit.FillColor = System.Drawing.Color.Red;
            this.ControlExit.IconColor = System.Drawing.Color.White;
            this.ControlExit.Location = new System.Drawing.Point(1039, 12);
            this.ControlExit.Name = "ControlExit";
            this.ControlExit.Size = new System.Drawing.Size(69, 29);
            this.ControlExit.TabIndex = 7;
            // 
            // btnGoRegistration
            // 
            this.btnGoRegistration.Animated = true;
            this.btnGoRegistration.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGoRegistration.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnGoRegistration.BorderRadius = 15;
            this.btnGoRegistration.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGoRegistration.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGoRegistration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGoRegistration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGoRegistration.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold);
            this.btnGoRegistration.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGoRegistration.Location = new System.Drawing.Point(935, 12);
            this.btnGoRegistration.Name = "btnGoRegistration";
            this.btnGoRegistration.Size = new System.Drawing.Size(76, 29);
            this.btnGoRegistration.TabIndex = 6;
            this.btnGoRegistration.Text = "Back";
            this.btnGoRegistration.Click += new System.EventHandler(this.btnGoRegistration_Click);
            // 
            // Grafique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1153, 487);
            this.Controls.Add(this.ControlExit);
            this.Controls.Add(this.btnGoRegistration);
            this.Controls.Add(this.chartMeslekMaas);
            this.Controls.Add(this.chartSehir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1420, 581);
            this.Name = "Grafique";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafique";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Grafique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSehir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMeslekMaas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSehir;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMeslekMaas;
        private Guna.UI2.WinForms.Guna2ControlBox ControlExit;
        private Guna.UI2.WinForms.Guna2Button btnGoRegistration;
    }
}