using G1ANT.Language;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.TumblrApp
{
    [Command(Name = "tumblrapp.close", Tooltip = "This command closes Tumblr app")]
    public class CloseCommand : Language.Command
    {
        public class Arguments : CommandArguments
        {

        }

        public CloseCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public void Execute(Arguments arguments)
        {
            var driver = OpenCommand.GetDriver();
            driver.Quit();
        }
    }
}