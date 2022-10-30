using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukitLib.Exceptions.Discord
{
  public class BukitDiscordException : Exception
  {
    /// <summary>
    /// Constructor
    /// </summary>
    public BukitDiscordException() : base()
    {

    }


    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="nMessage">Exception message</param>
    public BukitDiscordException(string? nMessage)
      : base(nMessage)
    {

    }


    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="nMessage">Exception message</param>
    /// <param name="nInnerException">Inner Exception</param>
    public BukitDiscordException(string? nMessage, Exception nInnerException)
      : base(nMessage, nInnerException)
    {

    }
  }
}
