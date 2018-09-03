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
    }
}
