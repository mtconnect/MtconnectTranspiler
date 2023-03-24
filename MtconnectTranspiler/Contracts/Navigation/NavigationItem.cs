namespace MtconnectTranspiler.Contracts.Navigation
{
    /// <summary>
    /// Represents a navigational path
    /// </summary>
    public class NavigationItem
    {
        /// <summary>
        /// Represents a part of the path
        /// </summary>
        public virtual string Name { get; }

        /// <summary>
        /// Represents the full path
        /// </summary>
        public string FullName => Parent != null
            ? $"{Parent.FullName}.{Name}"
            : Name;

        /// <summary>
        /// Reference to the parent item.
        /// </summary>
        public NavigationItem? Parent { get; set; }

        /// <summary>
        /// Constructs a new <see cref="NavigationItem"/>.
        /// </summary>
        /// <param name="path">The current end part in the navigational path.</param>
        /// <param name="parent">Optional reference to a parent within the navigational path.</param>
        public NavigationItem(string path, NavigationItem? parent = null)
        {
            Name = path;
            Parent = parent;
        }

        /// <summary>
        /// Implicitly references the <see cref="NavigationItem.FullName"/>.
        /// </summary>
        /// <param name="item">Reference to the <see cref="NavigationItem"/></param>
        public static implicit operator string(NavigationItem item) => item.FullName;
        /// <summary>
        /// Implicitly creates a <see cref="NavigationItem"/> using the <paramref name="item"/> as a part in the navigational path.
        /// </summary>
        /// <param name="item">The current end part in a navigational path.</param>
        public static implicit operator NavigationItem(string item) => new NavigationItem(item);
        /// <summary>
        /// Implicitly creates a <see cref="NavigationItem"/> using a parent <see cref="NavigationItem"/> and a new end part.
        /// </summary>
        /// <param name="path">A tuple with the first item being a parent <see cref="NavigationItem"/> and the second item being the end part in the navigational path.</param>
        public static implicit operator NavigationItem((NavigationItem, string) path) => new NavigationItem(path.Item2, path.Item1);
    }
}
