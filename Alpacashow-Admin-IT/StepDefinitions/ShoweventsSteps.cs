using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
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
         dynamic actualContent, expectedContent;
         GetActualAndExpectedContent(expectedShoweventsTable, out actualContent, out expectedContent);
         Assert.IsTrue(DynamicObjectsComparer.CompareDynamicObjects(expectedContent, actualContent,
            CompareMethod.ExactMatch), DynamicObjectsComparer.GetDiffrences());
      }

      [Then(@"verwacht ik in ieder geval de volgende showevents als resultaat")]
      public void DanVerwachtIkInIederGevalDeVolgendeShoweventsAlsResultaat(Table expectedShoweventsTable)
      {
         dynamic actualContent, expectedContent;
         GetActualAndExpectedContent(expectedShoweventsTable, out actualContent, out expectedContent);
         Assert.IsTrue(DynamicObjectsComparer.CompareDynamicObjects(expectedContent, actualContent,
            CompareMethod.MustContainExpected), DynamicObjectsComparer.GetDiffrences());
      }

      [Then(@"verwacht ik de volgende gegevens van showevents als resultaat")]
      public void DanVerwachtIkDeVolgendeGegevensVanShoweventsAlsResultaat(Table expectedShoweventsTable)
      {
         dynamic actualContent, expectedContent;
         GetActualAndExpectedContent(expectedShoweventsTable, out actualContent, out expectedContent);
         Assert.IsTrue(DynamicObjectsComparer.CompareDynamicObjects(expectedContent, actualContent,
            CompareMethod.ExactMatchOfExpectedValues), DynamicObjectsComparer.GetDiffrences());
      }

      [Then(@"verwacht ik in ieder geval de volgende gegevens van showevents als resultaat")]
      public void DanVerwachtIkInIederGevalDeVolgendeGegevensVanShoweventsAlsResultaat(Table expectedShoweventsTable)
      {
         dynamic actualContent, expectedContent;
         GetActualAndExpectedContent(expectedShoweventsTable, out actualContent, out expectedContent);
         Assert.IsTrue(DynamicObjectsComparer.CompareDynamicObjects(expectedContent, actualContent,
            CompareMethod.MustContainExpectedValues), DynamicObjectsComparer.GetDiffrences());
      }


      private static void GetActualAndExpectedContent(Table expectedShoweventsTable, out dynamic actualContent, out dynamic expectedContent)
      {
         var response = ScenarioContext.Current["webservice-response"] as HttpResponseMessage;
         var json = response.Content.ReadAsStringAsync().Result;
         
         // Use of dynamics to get result
         var jsonDeserilized = JsonConvert.DeserializeObject(json);
         actualContent = DynamicJsonConverter.CreateDynamicJsonSet(jsonDeserilized);
         expectedContent = expectedShoweventsTable.CreateDynamicSet();
      }


   }
}

