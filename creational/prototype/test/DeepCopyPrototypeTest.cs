using Xunit;

namespace Lncodes.Tutorial.Prototype.Test
{
    public sealed class DeepCopyPrototypeTest
    {
        [Theory]
        [ClassData(typeof(DeepCopyTheoryData))]
        public void Clone_ManualDeepCopyPrototype_AreNotEqual(string name, int level, DeepInventory inventory)
        {
            var expected = new ManualDeepCopyPrototype(name, level, inventory);

            var actual = expected.Clone();
            actual.SetInventoryCapacity(default);

            Assert.NotEqual(expected.GetResult(), actual.GetResult());
        }

        [Theory]
        [ClassData(typeof(DeepCopyTheoryData))]
        public void Clone_JsonSerializationPrototype_AreNotEqual(string name, int level, DeepInventory inventory)
        {
            var expected = new JsonSerializationPrototype(name, level, inventory);

            var actual = expected.Clone();
            actual.SetInventoryCapacity(default);

            Assert.NotEqual(expected.GetResult(), actual.GetResult());
        }

        [Theory]
        [ClassData(typeof(DeepCopyTheoryData))]
        public void Clone_JsonSerializationPrototype_CopiesValuesIntoNewInventory(string name, int level, DeepInventory inventory)
        {
            var original = new JsonSerializationPrototype(name, level, inventory);

            var clone = original.Clone();

            Assert.Equal(original.GetResult(), clone.GetResult());
            Assert.NotSame(original.Inventory, clone.Inventory);
        }

        [Theory]
        [ClassData(typeof(DeepCopyTheoryData))]
        public void Clone_XmlSerializationPrototype_AreNotEqual(string name, int level, DeepInventory inventory)
        {
            var expected = new XmlSerializationPrototype(name, level, inventory);

            var actual = expected.Clone();
            actual.SetInventoryCapacity(default);

            Assert.NotEqual(expected.GetResult(), actual.GetResult());
        }
    }
}
