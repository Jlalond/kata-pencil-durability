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

        [Fact]
        public void WriteToPaperMultipleTimesAndReadBackJoinedString()
        {
            var paper = new Paper();
            paper.Write("Jacob");
            paper.Write(" is ");
            paper.Write("cool");
            Assert.Equal("Jacob is cool", paper.ReadAll());
        }

        [Fact]
        public void WriteEmptyStringAndGetBackEmpty()
        {
            var paper = new Paper();
            paper.Write(string.Empty);
            Assert.Equal(string.Empty, paper.ReadAll()
            );
        }
    }
}
