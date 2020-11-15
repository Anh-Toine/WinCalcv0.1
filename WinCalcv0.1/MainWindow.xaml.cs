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

        public MainWindow()
        {

            InitializeComponent();
            btn_ac.Click += new RoutedEventHandler(AC_Click);
            btn_pm.Click += new RoutedEventHandler(PM_Click);
            btn_per.Click += new RoutedEventHandler(PER_Click);
        }

        //A single event handler
        private void commonnum_Handler(object sender,RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string btncont = btn.Content.ToString();
            
            if(result.Text == "0")
            {
                result.Text = btncont;
            }
            else if(btncont == ".")
            {
                if (!result.Text.Contains('.'))
                {
                    result.Text += ".";
                }
            }
            else
            {
                result.AppendText(btncont);
            }
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

        private void opt_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            string @operator = b.Content.ToString();
            switch (@operator)
            {
                case "+":
                    selectedOperator = SelectedOperator.ADD;
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
        }
        private void equ_Click(object sender,RoutedEventArgs e)
        {

        }
    }
}
