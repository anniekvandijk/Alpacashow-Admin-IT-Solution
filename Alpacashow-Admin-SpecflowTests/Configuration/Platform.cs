using System.Xml.Serialization;

namespace Alpacashow_Admin_SpecflowTests.Configuration
{
   public class Platform
   {
      /// <summary>
      /// Gets or sets the name.
      /// </summary>
      [XmlAttribute]
      public string Name { get; set; }

      /// <summary>
      /// Gets or sets the RootURL.
      /// </summary>
      public string Url { get; set; }

   }
}
