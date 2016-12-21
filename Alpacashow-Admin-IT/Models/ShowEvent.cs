using System.Collections.Generic;

namespace Alpacashow_Admin_SpecflowTests.Models
{
   public class ShowEvent
   {
      public string name { get; set; }
      public string date { get; set; }
      public string closeDate { get; set; }
      public string location { get; set; }
      public string judge { get; set; }
      public List<Show> shows { get; set; }
      public List<object> participants { get; set; }
   }
}

