using System.Runtime.InteropServices.ComTypes;
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

        [Fact]
        public void ErasePhraseSuccessfull()
        {
            var eraser = new Eraser(1000);
            var pencil = new Pencil(100);
            var paper = new Paper();
            paper.Write(pencil, "Jacob");
            paper.Erase(eraser, "Jacob");
            Assert.Equal("     ", paper.ReadAll());
        }

        [Fact]
        public void ErasePartialPhraseStartingFromTheBackOfTheWord()
        {
            var eraser = new Eraser(2);
            var pencil = new Pencil(100);
            var paper = new Paper();
            paper.Write(pencil, "Jacob");
            paper.Erase(eraser, "Jacob");
            Assert.Equal("Jac  ", paper.ReadAll());
        }

        [Fact]
        public void EraseNonExistantWord()
        {
            var eraser = new Eraser(2);
            var pencil = new Pencil(100);
            var paper = new Paper();
            paper.Write(pencil, "Jacob");
            paper.Erase(eraser, "Bacon");
            Assert.Equal("Jacob", paper.ReadAll());
        }

        [Fact]
        public void EraseEmptyString()
        {
            var eraser = new Eraser(2);
            var pencil = new Pencil(100);
            var paper = new Paper();
            paper.Write(pencil, "Jacob");
            paper.Erase(eraser, string.Empty);
            Assert.Equal("Jacob", paper.ReadAll());
        }

        [Fact]
        public void EditOverIsSuccessful()
        {
            var eraser = new Eraser(100);
            var pencil = new Pencil(100);
            var paper = new Paper();
            paper.Write(pencil, "Jacob is cool");
            paper.Erase(eraser, "is");
            paper.Edit("as");
            Assert.Equal("Jacob as cool", paper.ReadAll());
        }

        [Fact]
        public void EditOverWordsIsSuccesful()
        {
            var eraser = new Eraser(100);
            var pencil = new Pencil(100);
            var paper = new Paper();
            paper.Write(pencil, "Jacob is cool");
            paper.Erase(eraser, "is");
            paper.Edit("bocaj");
            Assert.Equal("Jacob boc@@ol", paper.ReadAll());
        }

        [Fact]
        public void EditWithNoPreviousErasesDoesNothing()
        {
            var pencil = new Pencil(100);
            var paper = new Paper();
            paper.Write(pencil, "Jacob is cool");
            paper.Edit("bocaj");
            Assert.Equal("Jacob is cool", paper.ReadAll());
        }
    }
}
