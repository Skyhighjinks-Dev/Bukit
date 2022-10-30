namespace BukitLib.Attributes.Database
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SqlTableAttribute : Attribute
    {
        /// <summary>Table name</summary>
        public string TableName { get; set; }

        /// <summary>Table schema</summary>
        public string Schema { get; set; }


        /// <summary>
        /// Constructor
        /// </summary>
        public SqlTableAttribute(string nTable) : this(nTable, "dbo")
        {
        }


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nTable">Table Name</param>
        /// <param name="nSchema">Schema</param>
        public SqlTableAttribute(string nTable, string nSchema)
        {
            string tableName = nTable.Replace("table", "", true, null);

            TableName = tableName;
            Schema = nSchema;
        }
    }
}
