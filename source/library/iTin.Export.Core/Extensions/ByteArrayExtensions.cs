﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using iTin.Export.ComponentModel;
using iTin.Export.Helper;

using Ionic.Zip;

namespace iTin.Export
{
    /// <summary>
    /// Static class than contains extension methods for objects <see cref="T:System.Array" /> of type <see cref="T:System.Byte" />.
    /// </summary> 
    static class ByteArrayExtensions
    {
        /// <summary>
        /// Saves this byte array into file.
        /// </summary>
        /// <param name="data">Data to save.</param>
        /// <param name="filename">Destination file.</param>
        public static void SaveToFile(this byte[] data, string filename)
        {
            SentinelHelper.ArgumentNull(data);
            SentinelHelper.IsTrue(string.IsNullOrEmpty(filename));

            using (var ms = new MemoryStream(data))
            {                
                ms.SaveToFile(filename);
            }
        }

        /// <summary>
        /// Creates a zip file with specified elements.
        /// </summary>
        /// <param name="elements">Zip elements.</param>
        /// <param name="writer">Writer reference.</param>
        /// <returns>
        /// A <see cref="T:System.String" /> than contains the path to created file.
        /// </returns>
        public static string ToZip(this IEnumerable<byte[]> elements, IWriter writer)
        {
            SentinelHelper.ArgumentNull(writer);
            SentinelHelper.ArgumentNull(writer.ResponseInfo);
            SentinelHelper.ArgumentNull(writer.ResponseInfo.Header);
           
            var elementList = elements as IList<byte[]> ?? elements.ToList();
            SentinelHelper.ArgumentNull(elementList);
            
            var header = writer.ResponseInfo;
            var zipName = header.ExtractFileName();
            var tempDirectory = FileHelper.TinExportTempDirectory;
            var zipPath = Path.Combine(tempDirectory, zipName);
            var zipNameWithoutExtension = Path.GetFileNameWithoutExtension(zipName);

            File.Delete(zipPath);

            using (var zip = new ZipFile(zipPath))
            {
                var currentFile = 0;
                var filenameBuilder = new StringBuilder();
                foreach (var element in elementList)
                {
                    filenameBuilder.Clear();
                    filenameBuilder.Append(zipNameWithoutExtension);
                    filenameBuilder.Append(currentFile);
                    filenameBuilder.Append(".");
                    filenameBuilder.Append(writer.ExtendedInformation.Extension);
                    zip.AddEntry(filenameBuilder.ToString(), element);
                    currentFile++;
                }

                zip.Save();
            }

            return zipPath;
        }

        /// <summary>
        /// Creates a zip file with specified elements.
        /// </summary>
        /// <param name="values">Element to zip.</param>
        /// <param name="names">The filename collection.</param>
        /// <param name="writer">Writer reference.</param>
        /// <returns>
        /// A <see cref="T:System.String" /> than contains the path to created file.
        /// </returns>
        public static string ToZip(this IEnumerable<byte[]> values, IEnumerable<string> names, IWriter writer)
        {
            var nameList = names as IList<string> ?? names.ToList();
            SentinelHelper.ArgumentNull(nameList);

            var valueList = values as IList<byte[]> ?? values.ToList();
            SentinelHelper.ArgumentNull(valueList);          

            SentinelHelper.ArgumentNull(writer);
            var dictionary = new Dictionary<string, byte[]>();

            var currentFile = 0;
            foreach (var name in nameList)
            {
                dictionary.Add(name, valueList[currentFile]);
                currentFile++;
            }

            return dictionary.ToZip(writer);
        }

        /// <summary>
        /// Creates a zip file with specified elements.
        /// </summary>
        /// <param name="elements">Element to zip.</param>
        /// <param name="writer">Writer reference.</param>
        /// <returns>
        /// A <see cref="T:System.String" /> than contains the path to created file.
        /// </returns>
        public static string ToZip(this IDictionary<string, byte[]> elements, IWriter writer)
        {
            SentinelHelper.ArgumentNull(writer);
            SentinelHelper.ArgumentNull(elements);
            SentinelHelper.ArgumentNull(writer.ResponseInfo);
            SentinelHelper.ArgumentNull(writer.ResponseInfo.Header);

            var response = writer.ResponseInfo;
            var zipName = response.ExtractFileName();

            var tempDirectory = FileHelper.TinExportTempDirectory;
            var zipPath = Path.Combine(tempDirectory, zipName);

            File.Delete(zipPath);

            using (var zip = new ZipFile(zipPath))
            {
                foreach (var element in elements)
                {
                    zip.AddEntry(element.Key, element.Value);
                }

                zip.Save();
            }

            return zipPath;
        }
    }
}
