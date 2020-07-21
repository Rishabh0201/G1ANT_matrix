using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G1ANT.Language;
using System.Threading;


namespace G1ANT.Addon.irctc
{
    [Command(Name = "irctc.charts", Tooltip = "This command check the charts on  irctc ")]
    public class irctcchartsCommand : Command
    {
        public irctcchartsCommand(AbstractScripter scripter) : base(scripter)
        {

        }
        public class Arguments : SeleniumCommandArguments
        {

            
            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);
        }

        public void Execute(Arguments arguments)
        {
            try
            {

                arguments.Search.Value = "/html/body/app-root/app-home/div[2]/div/app-main-page/div[1]/div/div[1]/div/div/div[1]/div/app-jp-input/div[5]/div[2]/a/label";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
                Thread.Sleep(3000);


                




            }

            catch (Exception ex)
            {
                throw new ApplicationException($"Error occured while opening new selenium instance. Message: {ex.Message}", ex);
            }
        }
    }


}
