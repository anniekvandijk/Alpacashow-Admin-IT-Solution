using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Alpacashow_Admin_SpecflowTests.Configuration
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
         var settings = Settings.Instance.ActiveSettings;

         FeatureContext.Current.Add("Settings-url", settings.Url);
      }
   }
}
