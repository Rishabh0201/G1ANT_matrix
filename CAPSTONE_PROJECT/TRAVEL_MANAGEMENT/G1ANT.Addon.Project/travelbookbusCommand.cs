using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G1ANT.Language;
using System.Threading;

namespace G1ANT.Addon.Project
{
    [Command(Name = "travel.bus", Tooltip = "This command books bus ")]
    public class travelbookbusCommand : Command
    {
        public travelbookbusCommand(AbstractScripter scripter) : base(scripter)
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



            [Argument(Required = true, Tooltip = "first")]
            public TextStructure firstname { get; set; }
            [Argument(Required = true, Tooltip = "last")]
            public TextStructure age { get; set; }

            [Argument(Required = true, Tooltip = "last")]
            public TextStructure email { get; set; }

            [Argument(Required = true, Tooltip = "last")]
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
                        "https://www.makemytrip.com/bus-tickets/",
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

                arguments.Search.Value = "fromCity";
                arguments.By.Value = "id";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
                Thread.Sleep(500);
                arguments.Search.Value = "/html/body/div/div/div[2]/div/div/div[2]/div[1]/div[1]/div[1]/div/div/div/input";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
                Thread.Sleep(500);
                SeleniumManager.CurrentWrapper.TypeText(arguments.from.Value, arguments, arguments.Timeout.Value);
                Thread.Sleep(500);
                SeleniumManager.CurrentWrapper.PressKey("enter", arguments, arguments.Timeout.Value);
                Thread.Sleep(500);
                arguments.Search.Value = "toCity";
                arguments.By.Value = "id";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
                Thread.Sleep(500);
                arguments.Search.Value = "/html/body/div/div/div[2]/div/div/div[2]/div[1]/div[2]/div[1]/div/div/div/input";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
                Thread.Sleep(500);
                SeleniumManager.CurrentWrapper.TypeText(arguments.to.Value, arguments, arguments.Timeout.Value);
                Thread.Sleep(500);
                SeleniumManager.CurrentWrapper.PressKey("down", arguments, arguments.Timeout.Value);
                SeleniumManager.CurrentWrapper.PressKey("enter", arguments, arguments.Timeout.Value);
                Thread.Sleep(500);
                arguments.Search.Value = "search_button";
                arguments.By.Value = "id";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
                Thread.Sleep(3000);
                arguments.Search.Value = "/html/body/div/div/div/div[3]/div[3]/div/div[2]/div[1]/div/div/div[3]/a";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
                Thread.Sleep(1000);
                arguments.Search.Value = "/html/body/div/div/div/div[3]/div[3]/div/div[2]/div[1]/div[2]/div/div/div/div[2]/div/div/div/div[2]/span[11]";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
                Thread.Sleep(1000);
                arguments.Search.Value = "/html/body/div/div/div/div[3]/div[3]/div/div[2]/div[1]/div[2]/div/div/div/div[2]/div/div/ul/li[5]/a";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
                Thread.Sleep(1000);
                arguments.Search.Value = "/html/body/div/div/div/div[3]/div/section[1]/div[2]/div/ul/div/div[2]/form/div[1]/div/input";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
                Thread.Sleep(500);
                SeleniumManager.CurrentWrapper.TypeText(arguments.firstname.Value, arguments, arguments.Timeout.Value);
                Thread.Sleep(500);
                arguments.Search.Value = "/html/body/div/div/div/div[3]/div/section[1]/div[2]/div/ul/div/div[2]/form/div[2]/input";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
                Thread.Sleep(500);
                SeleniumManager.CurrentWrapper.TypeText(arguments.age.Value, arguments, arguments.Timeout.Value);
                Thread.Sleep(500);
                arguments.Search.Value = "/html/body/div/div/div/div[3]/div/section[1]/div[2]/div/ul/div/div[2]/form/div[3]/div/p/span[1]";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
                Thread.Sleep(500);
                arguments.Search.Value = "/html/body/div/div/div/div[3]/div/section[1]/div[2]/div/ul/div/div[2]/form/div[3]/div/ul/li[1]";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
                Thread.Sleep(500);
                arguments.Search.Value = "contactEmail";
                arguments.By.Value = "id";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
                Thread.Sleep(500);
                SeleniumManager.CurrentWrapper.TypeText(arguments.email.Value, arguments, arguments.Timeout.Value);
                Thread.Sleep(500);
                arguments.Search.Value = "mobileNumber";
                arguments.By.Value = "id";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
                Thread.Sleep(500);
                SeleniumManager.CurrentWrapper.TypeText(arguments.phnnumber.Value, arguments, arguments.Timeout.Value);
                Thread.Sleep(500);
                arguments.Search.Value = "/html/body/div/div/div/div[3]/div/section[1]/div[5]/div/div[4]/div[2]/span[1]";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
                Thread.Sleep(500);
                arguments.Search.Value = "/html/body/div/div/div/div[3]/div/section[2]/div/div[1]/a";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
                Thread.Sleep(500);







            }

            catch (Exception ex)
            {
                throw new ApplicationException($"Error occured while opening new selenium instance. Message: {ex.Message}", ex);
            }
        }
    }


}


