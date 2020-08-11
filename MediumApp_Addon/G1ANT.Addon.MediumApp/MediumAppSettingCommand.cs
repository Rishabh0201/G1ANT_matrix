using System;
using G1ANT.Language;
using System.Threading;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.MediumApp
{
    [Command(Name = "mediumapp.setting", Tooltip = "This command helps you to set setting of Medium App")]
    public class MediumAppSettingCommand : Language.Command
    {
        public class Arguments : CommandArguments
        {
            [Argument(Required = true, Tooltip = "Type text here which you want to search.")]
            public TextStructure Text { get; set; } = new TextStructure("");

            [Argument(Required = false, Tooltip = "Provide name of the capaility")]
            public TextStructure Search { get; set; } = new TextStructure("");

            [Argument(Required = false, Tooltip = "Provide element ID")]
            public TextStructure By { get; set; } = new TextStructure("id");
        }

        public MediumAppSettingCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {

            arguments.Search.Value = "Open navigation drawer";
            arguments.By.Value = "accessibilityid";
            ElementHelper.GetElement(arguments.By.Value.ToLower(), arguments.Search.Value).Click();
            Thread.Sleep(2000);
            arguments.Search.Value = "com.medium.reader:id/nav_settings";
            arguments.By.Value = "id";
            ElementHelper.GetElement(arguments.By.Value.ToLower(), arguments.Search.Value).Click();
            Thread.Sleep(2000);
            






        }
    }
}