using BukitLib.Exceptions.Discord;
using Discord;
using Discord.WebSocket;
namespace BukitLib.Discord.Commands
{
  public class BukitCommand
  {
    /// <summary>Command info</summary>
    public BukitCommandInfo CommandInfo { get; private set; }


    /// <summary>
    /// Constructor
    /// </summary>
    public BukitCommand()
    {
      CommandInfo = GetCommand();
    }


    /// <summary>
    /// Retrieves an action to complete with this command 
    /// </summary>
    /// <returns></returns>
    /// <exception cref="BukitDiscordCommandActionMissingException"></exception>
    public virtual BukitCommandInfo GetCommand()
    { 
      throw new BukitDiscordCommandActionMissingException("Must override GetCommand() method!"); 
    }
  }
}
