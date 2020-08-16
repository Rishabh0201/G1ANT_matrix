using G1ANT.Language;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.WebexApp
{
    [Command(Name = "webexapp.close", Tooltip = "This command closes webex appium session")]
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
