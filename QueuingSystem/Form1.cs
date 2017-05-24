using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingSystem {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        static Random rnd = new Random();
        private void radioChanged()
        {
            if (radioButton1.Checked)
            {
                R1TextBox.Visible = false;
                R2TextBox.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
            }
            else if (radioButton2.Checked)
            {
                R1TextBox.Visible = true;
                R2TextBox.Visible = false;
                label7.Visible = true;
                label8.Visible = false;
            }
            else if (radioButton3.Checked)
            {
                R1TextBox.Visible = false;
                R2TextBox.Visible = true;
                label7.Visible = false;
                label8.Visible = true;
            }
            else if (radioButton4.Checked)
            {
                R1TextBox.Visible = true;
                R2TextBox.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
            }
        }
        

        private static double theory(double ro, int m) {
            if(ro > 0.99 && ro < 1.01) {
                ro = 1.01;
            }
            double n_queue = (Math.Pow(ro, 2) * (1 - (Math.Pow(ro, m) * (m + 1 - (m * ro))))) / ((1 - ro) * (1 - Math.Pow(ro, m + 2)));
            double n_service;
            if(m == 0) {
                m = 1;
                n_service = (ro - Math.Pow(ro, m + 1)) / (1 - Math.Pow(ro, m + 1));
            } else {
                n_service = (ro - Math.Pow(ro, m + 1)) / (1 - Math.Pow(ro, m + 1));
            }
            return n_queue + n_service;
        }

        private static double[] poissonExperiment(double lambda, int mu, int m, int R1, int R2, int n, int period) {
            double[] result = new double[2];
            if(lambda == 0) {
                result[0] = 0;
                result[1] = 0;
            } else {
                int N = 0;
                double N_average = 0;
                double t1 = 0, t2 = 1;
                double[] deviation = new double[n / period + 1];

                result[0] = 0;
                result[1] = 0;
                int i = 0;
                int n_i = 0;
                do {
                    if(t1 < t2) {
                        if(n_i % period == 0) {
                            N_average = N_average + N;
                            deviation[i] = N;
                            i++;
                        }
                        if(N == 0) {
                            t2 = poissonRand(mu, R2);
                        } else {
                            t2 = t2 - t1;
                        }
                        if(N <= m) {
                            N = N + 1;
                        }
                        t1 = poissonRand(lambda, R1);
                        n_i++;
                    } else {
                        N = N - 1;
                        if(N == 0) {
                            t1 = 0;
                            t2 = 1;
                        } else {
                            t1 = t1 - t2;
                            t2 = poissonRand(mu, R2);
                        }
                    }
                } while(n_i <= n);
                N_average = N_average / (n / period);
                result[0] = N_average;
                double S = 0;
                for(i = 0; i <= n / period; i++) {
                    S = S + Math.Pow(deviation[i] - N_average, 2);
                }
                S = Math.Sqrt(S / ((n / period + 1) - 1));
                result[1] = S;
            }
            return result;
        }

        private static double poissonRand(double a, int R) {
            double result = 0;
            for(int i = 0; i < R; i++) {
                result = result - (Math.Log(rnd.NextDouble()) / a);
            }
            return result / R;
        }

        private void start_btn_Click(object sender, EventArgs e) {

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            
            int m = Convert.ToInt32(mTextBox.Text); // Количество мест в очереди
            int ro_max = Convert.ToInt32(roTextBox.Text); // Максимальная нагрузка
            int mu = Convert.ToInt32(muTextBox.Text); // Интенсивность потока обслуживания
            int n = Convert.ToInt32(nTextBox.Text); // Кол-во заявок
            int period = n / Convert.ToInt32(periodTextBox.Text); // Периодичность
            double step = Convert.ToDouble(stepTextBox.Text); // Шаг по lambda (ro)

            int lambda = ro_max; // Входящий поток заявок на обслуживание
            double[] n_array = new double[2];

            for(double ro = 0; ro <= ro_max; ro += step) {
                // Теория
                
                chart1.Series[0].Points.AddXY(ro, theory(ro, m));

                // Эксперимент

                if (radioButton1.Checked) {
                    n_array = poissonExperiment(ro, mu, m, 1, 1, n, period);
                } else if(radioButton2.Checked) {
                    int R1 = Convert.ToInt32(R1TextBox.Text);
                    n_array = poissonExperiment(ro, mu, m, R1, 1, n, period);
                } else if(radioButton3.Checked) {
                    int R2 = Convert.ToInt32(R2TextBox.Text);
                    n_array = poissonExperiment(ro, mu, m, 1, R2, n, period);
                } else if(radioButton4.Checked) {
                    int R1 = Convert.ToInt32(R1TextBox.Text);
                    int R2 = Convert.ToInt32(R2TextBox.Text);
                    n_array = poissonExperiment(ro, mu, m, R1, R2, n, period);
                }
                chart1.Series[1].Points.AddXY(ro, n_array[0]); // Линия эксперимента
                chart1.Series[2].Points.AddXY(ro, n_array[1]); // Линия СКО
            }

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            //chart1.ChartAreas[0].AxisY.Maximum = m;
            chart1.ChartAreas[0].AxisX.Interval = 0.5;
            if (m < 5) {
                chart1.ChartAreas[0].AxisY.Interval = 0.5;
            } else if(m < 50) {
             chart1.ChartAreas[0].AxisY.Interval = 2;
            } else if (m < 100) {
             chart1.ChartAreas[0].AxisY.Interval = 5;
            } else {
             chart1.ChartAreas[0].AxisY.Interval = 10;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioChanged();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioChanged();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioChanged();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioChanged();
        }
    }
}
