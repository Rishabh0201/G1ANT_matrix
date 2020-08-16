using G1ANT.Language;
using OpenQA.Selenium.Remote;

namespace G1ANT.Addon.Appium

{
    [Command(Name = "lineapp.close", Tooltip = "This command closes lineapp session")]
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
