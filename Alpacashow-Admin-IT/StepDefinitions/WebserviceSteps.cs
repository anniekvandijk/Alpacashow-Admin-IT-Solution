using Alpacashow_Admin_IT.Configuration;
using System;
using System.Net.Http;
using TechTalk.SpecFlow;

namespace Alpacashow_Admin_SpecflowTests.StepDefinitions
{
    [Binding]
    public class WebserviceSteps
    {
        [Given(@"de volgende '(showevents)' zijn aanwezig")]
        public void GegevenDeVolgendeShowsZijnAanwezig(String path, Table table)
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"ik alle '(showevents)' opvraag")]
        public void AlsIkAlleShowsOpvraag(String path)
        {
         var settings = FeatureContext.Current["environment-settings"];

         string url = $"{settings}{path}";

         var client = new HttpClient();
         var response = client.GetAsync(url).Result;

         ScenarioContext.Current.Add("webservice-response", response);
      }
        
        [Then(@"verwacht ik de volgende '(showevents)' als resultaat")]
        public void DanVerwachtIkDeVolgendeShowsAlsResultaat(String path, Table table)
        {
         var result = ScenarioContext.Current["webservice-response"];

           ScenarioContext.Current.Pending();
      }
   }
}
