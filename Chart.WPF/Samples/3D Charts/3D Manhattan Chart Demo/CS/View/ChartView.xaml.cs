#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _3DManhattanChart
{
    /// <summary>
    /// Interaction logic for ChartView.xaml
    /// </summary>
    public partial class ChartView : UserControl
    {
        public ChartView()
        {
            InitializeComponent();
            this.Chart1.Loaded += new RoutedEventHandler(Chart1_Loaded);
        }

        void Chart1_Loaded(object sender, RoutedEventArgs e)
        {
            this.Chart1.Areas[0].Series[0].Type = Syncfusion.Windows.Chart.ChartTypes.Column;
            this.Chart1.Areas[0].Series[0].Type = Syncfusion.Windows.Chart.ChartTypes.Column;
        }
    }
}
