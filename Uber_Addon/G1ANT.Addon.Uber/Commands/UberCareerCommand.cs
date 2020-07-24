using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G1ANT.Language;
using OpenQA.Selenium;
using System.Threading;

namespace G1ANT.Addon.Uber
{

    [Command(Name = "uber.career", Tooltip = "This command is used to land on career page of Uber.")]
    public class UberCareerCommand : Command
    {
        public UberCareerCommand(AbstractScripter scripter) : base(scripter)
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


                arguments.Search.Value = "/html/body/div/div/div/div[1]/main/footer/section/div/div/div/div[2]/div/div[1]/a[5]/p";
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