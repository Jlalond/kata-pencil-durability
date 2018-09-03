using System.Text;
using PencilDurabilityKata.WritingUtensils;
using Xunit;

namespace PencilDurabilityKata.Tests
{
    public class EraserTests
    {
        [Fact]
        public void EraseReturnsAllCharacters()
        {
            var eraser = new Eraser(1000);
            var stringBuilder = new StringBuilder();
            for (var i = 0; i < 5; i++)
            {
                stringBuilder.Append(eraser.Erase('J'));
            }

            Assert.Equal("JJJJJ", stringBuilder.ToString());
        }

        [Fact]
        public void EraseReturnsAllWhiteSpace()
        {
            var eraser = new Eraser(0);
            var stringBuilder = new StringBuilder();
            for (var i = 0; i < 5; i++)
            {
                stringBuilder.Append(eraser.Erase('j'));
            }

            Assert.Equal("     ", stringBuilder.ToString());
        }

        [Fact]
        public void EraseWhiteSpaceHasNoCost()
        {
            var eraser = new Eraser(1);
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(eraser.Erase(' '));
            stringBuilder.Append(eraser.Erase('j'));
            stringBuilder.Append(eraser.Erase(' '));

            Assert.Equal(" j ", stringBuilder.ToString());
        }
    }
}
