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
using QuanLySach;

namespace QuanLySach
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Model1 db = new Model1();
        public delegate void DataChangedEventHnadler(object sender, EventArgs e);
        public event DataChangedEventHnadler DataChanged;
        private int id = -1;
        public Window1()
        {
            InitializeComponent();
            HienThiLoaiSach();
        }

        public Window1(int idSachSelected): this()
        {
            id = idSachSelected;
            HienThiLoaiSach();
            HienThiDuLieuSua();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try {   // Lấy dữ liệu từ các TextBox
            string Masach = Ma_Sach.Text;
            string name = Ten_Sach.Text;
            int dongia = int.Parse(Don_Gia.Text);
            int soluong = int.Parse(So_Luong.Text);
            int LoaiSach = int.Parse(cbbLoaiSach.SelectedValue.ToString());

            var sach = new Sach();
            sach.MaSach = Masach;
            sach.TenSach = name;
            sach.DonGia = dongia;
            sach.SoLuong = soluong;
            sach.MAloaisach = LoaiSach;
            db.Sach.Add(sach);
            db.SaveChanges();
            MessageBox.Show("Them du lieu thanh cong ! ", "Thong Bao", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            this.Close();
                DataChangedEventHnadler handler = DataChanged;
                if(handler != null)
                {
                    handler(this, new EventArgs());
                }
            }
            catch
            {
                MessageBox.Show("Co loi xay ra vui long kiem tra lai! ", "Thong Bao", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
         
        }
        public void HienThiLoaiSach()
        {
            var listDS = db.loaisach.ToList();
            cbbLoaiSach.ItemsSource = listDS;
        }
        public void HienThiDuLieuSua()
        {
            var sachSelected = db.Sach.Find(id);
            if(sachSelected != null)
            {
                Ma_Sach.Text = sachSelected.MaSach.ToString();
                Ten_Sach.Text = sachSelected.TenSach.ToString();
                Don_Gia.Text = sachSelected.DonGia.ToString();
                So_Luong.Text = sachSelected.SoLuong.ToString();
                loaisach LoaiSach = db.loaisach.Find(sachSelected.MAloaisach);
                cbbLoaiSach.SelectedItem = LoaiSach;
            }
        }


    }
}
