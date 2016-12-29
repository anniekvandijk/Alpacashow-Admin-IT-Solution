﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Alpacashow_Admin_SpecflowTests.Features.Webservice
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class ShoweventsCRUDFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ShowEvents.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("nl-NL"), "Showevents CRUD", "   Als gebruiker moet ik showevents kunnen \r\n   opvragen, toevoegen wijzigen en v" +
                    "erwijderen\r\n   Wanneer het opgevraagde event niet bestaat of er gaat wat fout\r\n " +
                    "  Dan verwacht ik een duidelijke foutcode ", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Showevents CRUD")))
            {
                Alpacashow_Admin_SpecflowTests.Features.Webservice.ShoweventsCRUDFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 9
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "date",
                        "closeDate",
                        "location",
                        "judge",
                        "shows",
                        "participants"});
            table1.AddRow(new string[] {
                        "Assen 2017",
                        "2017-05-01",
                        "2017-04-01",
                        "Assen",
                        "Rob Bettinson",
                        "Haltershow, Fleeceshow",
                        ""});
            table1.AddRow(new string[] {
                        "Boekel 2017",
                        "2017-06-01",
                        "2017-05-01",
                        "Boekel",
                        "judge X",
                        "Haltershow",
                        ""});
#line 10
 testRunner.Given("de volgende showevents zijn aanwezig", ((string)(null)), table1, "Stel ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Opvragen van exact alle showevents")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Showevents CRUD")]
        public virtual void OpvragenVanExactAlleShowevents()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Opvragen van exact alle showevents", ((string[])(null)));
#line 15
this.ScenarioSetup(scenarioInfo);
#line 9
this.FeatureBackground();
#line 16
   testRunner.When("ik alles opvraag via webservice \'showevents\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Als ");
#line 17
   testRunner.Then("verwacht ik een status \'OK\' met code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dan ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "date",
                        "closeDate",
                        "location",
                        "judge",
                        "shows",
                        "participants"});
            table2.AddRow(new string[] {
                        "Boekel 2017",
                        "2017-06-01",
                        "2017-05-01",
                        "Boekel",
                        "judge X",
                        "Haltershow",
                        ""});
            table2.AddRow(new string[] {
                        "Assen 2017",
                        "2017-05-01",
                        "2017-04-01",
                        "Assen",
                        "Rob Bettinson",
                        "Haltershow, Fleeceshow",
                        ""});
#line 18
 testRunner.And("verwacht ik de volgende showevents als resultaat", ((string)(null)), table2, "En ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Opvragen van een specifiek showevent")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Showevents CRUD")]
        public virtual void OpvragenVanEenSpecifiekShowevent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Opvragen van een specifiek showevent", ((string[])(null)));
#line 24
this.ScenarioSetup(scenarioInfo);
#line 9
this.FeatureBackground();
#line 25
   testRunner.When("ik \'Boekel 2017_2017-06-01\' opvraag van webservice \'showevents\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Als ");
#line 26
   testRunner.Then("verwacht ik een status \'OK\' met code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dan ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "date",
                        "closeDate",
                        "location",
                        "judge",
                        "shows",
                        "participants"});
            table3.AddRow(new string[] {
                        "Boekel 2017",
                        "2017-06-01",
                        "2017-05-01",
                        "Boekel",
                        "judge X",
                        "Haltershow",
                        ""});
#line 27
   testRunner.And("verwacht ik de volgende showevents als resultaat", ((string)(null)), table3, "En ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Nieuw showevent opvoeren")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Showevents CRUD")]
        public virtual void NieuwShoweventOpvoeren()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Nieuw showevent opvoeren", ((string[])(null)));
#line 31
this.ScenarioSetup(scenarioInfo);
#line 9
this.FeatureBackground();
#line hidden
#line 32
   testRunner.When("ik onderstaande opstuur naar webservice \'showevents\'", "{\r\n\"name\": \"Test 2017\",\r\n\"date\": \"2017-03-01\",\r\n\"closeDate\": \"2017-02-15\",\r\n\"loca" +
                    "tion\": \"Test\",\r\n\"judge\": \"judge Y\",\r\n\"shows\": [\r\n {\r\n   \"showType\": \"Male progen" +
                    "y show\"\r\n }\r\n]\r\n}", ((TechTalk.SpecFlow.Table)(null)), "Als ");
#line 47
   testRunner.Then("verwacht ik een status \'OK\' met code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dan ");
#line 48
   testRunner.When("ik alles opvraag via webservice \'showevents\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Als ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "date",
                        "closeDate",
                        "location",
                        "judge",
                        "shows",
                        "participants"});
            table4.AddRow(new string[] {
                        "Assen 2017",
                        "2017-05-01",
                        "2017-04-01",
                        "Assen",
                        "Rob Bettinson",
                        "Haltershow, Fleeceshow",
                        ""});
            table4.AddRow(new string[] {
                        "Boekel 2017",
                        "2017-06-01",
                        "2017-05-01",
                        "Boekel",
                        "judge X",
                        "Haltershow",
                        ""});
            table4.AddRow(new string[] {
                        "Test 2017",
                        "2017-03-01",
                        "2017-02-15",
                        "Test",
                        "judge Y",
                        "Male progeny show",
                        ""});
#line 49
 testRunner.Then("verwacht ik de volgende showevents als resultaat", ((string)(null)), table4, "Dan ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Opvragen van alle showevents")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Showevents CRUD")]
        public virtual void OpvragenVanAlleShowevents()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Opvragen van alle showevents", ((string[])(null)));
#line 55
this.ScenarioSetup(scenarioInfo);
#line 9
this.FeatureBackground();
#line 56
   testRunner.When("ik alles opvraag via webservice \'showevents\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Als ");
#line 57
   testRunner.Then("verwacht ik een status \'OK\' met code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dan ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "date",
                        "closeDate",
                        "location",
                        "judge",
                        "shows",
                        "participants"});
            table5.AddRow(new string[] {
                        "Test 2017",
                        "2017-03-01",
                        "2017-02-15",
                        "Test",
                        "judge Y",
                        "Male progeny show",
                        ""});
            table5.AddRow(new string[] {
                        "Assen 2017",
                        "2017-05-01",
                        "2017-04-01",
                        "Assen",
                        "Rob Bettinson",
                        "Haltershow, Fleeceshow",
                        ""});
#line 58
 testRunner.And("verwacht ik in ieder geval de volgende showevents als resultaat", ((string)(null)), table5, "En ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Opvragen van exact alle showevents met bepaalde waarde")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Showevents CRUD")]
        public virtual void OpvragenVanExactAlleShoweventsMetBepaaldeWaarde()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Opvragen van exact alle showevents met bepaalde waarde", ((string[])(null)));
#line 63
this.ScenarioSetup(scenarioInfo);
#line 9
this.FeatureBackground();
#line 64
   testRunner.When("ik alles opvraag via webservice \'showevents\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Als ");
#line 65
   testRunner.Then("verwacht ik een status \'OK\' met code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dan ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "date",
                        "closeDate",
                        "location"});
            table6.AddRow(new string[] {
                        "Test 2017",
                        "2017-03-01",
                        "2017-02-15",
                        "Test"});
            table6.AddRow(new string[] {
                        "Assen 2017",
                        "2017-05-01",
                        "2017-04-01",
                        "Assen"});
            table6.AddRow(new string[] {
                        "Boekel 2017",
                        "2017-06-01",
                        "2017-05-01",
                        "Boekel"});
#line 66
 testRunner.And("verwacht ik de volgende gegevens van showevents als resultaat", ((string)(null)), table6, "En ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Opvragen van alle showevents met bepaalde waarde")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Showevents CRUD")]
        public virtual void OpvragenVanAlleShoweventsMetBepaaldeWaarde()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Opvragen van alle showevents met bepaalde waarde", ((string[])(null)));
#line 72
this.ScenarioSetup(scenarioInfo);
#line 9
this.FeatureBackground();
#line 73
   testRunner.When("ik alles opvraag via webservice \'showevents\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Als ");
#line 74
   testRunner.Then("verwacht ik een status \'OK\' met code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dan ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "location",
                        "judge",
                        "shows",
                        "participants"});
            table7.AddRow(new string[] {
                        "Assen",
                        "Rob Bettinson",
                        "Haltershow, Fleeceshow",
                        ""});
#line 75
 testRunner.And("verwacht ik in ieder geval de volgende gegevens van showevents als resultaat", ((string)(null)), table7, "En ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Bestaand showevent wijzigen met tabel")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Showevents CRUD")]
        public virtual void BestaandShoweventWijzigenMetTabel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Bestaand showevent wijzigen met tabel", ((string[])(null)));
#line 79
this.ScenarioSetup(scenarioInfo);
#line 9
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "parameter",
                        "value"});
            table8.AddRow(new string[] {
                        "name",
                        "Test 2017"});
            table8.AddRow(new string[] {
                        "date",
                        "2017-03-01"});
            table8.AddRow(new string[] {
                        "closeDate",
                        "2017-02-15"});
            table8.AddRow(new string[] {
                        "location",
                        "Teslocatie"});
            table8.AddRow(new string[] {
                        "judge",
                        "jury Z"});
            table8.AddRow(new string[] {
                        "shows.showType",
                        "Haltershow"});
            table8.AddRow(new string[] {
                        "shows.showType",
                        "Male progeny show"});
#line 80
   testRunner.When("ik onderstaande wijziging stuur voor \'Test 2017_2017-03-01\' naar webservice \'show" +
                    "events\'", ((string)(null)), table8, "Als ");
#line 89
   testRunner.Then("verwacht ik een status \'OK\' met code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dan ");
#line 90
   testRunner.When("ik alles opvraag via webservice \'showevents\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Als ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "date",
                        "closeDate",
                        "location",
                        "judge",
                        "shows",
                        "participants"});
            table9.AddRow(new string[] {
                        "Assen 2017",
                        "2017-05-01",
                        "2017-04-01",
                        "Assen",
                        "Rob Bettinson",
                        "Haltershow, Fleeceshow",
                        ""});
            table9.AddRow(new string[] {
                        "Boekel 2017",
                        "2017-06-01",
                        "2017-05-01",
                        "Boekel",
                        "judge X",
                        "Haltershow",
                        ""});
            table9.AddRow(new string[] {
                        "Test 2017",
                        "2017-03-01",
                        "2017-02-15",
                        "Teslocatie",
                        "jury Z",
                        "Haltershow, Male progeny show",
                        ""});
#line 91
 testRunner.Then("verwacht ik de volgende showevents als resultaat", ((string)(null)), table9, "Dan ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Bestaand showevent wijzigen met file")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Showevents CRUD")]
        public virtual void BestaandShoweventWijzigenMetFile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Bestaand showevent wijzigen met file", ((string[])(null)));
#line 98
this.ScenarioSetup(scenarioInfo);
#line 9
this.FeatureBackground();
#line 99
   testRunner.When("ik \'wijzigShowEvent\' als wijziging stuur voor \'Test 2017_2017-03-01\' naar webserv" +
                    "ice \'showevents\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Als ");
#line 100
   testRunner.Then("verwacht ik een status \'OK\' met code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dan ");
#line 101
   testRunner.When("ik alles opvraag via webservice \'showevents\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Als ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "date",
                        "closeDate",
                        "location",
                        "judge",
                        "shows",
                        "participants"});
            table10.AddRow(new string[] {
                        "Assen 2017",
                        "2017-05-01",
                        "2017-04-01",
                        "Assen",
                        "Rob Bettinson",
                        "Haltershow, Fleeceshow",
                        ""});
            table10.AddRow(new string[] {
                        "Boekel 2017",
                        "2017-06-01",
                        "2017-05-01",
                        "Boekel",
                        "judge X",
                        "Haltershow",
                        ""});
            table10.AddRow(new string[] {
                        "Test 2017",
                        "2017-03-01",
                        "2017-01-15",
                        "Test",
                        "judge Y",
                        "Haltershow",
                        ""});
#line 102
 testRunner.Then("verwacht ik de volgende showevents als resultaat", ((string)(null)), table10, "Dan ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Bestaand showevent wijzigen met multiline text")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Showevents CRUD")]
        public virtual void BestaandShoweventWijzigenMetMultilineText()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Bestaand showevent wijzigen met multiline text", ((string[])(null)));
#line 108
this.ScenarioSetup(scenarioInfo);
#line 9
this.FeatureBackground();
#line hidden
#line 109
   testRunner.When("ik onderstaande wijziging opstuur voor \'Test 2017_2017-03-01\' naar webservice \'sh" +
                    "owevents\'", "{\r\n\"name\": \"Test 2017\",\r\n\"date\": \"2017-03-01\",\r\n\"closeDate\": \"2017-02-15\",\r\n\"loca" +
                    "tion\": \"Test wijziging locatie\",\r\n\"judge\": \"judge Y\",\r\n\"participants\": [],\r\n\"sho" +
                    "ws\": [\r\n {\r\n   \"showType\": \"Haltershow\"\r\n }\r\n]\r\n}", ((TechTalk.SpecFlow.Table)(null)), "Als ");
#line 125
   testRunner.Then("verwacht ik een status \'OK\' met code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dan ");
#line 126
   testRunner.When("ik alles opvraag via webservice \'showevents\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Als ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "date",
                        "closeDate",
                        "location",
                        "judge",
                        "shows",
                        "participants"});
            table11.AddRow(new string[] {
                        "Assen 2017",
                        "2017-05-01",
                        "2017-04-01",
                        "Assen",
                        "Rob Bettinson",
                        "Haltershow, Fleeceshow",
                        ""});
            table11.AddRow(new string[] {
                        "Boekel 2017",
                        "2017-06-01",
                        "2017-05-01",
                        "Boekel",
                        "judge X",
                        "Haltershow",
                        ""});
            table11.AddRow(new string[] {
                        "Test 2017",
                        "2017-03-01",
                        "2017-02-15",
                        "Test wijziging locatie",
                        "judge Y",
                        "Haltershow",
                        ""});
#line 127
 testRunner.Then("verwacht ik de volgende showevents als resultaat", ((string)(null)), table11, "Dan ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Bestaande showevent verwijderen")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Showevents CRUD")]
        public virtual void BestaandeShoweventVerwijderen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Bestaande showevent verwijderen", ((string[])(null)));
#line 133
this.ScenarioSetup(scenarioInfo);
#line 9
this.FeatureBackground();
#line 134
   testRunner.When("ik een verwijderverzoek opstuur voor \'Test 2017_2017-03-01\' naar webservice \'show" +
                    "events\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Als ");
#line 135
   testRunner.Then("verwacht ik een status \'OK\' met code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dan ");
#line 136
   testRunner.When("ik alles opvraag via webservice \'showevents\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Als ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "date",
                        "closeDate",
                        "location",
                        "judge",
                        "shows",
                        "participants"});
            table12.AddRow(new string[] {
                        "Assen 2017",
                        "2017-05-01",
                        "2017-04-01",
                        "Assen",
                        "Rob Bettinson",
                        "Haltershow, Fleeceshow",
                        ""});
            table12.AddRow(new string[] {
                        "Boekel 2017",
                        "2017-06-01",
                        "2017-05-01",
                        "Boekel",
                        "judge X",
                        "Haltershow",
                        ""});
#line 137
 testRunner.Then("verwacht ik de volgende showevents als resultaat", ((string)(null)), table12, "Dan ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
