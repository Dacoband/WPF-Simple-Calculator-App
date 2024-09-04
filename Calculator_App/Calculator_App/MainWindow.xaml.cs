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

        private void eightButtuon_Click(object sender, RoutedEventArgs e)
        {
            if (resultLable.Content.ToString() == "0")
            {
                resultLable.Content = "8";
            }
            else 
            { 
                resultLable.Content = $"{resultLable.Content}8";
            }
        }

        private void nineButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLable.Content.ToString() == "0")
            {
                resultLable.Content = "9";
            }
            else 
            {
                resultLable.Content = $"{resultLable.Content}9";
            }
        }

        private void fourButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLable.Content.ToString() == "0")
            {
                resultLable.Content = "4";
            }
            else
            {
                resultLable.Content = $"{resultLable.Content}4";
            }
        }

        private void fiveButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLable.Content.ToString() == "0")
            {
                resultLable.Content = "5";
            }
            else
            {
                resultLable.Content = $"{resultLable.Content}5";
            }
        }

        private void sixButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLable.Content.ToString() == "0")
            {
                resultLable.Content = "6";
            }
            else
            {
                resultLable.Content = $"{resultLable.Content}6";
            }
        }

        private void oneButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLable.Content.ToString() == "0")
            {
                resultLable.Content = "1";
            }
            else
            {
                resultLable.Content = $"{resultLable.Content}1";
            }
        }

        private void twoButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLable.Content.ToString() == "0")
            {
                resultLable.Content = "2";
            }
            else
            {
                resultLable.Content = $"{resultLable.Content}2";
            }
        }

        private void threeButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLable.Content.ToString() == "0")
            {
                resultLable.Content = "3";
            }
            else
            {
                resultLable.Content = $"{resultLable.Content}3";
            }
        }

        private void zeroButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLable.Content.ToString() == "0")
            {
                resultLable.Content = "0";
            }
            else
            {
                resultLable.Content = $"{resultLable.Content}0";
            }
        }

        private void sevenButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLable.Content.ToString() == "0")
            {
                resultLable.Content = "7";
            }
            else 
            { 
                resultLable.Content = $"{resultLable.Content}7";
            }
        }
    }
}