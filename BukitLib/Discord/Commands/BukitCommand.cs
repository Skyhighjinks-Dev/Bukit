using BukitLib.Exceptions.Discord;
using Discord;
using Discord.WebSocket;
namespace BukitLib.Discord.Commands
{
  public class BukitCommand
  {
    /// <summary>Discord slash command</summary>
    public SlashCommandBuilder SlashCommand { get; private set; }


    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="nName">Command Name</param>
    /// <param name="nDescription">Command Description</param>
    protected BukitCommand(string nName, string nDescription)
    { 
      if(string.IsNullOrEmpty(nName))
        throw new BukitDiscordException("A command must have a name!");

      SlashCommandBuilder builder = new SlashCommandBuilder();
      
      this.SlashCommand = builder.WithName(nName)
                                 .WithDescription(nDescription);
    }


    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="slashCommand">Slash command</param>
    public BukitCommand(SlashCommandBuilder slashCommand)
    {
      SlashCommand = slashCommand;
    }


    /// <summary>
    /// Retrieves an action to complete with this command 
    /// </summary>
    /// <returns></returns>
    /// <exception cref="BukitDiscordCommandActionMissingException"></exception>
    public virtual Action<SocketSlashCommand> GetCommand()
    { 
      throw new BukitDiscordCommandActionMissingException("Must override GetCommand() method!"); 
    }
  }
}
