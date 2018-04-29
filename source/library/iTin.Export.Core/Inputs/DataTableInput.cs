﻿
namespace iTin.Export.Inputs
{
    using System.Data;
    using System.Linq;

    using Adapters.Native;
    using ComponentModel;
    using Helpers;

    /// <inheritdoc />
    /// <summary>
    /// Class than allows you to export an object of type <see cref="T:System.Data.DataTable" />.
    /// </summary>
    [InputOptions(AdapterType = typeof(DataSetAdapter))]
    public class DataTableInput : DataRowInput
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.DataTableInput" /> class.
        /// </summary>
        /// <param name="table">The table.</param>
        public DataTableInput(DataTable table)
            : this(SentinelHelper.PassThroughNonNull(table), SentinelHelper.PassThroughNonNull(table).TableName)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.DataTableInput" /> class.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="name">The name.</param>
        public DataTableInput(DataTable table, string name)
            : base(SentinelHelper.PassThroughNonNull(table).Rows.Cast<DataRow>(), name)
        {
        }
    }
}
