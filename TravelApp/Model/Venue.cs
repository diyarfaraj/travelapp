using System.Collections.Generic;
using TravelApp.Helpers;

namespace TravelApp.Model
{
    public class VenueRoot
    {
        public Response response { get; set; }
        public static string GenerateUrl(string query)
        {
            
            return string.Format(Constants.VENUE_SEARCH, query);
        }
        

    }
    
    public class Location
    {
        public string Address { get; set; }
        public string CrossStreet { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public int Distance { get; set; }
        public string PostalCode { get; set; }
        public string Cc { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }

    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string PluralName { get; set; }
        public string ShortName { get; set; }
        public bool Primary { get; set; }
    }


    public class Venue
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Location Location { get; set; }
        public IList<Category> Categories { get; set; }
        public int Code { get; set; }
        public string RequestId { get; set; }
    }

    public class Response
    {
        public IList<Venue> Venues { get; set; }
    }
}