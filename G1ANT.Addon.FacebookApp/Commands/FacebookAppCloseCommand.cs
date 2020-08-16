using G1ANT.Language;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.FacebookApp
{
    [Command(Name = "facebook.close", Tooltip = "This command closes facebook session")]
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
