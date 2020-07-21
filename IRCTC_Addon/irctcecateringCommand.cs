using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G1ANT.Language;
using System.Threading;


namespace G1ANT.Addon.irctc
{
    [Command(Name = "irctc.ecatering", Tooltip = "This command opnes e catering services on irctc ")]
    public class irctcecateringCommand : Command
    {
        public irctcecateringCommand(AbstractScripter scripter) : base(scripter)
        {

        }
        public class Arguments : SeleniumCommandArguments
        {

            [Argument(Required = true, Tooltip = "Enter the pnr number")]
            public TextStructure pnr { get; set; }
            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(false);




            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);
        }

        public void Execute(Arguments arguments)
        {
            try
            {

                SeleniumManager.CurrentWrapper.Navigate("https://www.ecatering.irctc.co.in/", arguments.Timeout.Value, arguments.NoWait.Value);

                arguments.Search.Value = "/html/body/div[1]/div/div/div/div/div/div";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
                
                arguments.Search.Value = "/html/body/div[1]/div/section[2]/div[2]/input";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
                SeleniumManager.CurrentWrapper.TypeText(arguments.pnr.Value, arguments, arguments.Timeout.Value);
                Thread.Sleep(1000);
                SeleniumManager.CurrentWrapper.PressKey("enter", arguments, arguments.Timeout.Value);

                




            }

            catch (Exception ex)
            {
                throw new ApplicationException($"Error occured while opening new selenium instance. Message: {ex.Message}", ex);
            }
        }
    }


}
