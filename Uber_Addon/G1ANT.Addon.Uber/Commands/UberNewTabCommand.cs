using G1ANT.Language;
using System;
using System.Threading;

namespace G1ANT.Addon.Uber
{
    [Command(Name = "uber.newtab", Tooltip = "This command adds a new tab of 'www.Uber.com' in to the current browser")]
    public class UberNewTabCommand : Command
    {
        public class Arguments : CommandArguments
        {
            [Argument(Tooltip = "Webpage address to load")]
            public TextStructure Url { get; set; } = new TextStructure("www.uber.com");

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(false);

        }
        public UberNewTabCommand(AbstractScripter scripter) : base(scripter)
        {
        }
        public void Execute(Arguments arguments)
        {
            try
            {
                SeleniumManager.CurrentWrapper.NewTab(arguments.Timeout.Value, arguments.Url?.Value, arguments.NoWait.Value);
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error occured while opening new tab. Url '{arguments.Url.Value}'. Message: {ex.Message}", ex);
            }
        }
    }
}