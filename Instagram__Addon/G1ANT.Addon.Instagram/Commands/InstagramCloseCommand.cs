using G1ANT.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1ANT.Addon.Instagram
{
    [Command(Name = "instagram.close", Tooltip = "This command is use to closes a web browser in which Instagram is opened")]
    public class InstagramCloseCommand : Command
    {
        public class Arguments : CommandArguments
        {
        }
        public InstagramCloseCommand(AbstractScripter scripter) : base(scripter)
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