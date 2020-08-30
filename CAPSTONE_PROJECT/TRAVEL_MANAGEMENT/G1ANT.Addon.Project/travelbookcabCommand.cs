using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G1ANT.Language;
using System.Threading;

namespace G1ANT.Addon.Project
{
    [Command(Name = "travel.cab", Tooltip = "This command books cab ")]
    public class travelbookcabCommand : Command
    {
        public travelbookcabCommand(AbstractScripter scripter) : base(scripter)
        {

        }
        public class Arguments : SeleniumCommandArguments
        {

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(false);

            [Argument(Required = true, Tooltip = "From")]
            public TextStructure from { get; set; }

            [Argument(Required = true, Tooltip = "to")]
            public TextStructure to { get; set; }

            [Argument(Required = true, Tooltip = "firstname")]
            public TextStructure firstname { get; set; }

            [Argument(Required = true, Tooltip = "lastname")]
            public TextStructure lastname { get; set; }

            [Argument(Required = true, Tooltip = "add")]
            public TextStructure add { get; set; }

            [Argument(Required = true, Tooltip = "email")]
            public TextStructure email { get; set; }

            [Argument(Required = true, Tooltip = "phnnumber")]
            public TextStructure phnnumber { get; set; }

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);
        }

        public void Execute(Arguments arguments)
        {
            try
            {
                
                SeleniumWrapper wrapper = SeleniumManager.CreateWrapper(
                        "chrome",
                        "https://www.makemytrip.com/cabs/",
                        arguments.Timeout.Value,
                        false,
                        Scripter.Log,
                        Scripter.Settings.UserDocsAddonFolder.FullName);
                int wrapperId = wrapper.Id;
                OnScriptEnd = () =>
                {
                    SeleniumManager.DisposeAllOpenedDrivers();
                    SeleniumManager.RemoveWrapper(wrapperId);
                    SeleniumManager.CleanUp();
                };
                








            }

            catch (Exception ex)
            {
              throw new ApplicationException($"Error occured while opening new selenium instance. Message: {ex.Message}", ex);
            }
        }
    }

}


