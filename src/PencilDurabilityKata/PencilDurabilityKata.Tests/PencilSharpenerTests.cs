using PencilDurabilityKata.Sharpener;
using PencilDurabilityKata.WritingUtensils;
using Xunit;

namespace PencilDurabilityKata.Tests
{
    public class PencilSharpenerTests
    {
        [Fact]
        public void SharpenAPencilGetBackFourtyThousandDurability()
        {
            var pencil = new Pencil(0, 1);
            var sharpener = new PencilSharpener();
            sharpener.Sharpen(pencil);
            Assert.Equal(40000, pencil.DurabilityRating);
        }

        [Fact]
        public void PencilWithNoLengthCannotBeSharpened()
        {
            var pencil = new Pencil(100, 0);
            var sharpener = new PencilSharpener();
            sharpener.Sharpen(pencil);
            Assert.Equal(100, pencil.DurabilityRating);
        }
    }
}
