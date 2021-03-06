﻿
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helpers;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    public partial class ReferenceModel
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultPath = "Default";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ReferencesModel _owner;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _path;

        public ReferenceModel()
        {
        }

        [XmlAttribute]
        public string Assembly { get; set; }

        /// <summary>
        /// Gets or sets the path where is located the assembly.
        /// </summary>
        /// <value>
        /// Path where is located the assembly. To specify a relative path use the character (~). The default is "<c>Default</c>".
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Reference Path="Default|string" .../&gt;
        /// </code>
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">If <paramref name="value" /> is <strong>null</strong>.</exception>
        /// <exception cref="T:iTin.Export.Model.InvalidPathNameException">If <paramref name="value" /> is an invalid path name.</exception>
        [XmlAttribute]
        [DefaultValue(DefaultPath)]
        public string Path
        {
            get => _path.Replace(DefaultPath, "~");
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidPath(value), new InvalidPathNameException(ErrorMessageHelper.ModelPathErrorMessage("Path", value)));

                _path = value;
            }
        }

        [Browsable(false)]
        [XmlIgnore]
        public ReferencesModel Owner => _owner;


        public override bool IsDefault => string.IsNullOrEmpty(Assembly) && Path.Equals(DefaultPath);

        public void SetOwner(ReferencesModel reference)
        {
            _owner = reference;
        }
    }
}
