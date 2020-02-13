using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Presenter
    {
        Model model;
        MainWindow mainWindow;
        

        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            model = new Model();
            this.mainWindow.Add += MainWindow_Add;
            this.mainWindow.Subtract += MainWindow_Subtract;
            this.mainWindow.Multiply += MainWindow_Multiply;
            this.mainWindow.Division += MainWindow_Division;
            
        }

        private double GetAToDouble()
        {
            return double.Parse(mainWindow.TextBoxA.Text);
        }

        private double GetBToDouble()
        {
            return double.Parse(mainWindow.TextBoxB.Text);
        }
        
        private void MainWindow_Add (object sender, EventArgs e)
        {
            mainWindow.TextBoxResult.Text = model.Add(GetAToDouble(), GetBToDouble()).ToString();
        }

        private void MainWindow_Subtract(object sender, EventArgs e)
        {
            mainWindow.TextBoxResult.Text = model.Subtract(GetAToDouble(), GetBToDouble()).ToString();
        }

        private void MainWindow_Multiply(object sender, EventArgs e)
        {
            mainWindow.TextBoxResult.Text = model.Multiply(GetAToDouble(), GetBToDouble()).ToString();
        }

        private void MainWindow_Division(object sender, EventArgs e)
        {
            if (GetBToDouble() == 0)
            {
                mainWindow.TextBoxResult.Text = "Division by 0 impossible"; 
            } else
            {
                mainWindow.TextBoxResult.Text = model.Division(GetAToDouble(), GetBToDouble()).ToString();
            }
            
        }

    }
}
