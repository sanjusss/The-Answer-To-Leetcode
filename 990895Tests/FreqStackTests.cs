using Microsoft.VisualStudio.TestTools.UnitTesting;
using _990895;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _990895.Tests
{
    [TestClass()]
    public class FreqStackTests
    {
        [TestMethod()]
        public void FreqStackTest()
        {
            FreqStack stack = new FreqStack();
            stack.Push(5);
            stack.Push(7);
            stack.Push(5);
            stack.Push(7);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}