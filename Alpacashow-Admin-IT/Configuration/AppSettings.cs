using System.Collections;
using System.Configuration;
using System.Xml.Serialization;

namespace Alpacashow_Admin_IT.Configuration
{
   /// <summary>
   /// Gets the settings from app.config
   /// </summary>
   public class AppSettings
   {

      public static string getEnvironmentUrl ()
      {
         var actEnv = GetActiveEnvironment();
         if (actEnv == "Local")
         {
            return ConfigurationManager.AppSettings["LocalUrl"];
         }
         if (actEnv == "Docker")
         {
            return ConfigurationManager.AppSettings["DockerUrl"];
         } else
         {
            throw new SettingsPropertyNotFoundException("No settings for ActiveEnvironment '" + actEnv + "'");
         }
      }

      private static string GetActiveEnvironment ()
      {
         return ConfigurationManager.AppSettings["ActiveEnvironment"];
      }
   }
}




