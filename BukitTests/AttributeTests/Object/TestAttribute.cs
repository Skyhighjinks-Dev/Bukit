using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukitTests.AttributeTests.Object
{
  [AttributeUsage(AttributeTargets.Class)]
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
