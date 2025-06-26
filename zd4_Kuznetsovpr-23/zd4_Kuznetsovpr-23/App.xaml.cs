using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using zd4_Kuznetsovpr_23.Services;
using zd4_Kuznetsovpr_23.Views;
using zd4_Kuznetsovpr23;

namespace zd4_Kuznetsovpr_23
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new Calculatorxaml();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
