using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BukitTests.AttributeTests.Object
{
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field)]
  public class TestAttribute : Attribute
  {
    public string Value { get; set; }

    public TestAttribute()
    { 
    
    }

    public TestAttribute(string nValue)
    { 
      this.Value = nValue;
    }
  }
}
