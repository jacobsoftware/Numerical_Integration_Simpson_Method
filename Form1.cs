using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Text.RegularExpressions;

// Całkowanie numeryczne metodą Simpsona - Jakub Matecki, Paweł Gunia, Kamil Kunowski, Jakub Kokociński
namespace CałkowanieNumeryczneMetodąSimsona
{
    public partial class CałkowanieNumeryczneMetodąSimpsona : Form
    {   //inicjowanie zmiennych globalnych
        double xKoniec, xPoczatek, wartoscCalki, sumaFunkcji, dx, x;
        int N;
        double[] wspolczynniki = new double[11] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        
        public CałkowanieNumeryczneMetodąSimpsona()
        {
            InitializeComponent();
        }
        public void RozkodujWspolczynniki()//zamiana parametrów z string na double
        {
            wspolczynniki[0] = double.Parse(tBx10.Text, System.Globalization.CultureInfo.InvariantCulture);
            wspolczynniki[1] = double.Parse(tBx9.Text, System.Globalization.CultureInfo.InvariantCulture);
            wspolczynniki[2] = double.Parse(tBx8.Text, System.Globalization.CultureInfo.InvariantCulture);
            wspolczynniki[3] = double.Parse(tBx7.Text, System.Globalization.CultureInfo.InvariantCulture);
            wspolczynniki[4] = double.Parse(tBx6.Text, System.Globalization.CultureInfo.InvariantCulture);
            wspolczynniki[5] = double.Parse(tBx5.Text, System.Globalization.CultureInfo.InvariantCulture);
            wspolczynniki[6] = double.Parse(tBx4.Text, System.Globalization.CultureInfo.InvariantCulture);
            wspolczynniki[7] = double.Parse(tBx3.Text, System.Globalization.CultureInfo.InvariantCulture);
            wspolczynniki[8] = double.Parse(tBx2.Text, System.Globalization.CultureInfo.InvariantCulture);
            wspolczynniki[9] = double.Parse(tBx1.Text, System.Globalization.CultureInfo.InvariantCulture);
            wspolczynniki[10] = double.Parse(tBwyrazWolny.Text, System.Globalization.CultureInfo.InvariantCulture);
            xKoniec = double.Parse(tBKoniec.Text, System.Globalization.CultureInfo.InvariantCulture);
            xPoczatek = double.Parse(tBPoczatek.Text, System.Globalization.CultureInfo.InvariantCulture);
        }
        public double funkcja(double x)//wartosc funkcji wielomianu, która wprowadził użytkownik
        {
            double wynik = (wspolczynniki[0] * Math.Pow(x, 10)) + (wspolczynniki[1] * Math.Pow(x, 9)) + (wspolczynniki[2] * Math.Pow(x, 8)) +
                (wspolczynniki[3] * Math.Pow(x, 7)) + (wspolczynniki[4] * Math.Pow(x, 6)) + (wspolczynniki[5] * Math.Pow(x, 5)) +
                (wspolczynniki[6] * Math.Pow(x, 4)) + (wspolczynniki[7] * Math.Pow(x, 3)) + (wspolczynniki[8] * Math.Pow(x, 2)) +
                (wspolczynniki[9] * x) + (wspolczynniki[10]);
            return wynik;
        }
        public void Oblicz()//całkowanie numeryczne za pomocą metody Simpsona
        {

            N = int.Parse(tBPodprzedzialy.Text);
            wartoscCalki = 0;
            sumaFunkcji = 0;
            //dzielenie podprzedziałów na równe wartości
            dx = (xKoniec - xPoczatek) / N;
            for(int i=1;i<=N;i++)
            {
                //wyznaczanie wartości x dla funkcji wprowadzonej przez użytkownika
                x = xPoczatek + (i * dx);
                //
                sumaFunkcji = sumaFunkcji + funkcja(x - dx / 2);
                if (i < N)
                    wartoscCalki = wartoscCalki + funkcja(x);
            }
            //suma n-tych elementów 
            wartoscCalki = dx / 6 * (funkcja(xPoczatek) + funkcja(xKoniec) + 2 * wartoscCalki + 4 * sumaFunkcji);
            
        }

        public Boolean Regexp(string formula, TextBox tb)//funkcja regex odpowiedzialna za sprawdzanie
                                                         //czy uzytkownik wprowadzil prawidlowe wartosci
        {
            bool blad = false;
            Regex regex = new Regex(formula);
            if(regex.IsMatch(tb.Text))
            {
                tb.ForeColor = Color.Black;
            }
            else
            {
                tb.ForeColor = Color.Red;
                blad = true;
            }
            return blad;
        }

            private void bWynik_Click(object sender, EventArgs e)//wykonanie wszystkich metod
        {
            bool wystapilBlad = false;
            // [=]? - moze istniec znak na początku
            //[0-9]* zero lub więcej cyfr z danego zakresu
            // [.]? może wystapić kropka, ale nie przecinek
            //[0-9]+ przynajmniej jedno wystąpienie cyfry z danego zakresu 
            if(Regexp(@"^[-]?([0-9]*[.]?[0-9]+|[0-9]+[.]?[0-9]*)$", tBKoniec))wystapilBlad = true;
            if(Regexp(@"^[-]?([0-9]*[.]?[0-9]+|[0-9]+[.]?[0-9]*)$", tBPoczatek)) wystapilBlad = true;
            if (Regexp(@"^\d+$", tBPodprzedzialy))  wystapilBlad = true;
            if (Regexp(@"^[-]?([0-9]*[.]?[0-9]+|[0-9]+[.]?[0-9]*)$", tBx10)) wystapilBlad = true;
            if (Regexp(@"^[-]?([0-9]*[.]?[0-9]+|[0-9]+[.]?[0-9]*)$", tBx9)) wystapilBlad = true;
            if (Regexp(@"^[-]?([0-9]*[.]?[0-9]+|[0-9]+[.]?[0-9]*)$", tBx8)) wystapilBlad = true;
            if (Regexp(@"^[-]?([0-9]*[.]?[0-9]+|[0-9]+[.]?[0-9]*)$", tBx7)) wystapilBlad = true;
            if (Regexp(@"^[-]?([0-9]*[.]?[0-9]+|[0-9]+[.]?[0-9]*)$", tBx6)) wystapilBlad = true;
            if (Regexp(@"^[-]?([0-9]*[.]?[0-9]+|[0-9]+[.]?[0-9]*)$", tBx5)) wystapilBlad = true;
            if (Regexp(@"^[-]?([0-9]*[.]?[0-9]+|[0-9]+[.]?[0-9]*)$", tBx4)) wystapilBlad = true;
            if (Regexp(@"^[-]?([0-9]*[.]?[0-9]+|[0-9]+[.]?[0-9]*)$", tBx3)) wystapilBlad = true;
            if (Regexp(@"^[-]?([0-9]*[.]?[0-9]+|[0-9]+[.]?[0-9]*)$", tBx2)) wystapilBlad = true;
            if (Regexp(@"^[-]?([0-9]*[.]?[0-9]+|[0-9]+[.]?[0-9]*)$", tBx1)) wystapilBlad = true;
            if (Regexp(@"^[-]?([0-9]*[.]?[0-9]+|[0-9]+[.]?[0-9]*)$", tBwyrazWolny)) wystapilBlad = true;
            if( wystapilBlad == false)
            {
                RozkodujWspolczynniki();
                if (xKoniec > xPoczatek) 
                {
                    Oblicz();
                    lBWynik.Text = "P= " + wartoscCalki.ToString();
                    Rysuj();
                }
                else
                {
                    MessageBox.Show("Początek przedziału nie może być większy od jego końca.");
                }
            }
            else
            {
                MessageBox.Show("Wprowadziłeś błędne wartości.");
            }
                    
        }
        public void Rysuj()//metoda odpowiedzialna za wyrysowanie funkcji podcałkowej na wykresie 
        {
            //jeśli mamy więcej niż 9 podprzedziałów
            double[] punktyX = new double[N+1];
            double[] punktyY = new double[N + 1];
            punktyX[0] = xPoczatek;
            punktyX[N] = xKoniec;
            //jeśli mamy mniej niż 10
            double[] punktyX2 = new double[20];
            double[] punktyY2 = new double[20];
            //dx = (xKoniec - xPoczatek) / N;
            for (int i=1;i<N;i++)
            {
                punktyX[i] = punktyX[i - 1] + dx;
            }
            for(int i=0;i<N+1; i++)
            {
                punktyY[i] = funkcja(punktyX[i]);
            }


             punktyX2[0] = xPoczatek;
             punktyX2[19] = xKoniec;
             double zakres = (xKoniec-xPoczatek)/20;        
             for (int i = 1; i < 19; i++)
             {
                punktyX2[i] = punktyX2[i - 1] + zakres;
             }
             for (int i = 0; i < 20; i++)
             {
                punktyY2[i] = funkcja(punktyX2[i]);

             }
            double[] srodekPodprzedzialuX = new double[N];
            double[] srodekPodprzedzialuY = new double[N];
            for(int i=0;i<N;i++)
            {
                srodekPodprzedzialuX[i] = punktyX[i] + ((punktyX[i + 1] - punktyX[i])/2);
            }
            for(int i=0;i<N;i++)
            {
                srodekPodprzedzialuY[i] = funkcja(srodekPodprzedzialuX[i]);
            }
            chart1.Series.Clear();
            chart1.Series.Add("f(x)");
            chart1.Series.Add("punkty podprzedziału");
            chart1.Series["punkty podprzedziału"].ChartType = SeriesChartType.Point;
            chart1.Series["punkty podprzedziału"].Color = Color.Blue;
            chart1.Series["f(x)"].ChartType = SeriesChartType.Line;
            chart1.Titles.Clear();
            chart1.Titles.Add("Wykres funkcji f(x) wprowadzonej przez użytkownika");
            chart1.ChartAreas[0].AxisX.Title = "x";
            chart1.ChartAreas[0].AxisY.Title = "y";
            chart1.Series["f(x)"].Color = Color.Red;
            chart1.Series.Add("środek podprzedziału");
            chart1.Series["środek podprzedziału"].ChartType = SeriesChartType.Point;
            chart1.Series["środek podprzedziału"].Color = Color.Green;

            for (int i = 0; i < 20; i++)
            {
                chart1.Series["f(x)"].Points.AddXY(punktyX2[i], punktyY2[i]);
            }

            for (int i = 0; i < N + 1; i++)
            {
                chart1.Series["punkty podprzedziału"].Points.AddXY(punktyX[i], punktyY[i]);

            }
            for(int i=0;i<N;i++)
            {
                chart1.Series["środek podprzedziału"].Points.AddXY(srodekPodprzedzialuX[i], srodekPodprzedzialuY[i]);
            }

            
        }

        private void tBPodprzedzialy_TextChanged(object sender, EventArgs e)
        {
            tBPodprzedzialy.ForeColor = Color.Black;
        }

        private void tBx10_TextChanged(object sender, EventArgs e)
        {
            tBx10.ForeColor = Color.Black;
        }

        private void tBx9_TextChanged(object sender, EventArgs e)
        {
            tBx9.ForeColor = Color.Black;
        }

        private void tBx8_TextChanged(object sender, EventArgs e)
        {
            tBx8.ForeColor = Color.Black;
        }

        private void tBx7_TextChanged(object sender, EventArgs e)
        {
            tBx7.ForeColor = Color.Black;
        }

        private void tBx6_TextChanged(object sender, EventArgs e)
        {
            tBx6.ForeColor = Color.Black;
        }

        private void tBx5_TextChanged(object sender, EventArgs e)
        {
            tBx5.ForeColor = Color.Black;
        }

        private void tBx4_TextChanged(object sender, EventArgs e)
        {
            tBx4.ForeColor = Color.Black;
        }

        private void tBx3_TextChanged(object sender, EventArgs e)
        {
            tBx3.ForeColor = Color.Black;
        }

        private void tBx2_TextChanged(object sender, EventArgs e)
        {
            tBx2.ForeColor = Color.Black;
        }

        private void tBx1_TextChanged(object sender, EventArgs e)
        {
            tBx1.ForeColor = Color.Black;
        }

        private void tBwyrazWolny_TextChanged(object sender, EventArgs e)
        {
            tBwyrazWolny.ForeColor = Color.Black;
        }

        private void lBWynik_Click(object sender, EventArgs e)
        {

        }

        private void CałkowanieNumeryczneMetodąSimsona_Load(object sender, EventArgs e)
        {

        }


        private void tBPoczatek_TextChanged(object sender, EventArgs e)
        {
            tBPoczatek.ForeColor = Color.Black;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tBKoniec_TextChanged(object sender, EventArgs e)
        {
            tBKoniec.ForeColor = Color.Black;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


    }
}
