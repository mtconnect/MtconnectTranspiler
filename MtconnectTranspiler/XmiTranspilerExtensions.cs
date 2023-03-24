using System.IO;

namespace MtconnectTranspiler
{
    /// <summary>
    /// Helper methods to be used when performing basic transpilation.
    /// </summary>
    public static class XmiTranspilerExtensions
    {
        /// <summary>
        /// Writes the contents to the specified file after verifying the directory exists
        /// </summary>
        /// <param name="filepath">Location to write the contents</param>
        /// <param name="contents">Contents of the file</param>
        /// <param name="overwriteExisting">Flag for whether or not the file should be overwritten if it exists. If the file exists and this is set to fals, then the filename is appended with an underscore (_) and an auto-incrementing number.</param>
        public static void WriteToFile(string filepath, string contents, bool overwriteExisting = false)
        {
            string folder = Path.GetDirectoryName(filepath);
            if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);

            if (!overwriteExisting)
            {
                int copyCount = 0;
                do
                {
                    if (File.Exists(filepath))
                    {
                        copyCount += 1;
                        int extensionIndex = filepath.LastIndexOf(".");
                        filepath = $"{filepath.Substring(0, extensionIndex)}_{copyCount}{filepath.Substring(extensionIndex)}";
                    }
                } while (File.Exists(filepath));
            }

            File.WriteAllText(filepath, contents);
        }
    }
}
