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
using System.Windows.Shapes;

namespace Zadanie3
{
    /// <summary>
    /// Logika interakcji dla klasy OknoSzczegółów.xaml
    /// </summary>
    public partial class OknoSzczegółów : Window
    {
        public OknoSzczegółów(Album album)
        {
            DataContext = album;
            InitializeComponent();
        }

        private void OK(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
