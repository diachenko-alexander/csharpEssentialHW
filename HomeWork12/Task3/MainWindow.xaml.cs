using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task3
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
        public event EventHandler StartTimer = null;
        public event EventHandler StopTimer = null;
        public event EventHandler ResetTimer = null;
        
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            StartTimer.Invoke(sender, e);
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            StopTimer.Invoke(sender, e);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ResetTimer.Invoke(sender, e);
        }               
    }
}
