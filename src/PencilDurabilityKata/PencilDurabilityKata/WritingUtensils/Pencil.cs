namespace PencilDurabilityKata.WritingUtensils
{
    public class Pencil
    {
        public int DurabilityRating { get; private set; }
        private int _pencilLength;
        private const int SharpeningDurabilityRating = 40000;
        private const char WhiteSpace = ' ';
        private const int UpperCaseCost = 2;

        public Pencil(int durabilityRating)
        {
            DurabilityRating = durabilityRating;
            _pencilLength = 10;
        }

        public Pencil(int durabilityRating, int pencilLength)
        {
            DurabilityRating = durabilityRating;
            _pencilLength = pencilLength;
        }

        public void Sharpen()
        {
            if (_pencilLength > 0)
            {
                DurabilityRating = SharpeningDurabilityRating;
                _pencilLength--;
            }
        }

        public char WriteCharacterIfSharp(char characterToWrite)
        {
            if (IsWhiteSpaceOrNewLine(characterToWrite))
            {
                return characterToWrite;
            }

            if (IsUpperCase(characterToWrite) && DurabilityRating >= UpperCaseCost)
            {
                DurabilityRating -= UpperCaseCost;
                return characterToWrite;
            }

            if (DurabilityRating > 0)
            {
                DurabilityRating--;
                return characterToWrite;
            }

            return WhiteSpace;
        }

        private static bool IsWhiteSpaceOrNewLine(char character)
        {
            return character == ' ' || character == '\n';
        }

        private static bool IsUpperCase(char character)
        {
            return char.IsUpper(character);
        }
    }
}
