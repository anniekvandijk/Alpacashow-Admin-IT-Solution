using System.Configuration;


namespace Alpacashow_Admin_IT.Configuration
{
   /// <summary>
   /// Gets the settings from app.config
   /// </summary>
   public class Environment : ConfigurationSection
   {

      public static Environment Settings
      {
         get
         {
            return ConfigurationManager.GetSection("Environment") as Environment; 
         }
      }

      [ConfigurationProperty("environmentName" , IsRequired = true)]
      public string EnvironmentName
      {
         get { return (string)this["environmentName"]; }
         set { this["environmentName"] = value; }
      }
   }

}


