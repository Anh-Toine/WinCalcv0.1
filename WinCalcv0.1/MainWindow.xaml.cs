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
    public partial class MainWindow : Window
    {
        double firstnum;
        SelectedOperator selectedOperator;

        public MainWindow()
        {

            InitializeComponent();

        }
        public enum SelectedOperator
        {
            PLUS,
            MINUS,
            MULTIPLY,
            DIVIDE
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
            else
            {
                result.AppendText(btncont);
            }
        }
        void ac_Handler(object sender,RoutedEventArgs e)
        {
            Button b = FindName("btn_ac") as Button;
            b.Click += AC_Click;
        }
        private void AC_Click(object sender, RoutedEventArgs e)
        {
            result.Text = "0";
        }
        
        //private void btn_ac_Click(object sender, RoutedEventArgs e)
        //{
        //    numone = 0;
        //    numtwo = 0;
        //    opt = "";
        //    result.Text = "0";
        //}
    }
}
