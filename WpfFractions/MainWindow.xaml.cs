using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using FractionLibrary;

namespace WpfFractions
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _choise = 0; // backing field for choise
        private bool _number = false;

        public int Choise // property for choise
        {
            get { return _choise; }
            set
            {
                _choise = value;
            }
        }

        public bool Number // property for choise
        {
            get { return _number; }
            set
            {
                _number = value;
            }
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {

            Number = !Number;
            if (Number == true)
            {
                Grid.SetRowSpan(Numerator3, 3);
                Number_Button.Content = "Change to fraction";
                Denumerator3.Visibility = Visibility.Collapsed;
                BreukStreep3.Visibility = Visibility.Collapsed;
            }
            else
            {
                Grid.SetRowSpan(Numerator3, 1);
                Number_Button.Content = "Change to number";
                Denumerator3.Visibility = Visibility.Visible;
                BreukStreep3.Visibility= Visibility.Visible;
            }
            Output();
        }


        public MainWindow()
        {
            InitializeComponent();
            InitializeInputValidation();
            Numerator1.TextChanged += InputTextBox_TextChanged;
            Denumerator1.TextChanged += InputTextBox_TextChanged;
            Numerator2.TextChanged += InputTextBox_TextChanged;
            Denumerator2.TextChanged += InputTextBox_TextChanged;

            Output();
        }

        private void InitializeInputValidation()
        {
            // Attach event handlers for input validation
            Numerator1.PreviewTextInput += NumericTextBox_PreviewTextInput;
            Numerator2.PreviewTextInput += NumericTextBox_PreviewTextInput;
            Denumerator1.PreviewTextInput += NumericTextBox_PreviewTextInput;
            Denumerator2.PreviewTextInput += NumericTextBox_PreviewTextInput;
        }

        private void NumericTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox? textBox = sender as TextBox;

            // Check if the input is a numeric character or a negative sign
            if (!char.IsDigit(e.Text, e.Text.Length - 1) && (e.Text != "-" || textBox.Text.Contains("-")))
            {
                e.Handled = true; // Block the input if it's not a digit or if "-" is not at the beginning
            }
        }

        private void InputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Output();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Numerator2.Visibility = Visibility.Visible;
            Denumerator2.Visibility = Visibility.Visible;
            Symbool.Visibility = Visibility.Visible;
            Symbool.Text = "+";
            Choise = 1;
            Output();
        }

        private void SubtractButton_Click(object sender, RoutedEventArgs e)
        {
            Numerator2.Visibility = Visibility.Visible;
            Denumerator2.Visibility = Visibility.Visible;
            Symbool.Visibility = Visibility.Visible;
            Symbool.Text = "-";
            Choise = 2;
            Output();
        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            Numerator2.Visibility = Visibility.Visible;
            Denumerator2.Visibility = Visibility.Visible;
            Symbool.Visibility = Visibility.Visible;
            Symbool.Text = "*";
            Choise = 3;
            Output();
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            Numerator2.Visibility = Visibility.Visible;
            Denumerator2.Visibility = Visibility.Visible;
            Symbool.Visibility = Visibility.Visible;
            Symbool.Text = "/";
            Choise = 4;
            Output();
        }
        private void InvertButton_Click(object sender, RoutedEventArgs e)
        {
            Numerator2.Visibility = Visibility.Collapsed;
            Denumerator2.Visibility = Visibility.Collapsed;
            Symbool.Visibility = Visibility.Collapsed;
            Choise = 5;
            Numerator1.Text = string.Empty;
            Denumerator1.Text = string.Empty;
            Denumerator2.Text = string.Empty;
            Numerator2.Text = string.Empty;
            Numerator3.Text = string.Empty;
            Denumerator3.Text = string.Empty;
            Output();
        }
        private void ReciprocalButton_Click(object sender, RoutedEventArgs e)
        {
            Numerator2.Visibility = Visibility.Collapsed;
            Denumerator2.Visibility = Visibility.Collapsed;
            Symbool.Visibility = Visibility.Collapsed;
            Choise = 6;
            Numerator1.Text = string.Empty;
            Denumerator1.Text = string.Empty;
            Denumerator2.Text = string.Empty;
            Numerator2.Text = string.Empty;
            Numerator3.Text = string.Empty;
            Denumerator3.Text = string.Empty;
            Output();
        }

        private void SimplifyButton_Click(object sender, RoutedEventArgs e)
        {
            Numerator2.Visibility = Visibility.Collapsed;
            Denumerator2.Visibility = Visibility.Collapsed;
            Symbool.Visibility = Visibility.Collapsed;
            Choise = 7;
            Numerator1.Text = string.Empty;
            Denumerator1.Text = string.Empty;
            Denumerator2.Text = string.Empty;
            Numerator2.Text = string.Empty;
            Numerator3.Text = string.Empty;
            Denumerator3.Text = string.Empty;
            Output();
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.Show();
            this.Close();
        }

        private async void ShowErrorAndHideAfterDelay()
        {
            error.Visibility = Visibility.Visible;

            // Start a timer to hide the error after 5 seconds
            await Task.Delay(5000);
            error.Visibility = Visibility.Collapsed;
        }

        private void Output()
        {
            
            Fraction fraction1, fraction2;

            if(Denumerator1.Text == "0" || Denumerator2.Text == "0")
            {
                error.Visibility = Visibility.Visible;
                if (Denumerator1.Text == "0")
                {
                    Denumerator1.Text = "1";
                }

                if (Denumerator2.Text == "0")
                {
                    Denumerator2.Text = "1";
                }
                ShowErrorAndHideAfterDelay();
            }
            if (_choise == 4 && Numerator2.Text == "0")
            {
                ShowErrorAndHideAfterDelay();
                Numerator2.Text = "1";

            }

            if (!string.IsNullOrEmpty(Numerator1.Text) && !string.IsNullOrEmpty(Denumerator1.Text))
            {
                fraction1 = new Fraction(int.Parse(Numerator1.Text), int.Parse(Denumerator1.Text));
                if (!string.IsNullOrEmpty(Numerator2.Text) && !string.IsNullOrEmpty(Denumerator2.Text))
                {
                    fraction2 = new Fraction(int.Parse(Numerator2.Text), int.Parse(Denumerator2.Text));
                    switch (_choise)
                    {
                        case 1: // add
                            UpdateResult(fraction1.Add(fraction2));
                            break;
                        case 2: // subtract
                            UpdateResult(fraction1.Subtract(fraction2));
                            break;
                        case 3: // multiply
                            UpdateResult(fraction1.Multiply(fraction2));
                            break;
                        case 4: // divide
                            UpdateResult(fraction1.Divide(fraction2));
                            break;
                    }
                }
                else
                {
                    switch (_choise)
                    {
                        case 5: // invert
                            UpdateResult(fraction1.Invert());
                            break;
                        case 6: // reciprocal
                            UpdateResult(fraction1.ReciProcal());
                            break;
                        case 7: // simplify
                            UpdateResult(fraction1.Simplify());
                            break;
                    }
                }
            }

        }

        private void UpdateResult(Fraction result)
        {
            if (!_number)
            {
                Numerator3.Text = result.Numerator.ToString();
                Denumerator3.Text = result.Denominator.ToString();
            }
            else
            {
                Numerator3.Text = result.Result().ToString();
                Denumerator3.Text = "";
            }
        }
    }
}
