using G1ANT.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1ANT.Addon.OlaCab
{
    [Command(Name = "olacab.close", Tooltip = "This command is use to closes a chrome web browser in which OlaCab is opened.")]
    public class OlaCabCloseCommand : Command
    {
        public class Arguments : CommandArguments
        {
        }
        public OlaCabCloseCommand(AbstractScripter scripter) : base(scripter)
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