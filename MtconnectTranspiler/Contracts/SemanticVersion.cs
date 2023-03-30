using System;

namespace MtconnectTranspiler.Contracts
{
    /// <summary>
    /// Represents a semantic version
    /// </summary>
    public struct SemanticVersion
    {
        /// <summary>
        /// Represents incompatible API changes
        /// </summary>
        public int Major { get; }

        /// <summary>
        /// Represents added functionality in a backwards compatible manner within the <see cref="Major"/> version
        /// </summary>
        public int Minor { get; }

        /// <summary>
        /// Represents backwards compatible bug fixes
        /// </summary>
        public int Patch { get; }

        /// <summary>
        /// Represents the official release date for the version
        /// </summary>
        public DateTime ReleaseDate { get; }

        /// <summary>
        /// Constructs a new instance of the <see cref="SemanticVersion"/>
        /// </summary>
        /// <param name="major"><inheritdoc cref="Major" path="/summary"/></param>
        /// <param name="minor"><inheritdoc cref="Minor" path="/summary"/></param>
        /// <param name="patch"><inheritdoc cref="Patch" path="/summary"/></param>
        /// <param name="release"><inheritdoc cref="ReleaseDate" path="/summary"/></param>
        public SemanticVersion(int major, int minor, int patch, DateTime release)
        {
            Major = major;
            Minor = minor;
            Patch = patch;
            ReleaseDate = release;
        }
    }
}
