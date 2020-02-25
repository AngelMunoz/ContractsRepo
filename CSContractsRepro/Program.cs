using System;
using System.Threading.Tasks;

namespace CSContractsRepro
{
  class Program
  {
    static async Task Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      var locator = new Windows.Devices.Geolocation.Geolocator();
      var location = await locator.GetGeopositionAsync();
      var position = location.Coordinate.Point.Position;
      var latlong = string.Format("lat:{0}, long:{1}", position.Latitude, position.Longitude);
      Console.WriteLine(latlong);
    }
  }
}
