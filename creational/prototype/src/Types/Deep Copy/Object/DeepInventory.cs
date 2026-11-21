using System.Text.Json.Serialization;

namespace Lncodes.Tutorial.Prototype
{
    /// <summary>
    /// [JsonInclude] lets JsonSerializationPrototype copy non-public members; the xml type ignores it
    /// </summary>
    public sealed class DeepInventory
    {
        [JsonInclude]
        internal int Capacity;

        /// <summary>
        /// Constructor for xml prototype cause it's must have paramterless constructor
        /// </summary>
        [JsonConstructor]
        private DeepInventory() { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="capacity"></param>
        public DeepInventory(int capacity) =>
            Capacity = capacity;
    }
}
