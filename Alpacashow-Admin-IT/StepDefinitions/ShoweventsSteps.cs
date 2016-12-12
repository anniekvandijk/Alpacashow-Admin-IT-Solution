﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Dynamitey;
using System.Linq;

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

      //   Assert.IsTrue(CompareObjectCollections.actualContent, CompareObjectCollections.expectedContent);
      }
   }
}

