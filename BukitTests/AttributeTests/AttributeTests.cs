using BukitLib.Attributes.Database;
using BukitLib.Utility;
using BukitTests.AttributeTests.Object;
using BukitTests.AttributeTests.Object.SQLObjects;
using TestAttribute = BukitTests.AttributeTests.Object.TestAttribute;

namespace BukitTests.AttributeTests
{
  public class AttributeTests
  {
    [TestCase]
    public void TestGetAttribute()
    { 
      TestAttribute tA = Attributes.GetAttribute<TestAttribute, TestObject>(false);
      Assert.IsTrue(TestAttributeResult(tA, "TestClass", true));
    }

    [TestCase]
    public void TestGetAttributeProperty()
    { 
      TestAttribute tA = Attributes.GetAttribute<TestAttribute, TestObject>(nameof(TestObject.TestString_Property), false);
      Assert.IsTrue(TestAttributeResult(tA, "TestProperty", true));
    }

    [TestCase]
    public void TestGetAttributeField()
    { 
      TestAttribute tA = Attributes.GetAttribute<TestAttribute, TestObject>(nameof(TestObject.TestString_Field), false);
      Assert.IsTrue(TestAttributeResult(tA, "TestField", true));
    }

    [TestCase]
    public void TestSqlTableAttribute()
    { 
      SqlTableAttribute sqlTblAttr = Attributes.GetAttribute<SqlTableAttribute, TestSqlTableAttribute>();

      string tblName = nameof(TestSqlTableAttribute).Replace("table", "", true, null);
      Assert.IsTrue(string.Compare(tblName, sqlTblAttr.TableName, true) == 0);
    }
    

    private bool TestAttributeResult(TestAttribute nAttribute, string? nAttrValue = null, bool nIgnoreCaseSensitivity = true)
    { 
      bool result = nAttribute != null && !string.IsNullOrEmpty(nAttribute.Value);

      if(!string.IsNullOrEmpty(nAttrValue))
        result = result && (string.Compare(nAttrValue, nAttribute.Value, nIgnoreCaseSensitivity) == 0);

      return result;
    }
  }
}
