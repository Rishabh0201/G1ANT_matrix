using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using G1ANT.Language;

namespace G1ANT.Addon.Project
{
    [Command(Name = "travel.cruise", Tooltip = "This command books train ")]
    public class travelbookcruiseCommand : Command
    {
        public travelbookcruiseCommand(AbstractScripter scripter) : base(scripter)
        {

        }
        public class Arguments : SeleniumCommandArguments
        {

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(false);

            [Argument(Required = true, Tooltip = "From")]
            public TextStructure from { get; set; }

    



            [Argument(Required = true, Tooltip = "first")]
            public TextStructure firstname { get; set; }
            [Argument(Required = true, Tooltip = "last")]
            public TextStructure age { get; set; }



            







            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);
        }

        public void Execute(Arguments arguments)
        {
            try
            {

                SeleniumManager.CurrentWrapper.Navigate("https://www.yatra.com/cruise", arguments.Timeout.Value, arguments.NoWait.Value);
                Thread.Sleep(2000);
                







            }

            catch (Exception ex)
            {
                throw new ApplicationException($"Error occured while opening new selenium instance. Message: {ex.Message}", ex);
            }
        }
    }


}
