using PencilDurabilityKata.Sharpener;
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
    }
}
