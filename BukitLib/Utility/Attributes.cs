using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BukitLib.Utility
{
  public static class Attributes
  {
    public static T GetAttribute<T, U>(bool nInherit = false) where T : Attribute
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

    public static T GetAttribute<T, U>(string nPropertyName, bool nInherit = false) where T : Attribute
    { 
      try
      {         
        T attr = default(T)!;

        PropertyInfo? pi = typeof(U).GetProperty(nPropertyName);
        if(pi != null)
          attr = (T)pi.GetCustomAttributes(typeof(T), nInherit).FirstOrDefault()!;

        FieldInfo? fi = typeof(U).GetField(nPropertyName);
        if(fi != null)
          attr = (T)fi.GetCustomAttributes(typeof(T), nInherit).FirstOrDefault()!;

        return attr;
      }
      catch(Exception ex)
      { 
        return default(T)!;
      }
    }
  }
}
