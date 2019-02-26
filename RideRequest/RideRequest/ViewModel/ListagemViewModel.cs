using Newtonsoft.Json;
using RideRequest.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RideRequest.ViewModel
{
    public class ListagemViewModel
    {
        public Address originAddress;
        public Address destinyAddress;
        public ICommand SearchCommand { get; set; }
        private Shared shared = new Shared();

        public ListagemViewModel()
        {
            SearchCommand = new Command(() =>
            {
                var lugares = new Address[]{ this.originAddress, this.destinyAddress};
                MessagingCenter.Send(lugares, "Lugares");
            }, () => //Can Execute?
            {
                return (this.originAddress != null && this.destinyAddress != null);
            });
        }

        public async Task<List<Address>> GetSuggestions(string text)
        {
            var result = Task.Run(async () =>
            {
                var urlToGetSuggestions = string.Format(
                    "http://autocomplete.geocoder.api.here.com/6.2/suggest.json?query={0}" +
                    "&app_id={1}" +
                    "&app_code={2}", text, shared.HereAppId, shared.HereAppCode);

                var places = new List<Address>();
                HttpClient client = new HttpClient();
                var matches = await client.GetStringAsync(urlToGetSuggestions);

                var matchesJson = JsonConvert.DeserializeObject<Suggestions>(matches);
                foreach (var place in matchesJson.suggestions)
                {
                    places.Add(new Address
                    {
                        City = place.Address.City,
                        Country = place.Address.Country,
                        State = place.Address.State,
                        LocationId = place.locationId,
                        DisplayName = $"{place.label}, {place.Address.State}",
                        FullDisplayName = $"{place.label}, {place.Address.State}, {place.Address.Country}",
                    });
                }


                return places;
            });
            await Task.Delay(1000); //Simulate slow web service response
            return await result;
        }
        
    }
}
