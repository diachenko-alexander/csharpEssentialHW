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

namespace Task4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler Add = null;
        public event EventHandler Subtract = null;
        public event EventHandler Multiply = null;
        public event EventHandler Division = null;
        public event EventHandler Result = null;

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            Add.Invoke(sender, e);
        }

        private void ButtonSubtract_Click(object sender, RoutedEventArgs e)
        {
            Subtract.Invoke(sender, e);
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            Multiply.Invoke(sender, e);
        }

        private void ButtonDivision_Click(object sender, RoutedEventArgs e)
        {
            Division.Invoke(sender, e);
        }

        private void ButtonResult_Click(object sender, RoutedEventArgs e)
        {
            Result.Invoke(sender, e);
        }
    }
}
