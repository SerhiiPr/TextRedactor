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

namespace TextRedactor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //event MouseUp on Image "Open File"
        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            // FileProcess tool for work with file
            FileProcess fp = new FileProcess();
            //  fp.Open(richtexbox, label)
            fp.Open(docBox, LabelShowFileName);
        }
    }
}
