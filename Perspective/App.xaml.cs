﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Perspective
{
    /// <summary>
    /// App.xaml 的互動邏輯
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // Create the startup window
            MainWindow mainWindow = new MainWindow();
            // Show the window
            //wnd.Show();

            //多載寫法
            if (e.Args.Length == 0)
            {
                //application.Run();
                mainWindow = new MainWindow();
            }
            else
            {
                mainWindow = new MainWindow(e.Args[0].ToString());
            }
            mainWindow.Show();
        }

        //public static MainWindow mainWindow;

        //[STAThread]
        //public static void Main(string[] args)
        //{
        //    //多載寫法
        //    var application = new App();
        //    application.InitializeComponent();
        //    if (args.Length == 0)
        //    {
        //        //application.Run();
        //        mainWindow = new MainWindow();
        //        application.Run(mainWindow);
        //    }
        //    else
        //    {
        //        mainWindow = new MainWindow(args[0].ToString());
        //        application.Run(mainWindow);
        //    }
        //}
    }
}
