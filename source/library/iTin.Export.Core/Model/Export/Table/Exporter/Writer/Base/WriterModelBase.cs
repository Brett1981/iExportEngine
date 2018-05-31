
namespace iTin.Export.Model
{
    using System.Diagnostics;

    /// <summary>
    /// Base class for different types of writers.
    /// </summary>
    /// <remarks>
    /// <para>The following table shows different types of writers.</para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Class</term>
    ///     <description>Description</description>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="T:iTin.Export.Model.WriterModel" /></term>
    ///     <description>Represents an exporter based on a custom writer.</description>
    ///   </item>
    /// </list>
    /// </remarks>
    public partial class WriterModelBase
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private FilterModel _filter;
        #endregion

        #region public properties

        #region [public] (FilterModel) Filter: Gets or sets a referenceto set of properties that allow you to specify a writer
        /// <summary>
        /// Gets or sets a referenceto set of properties that allow you to specify a writer.
        /// </summary>
        /// <value>
        /// Reference to set of properties that allow you to specify a writer.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Writer&gt;
        ///   &lt;Filter/&gt;
        /// &lt;/Writer&gt;
        /// </code>
        /// </remarks>
        public FilterModel Filter
        {
            get
            {
                if (_filter == null)
                {
                    _filter = new FilterModel();
                }

                _filter.SetParent(this);

                return _filter;
            }
            set => _filter = value;
        }
        #endregion

        #endregion
    }
}
