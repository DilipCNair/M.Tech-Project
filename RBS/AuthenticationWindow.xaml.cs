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
using MahApps.Metro.Controls;
using System.Windows.Forms;

namespace RBS
{
    /// <summary>
    /// Interaction logic for AuthenticationWindow.xaml
    /// </summary>
    public partial class AuthenticationWindow : MetroWindow
    {
        public AuthenticationWindow()
        {
            InitializeComponent();
            GlobalResources.Minimize += GlobalResources_Minimize;
        }

        private void GlobalResources_Minimize(object sender, EventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
