using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BTT2
{
    public partial class MainPage : ContentPage
    {
    
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageListView());
        }
        private void Button_Clicked1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageListView());
        }

    }
}
