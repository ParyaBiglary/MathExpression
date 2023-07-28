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
using org.mariuszgromada.math.mxparser;

namespace MathExpression
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void Calculate_Button(object sender, RoutedEventArgs e)
        {
            var expression = ExpressionTextBox.Text;
            var ex = new org.mariuszgromada.math.mxparser.Expression(expression);
            AnswerTextBlock.Text = ex.calculate().ToString();
        }

    }
}
