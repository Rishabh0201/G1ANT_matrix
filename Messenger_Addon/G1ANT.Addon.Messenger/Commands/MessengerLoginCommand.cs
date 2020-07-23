using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G1ANT.Language;
using OpenQA.Selenium;

namespace G1ANT.Addon.Messenger
{
    [Command(Name = "messenger.login", Tooltip = "This command login in Messenger web browser.")]
    public class MessengerLoginCommand : Command
    {
        public MessengerLoginCommand(AbstractScripter scripter) : base(scripter)
        {
        }
        public class Arguments : SeleniumCommandArguments
        {
            [Argument(Required = true, Tooltip = "Enter the Login Mobile number here")]
            public TextStructure phone { get; set; }
            [Argument(Required = true, Tooltip = "Enter the password here")]
            public TextStructure pword { get; set; }

            [Argument(Tooltip = "If set to `true`, the command should wait for a new window to appear after clicking the specified element")]
            public BooleanStructure WaitForNewWindow { get; set; } = new BooleanStructure(false);

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);
        }
        public void Execute(Arguments arguments)
        {
            try
            {            
                
                arguments.Search.Value = "email";
                arguments.By.Value = "id";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);
                Thread.Sleep(300);
                SeleniumManager.CurrentWrapper.TypeText(arguments.phone.Value, arguments, arguments.Timeout.Value);
                Thread.Sleep(300);
                arguments.Search.Value = "pass";
                arguments.By.Value = "id";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);
                Thread.Sleep(200);
                SeleniumManager.CurrentWrapper.TypeText(arguments.pword.Value, arguments, arguments.Timeout.Value);
                arguments.Search.Value = "loginbutton";
                arguments.By.Value = "id";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, arguments.WaitForNewWindow.Value);
                Thread.Sleep(9000);
                
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error occured while opening new selenium instance. Message: {ex.Message}", ex);
            }
        }
    }
}