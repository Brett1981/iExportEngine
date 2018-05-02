﻿
namespace iTin.Export.Inputs
{
    using System;

    using Adapters;
    using ComponentModel.Inputs;

    /// <inheritdoc />
    /// <summary>
    /// Class than allows you to export an object of type <see cref="T:System.Uri" />.
    /// </summary>
    [InputOptions(AdapterType = typeof(XmlAdapter))]
    public class JsonInput : BaseInput
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.XmlInput" /> class.
        /// </summary>
        /// <param name="xml">The XML.</param>
        public JsonInput(Uri xml)
            : base(xml)
        {
        }
    }
}
