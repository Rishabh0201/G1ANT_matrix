using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G1ANT.Language;


namespace G1ANT.Addon.viber
{
    [Command(Name = "viber.login", Tooltip = "This command automate login on viber ")]
    public class viberloginCommand : Command
    {
        public viberloginCommand(AbstractScripter scripter) : base(scripter)
        {

        }
        public class Arguments : SeleniumCommandArguments
        {
            [Argument(Required = true ,Tooltip = "Enter the phone number")]
            public TextStructure phonenumber { get; set; }
            [Argument(Required = true, Tooltip = "Enter the password")]
            public TextStructure password { get; set; }


            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(false);



            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);
        }

        public void Execute(Arguments arguments)
        {
            try
            {
                SeleniumManager.CurrentWrapper.Navigate("https://account.viber.com/en/login", arguments.Timeout.Value, arguments.NoWait.Value);
                arguments.Search.Value = "/html/body/div/div/div[2]/section/div/div/div/div/div[3]/form/div[1]/div[2]/div/input[2]";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
                SeleniumManager.CurrentWrapper.TypeText(arguments.phonenumber.Value, arguments, arguments.Timeout.Value);

                arguments.Search.Value = "/html/body/div/div/div[2]/section/div/div/div/div/div[3]/form/div[2]/div[1]/input";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
                SeleniumManager.CurrentWrapper.TypeText(arguments.password.Value, arguments, arguments.Timeout.Value);
                SeleniumManager.CurrentWrapper.PressKey("enter", arguments, arguments.Timeout.Value);


            }

            catch (Exception ex)
            {
                throw new ApplicationException($"Error occured while opening new selenium instance. Message: {ex.Message}", ex);
            }
        }
    }


}
