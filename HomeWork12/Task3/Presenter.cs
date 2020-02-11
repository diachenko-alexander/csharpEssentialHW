using System;

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
            this.mainWindow.StopTimer += MainWindow_StopTimer;
            this.mainWindow.ResetTimer += MainWindow_ResetTimer;
            model.TimerTick += TextBoXUpdate;
            
        }

        private void MainWindow_StartTimer(object sender, EventArgs e)
        {
            model.TimerStart();            
        }

        private void MainWindow_StopTimer(object sender, EventArgs e)
        {
            model.TimerStop();
        }

        private void MainWindow_ResetTimer(object sender, EventArgs e)
        {
            model.TimerReset();
            mainWindow.TextBox.Text = model.Second.ToString();
        }

        private void TextBoXUpdate (object sender, EventArgs e)
        {
            mainWindow.TextBox.Text = model.Second.ToString();
        }
    }
}
