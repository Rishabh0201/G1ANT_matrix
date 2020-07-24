using System;
using G1ANT.Language;
using System.Threading;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.OlaCabApp
{
    [Command(Name = "olacabapp.pass", Tooltip = "This command shows pass in OlaCab App")]
    public class OlaCabAppPassCommand : Language.Command
    {
        public class Arguments : CommandArguments
        {


            [Argument(Required = false, Tooltip = "Provide name of the capaility")]
            public TextStructure Search { get; set; } = new TextStructure("");

            [Argument(Required = false, Tooltip = "Provide element ID")]
            public TextStructure By { get; set; } = new TextStructure("id");
        }

        public OlaCabAppPassCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {

            arguments.Search.Value = "//android.webkit.WebView[@content-desc='Book Cabs Nearby at Best Price | Hire Taxi Nearby Online at Olacabs.com']/android.view.View/android.view.View[1]/android.view.View/android.view.View[1]/android.view.View/android.widget.Image";
            arguments.By.Value = "xpath";
            ElementHelper.GetElement(arguments.By.Value.ToLower(), arguments.Search.Value).Click();
            Thread.Sleep(1000);
            arguments.Search.Value = "//android.webkit.WebView[@content-desc='Book Cabs Nearby at Best Price | Hire Taxi Nearby Online at Olacabs.com']/android.view.View/android.view.View[2]/android.view.View[2]";
            arguments.By.Value = "xpath";
            ElementHelper.GetElement(arguments.By.Value.ToLower(), arguments.Search.Value).Click();
            Thread.Sleep(2000);










        }
    }
}