using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using G1ANT.Language;

namespace G1ANT.Addon.Twitter

{
    [Command(Name ="twitter.tweet", Tooltip ="This command use to tweet on Twitter")]
    class tweetCommand:Command 
    {
        public tweetCommand(AbstractScripter scripter) : base(scripter)
        {

        }
        public class Arguments : SeleniumCommandArguments
        {
            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(false);
            [Argument(Required = true, Tooltip = "Enter the email")]            
            public TextStructure MessageValue { get; set; }

        }
        public void Execute(Arguments arguments)
        { 
            try
            {
                
                SeleniumManager.CurrentWrapper.Navigate("https://twitter.com/compose/tweet", arguments.Timeout.Value, arguments.NoWait.Value);
                Thread.Sleep(500);
                arguments.Search.Value = "/html/body/div/div/div/div[1]/div[2]/div/div/div/div/div/div[2]/div[2]/div/div[3]/div/div/div/div[1]/div/div/div/div/div[2]/div[1]/div/div/div/div/div/div/div/div/div/div[1]/div/div/div/div[2]/div";
                arguments.By.Value = "xpath";
                SeleniumManager.CurrentWrapper.TypeText(arguments.MessageValue.Value, arguments, arguments.Timeout.Value);
                Thread.Sleep(2000);
                             
                
                

            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error occured while opening new selenium instance. Message: {ex.Message}", ex);
            }
        }
    }
}
