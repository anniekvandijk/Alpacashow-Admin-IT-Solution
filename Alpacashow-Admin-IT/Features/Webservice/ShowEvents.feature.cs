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
    public partial class ShowEventsCRUDFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ShowEvents.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ShowEvents CRUD", "   As a user I have to get, post, put and delete showevents\r\n   from the webservi" +
                    "ce\r\n   so I can use them in a frontend application", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "ShowEvents CRUD")))
            {
                Alpacashow_Admin_SpecflowTests.Features.Webservice.ShowEventsCRUDFeature.FeatureSetup(null);
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
#line 7
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
            table1.AddRow(new string[] {
                        "Test 2017",
                        "2017-03-01",
                        "2017-02-15",
                        "Testlocatie",
                        "jury Z",
                        "Haltershow, Male progeny show",
                        ""});
#line 8
 testRunner.Given("the following showevents are present", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Get exact all showevents")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ShowEvents CRUD")]
        public virtual void GetExactAllShowevents()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get exact all showevents", ((string[])(null)));
#line 14
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 15
   testRunner.When("i perform a \'GET\' on webservice \'showevents\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
   testRunner.Then("i expect status \'OK\' with code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
                        "Assen 2017",
                        "2017-05-01",
                        "2017-04-01",
                        "Assen",
                        "Rob Bettinson",
                        "Haltershow, Fleeceshow",
                        ""});
            table2.AddRow(new string[] {
                        "Boekel 2017",
                        "2017-06-01",
                        "2017-05-01",
                        "Boekel",
                        "judge X",
                        "Haltershow",
                        ""});
            table2.AddRow(new string[] {
                        "Test 2017",
                        "2017-03-01",
                        "2017-02-15",
                        "Testlocatie",
                        "jury Z",
                        "Haltershow, Male progeny show",
                        ""});
#line 17
   testRunner.And("i expect exact the following result of showevents", ((string)(null)), table2, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Get specific showevent")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ShowEvents CRUD")]
        public virtual void GetSpecificShowevent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get specific showevent", ((string[])(null)));
#line 23
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 24
   testRunner.When("i perform a \'GET\' for \'Boekel 2017_2017-06-01\' on webservice \'showevents\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
   testRunner.Then("i expect status \'OK\' with code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
#line 26
   testRunner.And("i expect exact the following result of showevents", ((string)(null)), table3, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Post new showevent")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ShowEvents CRUD")]
        public virtual void PostNewShowevent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post new showevent", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
#line 31
   testRunner.When("i perform a \'POST\' on webservice \'showevents\'", "{\r\n\"name\": \"Hapert 2018\",\r\n\"date\": \"2018-02-12\",\r\n\"closeDate\": \"2018-01-10\",\r\n\"lo" +
                    "cation\": \"Hapert\",\r\n\"judge\": \"judge bla\",\r\n\"shows\": [\r\n {\r\n   \"showType\": \"Femal" +
                    "e progeny show\"\r\n }\r\n]\r\n}", ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
   testRunner.Then("i expect status \'OK\' with code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 47
   testRunner.When("i perform a \'GET\' on webservice \'showevents\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
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
                        "Testlocatie",
                        "jury Z",
                        "Haltershow, Male progeny show",
                        ""});
            table4.AddRow(new string[] {
                        "Hapert 2018",
                        "2018-02-12",
                        "2018-01-10",
                        "Hapert",
                        "judge bla",
                        "Female progeny show",
                        ""});
#line 48
 testRunner.Then("i expect exact the following result of showevents", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Get all showevents but at least one with all values")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ShowEvents CRUD")]
        public virtual void GetAllShoweventsButAtLeastOneWithAllValues()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get all showevents but at least one with all values", ((string[])(null)));
#line 55
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 56
   testRunner.When("i perform a \'GET\' on webservice \'showevents\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
   testRunner.Then("i expect status \'OK\' with code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
                        "Assen 2017",
                        "2017-05-01",
                        "2017-04-01",
                        "Assen",
                        "Rob Bettinson",
                        "Haltershow, Fleeceshow",
                        ""});
#line 58
 testRunner.And("i expect at least the following result of showevents", ((string)(null)), table5, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Get all showevents with specific value")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ShowEvents CRUD")]
        public virtual void GetAllShoweventsWithSpecificValue()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get all showevents with specific value", ((string[])(null)));
#line 62
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 63
   testRunner.When("i perform a \'GET\' on webservice \'showevents\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
   testRunner.Then("i expect status \'OK\' with code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "date",
                        "closeDate",
                        "location"});
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
            table6.AddRow(new string[] {
                        "Test 2017",
                        "2017-03-01",
                        "2017-02-15",
                        "Testlocatie"});
#line 65
 testRunner.And("i expect exact the following specific results of showevents", ((string)(null)), table6, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Get all showevents but at least one with specific value")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ShowEvents CRUD")]
        public virtual void GetAllShoweventsButAtLeastOneWithSpecificValue()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get all showevents but at least one with specific value", ((string[])(null)));
#line 71
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 72
   testRunner.When("i perform a \'GET\' on webservice \'showevents\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 73
   testRunner.Then("i expect status \'OK\' with code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
#line 74
 testRunner.And("i expect at least the following specific results of showevents", ((string)(null)), table7, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Change excisting showevent with table")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ShowEvents CRUD")]
        public virtual void ChangeExcistingShoweventWithTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change excisting showevent with table", ((string[])(null)));
#line 78
this.ScenarioSetup(scenarioInfo);
#line 7
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
#line 79
   testRunner.When("i perform a \'PUT\' for the following change on \'Test 2017_2017-03-01\' to webservic" +
                    "e \'showevents\'", ((string)(null)), table8, "When ");
#line 88
   testRunner.Then("i expect status \'OK\' with code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 89
   testRunner.When("i perform a \'GET\' on webservice \'showevents\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
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
#line 90
 testRunner.Then("i expect exact the following result of showevents", ((string)(null)), table9, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Change excisting showevent with file")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ShowEvents CRUD")]
        public virtual void ChangeExcistingShoweventWithFile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change excisting showevent with file", ((string[])(null)));
#line 97
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 98
   testRunner.When("i perform a \'PUT\' with file \'wijzigShowEvent\' on \'Test 2017_2017-03-01\' to webser" +
                    "vice \'showevents\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
   testRunner.Then("i expect status \'OK\' with code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 100
   testRunner.When("i perform a \'GET\' on webservice \'showevents\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
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
#line 101
 testRunner.Then("i expect exact the following result of showevents", ((string)(null)), table10, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Change excisting showevent with multiline text")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ShowEvents CRUD")]
        public virtual void ChangeExcistingShoweventWithMultilineText()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change excisting showevent with multiline text", ((string[])(null)));
#line 107
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
#line 108
   testRunner.When("i perform a \'PUT\' for the following Json change on \'Test 2017_2017-03-01\' to webs" +
                    "ervice \'showevents\'", "{\r\n\"name\": \"Test 2017\",\r\n\"date\": \"2017-03-01\",\r\n\"closeDate\": \"2017-02-15\",\r\n\"loca" +
                    "tion\": \"Test wijziging locatie\",\r\n\"judge\": \"judge Y\",\r\n\"participants\": [],\r\n\"sho" +
                    "ws\": [\r\n {\r\n   \"showType\": \"Haltershow\"\r\n }\r\n]\r\n}", ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 124
   testRunner.Then("i expect status \'OK\' with code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 125
   testRunner.When("i perform a \'GET\' on webservice \'showevents\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
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
#line 126
 testRunner.Then("i expect exact the following result of showevents", ((string)(null)), table11, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Delete an existing showevent")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ShowEvents CRUD")]
        public virtual void DeleteAnExistingShowevent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete an existing showevent", ((string[])(null)));
#line 132
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 133
   testRunner.When("i perform a \'DELETE\'  on  \'Assen 2017_2017-05-01\' to webservice \'showevents\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 134
   testRunner.Then("i expect status \'OK\' with code 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 135
   testRunner.When("i perform a \'GET\' on webservice \'showevents\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
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
                        "Boekel 2017",
                        "2017-06-01",
                        "2017-05-01",
                        "Boekel",
                        "judge X",
                        "Haltershow",
                        ""});
            table12.AddRow(new string[] {
                        "Test 2017",
                        "2017-03-01",
                        "2017-02-15",
                        "Testlocatie",
                        "jury Z",
                        "Haltershow, Male progeny show",
                        ""});
#line 136
 testRunner.Then("i expect exact the following result of showevents", ((string)(null)), table12, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
