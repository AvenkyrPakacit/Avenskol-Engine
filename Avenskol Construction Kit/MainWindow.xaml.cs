﻿using System;
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
using Avenskol_Construction_Kit.GameProject;

namespace Avenskol_Construction_Kit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += OnMainWindowLoaded;
        }
        private void OnMainWindowLoaded(object sender, RoutedEventArgs e)
        {
            Loaded -= OnMainWindowLoaded;
            OpenProjectBrowserDialog();
        }
        private void OpenProjectBrowserDialog()
        {
            var projectBrowser = new ProjectBrowser();
            if(projectBrowser.ShowDialog() == false)
            {
                Application.Current.Shutdown();
            }
            else
            {

            }
        }
    }
}
