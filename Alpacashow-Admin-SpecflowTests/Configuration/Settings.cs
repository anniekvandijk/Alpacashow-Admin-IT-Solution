using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Alpacashow_Admin_SpecflowTests.Configuration
{
   /// <summary>
   /// The Settings.
   /// </summary>
   [XmlRoot(ConfigurationSectionName)]
   public class Settings
   {
      /// <summary>
      /// The name of the configuration section.
      /// </summary>
      internal const string ConfigurationSectionName = "environmentSettings";

      private static readonly Lazy<Settings> _lazyInstance;

      /// <summary>
      /// Initializes static members of the <see cref="Settings" /> class.
      /// </summary>
      static Settings()
      {
         _lazyInstance = new Lazy<Settings>(ReadConfiguration);
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="Settings" /> class.
      /// </summary>
      internal Settings()
      {
      }

      /// <summary>
      /// Gets the singeton instance of the <see cref="Settings"/> class.
      /// </summary>
      public static Settings Instance => _lazyInstance.Value;

      /// <summary>
      /// Gets or sets the active platform.
      /// </summary>
      public string ActivePlatform { get; set; }

      /// <summary>
      /// Gets or sets the active platform.
      /// </summary>
      [XmlIgnore]
      public Platform ActiveSettings => Platforms.Single(p => p.Name == ActivePlatform);

      /// <summary>
      /// Gets or sets the platforms.
      /// </summary>
      [XmlArray("Platforms"), XmlArrayItem("Platform")]
      public Platform[] Platforms { get; set; }

      private static Settings ReadConfiguration()
      {
         var settings = XmlSection<Settings>.GetSettings(ConfigurationSectionName);
         return settings;
      }
   }
}

}
