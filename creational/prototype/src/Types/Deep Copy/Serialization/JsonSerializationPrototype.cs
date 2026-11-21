using System.Text.Json;

namespace Lncodes.Tutorial.Prototype
{
    /// <summary>
    /// Deep copy by serializing the object to JSON and reading it back (System.Text.Json).
    /// Replaces the old BinaryFormatter example: BinaryFormatter was removed from .NET 9+
    /// because it is unsafe. Non-public members that must be copied are marked [JsonInclude].
    /// </summary>
    public sealed class JsonSerializationPrototype : DeepCharacter
    {
        /// <summary>
        /// Parameterless constructor used by the JSON deserializer
        /// </summary>
        [System.Text.Json.Serialization.JsonConstructor]
        private JsonSerializationPrototype() { }

        /// <inheritdoc cref="DeepCharacter"/>
        public JsonSerializationPrototype(string name, int level, DeepInventory inventory) : base(name, level, inventory) { }

        /// <summary>
        /// Method to clone JsonSerializationPrototype object
        /// </summary>
        /// <returns cref="JsonSerializationPrototype"></returns>
        public JsonSerializationPrototype Clone()
        {
            var json = JsonSerializer.Serialize(this);
            return JsonSerializer.Deserialize<JsonSerializationPrototype>(json);
        }
    }
}
