using RideRequest.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

namespace RideRequest.ViewModel
{
    public class DetalheViewModel
    {
        Shared shared = new Shared();
        public DetalheViewModel(Address[] Lugares)
        {
            //Get Latitude/longitude
            var AddressDetailOrigem = GetLatitudeLongitude(Lugares[0]);
            var AddressDetailDestino = GetLatitudeLongitude(Lugares[1]);

            //Get Uber Prices
            var uberPrice = GetUberPrice(AddressDetailOrigem, AddressDetailDestino);
            
            //Cabify TODO

        }

        private AddressDetail GetLatitudeLongitude(Address Lugar)
        {
            var urlToGetDetails = shared.URL_GET_LAT_LONG + 
                string.Format("geocode.json?locationid={0}&jsonattributes=1&gen=9&app_id={1}&app_code={2}"+
                    "&app_id={1}" +
                    "&app_code={2}", Lugar.LocationId, shared.HereAppId, shared.HereAppCode);

            var placeDetail = new AddressDetail();
            HttpClient client = new HttpClient();
            var matches = client.GetStringAsync(urlToGetDetails);
            //Deserializar aqui e retornar para calcular os preços

            return placeDetail;
        }

        public string GetUberPrice(AddressDetail origem, AddressDetail destino)
        {
            var urlEstimatedPrice = shared.URL_UBER_PRICE +
                string.Format("price?start_latitude={0}&start_longitude={1}&end_latitude={2}&end_longitude={3}",
                origem.latitude, origem.longitude, destino.latitude, destino.longitude);

            var estimatedPrices = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlEstimatedPrice);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            request.Headers["Authorization"] = "Token " + shared.server_token;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                estimatedPrices = reader.ReadToEnd();
            }

            return estimatedPrices;
        }
    }
}
