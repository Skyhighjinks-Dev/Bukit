using BukitLib.Discord.Commands;
using BukitLib.Exceptions;
using BukitLib.Exceptions.Discord;
using Discord;
using Discord.WebSocket;
using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("BukitTests")]
namespace BukitLib.Discord
{
  public class BukitDiscord
  { 
    /// <summary>Project assembly</summary>
    internal static Assembly? ProjAssembly = null;
    
    /// <summary>List of discord commands</summary>
    internal static List<BukitCommand>? CommandList = null;

    /// <summary>Discord Token</summary>
    private string Token;

    /// <summary>Discord client</summary>
    private DiscordSocketClient Client;


    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="nAssembly">Project assembly</param>
    /// <param name="nToken">DiscordToken</param>
    /// <exception cref="BukitException"></exception>
    public BukitDiscord(Assembly nAssembly, string nToken)
    { 
      if(nAssembly == null)
        throw new BukitException("Assembly cannot be null!");

      ProjAssembly = nAssembly;
      Token = nToken;

      RetrieveCommandList();
    }


    /// <summary>
    /// Runs discord
    /// </summary>
    /// <returns>Thread that contains discord client</returns>
    public async Task<Thread> Run()
    { 
      Thread thread = new Thread(async () => await RunDiscord().ConfigureAwait(false));

      thread.Start();
      return thread;
    }


    /// <summary>
    /// Runs discord client
    /// </summary>
    private async Task RunDiscord()
    { 
      Client = new DiscordSocketClient();
      
      await Client.LoginAsync(TokenType.Bot, Token);
      await Client.StartAsync();

      await Task.Delay(-1);
    }


    /// <summary>
    /// Retrieves and assigns command list from Assembly
    /// </summary>
    private void RetrieveCommandList()
    { 
      if(CommandList != null)
        return;

      CommandList = new List<BukitCommand>();

      List<Type> typeLst = ProjAssembly!
                            .GetTypes()
                            .Where(x => x.IsSubclassOf(typeof(BukitCommand)))
                            .ToList();

      
      // Creates an instance of each 
      try
      { 
        for(int x = 0; x < typeLst.Count; x++)
        { 
          CommandList.Add((BukitCommand)Activator.CreateInstance(typeLst[x])!);
        }
      } catch(MissingMethodException nException)
      { 
        throw new BukitDiscordException($"Command constructors must be public!\n{nException.Message}");
      }
    }
  }
}
