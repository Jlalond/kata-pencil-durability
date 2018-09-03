using PencilDurabilityKata.WritingSurfaces;
using Xunit;

namespace PencilDurabilityKata.Tests
{
    public class PaperTests
    {
        [Fact]
        public void WriteToPaperAndReadBackExactString()
        {
            var paper = new Paper();
            paper.Write("Jacob is cool");
            Assert.Equal("Jacob is cool", paper.ReadAll());
        }
    }
}
