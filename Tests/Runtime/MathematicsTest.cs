using NUnit.Framework;

using Unity.Mathematics;

using Saitama.Mathematics;

namespace Tests
{
    public class MathematicsTest
    {
        [Test]
        public void MathematicsTestExtension()
        {
            Assert.AreEqual(new int2(0).To1D(0), 0);
            Assert.AreEqual(new int2(0, 32).To1D(64), 32*64);
        }
    }
}
