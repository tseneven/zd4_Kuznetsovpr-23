using System;
using System.Collections.Generic;
using Xamarin.Forms;
using zd4_Kuznetsovpr_23.ViewModels;
using zd4_Kuznetsovpr_23.Views;

namespace zd4_Kuznetsovpr_23
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
