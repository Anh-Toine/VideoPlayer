using System;
using System.Collections.Generic;
using VideoPlayer.ViewModels;
using VideoPlayer.Views;
using Xamarin.Forms;

namespace VideoPlayer
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
