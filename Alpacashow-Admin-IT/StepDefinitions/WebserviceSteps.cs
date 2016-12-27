using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Alpacashow_Admin_SpecflowTests.Utilities;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Alpacashow_Admin_SpecflowTests.StepDefinitions
{
    [Binding]
    public class WebserviceSteps
    {

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
         var content = new StringContent(multilineText, Encoding.UTF8, "application/json");
         SentRequest(key, path, content, "PUT");
      }

       [When(@"ik onderstaande wijziging stuur voor '(.*)' naar webservice '(.*)'")]
      public void AlsIkOnderstaandeWijzigingStuurVoorNaarWebservice(string key, string path, Table table)
       {

         string[] newTableHeader = new string[] { "name", "date", "closeDate", "location", "judge", "shows", "participants" };
         Table convertedTable = TableConverter.ChangeVerticalTableToHorizontalWithNewHeader(table, newTableHeader);
          Table otherConvert = TableConverter.ChangeVerticalTableIds(table, newTableHeader);

         string JSONString = string.Empty;
         JSONString = JsonConvert.SerializeObject(table.CreateDynamicInstance());
         var content = new StringContent(JSONString, Encoding.UTF8, "application/json");
         SentRequest(key, path, content, "PUT");
      }



      [When(@"ik '(.*)' als wijziging stuur voor '(.*)' naar webservice '(.*)'")]
      public void AlsIkStuurVoorNaarWebservice(string file, string key, string path)
      {
         var fileContent = File.ReadAllText($"./Testdata/Input/json/{file}.json");
         var content = new StringContent(fileContent, Encoding.UTF8, "application/json");
         SentRequest(key, path, content, "PUT");
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

       private static void SentRequest(string key, string path, StringContent content, string HttpMethod)
       {
          var settings = FeatureContext.Current["environment-settings"];
          HttpResponseMessage response = null;
          var client = new HttpClient();
          client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

          string url;
          if (key.Equals(string.Empty))
          {
             url = settings + path;
          }
          else
          {
             url = settings + path + "/" + key;
          }

          if (HttpMethod == "PUT")
          {
             response = client.PutAsync(url, content).Result;
          }
          if (HttpMethod == "POST")
          {
             response = client.PostAsync(url, content).Result;
          }
          if (HttpMethod == "GET")
          { 
            response = client.GetAsync(url).Result;
          }
          if (HttpMethod == "DELETE")
          {
            response = client.DeleteAsync(url).Result;
         }

       ScenarioContext.Current.Add("webservice-response", response);
      }

   }
}
