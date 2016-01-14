/*
* Copyright (C) JAMK/IT/Esa Salmikangas
* This file is part of the IIO11300 course project.
* Created: 12.1.2016 Modified: 14.1.2016
* Authors: Jere Halme ,Esa Salmikangas
*/
using System;
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

namespace Tehtava1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            //TODO
            try
            {
                double windowArea;
                double windowPaneCircumference;
                double windowPaneArea;
                windowArea = BusinessLogicWindow.CalculateWindowArea(txtWidht.Text, txtHeight.Text);
                windowPaneCircumference = BusinessLogicWindow.CalculateWindowPaneCircumference(txtWidht.Text, txtHeight.Text, txtThickness.Text);
                windowPaneArea = BusinessLogicWindow.CalculateWindowPaneArea(txtWidht.Text, txtHeight.Text, txtThickness.Text);
                tbWindowAreaResult.Text = Convert.ToString(windowArea);
                tbWindowPaneCircumferenceResult.Text = Convert.ToString(windowPaneCircumference);
                tbWindowPaneAreaResult.Text = Convert.ToString(windowPaneArea);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //yield to an user that everything okay
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }

    public class BusinessLogicWindow
    {
        /// <summary>
        /// CalculatePerimeter calculates the perimeter of a window
        /// </summary>
        public static double CalculateWindowArea(string widht, string height)
        {

            return (Convert.ToDouble(widht) * Convert.ToDouble(height));
        }
        public static double CalculateWindowPaneCircumference(string widht, string height, string thickness)
        {
            return (2 * (Convert.ToDouble(widht) + (Convert.ToDouble(thickness)) * 2) + 2 * (Convert.ToDouble(height) + (Convert.ToDouble(thickness)) * 2));
        }
        public static double CalculateWindowPaneArea(string widht, string height, string thickness)
        {
            return (((Convert.ToDouble(widht) + (Convert.ToDouble(thickness) * 2)) * (Convert.ToDouble(height) + (Convert.ToDouble(thickness) * 2)))- (Convert.ToDouble(widht) * Convert.ToDouble(height)));
        }
    }
}
