using BukitLib.Discord.Commands;
using BukitLib.Exceptions;
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
    internal static List<BukitCommand> CommandList;

    /// <summary>Discord Token</summary>
    private string Token;


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

      this.Token = nToken;
    }
  }
}
