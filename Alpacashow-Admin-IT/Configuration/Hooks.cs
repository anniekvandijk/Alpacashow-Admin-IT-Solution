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
        var env = AppSettings.GetActiveEnvironment();
        var webserviceUrl = AppSettings.getWebserviceUrl();
        var frontendUrl = AppSettings.getFrontendUrl();

        FeatureContext.Current.Add("active-environment", env);
        FeatureContext.Current.Add("webservice-url", webserviceUrl);
        FeatureContext.Current.Add("frontend-url", frontendUrl);
     }
   }
}
