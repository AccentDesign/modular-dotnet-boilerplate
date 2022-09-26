// --------------------------------------------------------------------------------------------------
// <copyright file="IJsonSerializerOptions.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using System.Text.Json;

namespace Shared.Core.Interfaces.Serialization
{
    public interface IJsonSerializerOptions
    {
        /// <summary>
        /// Options for <see cref="System.Text.Json"/>.
        /// </summary>
        public JsonSerializerOptions JsonSerializerOptions { get; }
    }
}