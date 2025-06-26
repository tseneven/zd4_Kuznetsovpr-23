using System.ComponentModel;
using Xamarin.Forms;
using zd4_Kuznetsovpr_23.ViewModels;

namespace zd4_Kuznetsovpr_23.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}