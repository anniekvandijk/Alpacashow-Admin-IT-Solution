using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Alpacashow_Admin_SpecflowTests.Utilities;
using TechTalk.SpecFlow;

namespace Alpacashow_Admin_SpecflowTests.StepDefinitions
{
    [Binding]
    public class WebserviceSteps
    {

      [When(@"i perform a 'GET' on webservice '(.*)'")]
      public void GetAllShowevents(String path)
      {
         SentRequest(string.Empty, path, null, "GET");
      }

      [When(@"i perform a 'GET' for '(.*)' on webservice '(.*)'")]
      public void GetShoweventWithKey(string key, string path)
      {
         SentRequest(key, path, null, "GET");
      }

      [When(@"i perform a 'POST' on webservice '(.*)'")]
      public void PostShowevent(string path, string multilineText)
      {
         StringContent content = new StringContent(multilineText, Encoding.UTF8, "application/json");
         SentRequest(string.Empty, path, content, "POST");
      }
   
      [When(@"i perform a 'PUT' for the following Json change on '(.*)' to webservice '(.*)'")]
      public void PutShoweventWithJson(string key, string path, string multilineText)
      {
         var content = new StringContent(multilineText, Encoding.UTF8, "application/json");
         SentRequest(key, path, content, "PUT");
      }

      [When(@"i perform a 'PUT' for the following change on '(.*)' to webservice '(.*)'")]
      public void PutShoweventWithTable(string key, string path, Table table)
       {
         var JsonString = TableConverter.VerticalTableToJson(table);
         var content = new StringContent(JsonString, Encoding.UTF8, "application/json");
         SentRequest(key, path, content, "PUT");
      }

      [When(@"i perform a 'PUT' with file '(.*)' on '(.*)' to webservice '(.*)'")]
      public void PutShoweventWithFile(string file, string key, string path)
      {
         var fileContent = File.ReadAllText($"./Testdata/Input/json/{file}.json");
         var content = new StringContent(fileContent, Encoding.UTF8, "application/json");
         SentRequest(key, path, content, "PUT");
      }

      [When(@"i perform a 'DELETE'  on  '(.*)' to webservice '(.*)'")]
      public void DeleteShowevent(string key, string path)
      {
         SentRequest(key, path, null, "DELETE");
      }

      [Then(@"i expect status '(.*)' with code (.*)")]
      public void ExpectedStatus(string status, int code)
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

         object existingResponse;
         if (ScenarioContext.Current.TryGetValue("webservice-response", out existingResponse))
         {
            ScenarioContext.Current.Remove("webservice-response");
         }
         ScenarioContext.Current.Add("webservice-response", response);
      }

   }
}
