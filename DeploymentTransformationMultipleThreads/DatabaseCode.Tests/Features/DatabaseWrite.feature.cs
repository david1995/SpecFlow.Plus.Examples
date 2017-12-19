﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DatabaseCode.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Database Write", Description="    As a system\r\n    I want to modify the data inside my database\r\n    in order t" +
        "o work properly", SourceFile="Features\\DatabaseWrite.feature", SourceLine=0)]
    public partial class DatabaseWriteFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DatabaseWrite.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Database Write", "    As a system\r\n    I want to modify the data inside my database\r\n    in order t" +
                    "o work properly", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
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
#line 6
#line 7
    testRunner.Given("I have an empty database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        public virtual void CreatingAPersonInAnEmptyDatabase(string firstName, string lastName, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Creating a person in an empty database", exampleTags);
#line 9
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 10
    testRunner.Given("I have an empty database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
    testRunner.When(string.Format("I insert a person \"{0}\" \"{1}\" into the database", firstName, lastName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
    testRunner.And("I save and commit the changes to the database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
    testRunner.Then(string.Format("the database should contain a person called \"{0}\" \"{1}\".", firstName, lastName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Creating a person in an empty database, David", SourceLine=16)]
        public virtual void CreatingAPersonInAnEmptyDatabase_David()
        {
#line 9
this.CreatingAPersonInAnEmptyDatabase("David", "Eiwen", ((string[])(null)));
#line hidden
        }
        
        public virtual void ModifyingAPersonsNameInTheDatabaseInAWrongWay(string oldFirstName, string oldLastName, string newFirstName, string newLastName, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Modifying a person\'s name in the database in a wrong way", exampleTags);
#line 19
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "LastName"});
            table1.AddRow(new string[] {
                        "Davdi",
                        "Eiwne"});
#line 20
    testRunner.Given("I have a database containing the following persons:", ((string)(null)), table1, "Given ");
#line 24
    testRunner.And(string.Format("I get the person \"{0}\" \"{1}\" from the database", oldFirstName, oldLastName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
    testRunner.When(string.Format("I change its first name to \"{0}\"", newFirstName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
    testRunner.And(string.Format("I change its last name to \"{0}\"", newLastName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
    testRunner.Then("saving and committing should throw an exception.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Modifying a person\'s name in the database in a wrong way, Davdi", SourceLine=30)]
        public virtual void ModifyingAPersonsNameInTheDatabaseInAWrongWay_Davdi()
        {
#line 19
this.ModifyingAPersonsNameInTheDatabaseInAWrongWay("Davdi", "Eiwne", "David", "Eiwen", ((string[])(null)));
#line hidden
        }
        
        public virtual void ModifyingAPersonsNameInTheDatabaseCorrectly(string oldFirstName, string oldLastName, string newFirstName, string newLastName, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Modifying a person\'s name in the database correctly", exampleTags);
#line 33
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "LastName"});
            table2.AddRow(new string[] {
                        "Davdi",
                        "Eiwne"});
#line 34
    testRunner.Given("I have a database containing the following persons:", ((string)(null)), table2, "Given ");
#line 38
    testRunner.And(string.Format("I get the person \"{0}\" \"{1}\" from the database", oldFirstName, oldLastName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
    testRunner.When(string.Format("I delete a person called \"{0}\" \"{1}\"", oldFirstName, oldLastName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
    testRunner.And(string.Format("I insert a person \"{0}\" \"{1}\" into the database", newFirstName, newLastName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
    testRunner.And("I save and commit the changes to the database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
    testRunner.Then(string.Format("the database should contain a person called \"{0}\" \"{1}\".", newFirstName, newLastName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Modifying a person\'s name in the database correctly, Davdi", SourceLine=45)]
        public virtual void ModifyingAPersonsNameInTheDatabaseCorrectly_Davdi()
        {
#line 33
this.ModifyingAPersonsNameInTheDatabaseCorrectly("Davdi", "Eiwne", "David", "Eiwen", ((string[])(null)));
#line hidden
        }
        
        public virtual void DeletingAPersonInTheDatabase(string firstName, string lastName, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deleting a person in the database", exampleTags);
#line 48
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "LastName"});
            table3.AddRow(new string[] {
                        "David",
                        "Eiwen"});
#line 49
    testRunner.Given("I have a database containing the following persons:", ((string)(null)), table3, "Given ");
#line 52
    testRunner.When(string.Format("I delete a person called \"{0}\" \"{1}\"", firstName, lastName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
    testRunner.And("I save and commit the changes to the database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
    testRunner.Then(string.Format("the database should not contain a person called \"{0}\" \"{1}\".", firstName, lastName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Deleting a person in the database, David", SourceLine=57)]
        public virtual void DeletingAPersonInTheDatabase_David()
        {
#line 48
this.DeletingAPersonInTheDatabase("David", "Eiwen", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Clearing all persons from the database", SourceLine=59)]
        public virtual void ClearingAllPersonsFromTheDatabase()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Clearing all persons from the database", ((string[])(null)));
#line 60
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "LastName"});
            table4.AddRow(new string[] {
                        "David",
                        "Eiwen"});
#line 61
    testRunner.Given("I have a database containing the following persons:", ((string)(null)), table4, "Given ");
#line 64
    testRunner.When("I remove all persons", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
    testRunner.And("I save and commit the changes to the database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
    testRunner.Then("the database should not contain any person.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
