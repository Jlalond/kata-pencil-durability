using PencilDurabilityKata.WritingSurfaces;
using PencilDurabilityKata.WritingUtensils;
using Xunit;

namespace PencilDurabilityKata.Tests
{
    public class PaperTests
    {
        [Fact]
        public void WriteToPaperAndReadBackExactString()
        {
            var pencil = new Pencil(400);
            var paper = new Paper();
            paper.Write(pencil, "Jacob is cool");
            Assert.Equal("Jacob is cool", paper.ReadAll());
        }

        [Fact]
        public void WriteToPaperMultipleTimesAndReadBackJoinedString()
        {
            var pencil = new Pencil(400);
            var paper = new Paper();
            paper.Write(pencil, "Jacob");
            paper.Write(pencil, " is ");
            paper.Write(pencil, "cool");
            Assert.Equal("Jacob is cool", paper.ReadAll());
        }

        [Fact]
        public void WriteEmptyStringAndGetBackEmpty()
        {
            var pencil = new Pencil(400);
            var paper = new Paper();
            paper.Write(pencil, string.Empty);
            Assert.Equal(string.Empty, paper.ReadAll());
        }
    }
}
