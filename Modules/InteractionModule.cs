using Discord.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialBot.Modules
{
  public class InteractionModule:InteractionModuleBase<SocketInteractionContext>
  {
    [SlashCommand("ping","Receive a ping messege!")]

    public async Task HandlePingCommand()
    {
      await RespondAsync("PONG!");
    }
  }
}
