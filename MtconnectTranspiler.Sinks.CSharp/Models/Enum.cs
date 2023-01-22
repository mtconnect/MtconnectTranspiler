using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Model;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.UML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtconnectTranspiler.Sinks.CSharp.Models
{
    /// <summary>
    /// Generic type for a model derived from <see cref="XmiElement" />.
    /// </summary>
    /// <typeparam name="T">The type of <see cref="XmiElement" />.</typeparam>
    internal interface IModel<T> where T : XmiElement
    {
        /// <summary>
        /// Reference to the source <see cref="XmiElement" />.
        /// </summary>
        T Source { get; }
    }
    /// <summary>
    /// Generic type for a model derived from <see cref="XmiElement" /> which also might have normative versioning.
    /// </summary>
    /// <typeparam name="T">The type of <see cref="XmiElement" />.</typeparam>
    internal abstract class VersionedObject<T> : IModel<T> where T : XmiElement
    {
        /// <inheritdoc />
        public T Source { get; }

        /// <summary>
        /// The version of MTConnect when this became normative.
        /// </summary>
        public string NormativeVersion { get; }

        /// <summary>
        /// The version of MTConnect when this became deprecated.
        /// </summary>
        public string DeprecatedVersion { get; }

        public VersionedObject(MTConnectModel model, T source)
        {
            Source = source;
            var normative = model?.NormativeReferences?.FirstOrDefault(o => o.BaseElement == Source.Id);
            if (normative != null)
            {
                NormativeVersion = MTConnectHelperMethods.LookupMtconnectVersions(normative.Version);
                DeprecatedVersion = model?.DeprecatedReferences?.FirstOrDefault(o => o.BaseElement == Source.Id)?.Version;
            }
        }
    }
    internal class Enum : VersionedObject<UmlEnumeration>
    {
        public Enum(MTConnectModel model, UmlEnumeration source) : base(model, source)
        {
        }
    }
}
