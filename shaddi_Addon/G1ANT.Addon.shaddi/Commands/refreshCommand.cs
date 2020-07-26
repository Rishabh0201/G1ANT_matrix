using G1ANT.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1ANT.Addon.shaddi
{
    [Command(Name = "shaddi.refresh", Tooltip = "This command refreshes pinterest current tab content in the web browser")]
    public class refreshCommand : Command
    {
        public class Arguments : CommandArguments
        {
        }
        public refreshCommand(AbstractScripter scripter) : base(scripter)
        {
        }
        public void Execute(Arguments arguments)
        {
            try
            {
                SeleniumManager.CurrentWrapper.Refresh();
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error occured while refreshing selenium instance. Message: {ex.Message}", ex);
            }
        }
    }
}