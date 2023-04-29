using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SumButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(PrimerNumeroTextBox.Text, out double PrimerNumero) &&
                double.TryParse(SegundoNumeroTextBox.Text, out double SegundoNumero))
            {
                ResultadoLabel.Content = (PrimerNumero + SegundoNumero).ToString();
            }
            else
            {
                ResultadoLabel.Content = "Error";
            }
        }

        private void SubtractButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(PrimerNumeroTextBox.Text, out double PrimerNumero) &&
                double.TryParse(SegundoNumeroTextBox.Text, out double SegundoNumero))
            {
                ResultadoLabel.Content = (PrimerNumero - SegundoNumero).ToString();
            }
            else
            {
                ResultadoLabel.Content = "Error";
            }
        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(PrimerNumeroTextBox.Text, out double PrimerNumero) &&
                double.TryParse(SegundoNumeroTextBox.Text, out double SegundoNumero))
            {
                ResultadoLabel.Content = (PrimerNumero * SegundoNumero).ToString();
            }
            else
            {
                ResultadoLabel.Content = "Error";
            }
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(PrimerNumeroTextBox.Text, out double firstNumber) &&
                double.TryParse(SegundoNumeroTextBox.Text, out double secondNumber))
            {
                if (secondNumber != 0)
                {
                    ResultadoLabel.Content = (firstNumber / secondNumber).ToString();
                }
                else
                {
                    ResultadoLabel.Content = "No se puede dividir dentro de Cero";
                }
            }
            else
            {
                ResultadoLabel.Content = "Error";
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            PrimerNumeroTextBox.Text = "";
            SegundoNumeroTextBox.Text = "";
            ResultadoLabel.Content = "";
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.-]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
