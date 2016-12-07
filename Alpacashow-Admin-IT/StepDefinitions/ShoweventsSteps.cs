using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Dynamic;
using System.Net.Http;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

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
        public async void DanVerwachtIkDeVolgendeShoweventsAlsResultaat(Table showeventsTable)
        {

            var result = ScenarioContext.Current["webservice-response"] as HttpResponseMessage;

            // convert actual Json response
            var json = await result.Content.ReadAsStringAsync();
            dynamic actualContent = JsonConvert.DeserializeObject(json);
            foreach (dynamic actualShowevent in actualContent)
            {
               var actualName = actualShowevent.name;
               var actualDate = actualShowevent.date;
               var actualCloseDate = actualShowevent.closeDate;
               var actualLocation = actualShowevent.location;
               var actualJudge = actualShowevent.judge;
               foreach (var show in actualShowevent.show)
               {
                  var actualShowType = show.showType;
               }
            }

            // convert expected response
            dynamic dynamicShoweventsSet = showeventsTable.CreateDynamicSet();
            foreach (dynamic expectedShowevent in dynamicShoweventsSet)
            {
               var expectedName = expectedShowevent.naam;
               var expectedDate = expectedShowevent.datum;
               var expectedCloseDate = expectedShowevent.sluitingsdatum;
               var expectedLocation = expectedShowevent.locatie;
               var expectedJudge = expectedShowevent.jury;
               foreach (var show in expectedShowevent.show)
               {
                  var expectedShowType = show.showType;
               }
               
            }

        }
    }
}
