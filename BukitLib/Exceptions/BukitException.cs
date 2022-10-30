using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukitLib.Exceptions
{
  public class BukitException : Exception
  { 
    /// <summary>
    /// Constructor
    /// </summary>
    public BukitException() : base()
    { 
    
    }


    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="nMessage">Exception message</param>
    public BukitException(string? nMessage) : base(nMessage)
    { 
    
    }


    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="nMessage">Exception message</param>
    /// <param name="nInnerException">Inner Exception</param>
    public BukitException(string? nMessage, Exception nInnerException) 
      : base(nMessage, nInnerException)
    { 
    
    }
  }
}
