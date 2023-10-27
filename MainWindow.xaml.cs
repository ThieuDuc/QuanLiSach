using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Objects;
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
using QuanLySach;
namespace QuanLySach
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model1 db = new Model1();
        
        public MainWindow()
        {
            InitializeComponent();
            var listSach = db.Sach.ToList();
            datagridSach.ItemsSource = listSach;
            getData();
            HienThiLoaiSach();
        }
        public void getData()
        {
            datagridSach.ItemsSource = db.Sach.ToList();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void HienThiLoaiSach()
        {
            var listLoaiSach = db.loaisach.ToList();
            cbbLoaiSach.ItemsSource = listLoaiSach;
        }
        private void Add(object sender, RoutedEventArgs e)
        {
            Window1 insert = new Window1();
            insert.DataChanged += Window_DataChanged;
            insert.ShowDialog();
        }
        public ObservableCollection<Sach> Sachcollection { get; set; }

        private void Window_DataChanged(object sender , EventArgs e)
        {
            getData();
        }
        private void Confirm(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("HELLO");
            WindowTest confirm = new WindowTest();
            confirm.Show();
        }


        private void cbbLoaiSach_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int Maloaisach = -1;
            Maloaisach = int.Parse(cbbLoaiSach.SelectedValue.ToString());
            var dataSearch = db.Sach.Where(x => x.MAloaisach == Maloaisach).ToString();
            datagridSach.ItemsSource = dataSearch;
        }

        private void Button_Sua(object sender, RoutedEventArgs e)
        {
            try
            {
                int countSelecteditem = 0;
                countSelecteditem = datagridSach.SelectedItem.Count;
                if(countSelecteditem == 0)
                {
                    MessageBox.Show("Ban chua chon Item can sua ");
                }
                else
                {
                    Sach sachSelected = (Sach)datagridSach.SelectedItem;
                    int idSachSelected = sachSelected.Id_Sach;
                    Window1 insert = new Window1(idSachSelected);
                    insert.DataChanged += Window_DataChanged;
                    insert.ShowDialog();

                }
            }
            catch(Exception ex )
            {
                Console.WriteLine(ex);
            }
        }
    }
}
