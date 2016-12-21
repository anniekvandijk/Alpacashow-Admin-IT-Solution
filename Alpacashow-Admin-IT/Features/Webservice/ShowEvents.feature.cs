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
                        "naam",
                        "datum",
                        "sluitingsdatum",
                        "locatie",
                        "jury",
                        "shows",
                        "deelnemers"});
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
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Opvragen van alle showevents")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Showevents CRUD")]
        public virtual void OpvragenVanAlleShowevents()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Opvragen van alle showevents", ((string[])(null)));
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
                        "naam",
                        "datum",
                        "sluitingsdatum",
                        "locatie",
                        "jury",
                        "shows",
                        "deelnemers"});
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
 testRunner.Then("verwacht ik de volgende showevents als resultaat", ((string)(null)), table2, "Dan ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Opvragen van een specifiek showevent")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Showevents CRUD")]
        public virtual void OpvragenVanEenSpecifiekShowevent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Opvragen van een specifiek showevent", ((string[])(null)));
#line 23
this.ScenarioSetup(scenarioInfo);
#line 9
this.FeatureBackground();
#line 24
   testRunner.When("ik \'Boekel 2017_2017-06-01\' opvraag van webservice \'showevents\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Als ");
#line 25
   testRunner.Then("verwacht ik een status \'OK\' met code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dan ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Nieuw showevent opvoeren")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Showevents CRUD")]
        public virtual void NieuwShoweventOpvoeren()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Nieuw showevent opvoeren", ((string[])(null)));
#line 27
this.ScenarioSetup(scenarioInfo);
#line 9
this.FeatureBackground();
#line hidden
#line 28
   testRunner.When("ik onderstaande opstuur naar webservice \'showevents\'", "{\r\n\"name\": \"Test 2017\",\r\n\"date\": \"2017-03-01\",\r\n\"closeDate\": \"2017-02-15\",\r\n\"loca" +
                    "tion\": \"Test\",\r\n\"judge\": \"judge Y\",\r\n\"participants\": [],\r\n\"shows\": [\r\n {\r\n   \"sh" +
                    "owType\": \"Haltershow\"\r\n }\r\n]\r\n}", ((TechTalk.SpecFlow.Table)(null)), "Als ");
#line 44
testRunner.Then("verwacht ik een status \'OK\' met code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dan ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Bestaand showevent wijzigen met tabel")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Showevents CRUD")]
        public virtual void BestaandShoweventWijzigenMetTabel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Bestaand showevent wijzigen met tabel", ((string[])(null)));
#line 46
this.ScenarioSetup(scenarioInfo);
#line 9
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "veld",
                        "waarde"});
            table3.AddRow(new string[] {
                        "naam",
                        "Test 2017"});
            table3.AddRow(new string[] {
                        "datum",
                        "2017-03-01"});
            table3.AddRow(new string[] {
                        "sluitingsdatum",
                        "2017-02-15"});
            table3.AddRow(new string[] {
                        "locatie",
                        "Teslocatie"});
            table3.AddRow(new string[] {
                        "jury",
                        "jury Z"});
            table3.AddRow(new string[] {
                        "shows",
                        "Haltershow, Male progeny show"});
            table3.AddRow(new string[] {
                        "deelnemers",
                        ""});
#line 47
   testRunner.When("ik onderstaande wijziging stuur voor \'Test 2017_2017-03-01\' naar webservice \'show" +
                    "events\'", ((string)(null)), table3, "Als ");
#line 56
testRunner.Then("verwacht ik een status \'OK\' met code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dan ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Bestaand showevent wijzigen met file")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Showevents CRUD")]
        public virtual void BestaandShoweventWijzigenMetFile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Bestaand showevent wijzigen met file", ((string[])(null)));
#line 58
this.ScenarioSetup(scenarioInfo);
#line 9
this.FeatureBackground();
#line 59
   testRunner.When("ik \'wijzigShowEvent\' als wijziging stuur voor \'Test 2017_2017-03-01\' naar webserv" +
                    "ice \'showevents\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Als ");
#line 60
   testRunner.Then("verwacht ik een status \'OK\' met code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dan ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Bestaand showevent wijzigen met multiline text")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Showevents CRUD")]
        public virtual void BestaandShoweventWijzigenMetMultilineText()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Bestaand showevent wijzigen met multiline text", ((string[])(null)));
#line 62
this.ScenarioSetup(scenarioInfo);
#line 9
this.FeatureBackground();
#line hidden
#line 63
   testRunner.When("ik onderstaande wijziging opstuur voor \'Test 2017_2017-03-01\' naar webservice \'sh" +
                    "owevents\'", "{\r\n\"name\": \"Test 2017\",\r\n\"date\": \"2017-03-01\",\r\n\"closeDate\": \"2017-02-15\",\r\n\"loca" +
                    "tion\": \"Test wijziging locatie\",\r\n\"judge\": \"judge Y\",\r\n\"participants\": [],\r\n\"sho" +
                    "ws\": [\r\n {\r\n   \"showType\": \"Haltershow\"\r\n }\r\n]\r\n}", ((TechTalk.SpecFlow.Table)(null)), "Als ");
#line 79
testRunner.Then("verwacht ik een status \'OK\' met code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dan ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Bestaande showevent verwijderen")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Showevents CRUD")]
        public virtual void BestaandeShoweventVerwijderen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Bestaande showevent verwijderen", ((string[])(null)));
#line 81
this.ScenarioSetup(scenarioInfo);
#line 9
this.FeatureBackground();
#line 82
   testRunner.When("ik een verwijderverzoek opstuur voor \'Test 2017_2017-03-01\' naar webservice \'show" +
                    "events\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Als ");
#line 83
   testRunner.Then("verwacht ik een status \'OK\' met code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dan ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
