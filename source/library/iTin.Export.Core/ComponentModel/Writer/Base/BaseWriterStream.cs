﻿
namespace iTin.Export.ComponentModel.Writer
{
    using System.IO;

    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.ComponentModel.Writer.BaseWriter"/> Class, than implements interface <see cref="T:iTin.Export.ComponentModel.Writer.IWriterStream" />.
    /// Which acts as a base class for writers not based on markup languages​​, such as a writer for a binary file format.
    /// </summary>
    public abstract class BaseWriterStream : BaseWriter, IWriterStream
    {
        #region protected properties

        #region [protected] (ModelService) Service: Gets a reference to service render
        /// <summary>
        /// Gets a reference to service render.
        /// </summary>
        /// <value>The service.</value>
        protected ModelService Service => ModelService.Instance;
        #endregion

        #endregion

        #region public override properties

        #region [public] {override} (KnownWriterIdentifier) WriterIdentifier: Gets a value than identifies the type of writer
        /// <summary>
        /// Gets a value than identifies the type of writer.
        /// </summary>
        /// <value>
        /// Always returns ​the <see cref="T:iTin.Export.ComponentModel.Writers.KnownWriterIdentifier.WriterStream" /> value.
        /// </value>
        public override KnownWriterIdentifier WriterIdentifier => KnownWriterIdentifier.WriterStream;
        #endregion
       
        #endregion

        #region public methods

        #region [public] (void) CreateStream(): Creates a new non based writer for markup languages
        /// <summary>
        /// Creates a new non based writer for markup languages.
        /// </summary>
        public void CreateStream()
        {
            Stream = new MemoryStream();
        }
        #endregion

        #endregion
    }
}
