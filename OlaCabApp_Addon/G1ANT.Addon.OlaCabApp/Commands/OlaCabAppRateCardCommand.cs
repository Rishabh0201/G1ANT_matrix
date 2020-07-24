using System;
using G1ANT.Language;
using System.Threading;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.OlaCabApp
{
    [Command(Name = "olacabapp.ratecard", Tooltip = "This command shows rate list of diferent cities in OlaCab App")]
    public class OlaCabAppRateCardCommand : Language.Command
    {
        public class Arguments : CommandArguments
        {


            [Argument(Required = false, Tooltip = "Provide name of the capaility")]
            public TextStructure Search { get; set; } = new TextStructure("");

            [Argument(Required = false, Tooltip = "Provide element ID")]
            public TextStructure By { get; set; } = new TextStructure("id");
        }

        public OlaCabAppRateCardCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {

            arguments.Search.Value = "//android.webkit.WebView[@content-desc='Book Cabs Nearby at Best Price | Hire Taxi Nearby Online at Olacabs.com']/android.view.View/android.view.View[1]/android.view.View/android.view.View[1]/android.view.View/android.widget.Image";
            arguments.By.Value = "xpath";
            ElementHelper.GetElement(arguments.By.Value.ToLower(), arguments.Search.Value).Click();
            Thread.Sleep(1000);
            arguments.Search.Value = "//android.webkit.WebView[@content-desc='Book Cabs Nearby at Best Price | Hire Taxi Nearby Online at Olacabs.com']/android.view.View/android.view.View[2]/android.view.View[3]";
            arguments.By.Value = "xpath";
            ElementHelper.GetElement(arguments.By.Value.ToLower(), arguments.Search.Value).Click();
            Thread.Sleep(4000);










        }
    }
}