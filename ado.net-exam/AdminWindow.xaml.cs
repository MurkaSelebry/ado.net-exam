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
using ado.net_exam.DataLayer;

namespace ado.net_exam
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
            popular_tourD.ItemsSource = DL.tours.tour();
            unpopular_tourD.ItemsSource= DL.tours.untour();
            using (var db = new Tourist_Entities())
            {
                table_tour.ItemsSource = db.Туры.ToList();
                table_arc_tour.ItemsSource = db.Архивные_туры.ToList();
            }
        }

        private void show_diap_Click(object sender, RoutedEventArgs e)
        {
            diap.ItemsSource = DL.tours.diap_tours(d1.SelectedDate.Value, d2.SelectedDate.Value);
        }

        private void show_trans_Click(object sender, RoutedEventArgs e)
        {
            trandD.ItemsSource = DL.tours.transport(transBox.Text);
        }
    }
}
