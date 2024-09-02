using System;

namespace MtconnectTranspiler.Contracts.Navigation
{
    /// <summary>
    /// Holds the current instance of <see cref="IdCacheContext"/> for the current thread.
    /// This allows for a transactional context during deserialization.
    /// </summary>
    public static class IdCacheContextHolder
    {
        [ThreadStatic]
        private static IdCacheContext? _current;

        /// <summary>
        /// Gets or sets the current <see cref="IdCacheContext"/> for the current thread.
        /// </summary>
        public static IdCacheContext? Current
        {
            get { return _current; }
            set { _current = value; }
        }
    }

}
