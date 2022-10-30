using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukitLib.Discord.Commands
{
  public class BukitCommandInfo
  {
    /// <summary>Slash command info</summary>
    public SlashCommandBuilder SlashCommandBuilder { get; private set; }

    /// <summary>Command to execute</summary>
    public Action<SocketSlashCommand> CommandAction { get; private set; }


    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="nSlashCommandBuilder"></param>
    /// <param name="nCommandAction"></param>
    public BukitCommandInfo(SlashCommandBuilder nSlashCommandBuilder, 
                            Action<SocketSlashCommand> nCommandAction)
    {
      SlashCommandBuilder = nSlashCommandBuilder;
      CommandAction = nCommandAction;
    }
  }
}
