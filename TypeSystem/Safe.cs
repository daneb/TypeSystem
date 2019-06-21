using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TypeSystem
{
    public class Safe
    {

        [Fact]
        public void ThisIsSafe()
        {
            int a = 5;
            int b = a + 2; //OK

            bool test = true;

            // Error. Operator '+' cannot be applied to operands of type 'int' and 'bool'.
            int c = a + test;
        }

        [Fact]
        public void ThisIsUnSafe()
        {
            var integers = new ArrayList();
            integers.Add(1);
            integers.Add(2);
            integers.Add("3"); // **PROBLEM**

            for (int i = 0; i < integers.Count; ++i)
            {
                int integer = (int)integers[i];
                // do something
            }
        }
    }
}
