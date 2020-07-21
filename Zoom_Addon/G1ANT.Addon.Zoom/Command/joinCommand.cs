using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G1ANT.Language;

namespace G1ANT.Addon.Zoom
{

    [Command(Name = "zoom.join", Tooltip = "This command is used to join a meeting.")]
    public class joinCommand : Command
    {
        public joinCommand(AbstractScripter scripter) : base(scripter)
        {

        }
        public class Arguments : SeleniumCommandArguments
        {
            [Argument(Required = true, Tooltip = "Enter the value of MeetingID ")]
            public TextStructure meetingidvalue { get; set; }

            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);
        }
        public void Execute(Arguments arguments)
        {
            try
            {
                arguments.Search.Value = "/html/body/div[1]/div[2]/div/div[1]/div[2]/div[2]/div/ul[2]/li[3]/a";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
                arguments.Search.Value = "join-confno";
                arguments.By.Value = "id";
                SeleniumManager.CurrentWrapper.TypeText(arguments.meetingidvalue.Value, arguments, arguments.Timeout.Value);
                arguments.Search.Value = "/html/body/div[1]/div[3]/div[3]/div[2]/div/div[3]/form/div[2]/div/a";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error occured while opening new selenium instance. Message: {ex.Message}", ex);
            }



        }


    }
}
