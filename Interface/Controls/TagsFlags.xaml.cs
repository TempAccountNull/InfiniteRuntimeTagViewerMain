﻿using System.Windows;
using System.Windows.Controls;
using InfiniteRuntimeTagViewer.Halo;

namespace InfiniteRuntimeTagViewer.Interface.Controls
{
    /// <summary>
    /// Interaction logic for TagsFlags.xaml
    /// </summary>
    public partial class TagsFlags : UserControl
    {
		public TagEditorDefinition ValueDefinition { get; set; }

		public TagsFlags() => InitializeComponent();


        public long address;
        public MainWindow? _mainwindow;

        public void Calculate_and_report()
        {
            if (_mainwindow != null)
            {
                int flag_as_int8 = 0;
                flag_as_int8 = (flag1.IsChecked == true) ? flag_as_int8 + 1 : flag_as_int8;
                flag_as_int8 = (flag2.IsChecked == true) ? flag_as_int8 + 2 : flag_as_int8;
                flag_as_int8 = (flag3.IsChecked == true) ? flag_as_int8 + 4 : flag_as_int8;
                flag_as_int8 = (flag4.IsChecked == true) ? flag_as_int8 + 8 : flag_as_int8;
                flag_as_int8 = (flag5.IsChecked == true) ? flag_as_int8 + 16 : flag_as_int8;
                flag_as_int8 = (flag6.IsChecked == true) ? flag_as_int8 + 32 : flag_as_int8;
                flag_as_int8 = (flag7.IsChecked == true) ? flag_as_int8 + 64 : flag_as_int8;
                flag_as_int8 = (flag8.IsChecked == true) ? flag_as_int8 + 128 : flag_as_int8;

				_mainwindow.AddPokeChange(ValueDefinition, flag_as_int8.ToString());
            }
        }

        private void flag1_Checked(object sender, RoutedEventArgs e)
        {
            Calculate_and_report();
        }
    }
}
