using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Net.Http;
using Alpacashow_Admin_SpecflowTests.Models;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Alpacashow_Admin_SpecflowTests.Utilities;

namespace Alpacashow_Admin_SpecflowTests.StepDefinitions
{
   [Binding]
   public class ShoweventsSteps
   {
      [Given(@"de volgende showevents zijn aanwezig")]
      public void GegevenDeVolgendeShoweventsZijnAanwezig(Table table)
      {
         //ScenarioContext.Current.Pending();
         dynamic tableContent = table.CreateDynamicSet();
         ScenarioContext.Current.Add("temp", tableContent);
      }

      [Then(@"verwacht ik de volgende showevents als resultaat")]
      public void DanVerwachtIkDeVolgendeShoweventsAlsResultaat(Table expectedShoweventsTable)
      { 
         var result = ScenarioContext.Current["webservice-response"] as HttpResponseMessage;

         var json = result.Content.ReadAsStringAsync().Result;
         var actualContent1 = JsonConvert.DeserializeObject<ShowEvent[]>(json);

         string[] newTableHeader = new string[] { "name", "date", "closeDate", "location", "judge", "shows", "participants" };
         Table convertedTable = TableConverter.ChangeHorizontalTableHeader(expectedShoweventsTable, newTableHeader);

         var expectedContent1 = expectedShoweventsTable.CreateSet<ShowEvent>();

         // Use of dynamics to get result
         dynamic actualContent = JsonConvert.DeserializeObject(json);
         dynamic expectedContent = expectedShoweventsTable.CreateDynamicSet();
         Assert.IsTrue(ObjectsComparer.DynamicObjectsComparer(expectedContent, actualContent));
      }
   }
}

