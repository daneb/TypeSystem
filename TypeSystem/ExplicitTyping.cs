using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TypeSystem
{
    public class ExplicitTyping
    {
        // This would have failed in C# 1 and 2, prior to the introduction of var in 3.0
        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/var
        [Fact]
        public void ImplicitTypingWillFail()
        {
            var s = "Hello";
            var x = s.Length;
            var twiceX = x * 2;
        }

        [Fact]
        public void ExplicitTypingSucess()
        {
            string s = "Hello";
            int x = s.Length;
            int twiceX = x * 2;
        }

    }
}
