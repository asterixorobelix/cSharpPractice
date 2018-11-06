using KataSolutions;
using System;
using System.Collections.Generic;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(new List<int> { 2, 3, 4, 5 }, RemoveTheMinimum.RemoveSmallest(new List<int> { 1, 2, 3, 4, 5 }));
            Console.ReadLine();
        }
    }
}
