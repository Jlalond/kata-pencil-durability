using System.Text;
using PencilDurabilityKata.WritingUtensils;
using Xunit;

namespace PencilDurabilityKata.Tests
{
    public class EraserTests
    {
        [Fact]
        public void EraseReturnsAllWhiteSpace()
        {
            var eraser = new Eraser(1000);
            var stringBuilder = new StringBuilder();
            for (var i = 0; i < 5; i++)
            {
                stringBuilder.Append(eraser.Erase('J'));
            }

            Assert.Equal("JJJJJ", stringBuilder.ToString());
        }
    }
}
