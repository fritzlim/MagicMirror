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

using MetroRadiance.UI.Controls;

namespace Baku.MagicMirror.Views
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MagicMirrorWindow : MetroWindow
    {
        public MagicMirrorWindow()
        {
            InitializeComponent();
            Application.Current.MainWindow = this;
        }
    }
}
