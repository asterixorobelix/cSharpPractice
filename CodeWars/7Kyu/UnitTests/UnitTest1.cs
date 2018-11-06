using KataSolutions;
using System;
using System.Collections.Generic;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void BasicTests()
        {
            Assert.Equal(expected: new List<int> { 2, 3, 4, 5 }, actual: RemoveTheMinimum.RemoveSmallest(new List<int> { 1, 2, 3, 4, 5 }));
            Assert.Equal(new List<int> { 5, 3, 2, 4 }, RemoveTheMinimum.RemoveSmallest(new List<int> { 5, 3, 2, 1, 4 }));
            Assert.Equal(new List<int> { 2, 3, 1, 1 }, RemoveTheMinimum.RemoveSmallest(new List<int> { 1, 2, 3, 1, 1 }));
            Assert.Equal(new List<int> (), RemoveTheMinimum.RemoveSmallest(new List<int> ()));
        }

        [Fact]
        public void AdvancedTests()
        {
            Assert.Equal(new List<int>(),RemoveTheMinimum.RemoveSmallest(null));
            Assert.Equal(new List<int> { 1, 2, 3, 1 }, RemoveTheMinimum.RemoveSmallest(new List<int> { 1, 2, 3, -1, 1 }));
        }
    }
}
