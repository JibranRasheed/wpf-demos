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
using Syncfusion.Windows.Edit;
using Syncfusion.Windows.Shared;

namespace EditControl_VisalBasic_Demo
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            Edit1.DocumentLanguage = Languages.VisualBasic;
            Edit1.DocumentSource = "../../Source.vb";
            fontlst.SelectedItem = new FontFamily("Verdana");
        }

        #region Menu Click Event

        /// <summary>
        /// Helper event to close the window when Exit MenuItem is selected.
        /// </summary>
        /// <param name="sender">represents the MenuItem object</param>
        /// <param name="e">represents RoutedEventArgs</param>
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
