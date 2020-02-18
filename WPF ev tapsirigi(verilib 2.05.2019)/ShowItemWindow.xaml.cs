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
using System.Windows.Shapes;
using ListboxItemnmsp;

namespace WPF_ev_tapsirigi_verilib_2._05._2019_
{
    /// <summary>
    /// Interaction logic for ShowItemWindow.xaml
    /// </summary>
    public partial class ShowItemWindow : Window
    {
        public ShowItemWindow(ListboxItemnmsp.ListboxItem listboxitem)
        {
            InitializeComponent();
            this.DataContext = this;
            GameTextblock.Text = listboxitem.ItemName;
            PriceTextblock.Text = listboxitem.ItemPrice.ToString();
            Operatingtxtbox.Text = listboxitem.ItemOperatingSystem;
            Yeartxtbox.Text = listboxitem.ItemYear.ToString();
        }
    }
}
