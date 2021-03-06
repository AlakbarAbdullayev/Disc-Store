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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ListboxItemnmsp;
using Microsoft.Win32;

namespace WPF_ev_tapsirigi_verilib_2._05._2019_
{
    /// <summary>
    /// Interaction logic for AdditionWindow.xaml
    /// </summary>
    public partial class AdditionWindow : Window
    {
        public AdditionWindow()
        {
            InitializeComponent();
        }
        ListboxItemnmsp.ListboxItem item;

        public object OpenFiledialog { get; private set; }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            GameNameTxtbox.Text = GameNameTxtbox.Text.Trim();
            PriceTxtBox.Text = PriceTxtBox.Text.Trim();
            ImagePathTxtbox.Text = ImagePathTxtbox.Text.Trim();
            Operatingtxtbox.Text = Operatingtxtbox.Text.Trim();
            Yeartxtbox.Text = Yeartxtbox.Text.Trim();

            if (GameNameTxtbox.Text.Length > 0)
            {
                if (PriceTxtBox.Text.Length > 0)
                {
                    double price = 0;
                    try
                    {
                        price = Convert.ToDouble(PriceTxtBox.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Price is not correct.Please Again", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }
                    if (ImagePathTxtbox.Text.Length > 0)
                    {
                        if (File.Exists(ImagePathTxtbox.Text) == true)
                        {
                            if (Operatingtxtbox.Text.Length > 0)
                            {
                                if (Yeartxtbox.Text.Length > 0)
                                {
                                    int year = 0;
                                    try
                                    {
                                        year = Convert.ToInt32(Yeartxtbox.Text);
                                    }
                                    catch (Exception)
                                    {
                                        MessageBox.Show("Year is not correct.Please Again", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                                        return;
                                    }
                                    item = new ListboxItemnmsp.ListboxItem();
                                    item.ItemName = GameNameTxtbox.Text;
                                    item.ItemPrice = price;
                                    item.ItemImagePath = ImagePathTxtbox.Text;
                                    item.ItemOperatingSystem = Operatingtxtbox.Text;
                                    item.ItemYear = year;
                                    MessageBox.Show("Game adds in  game list", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                                    this.DialogResult = true;
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Operating must not be empty", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("There is no file in ImagePath.Path is not correct", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("ImagePath must not be empty", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Price must not be empty", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("GameName must not be empty", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }


        public ListboxItemnmsp.ListboxItem GetAdditionItem()
        {
            return item;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName.Length > 0)
            {
                ImagePathTxtbox.Text = openFileDialog.FileName;
            }
        }
    }
}
