using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Net.Http;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Linq;
using System.Collections.Generic;
using System;
using Newtonsoft.Json.Linq;

namespace Alpacashow_Admin_SpecflowTests.StepDefinitions
{
   [Binding]
   public class ShoweventsSteps
   {
      [Given(@"de volgende showevents zijn aanwezig")]
      public void GegevenDeVolgendeShoweventsZijnAanwezig(Table table)
      {
         //ScenarioContext.Current.Pending();
      }

      [Then(@"verwacht ik de volgende showevents als resultaat")]
      public void DanVerwachtIkDeVolgendeShoweventsAlsResultaat(Table expectedShoweventsTable)
      { 
         var result = ScenarioContext.Current["webservice-response"] as HttpResponseMessage;

         var json = result.Content.ReadAsStringAsync().Result;
         dynamic actualContent = JsonConvert.DeserializeObject(json);
         dynamic expectedContent = expectedShoweventsTable.CreateDynamicSet();
         Assert.IsTrue(DynamicObjectsComparer(expectedContent, expectedContent));
      }

      public static bool DynamicObjectsComparer (dynamic expectedContent, dynamic actualContent)
      {
         var isEqual = false;

         foreach (dynamic expCont in expectedContent)
         {
            var expContSortedList = GetSortedList(expCont);
            foreach (dynamic actCont in actualContent)
            {
               var actContSortedList = GetSortedList(actCont);
                isEqual = expContSortedList.SequenceEqual(actContSortedList);
            }
         }

         return isEqual;
      }

      /// <summary>
      /// Sorts Lists of Key-Value pairs by Key.
      /// </summary>
      /// <param name="Content">Dynamic content.</param>
      /// <returns>Asending sorted List of Key-Value pairs.</returns>
      private static List<KeyValuePair<string, object>> GetSortedList (dynamic Content)
      {
         var keyValuePairList = new List<KeyValuePair<string, object>>();
         foreach (KeyValuePair<string, object> kvp in Content)
         {
            keyValuePairList.Add(new KeyValuePair<string, object>(kvp.Key, kvp.Value));
         }
         keyValuePairList.Sort(SortKeyValuePairByKey);
         return keyValuePairList;
      }

      /// <summary>
      /// Sorts Key-Value pairs by Key.
      /// </summary>
      /// <param name="a">First Key-Value pair.</param>
      /// <param name="b">Second Key-Value pair.</param>
      /// <returns>Asending Key-Value pairs.</returns>
      private static int SortKeyValuePairByKey(KeyValuePair<string, object> a, KeyValuePair<string, object> b)
      {
         return a.Key.CompareTo(b.Key);
      }
   }
}

