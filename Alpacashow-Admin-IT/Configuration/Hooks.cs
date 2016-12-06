using TechTalk.SpecFlow;

namespace Alpacashow_Admin_IT.Configuration
{
   /// <summary>
   ///
   /// </summary>
   [Binding]
   public static class Hooks
   {
      /// <summary>
      /// Befores the feature.
      /// </summary>
      [BeforeFeature]
      public static void BeforeFeature()
      {
         //var settings = Environment.Settings.EnvironmentName;

         string url = $"http://localhost:8081/webservice/";
         FeatureContext.Current.Add("environment-settings", url);
      }
   }
}
