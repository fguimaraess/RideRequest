using dotMorten.Xamarin.Forms;
using Newtonsoft.Json;
using RideRequest.Model;
using RideRequest.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RideRequest.View
{
    public partial class ListagemView : ContentPage
    {
        public ListagemViewModel ViewModel { get; set; }
        public ListagemView()
        {
            InitializeComponent();
            this.ViewModel = new ListagemViewModel();
            this.BindingContext = this.ViewModel;
        }

        private async void OnChangeOrigin(object sender, dotMorten.Xamarin.Forms.AutoSuggestBoxTextChangedEventArgs args)
        {
            AutoSuggestBox box = (AutoSuggestBox)sender;
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                if (string.IsNullOrWhiteSpace(box.Text) || box.Text.Length < 3)
                    box.ItemsSource = null;
                else
                {
                    var suggestions = await this.ViewModel.GetSuggestions(box.Text);
                    box.ItemsSource = suggestions.ToList();
                }
            }
        }

        private async void OnChangeDestiny(object sender, dotMorten.Xamarin.Forms.AutoSuggestBoxTextChangedEventArgs args)
        {
            AutoSuggestBox box = (AutoSuggestBox)sender;
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                if (string.IsNullOrWhiteSpace(box.Text) || box.Text.Length < 3)
                    box.ItemsSource = null;
                else
                {
                    var suggestions = await this.ViewModel.GetSuggestions(box.Text);
                    box.ItemsSource = suggestions.ToList();
                }
            }
        }
        

        private void ChooseOrigin(object sender, AutoSuggestBoxQuerySubmittedEventArgs e)
        {
            if (e.ChosenSuggestion == null)
            {
                this.ViewModel.originAddress = null;
            }
            else
            {
                this.ViewModel.originAddress = (Address)e.ChosenSuggestion;
            }
        }

        private void ChooseDestiny(object sender, AutoSuggestBoxQuerySubmittedEventArgs e)
        {
            if (e.ChosenSuggestion == null)
            {
                this.ViewModel.originAddress = null;
            }
            else
            {
                this.ViewModel.destinyAddress = (Address)e.ChosenSuggestion;
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<Address[]>(this, "Lugares", (lugares) => 
            {
                Navigation.PushAsync(new DetalheView(lugares));
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Address[]>(this, "Lugares");
        }
    }
}
