using G1ANT.Language;
using System;

namespace G1ANT.Addon.Facebook
{
    [Command(Name = "facebook.closetab", Tooltip = "This command is used to closes the current tab in the current browser in which Facebook is opened")]
    public class FacebookCloseTabCommand : Command
    {
        public class Arguments : CommandArguments
        {
            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);
        }
        public FacebookCloseTabCommand(AbstractScripter scripter) : base(scripter)
        {
        }
        public void Execute(Arguments arguments)
        {
            try
            {
                SeleniumManager.CurrentWrapper.CloseTab(arguments.Timeout.Value);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error occured while closing current tab. Message: {ex.Message}", ex);
            }
        }
    }
}