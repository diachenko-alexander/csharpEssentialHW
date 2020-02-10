using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Presenter
    {
        Model model;
        MainWindow mainWindow;

        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            model = new Model();
            this.mainWindow.StartTimer += MainWindow_StartTimer;
            
        }

        private void MainWindow_StartTimer(object sender, EventArgs e)
        {
            model.TimerStart();
           
                mainWindow.TextBox.Text = model.Second.ToString();
            
            //mainWindow.TextBox.Text = model.Second.ToString();          

        }

        private void TextBoXUpdate (object sender, EventArgs e)
        {
           // mainWindow.TextBox.Text = model.Second.ToString();
        }
    }
}
