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

namespace Calculator_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber, result;
        SelectedOperation selectedOperation;
        public MainWindow()
        {
            InitializeComponent();

            negativeButton.Click += NegativeButton_Click;

            acButton.Click += AcButton_Click;

            percentageButton.Click += PercentageButton_Click;

            equalButton.Click += EqualButton_Click;
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            double newNumber;
            if (double.TryParse(resultLable.Content.ToString(), out newNumber))
            {
                switch (selectedOperation) 
                { 
                    case SelectedOperation.Addition:
                        result = SimpleMath.Add(lastNumber, newNumber);
                        break;
                    case SelectedOperation.Sustraction:
                        result = SimpleMath.Sustraction(lastNumber, newNumber);
                        break;
                    case SelectedOperation.Multiplication:
                        result = SimpleMath.Multiply(lastNumber, newNumber);
                        break;
                    case SelectedOperation.Division:
                        result = SimpleMath.Divide(lastNumber, newNumber);
                        break;

                }

                resultLable.Content = result.ToString();
            }
        }

        private void pointButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLable.Content.ToString().Contains(" . "))
            {
                
            }
            else
            {

                resultLable.Content = $"{resultLable.Content}.";

            }
        }
        private void PercentageButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLable.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber / 100;
                resultLable.Content = lastNumber.ToString();
            }
        }

        private void NegativeButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLable.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * -1;
                resultLable.Content = lastNumber.ToString();
            }
        }

        private void AcButton_Click(object sender, RoutedEventArgs e)
        {
            resultLable.Content = "0";
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e) 
        {
            if (double.TryParse(resultLable.Content.ToString(), out lastNumber))
            {
                resultLable.Content = "0";
            }
            if(sender == multiplicationButton)
                selectedOperation = SelectedOperation.Multiplication;
            if(sender == divisionButton)
                selectedOperation = SelectedOperation.Division;
            if(sender == plusButton)
                selectedOperation = SelectedOperation.Addition;
            if(sender == minusButton)
                selectedOperation = SelectedOperation.Sustraction;
        }

        private void numberButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedValue = int.Parse((sender as Button).Content.ToString());
            if (resultLable.Content.ToString() == "0")
            {
                resultLable.Content = $"{selectedValue}";
            }
            else 
            { 
                resultLable.Content = $"{resultLable.Content}{selectedValue}";
            }
        }
    }

    public enum SelectedOperation { 
        Addition,
        Sustraction,
        Multiplication,
        Division
    }

    public class SimpleMath 
    {
        public static double Add(double n1, double n2) 
        { 
            return n1 + n2;
        }
        public static double Sustraction(double n1, double n2)
        {
            return n1 - n2;
        }
        public static double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }
        public static double Divide(double n1, double n2)
        {
            return n1 / n2;
        }
    }

}