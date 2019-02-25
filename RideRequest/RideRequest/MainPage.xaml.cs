using dotMorten.Xamarin.Forms;
using Newtonsoft.Json;
using RideRequest.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RideRequest
{
    public partial class MainPage : ContentPage
    {
        readonly string HereAppId = "MOoAGnNIBrHgC51qjnDC";
        readonly string HereAppCode = "5SwcjloK8L5OxUHhwJ7aIw";
        public MainPage()
        {
            InitializeComponent();
        }

        private async void SuggestBox_TextChanged(object sender, dotMorten.Xamarin.Forms.AutoSuggestBoxTextChangedEventArgs args)
        {
            AutoSuggestBox box = (AutoSuggestBox)sender;
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                if (string.IsNullOrWhiteSpace(box.Text) || box.Text.Length < 3)
                    box.ItemsSource = null;
                else
                {
                    var suggestions = await GetSuggestions(box.Text);
                    box.ItemsSource = suggestions.ToList();
                }
            }
        }

        private async Task<List<Suggestions>> GetSuggestions(string text)
        {
            var result = Task.Run(async () =>
            {
                var urlToGetSuggestions = string.Format(
                    "http://autocomplete.geocoder.api.here.com/6.2/suggest.json?query={0}"+
                    "&app_id={1}" +
                    "&app_code={2}", text, HereAppId, HereAppCode);

                var places = new List<Suggestions>();
                HttpClient client = new HttpClient();
                var matches = await client.GetStringAsync(urlToGetSuggestions);
                var matchesJson = JsonConvert.DeserializeObject<Suggestions>(matches);
                
                return places;
            });
            await Task.Delay(1000); //Simulate slow web service response
            return await result;
        }

        private void SuggestBox_QuerySubmitted(object sender, AutoSuggestBoxQuerySubmittedEventArgs e)
        {
            if (e.ChosenSuggestion == null)
                status.Text = "Query submitted: " + e.QueryText;
            else
                status.Text = "Suggestion chosen: " + e.ChosenSuggestion;
        }
    }
}
