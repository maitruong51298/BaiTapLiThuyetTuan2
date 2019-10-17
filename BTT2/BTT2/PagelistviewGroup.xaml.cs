using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BTT2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PagelistviewGroup : ContentPage
	{
		public PagelistviewGroup ()
		{
			InitializeComponent ();
            LoaiHoa l = new LoaiHoa();
            lstHoa.ItemsSource = l.ListLoaiHoa;
		}
	}
}