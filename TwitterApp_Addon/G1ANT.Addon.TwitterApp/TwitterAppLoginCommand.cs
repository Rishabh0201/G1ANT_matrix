using System;
using G1ANT.Language;
using System.Threading;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.TwitterApp
{
    [Command(Name = "twitterapp.login", Tooltip = "This command helps you to login your account in Twitter App")]
    public class TwitterAppLoginCommand : Language.Command
    {
        public class Arguments : CommandArguments
        {


            [Argument(Required = false, Tooltip = "Provide name of the capaility")]
            public TextStructure Search { get; set; } = new TextStructure("");

            [Argument(Required = false, Tooltip = "Provide element ID")]
            public TextStructure By { get; set; } = new TextStructure("id");
        }

        public TwitterAppLoginCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {

            arguments.Search.Value = "com.twitter.android:id/sign_in_text";
            arguments.By.Value = "id";
            ElementHelper.GetElement(arguments.By.Value.ToLower(), arguments.Search.Value).Click();
            Thread.Sleep(2000);









        }
    }
}