using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TravelApp.Model;

namespace TravelApp.Logic
{
    public class VenueLogic
    {
        public static async Task<List<Venue>> GetVenues(string query)
        {
            List<Venue> venues = new List<Venue>();
            var url = VenueRoot.GenerateUrl(query);
            using (HttpClient client = new HttpClient())
            {
                var res = await client.GetAsync(url);
                var json = await res.Content.ReadAsStringAsync();
                var venueRoot = JsonConvert.DeserializeObject<VenueRoot>(json);
                venues = venueRoot.response.Venues as List<Venue>;

            }
            return venues;
        }
    }
}