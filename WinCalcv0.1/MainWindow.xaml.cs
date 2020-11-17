using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Text.RegularExpressions;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TSCalc;

namespace WinCalcv0._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    enum SelectedOperator
    {
        ADD,
        SUBTRACT,
        MULTIPLY,
        DIVIDE
    }
    public partial class MainWindow : Window
    {
        double value;

        double lastValue;
        double res;
        SelectedOperator selectedOperator;
        Regex isnum = new Regex(@"\d+");
        public MainWindow()
        {

            InitializeComponent();
            btn_ac.Click += new RoutedEventHandler(AC_Click);
            btn_pm.Click += new RoutedEventHandler(PM_Click);
            btn_per.Click += new RoutedEventHandler(PER_Click);
            btn_equ.Click += new RoutedEventHandler(Equ_Click);
        }

        //A single event handler
        private void Commonnum_Handler(object sender,RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string btncont = btn.Content.ToString();
            
            if (isnum.IsMatch(btncont))
            {
                if(result.Text == "0")
                {
                    result.Text = btncont;
                }
                else
                {
                    result.Text += btncont;
                }
            }
            else
            {
                if (!result.Text.Contains('.'))
                {
                    result.AppendText(".");
                }
            }
            value = Double.Parse(result.Text);
            Console.WriteLine(value);
        }
        private void AC_Click(object sender, RoutedEventArgs e)
        {
            value = 0.0;
            lastValue = 0.0;
            res = 0.0;
            
            result.Text = "0";
        }
        private void PM_Click(object sender, RoutedEventArgs e)
        {
            value = Double.Parse(result.Text) * -1;
            result.Text = value.ToString();
        }
        private void PER_Click(object sender, RoutedEventArgs e)
        {
            value = Double.Parse(result.Text) / 100;
            result.Text = value.ToString();
        }

        private SelectedOperator Operator_Handler(string @operator)
        {
            switch (@operator)
            {
                case "+":
                    selectedOperator = SelectedOperator.ADD;
                    //Secondnum_Handler();
                    break;
                case "-":
                    selectedOperator = SelectedOperator.SUBTRACT;
                    break;
                case "*":
                    selectedOperator = SelectedOperator.MULTIPLY;
                    break;
                case "/":
                    selectedOperator = SelectedOperator.DIVIDE;
                    break;
            }
            return selectedOperator;
        }
        private void Secondnum_Handler()
        {
            if(value == null)
            {

            }
        }
        private void Equ_Click(object sender, RoutedEventArgs e)
        {
            
        }

    }
}
