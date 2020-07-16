using System;
using G1ANT.Language;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.youtubeandroid
{
    [Command(Name = "droidyoutube.subscriptions", Tooltip = "This command opens subscription page on Youtube")]
    public class subscriptionsyoutubedroidCommand : Language.Command
    {
        public class Arguments : CommandArguments
        {
            [Argument(Required = true, Tooltip = "Provide name of the capaility")]
            public TextStructure Search { get; set; } = new TextStructure("Subscriptions");

            [Argument(Required = true, Tooltip = "Provide element ID")]
            public TextStructure By { get; set; } = new TextStructure("AccessibilityId");
        }

        public subscriptionsyoutubedroidCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {
            var by = arguments.By.Value.ToLower();

            if (by == "xy")
            {
                TouchAction clickAction = new TouchAction(OpenCommand.GetDriver());
                var coordinates = arguments.Search.Value.Split(',');
                clickAction.Tap(int.Parse(coordinates[0]), int.Parse(coordinates[1])).Perform();
            }
            else
            {
                ElementHelper.GetElement(by, arguments.Search.Value).Click();
            }
        }
    }
}
