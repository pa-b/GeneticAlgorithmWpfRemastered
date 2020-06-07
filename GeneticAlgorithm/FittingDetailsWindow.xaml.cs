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

namespace GeneticAlgorithm
{
    /// <summary>
    /// Logika interakcji dla klasy FittingDetailsWindow.xaml
    /// </summary>
    public partial class FittingDetailsWindow : Window
    {
        public GA GA { get; set; }
        public FittingDetailsWindow(GA GAInstance)
        {
            InitializeComponent();
            GA = GAInstance;
        }
    }
}
