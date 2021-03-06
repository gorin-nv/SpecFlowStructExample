﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18444
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Services.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("методы UsersService")]
    public partial class МетодыUsersServiceFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UsersService.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("ru-RU"), "методы UsersService", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("поиск имен организаций пользователя")]
        public virtual void ПоискИменОрганизацийПользователя()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("поиск имен организаций пользователя", ((string[])(null)));
#line 4
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "user id",
                        "name",
                        "password"});
            table1.AddRow(new string[] {
                        "user",
                        "nick",
                        "12345"});
#line 5
 testRunner.Given("в репозитории пользователей поиск пользователя по имени \"nick\" и паролю \"12345\" в" +
                    "озвращает", ((string)(null)), table1, "Пусть ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "organization id",
                        "name",
                        "inn",
                        "owner id"});
            table2.AddRow(new string[] {
                        "org 1",
                        "org1",
                        "inn",
                        "user"});
#line 8
 testRunner.Given("в репозитории организаций поиск организаций по пользователю \"user\" возвращает", ((string)(null)), table2, "Пусть ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "password",
                        "inn"});
            table3.AddRow(new string[] {
                        "nick",
                        "12345",
                        "inn"});
#line 11
 testRunner.When("в сервисе пользователей запрашивается список имен организаций", ((string)(null)), table3, "Когда ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "name"});
            table4.AddRow(new string[] {
                        "org1"});
#line 14
 testRunner.Then("в сервисе пользователей возвращает список имен организаций", ((string)(null)), table4, "Тогда ");
#line 17
 testRunner.And("в репозитории пользователей был поиск пользователя по имени \"nick\" и паролю \"1234" +
                    "5\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 18
 testRunner.And("в репозитории организаций был поиск организаций по пользователю \"user\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
