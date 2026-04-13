using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LABA12
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double z = 0;

            try
            {
                
                if (rbVariant9.IsChecked == true)
                {
                    int N = int.Parse(txtN9.Text);
                    int K = int.Parse(txtK9.Text);
                    double x = double.Parse(txtX9.Text);
                    double y = double.Parse(txtY9.Text);

                   
                    for (int i = 1; i <= N; i++)
                    {
                        for (int j = 1; j <= K; j++)
                        {
                            z += (Math.Cos(Math.Pow(y, i)) + j * x) / (i * j);
                        }
                    }
                }
              
                else if (rbVariant11.IsChecked == true)
                {
                    int N = int.Parse(txtN11.Text);
                    int K = int.Parse(txtK11.Text);
                    double x = double.Parse(txtX11.Text);
                    double y = double.Parse(txtY11.Text);

                    for (int i = 1; i <= N; i++)
                    {
                        for (int j = 1; j <= K; j++)
                        {
                            z += (Math.Sin(Math.Pow(y, i)) + i * x) / ((i + 1) * j);
                        }
                    }
                }

               
                lblResult.Content = $"Ответ: {z:F4}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода: " + ex.Message);
            }
        }
    }
}