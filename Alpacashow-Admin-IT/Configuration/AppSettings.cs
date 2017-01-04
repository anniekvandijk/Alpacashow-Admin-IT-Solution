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

      public static string getWebserviceUrl ()
      {
         var actEnv = GetActiveEnvironment();
         if (actEnv == "Local")
         {
            return ConfigurationManager.AppSettings["LocalWebserviceUrl"];
         }
         if (actEnv == "Docker")
         {
            return ConfigurationManager.AppSettings["DockerWebserviceUrl"];
         } else
         {
            throw new SettingsPropertyNotFoundException("No settings for ActiveEnvironment '" + actEnv + "'");
         }
      }

        public static string getFrontendUrl()
        {
            var actEnv = GetActiveEnvironment();
            if (actEnv == "Local")
            {
                return ConfigurationManager.AppSettings["LocalFrontendUrl"];
            }
            else
            {
                throw new SettingsPropertyNotFoundException("No settings for ActiveEnvironment '" + actEnv + "'");
            }
        }

        public static string GetActiveEnvironment ()
      {
         return ConfigurationManager.AppSettings["ActiveEnvironment"];
      }
   }
}




