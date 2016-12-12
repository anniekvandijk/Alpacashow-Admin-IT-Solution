using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using TechTalk.SpecFlow;

namespace Alpacashow_Admin_SpecflowTests.StepDefinitions
{
    [Binding]
    public class WebserviceSteps
    {
        [Given(@"de volgende '(.*)' zijn aanwezig")]
        public void GegevenDeVolgendeShowsZijnAanwezig(String path, Table table)
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"ik alles opvraag via webservice '(.*)'")]
        public void AlsIkAlleShowsOpvraag(String path)
        {
         var settings = FeatureContext.Current["environment-settings"];

         string url = settings + path;

         var client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync(url).Result;

         ScenarioContext.Current.Add("webservice-response", response);
      }

      [When(@"ik '(.*)' opvraag van webservice '(.*)'")]
      public void AlsIkOpvraagMetKey(string key, string path)
      {
         var settings = FeatureContext.Current["environment-settings"];

         string url = settings + path + "/" + key;

         var client = new HttpClient();
         client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
         var response = client.GetAsync(url).Result;

         ScenarioContext.Current.Add("webservice-response", response);
      }

      [When(@"ik onderstaande opstuur naar webservice '(.*)'")]
      public void AlsIkDeVolgendeOpvoer(string path, string multilineText)
      {
         var settings = FeatureContext.Current["environment-settings"];

         string url = settings + path;

         var client = new HttpClient();
         StringContent content = new StringContent(multilineText);
         client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
         var response = client.PostAsync(url, content).Result;

         ScenarioContext.Current.Add("webservice-response", response);
      }

      [When(@"ik onderstaande wijziging opstuur voor '(.*)' naar webservice '(.*)'")]
      public void AlsIkOnderstaandeWijzigingOpstuurVoorKeyNaarWebservice(string key, string path, string multilineText)
      {
         var settings = FeatureContext.Current["environment-settings"];

         string url = settings + path + "/" + key;

         var client = new HttpClient();
         StringContent content = new StringContent(multilineText);
         client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
         var response = client.PutAsync(url, content).Result;

         ScenarioContext.Current.Add("webservice-response", response);
      }

      [When(@"ik een verwijderverzoek opstuur voor '(.*)' naar webservice '(.*)'")]
      public void AlsIkEenVerwijderverzoekOpstuurVoorKeyNaarWebservice(string key, string path)
      {
         var settings = FeatureContext.Current["environment-settings"];

         string url = settings + path + "/" + key;

         var client = new HttpClient();
         client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
         var response = client.DeleteAsync(url).Result;

         ScenarioContext.Current.Add("webservice-response", response);
      }

      [Then(@"verwacht ik een status '(.*)' met code (.*)")]
      public void DanVerwachtIkEenStatuscodeMetResponsemessage(string status, int code)
      {
         var result = ScenarioContext.Current["webservice-response"] as HttpResponseMessage;
         Assert.AreEqual(status, result.ReasonPhrase);
         Assert.AreEqual(code, (int)result.StatusCode);
      }

   }
}
