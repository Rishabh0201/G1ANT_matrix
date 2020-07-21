using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G1ANT.Language;
using System.Threading;


namespace G1ANT.Addon.irctc
{
    [Command(Name = "irctc.findtrain", Tooltip = "This command opens irctc ")]
    public class irctcfindtrainCommand : Command
    {
        public irctcfindtrainCommand(AbstractScripter scripter) : base(scripter)
        {

        }
        public class Arguments : SeleniumCommandArguments
        {

            [Argument(Required = true, Tooltip = "Enter the station name from where you want to depart")]
            public TextStructure from { get; set; }

            [Argument(Required = true, Tooltip = "Enter the station name where you want to arive")]
            public TextStructure to { get; set; }
            

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);
        }

        public void Execute(Arguments arguments)
        {
            try
            {
               
                arguments.Search.Value = "/html/body/app-root/app-home/div[2]/div/app-main-page/div[1]/div/div[1]/div/div/div[1]/div/app-jp-input/div[3]/form/div[2]/div[2]/p-autocomplete/span/input";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
                Thread.Sleep(1000);
                SeleniumManager.CurrentWrapper.TypeText(arguments.from.Value, arguments, arguments.Timeout.Value);
                Thread.Sleep(1000);
                SeleniumManager.CurrentWrapper.PressKey("enter", arguments, arguments.Timeout.Value);
                Thread.Sleep(1000);
                arguments.Search.Value = "/html/body/app-root/app-home/div[2]/div/app-main-page/div[1]/div/div[1]/div/div/div[1]/div/app-jp-input/div[3]/form/div[2]/div[4]/p-autocomplete/span/input";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
                SeleniumManager.CurrentWrapper.TypeText(arguments.to.Value, arguments, arguments.Timeout.Value);
                SeleniumManager.CurrentWrapper.PressKey("enter", arguments, arguments.Timeout.Value);
                Thread.Sleep(1000);
           
                                               

                
            }

            catch (Exception ex)
            {
                throw new ApplicationException($"Error occured while opening new selenium instance. Message: {ex.Message}", ex);
            }
        }
    }


}
