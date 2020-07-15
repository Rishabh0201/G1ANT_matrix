using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using G1ANT.Language;

namespace G1ANT.Addon.youtube
{
    [Command(Name = "youtube.upload", Tooltip = "This command upload videos on youtube")]
    public class uploadCommand : Command
    {
        public uploadCommand(AbstractScripter scripter) : base(scripter)
        {

        }
        public class Arguments : SeleniumCommandArguments
        {

            [Argument(DefaultVariable = "url", Tooltip = "")]
            public TextStructure url { get; set; } = new TextStructure("https://studio.youtube.com");
            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(false);
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);
        }
        public void Execute(Arguments arguments)
        {
            try
            {
                SeleniumManager.CurrentWrapper.Navigate(arguments.url.Value, arguments.Timeout.Value, arguments.NoWait.Value);
                arguments.Search.Value = "/html/body/ytcp-app/ytcp-entity-page/div/div/main/div/ytcp-animatable[1]/div[1]/ytcp-quick-actions/a[1]/ytcp-icon-button/iron-icon";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value);
                arguments.Search.Value = "/html/body/ytcp-uploads-dialog/paper-dialog/div/ytcp-uploads-file-picker/div/ytcp-button/div";
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