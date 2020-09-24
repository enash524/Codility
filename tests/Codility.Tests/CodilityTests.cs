using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace Codility.Tests
{
    public class CodilityTests
    {
        [Theory]
        [InlineData(9, 2)]
        [InlineData(529, 4)]
        [InlineData(20, 1)]
        [InlineData(15, 0)]
        [InlineData(32, 0)]
        public void BinaryGapTest(int n, int expected)
        {
            // Arrange

            // Act
            int actual = Codility.BinaryGap(n);

            // Assert
            actual
                .Should()
                .Be(expected);
        }

        [Theory]
        [InlineData(new int[5] { 3, 8, 9, 7, 6 }, 3, new int[5] { 9, 7, 6, 3, 8 })]
        [InlineData(new int[3] { 0, 0, 0 }, 1, new int[3] { 0, 0, 0 })]
        [InlineData(new int[4] { 1, 2, 3, 4 }, 4, new int[4] { 1, 2, 3, 4 })]
        public void CyclicRotationTest(int[] A, int K, int[] expected)
        {
            // Arrange

            // Act
            int[] actual = Codility.CyclicRotation(A, K);

            // Assert
            actual
                .Should()
                .NotBeNullOrEmpty()
                .And
                .HaveCount(expected.Length)
                .And
                .BeEquivalentTo(expected);
        }
    }
}
