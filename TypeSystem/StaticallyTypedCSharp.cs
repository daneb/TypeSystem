using System;
using Xunit;

namespace TypeSystem
{
    public class StaticallyTypedCSharp
    {
        [Fact]
        public void StaticTypeSuccess()
        {
            string o = "Hello";
            Assert.True(o.Length == 5);
        }

        [Fact]
        public void StaticTypeCompileEnforced()
        {
            Object o = "Hello";
            Assert.True(((string)o).Length == 5);
        }
    }
}
