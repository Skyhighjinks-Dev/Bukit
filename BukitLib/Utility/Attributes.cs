using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukitLib.Utility
{
  public static class Attributes
  {
    public static T GetAttribute<T, U>(bool nInherit = false) where T : new()
    { 
      try
      { 
        T attr = (T)typeof(U).GetCustomAttributes(typeof(T), nInherit).FirstOrDefault()!;
        return attr;
      } 
      catch (Exception ex)
      { 
        return default(T)!;
      }
    }
  }
}
