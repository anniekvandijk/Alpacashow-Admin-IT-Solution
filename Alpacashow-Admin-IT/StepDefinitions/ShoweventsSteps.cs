using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
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
         var settings = FeatureContext.Current["environment-settings"];
         string url = settings + "showevents";

         var client = new HttpClient();
         client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
         var response = client.GetAsync(url).Result as HttpResponseMessage;
         var json = response.Content.ReadAsStringAsync().Result;

         string[] newTableHeader = new string[] {"name", "date", "closeDate", "location", "judge", "shows", "participants"};
         Table convertedTable = TableConverter.ChangeHorizontalTableHeader(expectedShoweventsTable, newTableHeader);

         // Use of dynamics to get result
         var jsonDeserilized = JsonConvert.DeserializeObject(json);
         dynamic actualContent = DynamicJsonConverter.CreateDynamicJsonSet(jsonDeserilized);
         dynamic expectedContent = convertedTable.CreateDynamicSet();
         Assert.IsTrue(DynamicObjectsComparer.CompareDynamicObjects(expectedContent, actualContent,
            CompareMethod.ExactMatch));
      }
   }
}

