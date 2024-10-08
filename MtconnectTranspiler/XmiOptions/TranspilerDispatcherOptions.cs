﻿using Microsoft.Extensions.Logging;
using MtconnectTranspiler.Contracts;

namespace MtconnectTranspiler
{
    /// <summary>
    /// Options for constructing an instance of <see cref="TranspilerDispatcher"/>.
    /// </summary>
    public abstract class TranspilerDispatcherOptions
    {
        /// <summary>
        /// Returns an instance of <see cref="XmiDeserializer"/> that has a copy of the SysML model in memory.
        /// </summary>
        /// <param name="logger">Reference to dependency injected logger.</param>
        /// <returns>Instance of <see cref="XmiDeserializer"/></returns>
        public abstract XmiDeserializer GetDeserializer(ILogger<XmiDeserializer>? logger = null);
    }
}
