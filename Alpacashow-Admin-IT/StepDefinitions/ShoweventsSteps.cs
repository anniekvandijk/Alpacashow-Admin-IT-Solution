using System;
using System.IO;
using System.Net.Http;
using Alpacashow_Admin_SpecflowTests.Actions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Alpacashow_Admin_SpecflowTests.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Alpacashow_Admin_SpecflowTests.StepDefinitions
{
   [Binding]
   public class ShoweventsSteps
   {
        IWebDriver _driver;
        private static readonly string _projectDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

        [AfterScenario]
        public void AfterScenario()
        {
            //_driver.Dispose();
        }

        [Given(@"de volgende showevents zijn aanwezig")]
        [Given(@"the following showevents are present")]
      public void ShoweventsPresent(Table table)
      {
          ShoweventsActions.CreateShowevents(table);
      }

        // Frontend-steps

        [When(@"ik naar de pagina 'showevents' ga")]
        public void AlsIkNaarDePaginaGa()
        {
            string frontendUrl = (string) FeatureContext.Current["frontend-url"];
            _driver = new ChromeDriver(_projectDir + @"\Alpacashow-Admin-IT\Drivers");
            _driver.Manage().Window.Maximize();
            ScenarioContext.Current["driver"] = _driver;
            _driver.Navigate().GoToUrl(frontendUrl);
            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            _driver.FindElement(By.LinkText("Alpacashows")).Click();

        }

        [Then(@"verwacht ik de volgende showevents")]
        public void DanVerwachtIkDeVolgendeShowevents(Table table)
        {
            ScenarioContext.Current.Pending();
        }


        // Webservice steps

      [Then(@"i expect exact the following result of showevents")]
      public void ExactShoweventResult(Table expectedShoweventsTable)
      {
         Assert.IsTrue(GetActualAndExpectedContent(expectedShoweventsTable, CompareMethod.ExactMatch), DynamicObjectsComparer.GetDiffrences());
      }

      [Then(@"i expect at least the following result of showevents")]
      public void AtLeastShoweventResult(Table expectedShoweventsTable)
      {
         Assert.IsTrue(GetActualAndExpectedContent(expectedShoweventsTable, CompareMethod.MustContainExpected), DynamicObjectsComparer.GetDiffrences());
      }

      [Then(@"i expect exact the following specific results of showevents")]
      public void SpecificShoweventResult(Table expectedShoweventsTable)
      {
         Assert.IsTrue(GetActualAndExpectedContent(expectedShoweventsTable, CompareMethod.ExactMatchOfExpectedValues), DynamicObjectsComparer.GetDiffrences());
      }

      [Then(@"i expect at least the following specific results of showevents")]
      public void AtLeastSpecificShoweventResult(Table expectedShoweventsTable)
      {
         Assert.IsTrue(GetActualAndExpectedContent(expectedShoweventsTable, CompareMethod.MustContainExpectedValues), DynamicObjectsComparer.GetDiffrences());
      }

      private bool GetActualAndExpectedContent(Table expectedShoweventsTable, CompareMethod compareMethod)
      {
         var response = ScenarioContext.Current["webservice-response"] as HttpResponseMessage;
         var json = response.Content.ReadAsStringAsync().Result;
         
         // Use of dynamics to get result
         var jsonDeserilized = JsonConvert.DeserializeObject(json);
         dynamic actualContent = DynamicJsonConverter.CreateDynamicJsonSet(jsonDeserilized);
         dynamic expectedContent = expectedShoweventsTable.CreateDynamicSet();

         var equal = DynamicObjectsComparer.CompareDynamicObjects(expectedContent, actualContent, compareMethod);
         return equal;
      }
   }
}

