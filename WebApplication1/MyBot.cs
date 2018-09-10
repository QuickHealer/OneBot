using Microsoft.Bot;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class MyBot : IBot
    {
        public async Task OnTurn(ITurnContext turnContext)
        {
            if (turnContext.Activity.Type is ActivityTypes.Message)
            {
                string userInput = turnContext.Activity.Text;
                await turnContext.SendActivity($"You wrote {userInput}");
            }
        }
    }
}
