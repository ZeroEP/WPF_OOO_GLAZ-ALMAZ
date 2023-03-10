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
using WPF_OOO_GLAZ_ALMAZ.Entitys;

namespace WPF_OOO_GLAZ_ALMAZ
{
    /// <summary>
    /// Interaction logic for SypplyWindow.xaml
    /// </summary>
    public partial class SypplyWindow : Window
    {
        public SypplyWindow()
        {
            InitializeComponent();
            lvSupply.ItemsSource= EfModel.Init().Supplies.ToList();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            lvSupply.ItemsSource = EfModel.Init().Supplies.ToList().Where(x=>x.SupplyName== tbsearch.Text);
        }
    }
}
