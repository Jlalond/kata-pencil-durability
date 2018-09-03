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
            Assert.Equal(' ', pencil.WriteCharacterIfCapable('J'));
        }

        [Fact]
        public void DullPencilReturnsWhiteSpaceMultipleTimes()
        {
            var pencil = new Pencil(0);
            var stringbuilder = new StringBuilder();
            for (var i = 0; i < 5; i++)
            {
                stringbuilder.Append(pencil.WriteCharacterIfCapable('j'));
            }

            Assert.Equal("     ", stringbuilder.ToString());
        }

        [Fact]
        public void WhiteSpaceUsesNoDurability()
        {
            var pencil = new Pencil(1);
            var stringbuilder = new StringBuilder();
            stringbuilder.Append(pencil.WriteCharacterIfCapable(' '));
            stringbuilder.Append(pencil.WriteCharacterIfCapable('j'));

            Assert.Equal(" j", stringbuilder.ToString());
        }

        [Fact]
        public void UpperCaseLettersTakeTwoDurabilityPoints()
        {
            var pencil = new Pencil(2);
            var stringbuilder = new StringBuilder();
            stringbuilder.Append(pencil.WriteCharacterIfCapable('J'));
            stringbuilder.Append(pencil.WriteCharacterIfCapable('j'));

            Assert.Equal("J ", stringbuilder.ToString());
        }

        [Fact]
        public void MutlipleLettersCombineToTenPoints()
        {
            var pencil = new Pencil(10);
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(pencil.WriteCharacterIfCapable('J'));
            stringBuilder.Append(pencil.WriteCharacterIfCapable('J'));
            stringBuilder.Append(pencil.WriteCharacterIfCapable('J'));
            stringBuilder.Append(pencil.WriteCharacterIfCapable('J'));
            stringBuilder.Append(pencil.WriteCharacterIfCapable('j'));
            stringBuilder.Append(pencil.WriteCharacterIfCapable('j'));

            Assert.Equal("JJJJjj", stringBuilder.ToString());
        }

        [Fact]
        public void NewLineHasNoCost()
        {
            var pencil = new Pencil(1);
            var stringbuilder = new StringBuilder();
            stringbuilder.Append(pencil.WriteCharacterIfCapable('\n'));
            stringbuilder.Append(pencil.WriteCharacterIfCapable('j'));
            Assert.Equal("\nj", stringbuilder.ToString());
        }
    }
}
