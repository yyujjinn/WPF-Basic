using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber;  // 연산할 때 앞에 입력한 값을 저장하는 변수
        SelectedOperator selectedOperator;
        double result;      // 연산한 결과 값을 저장하는 변수

        public MainWindow()
        {
            InitializeComponent();
        }

        public enum SelectedOperator
        {
            Addition,
            Subtraction,
            Muliplication,
            Division
        }

        public class SimpleMath
        {
            public static double Add(double n1, double n2)
            {
                return n1 + n2;
            }

            public static double Subtract(double n1, double n2)
            {
                return n1 - n2;
            }

            public static double Muliple(double n1, double n2)
            {
                return n1 * n2;
            }

            public static double Divide(double n1, double n2)
            {
                return n1 / n2;
            }
        }

        // Number Event
        private void numberButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedValue = 0;
            if (sender == ZeroButton)
            {
                selectedValue = 0;
                if (resultLabel.Content.ToString() == "0")
                {
                    resultLabel.Content = selectedValue.ToString();
                }
                else
                {
                    resultLabel.Content += selectedValue.ToString();
                }
            }

            if (sender == OneButton)
            {
                selectedValue = 1;
                if (resultLabel.Content.ToString() == "0")
                {
                    resultLabel.Content = selectedValue.ToString();
                }
                else
                {
                    resultLabel.Content += selectedValue.ToString();
                }
            }

            if (sender == TwoButton)
            {
                selectedValue = 2;
                if (resultLabel.Content.ToString() == "0")
                {
                    resultLabel.Content = selectedValue.ToString();
                }
                else
                {
                    resultLabel.Content += selectedValue.ToString();
                }
            }

            if (sender == ThreeButton)
            {
                selectedValue = 3;
                if (resultLabel.Content.ToString() == "0")
                {
                    resultLabel.Content = selectedValue.ToString();
                }
                else
                {
                    resultLabel.Content += selectedValue.ToString();
                }
            }

            if (sender == FourButton)
            {
                selectedValue = 4;
                if (resultLabel.Content.ToString() == "0")
                {
                    resultLabel.Content = selectedValue.ToString();
                }
                else
                {
                    resultLabel.Content += selectedValue.ToString();
                }
            }

            if (sender == FiveButton)
            {
                selectedValue = 5;
                if (resultLabel.Content.ToString() == "0")
                {
                    resultLabel.Content = selectedValue.ToString();
                }
                else
                {
                    resultLabel.Content += selectedValue.ToString();
                }
            }

            if (sender == SixButton)
            {
                selectedValue = 6;
                if (resultLabel.Content.ToString() == "0")
                {
                    resultLabel.Content = selectedValue.ToString();
                }
                else
                {
                    resultLabel.Content += selectedValue.ToString();
                }
            }

            if (sender == SevenButton)
            {
                selectedValue = 7;
                if (resultLabel.Content.ToString() == "0")
                {
                    resultLabel.Content = selectedValue.ToString();
                }
                else
                {
                    resultLabel.Content += selectedValue.ToString();
                }
            }

            if (sender == EightButton)
            {
                selectedValue = 8;
                if (resultLabel.Content.ToString() == "0")
                {
                    resultLabel.Content = selectedValue.ToString();
                }
                else
                {
                    resultLabel.Content += selectedValue.ToString();
                }
            }

            if (sender == NineButton)
            {
                selectedValue = 9;
                if (resultLabel.Content.ToString() == "0")
                {
                    resultLabel.Content = selectedValue.ToString();
                }
                else
                {
                    resultLabel.Content += selectedValue.ToString();
                }
            }

        }

        // Plus, Minus, Multiple, Divide Event
        private void operatorButton_Click(object sender, RoutedEventArgs e)
        {
            lastNumber = double.Parse(resultLabel.Content.ToString());
            resultLabel.Content = " ";

            if(sender == PlusButton)
            {
                selectedOperator = SelectedOperator.Addition;
            }

            if(sender == MinusButton)
            {
                selectedOperator = SelectedOperator.Subtraction;
            }

            if(sender == MultipleButton)
            {
                selectedOperator = SelectedOperator.Muliplication;
            }

            if(sender == DevideButton)
            {
                selectedOperator = SelectedOperator.Division;
            }
        }

        // AcButton Click
        private void AcButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }

        // PlusMinusButton Click
        private void PlusMinusButton_Click(object sender, RoutedEventArgs e)
        {
            double lastNumber;
            if(double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * -1;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        // PercentButton Click
        private void PercentButton_Click(object sender, RoutedEventArgs e)
        {
            double lastNumber;
            if(double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * 0.01;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        // DotButton Click
        private void DotButton_Click(object sender, RoutedEventArgs e)
        {
            Boolean a;
            a = resultLabel.Content.ToString().Contains(".");
            if (resultLabel.Content.ToString() == "0")
            {
                return;
            }
            else
            {
                if(a == false)
                {
                    resultLabel.Content += ".";
                }
            }
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            double newNumber;
            newNumber = double.Parse(resultLabel.Content.ToString());       // 연산자 후 숫자 저장

            switch(selectedOperator)
            {
                case SelectedOperator.Addition:
                    result = SimpleMath.Add(lastNumber, newNumber);
                    break;

                case SelectedOperator.Subtraction:
                    result = SimpleMath.Subtract(lastNumber, newNumber);
                    break;

                case SelectedOperator.Muliplication:
                    result = SimpleMath.Muliple(lastNumber, newNumber);
                    break;

                case SelectedOperator.Division:
                    result = SimpleMath.Divide(lastNumber, newNumber);
                    break;
            }

            resultLabel.Content = result.ToString();

        }
    }
}
