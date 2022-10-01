using System.IO;

namespace MtconnectTranspiler
{
    public static class XmiTranspilerExtensions
    {
        /// <summary>
        /// Writes the contents to the specified file after verifying the directory exists
        /// </summary>
        /// <param name="filepath">Location to write the contents</param>
        /// <param name="contents"></param>
        public static void WriteToFile(string filepath, string contents)
        {
            string folder = Path.GetDirectoryName(filepath);
            if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);

            File.WriteAllText(filepath, contents);
        }
    }
}
