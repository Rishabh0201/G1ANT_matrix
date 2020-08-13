using System;
using G1ANT.Language;
using System.Threading;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.TumblrApp
{
    [Command(Name = "tumblrapp.profile", Tooltip = "This command helps you to see profile of Medium App Account")]
    public class TumblrAppProfileCommand : Language.Command
    {
        public class Arguments : CommandArguments
        {


            [Argument(Required = false, Tooltip = "Provide name of the capaility")]
            public TextStructure Search { get; set; } = new TextStructure("");

            [Argument(Required = false, Tooltip = "Provide element ID")]
            public TextStructure By { get; set; } = new TextStructure("id");
        }

        public TumblrAppProfileCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {
            arguments.Search.Value = "com.tumblr:id/topnav_account_button_img_active";
            arguments.By.Value = "id";
            ElementHelper.GetElement(arguments.By.Value.ToLower(), arguments.Search.Value).Click();
            Thread.Sleep(2000);
            









        }
    }
}