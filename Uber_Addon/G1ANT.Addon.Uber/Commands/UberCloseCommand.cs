using G1ANT.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1ANT.Addon.Uber
{
    [Command(Name = "uber.close", Tooltip = "This command is use to closes a chrome web browser in which Uber is opened.")]
    public class UberCloseCommand : Command
    {
        public class Arguments : CommandArguments
        {
        }
        public UberCloseCommand(AbstractScripter scripter) : base(scripter)
        {
        }
        public void Execute(Arguments arguments)
        {
            try
            {
                SeleniumManager.QuitCurrentWrapper();

            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error occured while closing selenium instance. Message: {ex.Message}", ex);
            }
        }
    }
}