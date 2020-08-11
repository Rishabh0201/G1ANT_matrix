using System;
using G1ANT.Language;
using System.Threading;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.MediumApp
{
    [Command(Name = "mediumapp.audio", Tooltip = "This command helps you to see audio articles on Medium App")]
    public class MediumAppAudioCommand : Language.Command
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

        public MediumAppAudioCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {

            arguments.Search.Value = "Open navigation drawer";
            arguments.By.Value = "accessibilityid";
            ElementHelper.GetElement(arguments.By.Value.ToLower(), arguments.Search.Value).Click();
            Thread.Sleep(2000);
            arguments.Search.Value = "/html/body/div[1]/div/div[2]/div[1]/div/div/div/div/div/div[40]";
            arguments.By.Value = "xpath";
            ElementHelper.GetElement(arguments.By.Value.ToLower(), arguments.Search.Value).Click();
            Thread.Sleep(2000);
            







        }
    }
}