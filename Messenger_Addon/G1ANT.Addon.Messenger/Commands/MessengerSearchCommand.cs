using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G1ANT.Language;

namespace G1ANT.Addon.Messenger
{
    [Command(Name = "messenger.search", Tooltip = "This command search any friend on Messenger")]
    class MessengerSearchCommand : Command
    {
        public MessengerSearchCommand(AbstractScripter scripter) : base(scripter)
        {

        }

        public class Arguments : SeleniumCommandArguments
        {
            [Argument(Required = true, Tooltip = "type your friend Name.")]
            public TextStructure Friend { get; set; }

            [Argument(Tooltip = "If set to `true`, the command should wait for a new window to appear after clicking the specified element")]
            public BooleanStructure WaitForNewWindow { get; set; } = new BooleanStructure(false);

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);
        }
        public void Execute(Arguments arguments)
        {
            try
            {
                arguments.Search.Value = "/html/body/div[1]/div/div/div[1]/div[2]/div[3]/div/div[1]/div/div/div[1]/span[1]/label/input";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.TypeText(arguments.Friend.Value, arguments, arguments.Timeout.Value);
                Thread.Sleep(500);
                SeleniumManager.CurrentWrapper.PressKey("enter", arguments, arguments.Timeout.Value);
                Thread.Sleep(2000);




            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error occured while typing text to element. Text: '{arguments.Friend.Value}'. 'Search element phrase: '{arguments.Search.Value}', by: '{arguments.By.Value}'. Message: {ex.Message}", ex);
            }
        }
    }
}
