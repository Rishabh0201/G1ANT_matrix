using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G1ANT.Language;
using OpenQA.Selenium;

namespace G1ANT.Addon.Messenger
{

    [Command(Name = "messenger.changetheme", Tooltip = "This command change Theme of message on Messenger web .")]
    public class MassangerChangeThemeCommand : Command
    {
        public MassangerChangeThemeCommand(AbstractScripter scripter) : base(scripter)
        {
        }
        public class Arguments : SeleniumCommandArguments
        {


            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(false);
        }
        public void Execute(Arguments arguments)
        {
            try
            {

                arguments.Search.Value = "/html/body/div[1]/div/div/div[2]/span/div[2]/div[1]/div/div/div[1]/div/div/div/div[2]/div[2]/span/div[3]/div[1]/div/div";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);


            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error occured while opening new selenium instance. Message: {ex.Message}", ex);
            }
        }
    }
}