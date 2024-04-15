
namespace GMap.NET.MapProviders
{
   using System;

   /// <summary>
   /// GoogleSatelliteTilesMap provider
   /// </summary>
   public class GoogleSatelliteTilesMapProvider : GoogleMapProviderBase
   {
      public static readonly GoogleSatelliteTilesMapProvider Instance;

      GoogleSatelliteTilesMapProvider()
      {
      }

      static GoogleSatelliteTilesMapProvider()
      {
         Instance = new GoogleSatelliteTilesMapProvider();
      }

      public string Version = "955";

      #region GMapProvider Members

      readonly Guid id = new Guid("D2BE466F-1E81-94E5-9D1D-C581D34F8921");
      public override Guid Id
      {
         get
         {
            return id;
         }
      }

      readonly string name = Resources.Strings.GoogleSatelliteMap;
      public override string Name
      {
         get
         {
            return name;
         }
      }

      public override PureImage GetTileImage(GPoint pos, int zoom)
      {
         string url = MakeTileImageUrl(pos, zoom, LanguageStr);

         return GetTileImageUsingHttp(url);
      }

      #endregion

       string MakeTileImageUrl(GPoint pos, int zoom, string language)
       {
           string sec1 = string.Empty; // after &x=...
           string sec2 = string.Empty; // after &zoom=...
           GetSecureWords(pos, out sec1, out sec2);

           return string.Format(tileUrl, pos.X, pos.Y, zoom, sessionID, base.APIKey);
       }

       static readonly string UrlFormatServer = "khms";
      static readonly string UrlFormatRequest = "kh";
      static readonly string UrlFormat = "https://{0}{1}.{10}/{2}/v={3}&hl={4}&x={5}{6}&y={7}&z={8}&s={9}";
       static readonly string sessionUrl = "https://tile.googleapis.com/v1/createSession";
       static readonly string tileUrl = "https://tile.googleapis.com/v1/2dtiles/{2}/{0}/{1}?session={3}&key={4}";

    }
}