using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukitTests.AttributeTests.Object
{
  [Test("TestClass")]
  public class TestObject
  {
    [Test("TestProperty")]
    public string TestString_Property { get; set; }

    [Test("TestField")]
    public string TestString_Field;
  }
}
