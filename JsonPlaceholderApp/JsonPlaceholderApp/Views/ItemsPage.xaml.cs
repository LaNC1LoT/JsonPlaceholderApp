using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using JsonPlaceholderApp.Models;
using JsonPlaceholderApp.Views;
using JsonPlaceholderApp.ViewModels;

namespace JsonPlaceholderApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();

            viewModel.Message = Display;
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (!(args.SelectedItem is Item item))
                return;

            //await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            ItemsListView.SelectedItem = null;
            
        }

        //async void AddItem_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        //}

        private async void Display(string title, string message)
        {
            await DisplayAlert(title, message, "OK");
        }
        

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (!viewModel.Items.Any())
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}