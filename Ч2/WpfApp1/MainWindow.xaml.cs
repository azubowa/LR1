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
using ЛабТП1.Kontroler;
using ЛабТП1.Model;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        order oformlenie = new order();
        menu todayMenu;
        public MainWindow()
        {
            todayMenu = new menu();

            InitializeComponent();

            MenuView.ItemsSource = todayMenu.MyMenu;
            OrderList.ItemsSource = oformlenie.C;
            AllOrders.ItemsSource = oformlenie.D;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (MenuView.SelectedItem == null)
            {
                MessageBox.Show("Выберите блюдо из меню");
            }
            else if (Convert.ToInt32(Kolvo.Text) <= 0)
            {
                MessageBox.Show("Введите количество корректно");
            }
            else
                try
                {
                    bool v = oformlenie.ChoseItem((interfacefood)MenuView.SelectedItem, Convert.ToInt32(Kolvo.Text));
                }
                catch (Exception)
                {
                    MessageBox.Show("Введите количество с помощью цифр");
                }
            OrderList.Items.Refresh();
        }

        private void EndOrder_Click(object sender, RoutedEventArgs e)
        {
            if (OrderList.Items.Count == 0)
            {
                MessageBox.Show("Выберите блюдо из меню");
            }
            else
                try
                {
                    oformlenie.FinishOrder();
                    OrderList.ItemsSource = oformlenie.C;
                }
                catch (Exception)
                {
                    MessageBox.Show("Выберите блюдо из меню");
                }
            AllOrders.Items.Refresh();
        }

        private void ClearOrderClick(object sender, RoutedEventArgs e)
        {
            if (OrderList.Items.Count == 0)
            {
                MessageBox.Show("Выберете блюдо из меню");
            }
            else
                try
                {
                    oformlenie.C.Clear();
                    name.Clear();
                    cost.Clear();
                    time.Clear();
                    cost1.Clear();
                    weight.Clear();
                    Kolvo.Clear();
                }
                catch
                {
                    MessageBox.Show("Выберете блюдо из меню");
                }
        }


        private void MenuView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MenuList(object sender, RoutedEventArgs e)
        {
            MenuView.ItemsSource = todayMenu.MyMenu;
        }

        private void OldOrderView_Click(object sender, RoutedEventArgs e)
        {
                if (AllOrders.SelectedItem == null)
                {
                    MessageBox.Show("Выберите заказ из списка");
                }
                else
                    try
                    {
                        OrderList.ItemsSource = ((total)AllOrders.SelectedItem).orderlist;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Выберите заказ из списка");
                    }
            }

        private void AllOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Kolvo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OrderList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}