using BukitLib.Utility;
using BukitTests.AttributeTests.Object;

using TestAttribute = BukitTests.AttributeTests.Object.TestAttribute;

namespace BukitTests.AttributeTests
{
  public class AttributeTests
  {
    [TestCase]
    public void TestGetAttribute()
    { 
      TestAttribute tA = Attributes.GetAttribute<TestAttribute, TestObject>(false);

      Assert.IsNotNull(tA?.Value);
    }
  }
}
