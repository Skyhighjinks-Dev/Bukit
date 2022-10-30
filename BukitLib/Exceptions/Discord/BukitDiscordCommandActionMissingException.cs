using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukitLib.Exceptions.Discord
{
  public class BukitDiscordCommandActionMissingException : Exception
  {
    /// <summary>
    /// Constructor
    /// </summary>
    public BukitDiscordCommandActionMissingException() : base()
    {

    }


    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="nMessage">Exception message</param>
    public BukitDiscordCommandActionMissingException(string? nMessage) 
      : base(nMessage)
    {

    }


    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="nMessage">Exception message</param>
    /// <param name="nInnerException">Inner Exception</param>
    public BukitDiscordCommandActionMissingException(string? nMessage, Exception nInnerException)
      : base(nMessage, nInnerException)
    {

    }
  }
}
