
namespace CałkowanieNumeryczneMetodąSimsona
{
    partial class CałkowanieNumeryczneMetodąSimpsona
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bWynik = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tBPoczatek = new System.Windows.Forms.TextBox();
            this.tBKoniec = new System.Windows.Forms.TextBox();
            this.tBPodprzedzialy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lBWynik = new System.Windows.Forms.Label();
            this.tBx10 = new System.Windows.Forms.TextBox();
            this.tBx9 = new System.Windows.Forms.TextBox();
            this.tBx8 = new System.Windows.Forms.TextBox();
            this.tBx7 = new System.Windows.Forms.TextBox();
            this.tBx6 = new System.Windows.Forms.TextBox();
            this.tBx5 = new System.Windows.Forms.TextBox();
            this.tBx4 = new System.Windows.Forms.TextBox();
            this.tBx3 = new System.Windows.Forms.TextBox();
            this.tBx2 = new System.Windows.Forms.TextBox();
            this.tBx1 = new System.Windows.Forms.TextBox();
            this.tBwyrazWolny = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Początek przedziału całkowania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Koniec przedziału całkowania";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Liczba podprzedziałów";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Wprowadź współczynniki wielomianu:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(53, 231);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(966, 404);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // bWynik
            // 
            this.bWynik.Location = new System.Drawing.Point(962, 678);
            this.bWynik.Name = "bWynik";
            this.bWynik.Size = new System.Drawing.Size(83, 27);
            this.bWynik.TabIndex = 6;
            this.bWynik.Text = "Oblicz";
            this.bWynik.UseVisualStyleBackColor = true;
            this.bWynik.Click += new System.EventHandler(this.bWynik_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 657);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Wynik całkowania";
            // 
            // tBPoczatek
            // 
            this.tBPoczatek.Location = new System.Drawing.Point(274, 54);
            this.tBPoczatek.Name = "tBPoczatek";
            this.tBPoczatek.Size = new System.Drawing.Size(34, 20);
            this.tBPoczatek.TabIndex = 8;
            this.tBPoczatek.TextChanged += new System.EventHandler(this.tBPoczatek_TextChanged);
            // 
            // tBKoniec
            // 
            this.tBKoniec.Location = new System.Drawing.Point(274, 80);
            this.tBKoniec.Name = "tBKoniec";
            this.tBKoniec.Size = new System.Drawing.Size(34, 20);
            this.tBKoniec.TabIndex = 9;
            this.tBKoniec.TextChanged += new System.EventHandler(this.tBKoniec_TextChanged);
            // 
            // tBPodprzedzialy
            // 
            this.tBPodprzedzialy.Location = new System.Drawing.Point(274, 106);
            this.tBPodprzedzialy.Name = "tBPodprzedzialy";
            this.tBPodprzedzialy.Size = new System.Drawing.Size(34, 20);
            this.tBPodprzedzialy.TabIndex = 10;
            this.tBPodprzedzialy.TextChanged += new System.EventHandler(this.tBPodprzedzialy_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(59, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(735, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Całkowanie numeryczne metodą Simpsona - Jakub Matecki, Paweł Gunia, Kamil Kunowsk" +
    "i, Jakub Kokociński";
            // 
            // lBWynik
            // 
            this.lBWynik.AutoSize = true;
            this.lBWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lBWynik.Location = new System.Drawing.Point(204, 657);
            this.lBWynik.Name = "lBWynik";
            this.lBWynik.Size = new System.Drawing.Size(48, 31);
            this.lBWynik.TabIndex = 15;
            this.lBWynik.Text = "P=";
            this.lBWynik.Click += new System.EventHandler(this.lBWynik_Click);
            // 
            // tBx10
            // 
            this.tBx10.Location = new System.Drawing.Point(89, 174);
            this.tBx10.Name = "tBx10";
            this.tBx10.Size = new System.Drawing.Size(35, 20);
            this.tBx10.TabIndex = 16;
            this.tBx10.Text = "0";
            this.tBx10.TextChanged += new System.EventHandler(this.tBx10_TextChanged);
            // 
            // tBx9
            // 
            this.tBx9.Location = new System.Drawing.Point(166, 174);
            this.tBx9.Name = "tBx9";
            this.tBx9.Size = new System.Drawing.Size(35, 20);
            this.tBx9.TabIndex = 17;
            this.tBx9.Text = "0";
            this.tBx9.TextChanged += new System.EventHandler(this.tBx9_TextChanged);
            // 
            // tBx8
            // 
            this.tBx8.Location = new System.Drawing.Point(249, 174);
            this.tBx8.Name = "tBx8";
            this.tBx8.Size = new System.Drawing.Size(35, 20);
            this.tBx8.TabIndex = 18;
            this.tBx8.Text = "0";
            this.tBx8.TextChanged += new System.EventHandler(this.tBx8_TextChanged);
            // 
            // tBx7
            // 
            this.tBx7.Location = new System.Drawing.Point(332, 174);
            this.tBx7.Name = "tBx7";
            this.tBx7.Size = new System.Drawing.Size(35, 20);
            this.tBx7.TabIndex = 19;
            this.tBx7.Text = "0";
            this.tBx7.TextChanged += new System.EventHandler(this.tBx7_TextChanged);
            // 
            // tBx6
            // 
            this.tBx6.Location = new System.Drawing.Point(415, 174);
            this.tBx6.Name = "tBx6";
            this.tBx6.Size = new System.Drawing.Size(35, 20);
            this.tBx6.TabIndex = 20;
            this.tBx6.Text = "0";
            this.tBx6.TextChanged += new System.EventHandler(this.tBx6_TextChanged);
            // 
            // tBx5
            // 
            this.tBx5.Location = new System.Drawing.Point(498, 174);
            this.tBx5.Name = "tBx5";
            this.tBx5.Size = new System.Drawing.Size(35, 20);
            this.tBx5.TabIndex = 21;
            this.tBx5.Text = "0";
            this.tBx5.TextChanged += new System.EventHandler(this.tBx5_TextChanged);
            // 
            // tBx4
            // 
            this.tBx4.Location = new System.Drawing.Point(581, 174);
            this.tBx4.Name = "tBx4";
            this.tBx4.Size = new System.Drawing.Size(29, 20);
            this.tBx4.TabIndex = 22;
            this.tBx4.Text = "0";
            this.tBx4.TextChanged += new System.EventHandler(this.tBx4_TextChanged);
            // 
            // tBx3
            // 
            this.tBx3.Location = new System.Drawing.Point(658, 174);
            this.tBx3.Name = "tBx3";
            this.tBx3.Size = new System.Drawing.Size(29, 20);
            this.tBx3.TabIndex = 23;
            this.tBx3.Text = "0";
            this.tBx3.TextChanged += new System.EventHandler(this.tBx3_TextChanged);
            // 
            // tBx2
            // 
            this.tBx2.Location = new System.Drawing.Point(735, 174);
            this.tBx2.Name = "tBx2";
            this.tBx2.Size = new System.Drawing.Size(29, 20);
            this.tBx2.TabIndex = 24;
            this.tBx2.Text = "0";
            this.tBx2.TextChanged += new System.EventHandler(this.tBx2_TextChanged);
            // 
            // tBx1
            // 
            this.tBx1.Location = new System.Drawing.Point(812, 174);
            this.tBx1.Name = "tBx1";
            this.tBx1.Size = new System.Drawing.Size(29, 20);
            this.tBx1.TabIndex = 25;
            this.tBx1.Text = "0";
            this.tBx1.TextChanged += new System.EventHandler(this.tBx1_TextChanged);
            // 
            // tBwyrazWolny
            // 
            this.tBwyrazWolny.Location = new System.Drawing.Point(877, 174);
            this.tBwyrazWolny.Name = "tBwyrazWolny";
            this.tBwyrazWolny.Size = new System.Drawing.Size(29, 20);
            this.tBwyrazWolny.TabIndex = 26;
            this.tBwyrazWolny.Text = "0";
            this.tBwyrazWolny.TextChanged += new System.EventHandler(this.tBwyrazWolny_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "x^10 + ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(207, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "x^9 + ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(290, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "x^8 + ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(373, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "x^7 + ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(456, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "x^6 + ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(539, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "x^5 + ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(616, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "x^4 + ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(693, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "x^3 + ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(770, 177);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "x^2 + ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(847, 177);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "x + ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(50, 177);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 13);
            this.label18.TabIndex = 39;
            this.label18.Text = "f(x) = ";
            // 
            // CałkowanieNumeryczneMetodąSimpsona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 717);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tBwyrazWolny);
            this.Controls.Add(this.tBx1);
            this.Controls.Add(this.tBx2);
            this.Controls.Add(this.tBx3);
            this.Controls.Add(this.tBx4);
            this.Controls.Add(this.tBx5);
            this.Controls.Add(this.tBx6);
            this.Controls.Add(this.tBx7);
            this.Controls.Add(this.tBx8);
            this.Controls.Add(this.tBx9);
            this.Controls.Add(this.tBx10);
            this.Controls.Add(this.lBWynik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBPodprzedzialy);
            this.Controls.Add(this.tBKoniec);
            this.Controls.Add(this.tBPoczatek);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bWynik);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CałkowanieNumeryczneMetodąSimpsona";
            this.Text = "CałkowanieNumeryczneMetodąSimpsona";
            this.Load += new System.EventHandler(this.CałkowanieNumeryczneMetodąSimsona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button bWynik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBPoczatek;
        private System.Windows.Forms.TextBox tBKoniec;
        private System.Windows.Forms.TextBox tBPodprzedzialy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lBWynik;
        private System.Windows.Forms.TextBox tBx10;
        private System.Windows.Forms.TextBox tBx9;
        private System.Windows.Forms.TextBox tBx8;
        private System.Windows.Forms.TextBox tBx7;
        private System.Windows.Forms.TextBox tBx6;
        private System.Windows.Forms.TextBox tBx5;
        private System.Windows.Forms.TextBox tBx4;
        private System.Windows.Forms.TextBox tBx3;
        private System.Windows.Forms.TextBox tBx2;
        private System.Windows.Forms.TextBox tBx1;
        private System.Windows.Forms.TextBox tBwyrazWolny;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
    }
}

