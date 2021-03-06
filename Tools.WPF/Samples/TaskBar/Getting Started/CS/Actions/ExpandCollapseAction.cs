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
using System.Windows.Interactivity;
using Syncfusion.Windows.Tools.Controls;
using System.Windows.Controls;
using System.Windows;

namespace TaskBarDemo
{
    public class ExpandCollapseAction : TargetedTriggerAction<CheckBox>
    {
#if Framework3_5       
        public FrameworkElement TargetObject
        {
            get { return (FrameworkElement)GetValue(TargetObjectProperty); }
            set { SetValue(TargetObjectProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Target.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TargetObjectProperty =
            DependencyProperty.Register("TargetObject", typeof(FrameworkElement), typeof(ExpandCollapseAction), new UIPropertyMetadata(null));
#endif

        protected override void Invoke(object parameter)
        {
            foreach (object obj in ((TaskBar)TargetObject).Items)
            {
                TaskBarItem item = obj as TaskBarItem;
                if (item != null)
                {
                    RoutedEventArgs rnt = parameter as RoutedEventArgs;
                    if ((rnt.OriginalSource as CheckBox).IsChecked == true)
                        TaskBar.SetIsOpened(item, true);
                    else
                        TaskBar.SetIsOpened(item, false);
                }
            }

        }
    }
}
