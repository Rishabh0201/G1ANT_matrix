using System;
using G1ANT.Language;
using System.Threading;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.ZomatoApp
{
    [Command(Name = "zomatoapp.search", Tooltip = "This command helps you to search restaurant or Food Dishes on Zomato App")]
    public class ZomatoAppSearchCommand : Language.Command
    {
        public class Arguments : CommandArguments
        {


            [Argument(Required = false, Tooltip = "Provide name of the capaility")]
            public TextStructure Search { get; set; } = new TextStructure("");

            [Argument(Required = false, Tooltip = "Provide element ID")]
            public TextStructure By { get; set; } = new TextStructure("id");
        }

        public ZomatoAppSearchCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {

            arguments.Search.Value = "com.application.zomato:id/edittext";
            arguments.By.Value = "id";
            ElementHelper.GetElement(arguments.By.Value.ToLower(), arguments.Search.Value).Click();
            Thread.Sleep(2000);









        }
    }
}