﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int k = 1;
            Cell cell;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 1; j < 7; j++)
                {
                    cell = new Cell();
                    cell.Name = "Cell" + i + j;
                    cell.Number.Text = (k++).ToString();
                    Grid.SetRow(cell, j);
                    Grid.SetColumn(cell, i);
                    this.Calendar.Children.Add(cell);
                }
            }

        }
    }
}
