using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BTT2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageListView : ContentPage
	{
        ObservableCollection<hoa> listHoa = new ObservableCollection<hoa>();
		public PageListView ()
		{
			InitializeComponent ();
            listHoa.Add( new hoa { TenHoa = "Hoa Hồng", Gia = 50000, Hinh = "HoaHong.png", MoTa = "Hoa hồng đỏ, vàng, trắng" });
            listHoa.Add(new hoa { TenHoa = "Hoa Hướng Dương", Gia = 70000, Hinh = "HoaHuongDuong.png", MoTa = "Hoa mặt trời." });
            listHoa.Add(new hoa { TenHoa = "Hoa Tu Líp", Gia = 100000, Hinh = "HoaTuLip.png", MoTa = "Hoa Tu Líp Tím, Vàng." });
            lsvHoa.ItemsSource = listHoa;
		}
	}
}