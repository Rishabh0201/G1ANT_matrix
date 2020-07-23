using G1ANT.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1ANT.Addon.Rapido
{
    [Command(Name = "rapido.refresh", Tooltip = "This command refreshes the current tab content in the web browser")]
    public class RapidoRefreshCommand : Command
    {
        public class Arguments : CommandArguments
        {
        }
        public RapidoRefreshCommand(AbstractScripter scripter) : base(scripter)
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