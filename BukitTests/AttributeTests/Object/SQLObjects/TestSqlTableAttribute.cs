using BukitLib.Attributes.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukitTests.AttributeTests.Object.SQLObjects
{
  [SqlTable(nameof(TestSqlTableAttribute))]
  public class TestSqlTableAttribute
  {
  }
}
