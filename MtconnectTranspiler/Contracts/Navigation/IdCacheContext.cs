using MtconnectTranspiler.Xmi;
using System;
using System.Collections.Generic;
using System.Text;

namespace MtconnectTranspiler.Contracts.Navigation
{
    /// <summary>
    /// Provides a context for caching object instances during deserialization.
    /// Implements <see cref="IDisposable"/> to ensure the context is cleaned up after use.
    /// </summary>
    public class IdCacheContext : IDisposable
    {
        /// <summary>
        /// Gets the dictionary used for caching object instances by their IDs.
        /// </summary>
        public Dictionary<string, object> IdCache { get; } = new Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdCacheContext"/> class.
        /// Sets the current context to this instance and throws an exception if a context already exists.
        /// </summary>
        public IdCacheContext()
        {
            if (IdCacheContextHolder.Current != null)
            {
                throw new InvalidOperationException("An IdCacheContext is already active on this thread.");
            }

            IdCacheContextHolder.Current = this;
        }

        /// <summary>
        /// Adds an object to the cache with the specified ID.
        /// </summary>
        /// <param name="id">The ID of the element.</param>
        /// <param name="element">The element to add to the cache.</param>
        public void AddToCache(string id, object element)
        {
            if (!string.IsNullOrEmpty(id))
            {
                IdCache[id] = element;
            }
        }

        /// <summary>
        /// Retrieves an object from the cache by its ID.
        /// </summary>
        /// <param name="id">The ID of the element to retrieve.</param>
        /// <returns>The element with the specified ID, or <c>null</c> if not found.</returns>
        public object? GetFromCache(string id)
        {
            if (IdCache.TryGetValue(id, out var element))
            {
                return element;
            }
            return null;
        }

        /// <summary>
        /// Disposes of the context, resetting the current context holder.
        /// </summary>
        public void Dispose()
        {
            IdCacheContextHolder.Current = null;
        }
    }
}
