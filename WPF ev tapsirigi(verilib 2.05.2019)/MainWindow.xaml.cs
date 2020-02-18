using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using ListboxItemnmsp;
using Microsoft.Win32;


namespace WPF_ev_tapsirigi_verilib_2._05._2019_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        private DateTime downTime;
        private object downSender;


        private ObservableCollection<ListboxItem> _items = new ObservableCollection<ListboxItem>()
        {
             new ListboxItem
            {
                ItemName="Pubg",
                ItemPrice=18,
                ItemImagePath="discs\\pubg.jpg",
                ItemOperatingSystem="PC",
                ItemYear=2017
            },

             new ListboxItem
            {
                ItemName="Assassin's Creed Unity",
                ItemPrice=25,
                ItemImagePath="discs\\creed.jpg",
                 ItemOperatingSystem="PC",
                ItemYear=2014
            },

              new ListboxItem
            {
                ItemName="Apex Legends",
                ItemPrice=50,
                ItemImagePath="discs\\apex.jpg",
                 ItemOperatingSystem="PC",
                ItemYear=2018
            },

              new ListboxItem {
                ItemName="CS Go",
                ItemPrice=10,
                ItemImagePath="discs\\csgo.jpg",
                 ItemOperatingSystem="PC",
                ItemYear=2010
            },


              new ListboxItem
            {
                ItemName="Pes 2018",
                ItemPrice=40,
                ItemImagePath="discs\\pes2018disc.png",
                 ItemOperatingSystem="PC",
                ItemYear=2018
            }
        };

        public ObservableCollection<ListboxItemnmsp.ListboxItem> items
        {
            get { return _items; }
            set
            {
                _items = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string propertyname = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }


        public MainWindow()
        {
            InitializeComponent();
            mainlistbox.ItemsSource = GetListboxItems(items);
            this.DataContext = this;

        }

        ObservableCollection<ListboxItem> GetListboxItems(ObservableCollection<ListboxItem> list)
        {
            return list;
        }




        private void Mainlistbox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (mainlistbox.SelectedIndex > -1)
            {
                BuyButton.Visibility = Visibility.Hidden;
                ShowItemWindow showItemWindow = new ShowItemWindow(items[mainlistbox.SelectedIndex]);
                showItemWindow.ShowDialog();
            }
        }




        //IMAGE

        // ADD

        private void AddImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.downSender = sender;
                this.downTime = DateTime.Now;
                BuyButton.Visibility = Visibility.Hidden;
                AdditionWindow addition = new AdditionWindow();
                addition.ShowDialog();
                bool? result = addition.DialogResult;
                if (result == true)
                {
                    items.Add(addition.GetAdditionItem());
                }
                if (mainlistbox.SelectedIndex > -1)
                {
                    BuyButton.Visibility = Visibility.Visible;
                }
            }
        }

        private void AddImage_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Released && sender == this.downSender)
            {
                TimeSpan timeSinceDown = DateTime.Now - this.downTime;
                if (timeSinceDown.TotalMilliseconds < 500)
                {
                    BuyButton.Visibility = Visibility.Hidden;
                    AdditionWindow addition = new AdditionWindow();
                    addition.ShowDialog();
                    bool? result = addition.DialogResult;
                    if (result == true)
                    {
                        items.Add(addition.GetAdditionItem());
                    }

                    if (mainlistbox.SelectedIndex > -1)
                    {
                        BuyButton.Visibility = Visibility.Visible;
                    }
                }
            }

        }


        //EDIT

        private void EditImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.downSender = sender;
                this.downTime = DateTime.Now;
                if (mainlistbox.SelectedIndex > -1)
                {
                    BuyButton.Visibility = Visibility.Hidden;
                    ListBoxItem editionWindow = new ListBoxItem(items[mainlistbox.SelectedIndex], mainlistbox.SelectedIndex);
                    editionWindow.ShowDialog();
                    bool? result = editionWindow.DialogResult;
                    if (result == true)
                    {
                        int count = editionWindow.GetEditCount();
                        CollectionViewSource.GetDefaultView(this.items).Refresh();
                        items[count] = editionWindow.GetEditionItem();
                    }

                    if (mainlistbox.SelectedIndex > -1)
                    {
                        BuyButton.Visibility = Visibility.Visible;
                    }
                }
            }
        }

        private void EditImage_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Released && sender == this.downSender)
            {
                TimeSpan timeSinceDown = DateTime.Now - this.downTime;
                if (timeSinceDown.TotalMilliseconds < 500)
                {
                    if (mainlistbox.SelectedIndex > -1)
                    {
                        BuyButton.Visibility = Visibility.Hidden;
                        ListBoxItem editionWindow = new ListBoxItem(items[mainlistbox.SelectedIndex], mainlistbox.SelectedIndex);
                        editionWindow.ShowDialog();
                        bool? result = editionWindow.DialogResult;
                        if (result == true)
                        {
                            int count = editionWindow.GetEditCount();
                            CollectionViewSource.GetDefaultView(this.items).Refresh();
                            items[count] = editionWindow.GetEditionItem();
                        }

                        if (mainlistbox.SelectedIndex > -1)
                        {
                            BuyButton.Visibility = Visibility.Visible;
                        }

                    }
                }
            }
        }


        //REMOVE

        private void RemoveImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.downSender = sender;
                this.downTime = DateTime.Now;
                if (mainlistbox.SelectedIndex > -1)
                {

                    if (MessageBox.Show("Do you want to remove this item", "Question", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
                    {
                        items.RemoveAt(mainlistbox.SelectedIndex);
                    }
                }
            }
        }

        private void RemoveImage_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Released && sender == this.downSender)
            {
                TimeSpan timeSinceDown = DateTime.Now - this.downTime;
                if (timeSinceDown.TotalMilliseconds < 500)
                {
                    if (mainlistbox.SelectedIndex > -1)
                    {
                        items.RemoveAt(mainlistbox.SelectedIndex);
                    }
                }
            }
        }


        private void RemoveAllButton_Click(object sender, RoutedEventArgs e)
        {
            if (items.Count > 0)
            {
                if (MessageBox.Show("Do you want to remove all items", "Question", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
                {
                    int index = items.Count - 1;
                    for (; index > -1;)
                    {
                        items.RemoveAt(index);
                        index = items.Count - 1;
                    }
                }
            }
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            if (mainlistbox.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Do you want to buy this item?{Environment.NewLine}               Price : {items[mainlistbox.SelectedIndex].ItemPrice}$", "Question", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
                {
                    items.RemoveAt(mainlistbox.SelectedIndex);
                    mainlistbox.SelectedIndex = -1;
                }
            }
        }

        private void Mainlistbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (mainlistbox.SelectedIndex > -1)
            {
                BuyButton.Visibility = Visibility.Visible;
            }
            else
            {
                BuyButton.Visibility = Visibility.Hidden;
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            //if (SearchTxtbox.Text.Length > -1)
            //{
            //    ObservableCollection<ListboxItemnmsp.ListboxItem> tempitems = new ObservableCollection<ListboxItem>();
            //    tempitems = items;
            //    if (items.Count > 0)
            //    {
            //        int index = items.Count - 1;
            //        for (; index > -1;)
            //        {
            //            items.RemoveAt(index);
            //            index = items.Count - 1;
            //        }
            //    }


            //    //ListboxItemnmsp.ListboxItem temp = new ListboxItem();

            //    for (int i = 0; i < tempitems.Count; i++)
            //    {
            //        if (tempitems[i].ItemName.StartsWith(SearchTxtbox.Text, StringComparison.CurrentCultureIgnoreCase))
            //        {
            //            //items.Add(tempitems[i]);
            //            mainlistbox.Items.Add(tempitems[i]);
            //        }
            //    }
            //}
        }





        private void SearchTxtbox_TextChanged(object sender, TextChangedEventArgs e)
        {


            //if (SearchTxtbox.Text.Length < 0)
            //{
            //    mainlistbox.ItemsSource = GetListboxItems(items);
            //}


        }
    }
}