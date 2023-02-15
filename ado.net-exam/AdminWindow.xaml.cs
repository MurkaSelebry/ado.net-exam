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
                table_customerD.ItemsSource = db.Клиенты_агенства.ToList();
                cities.ItemsSource = db.Города.ToList();
                countries.ItemsSource = db.Страны.ToList();
                hotels.ItemsSource = db.Гостиницы.ToList();
                seeing.ItemsSource = db.Достопримечательности.ToList();
                workers.ItemsSource = db.Работники_турагентства.ToList();
            }
            popular_touristD.ItemsSource = DL.tourists.tourist();

        }

        private void show_diap_Click(object sender, RoutedEventArgs e)
        {
            diap.ItemsSource = DL.tours.diap_tours(d1.SelectedDate.Value, d2.SelectedDate.Value);
        }

        private void show_trans_Click(object sender, RoutedEventArgs e)
        {
            trandD.ItemsSource = DL.tours.transport(transBox.Text);
        }

        private void visit_show_Click(object sender, RoutedEventArgs e)
        {
            visit_countryD.Text = DL.tourists.count_countries(country_visit.Text).ToString();
        }

        private void where_show_Click(object sender, RoutedEventArgs e)
        {
            whereD.ItemsSource = DL.tourists.where_tourist(where_text.Text);
        }

        private void show_intour_Click(object sender, RoutedEventArgs e)
        {
            in_tourD.Text = DL.customers.is_in_tour(text_in_tour.Text).ToString();
        }

        private void show_tour_customer_Click(object sender, RoutedEventArgs e)
        {
            tour_customerD.ItemsSource = DL.customers.listOfTours(tour_customer_text.Text);
        }

        private void delete_customer_Click(object sender, RoutedEventArgs e)
        {
            DL.customers.deleteCustomer(email.Text);
            table_customerD.ItemsSource = new Tourist_Entities().Клиенты_агенства.ToList();

        }
        string StringFromRichTextBox(RichTextBox rtb)
        {
            TextRange textRange = new TextRange(
                // TextPointer to the start of content in the RichTextBox.
                rtb.Document.ContentStart,
                // TextPointer to the end of content in the RichTextBox.
                rtb.Document.ContentEnd
            );

            // The Text property on a TextRange object returns a string
            // representing the plain text content of the TextRange.
            return textRange.Text;
        }
        private void Click_Insert(object sender, RoutedEventArgs e)
        {
            var s = StringFromRichTextBox(InsertData).Split(';');
            Клиенты_агенства new_customer = new Клиенты_агенства()
            {
                FIO = s[0],
                Phone = s[1],
                Email = s[2],
                DateOfBirth = DateTime.Parse(s[3]),
                FutureTours = s[4],
                PastTours = s[5]
            };
            DL.customers.insertCustomer(new_customer);
            table_customerD.ItemsSource = new Tourist_Entities().Клиенты_агенства.ToList();

        }


    }
}
