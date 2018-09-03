using System;
using System.Text;
using PencilDurabilityKata.WritingUtensils;
using Xunit;

namespace PencilDurabilityKata.Tests
{
    public class PencilTests
    {
        [Fact]
        public void DullPencilReturnsWhiteSpace()
        {
            var pencil = new Pencil(0);
            Assert.Equal(' ', pencil.WriteCharacterIfSharp('J'));
        }

        [Fact]
        public void DullPencilReturnsWhiteSpaceMultipleTimes()
        {
            var pencil = new Pencil(0);
            var stringbuilder = new StringBuilder();
            for (var i = 0; i < 5; i++)
            {
                stringbuilder.Append(pencil.WriteCharacterIfSharp('j'));
            }

            Assert.Equal("     ", stringbuilder.ToString());
        }

        [Fact]
        public void WhiteSpaceUsesNoDurability()
        {
            var pencil = new Pencil(1);
            var stringbuilder = new StringBuilder();
            stringbuilder.Append(pencil.WriteCharacterIfSharp(' '));
            stringbuilder.Append(pencil.WriteCharacterIfSharp('j'));

            Assert.Equal(" j", stringbuilder.ToString());
        }

        [Fact]
        public void UpperCaseLettersTakeTwoDurabilityPoints()
        {
            var pencil = new Pencil(2);
            var stringbuilder = new StringBuilder();
            stringbuilder.Append(pencil.WriteCharacterIfSharp('J'));
            stringbuilder.Append(pencil.WriteCharacterIfSharp('j'));

            Assert.Equal("J ", stringbuilder.ToString());
        }
    }
}
